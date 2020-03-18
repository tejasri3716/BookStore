namespace FundooApp.Controllers
{
    using Manager.IManager;
    using Microsoft.AspNetCore.Mvc;
    using Model.NoteModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class NoteController : ControllerBase
    {
        private readonly INoteManager manager;

        public NoteController(INoteManager noteManager)
        {
            manager = noteManager;
        }

        [HttpPost]
        [Route("api/addnote")]
        public async Task<IActionResult> AddNote([FromBody]NoteModel note)
        {
            try
            {
                var result = await this.manager.AddNotes(note);
                return Ok(new { result });
            }
            catch (Exception exeception)
            {
                return BadRequest(exeception.Message);
            }
        }

        [HttpPut]
        [Route("api/update")]
        public async Task<IActionResult> UpdateNote([FromBody]NoteModel note)
        {
            try
            {
                var result = await this.manager.UpdateNote(note);
                return Ok(new { result });
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        [Route("api/get")]
        public async Task<IActionResult> GetAllNotes()
        {
            try
            {
                List<NoteModel> notes = this.manager.GetAllNotes();
                return Ok(notes);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        [Route("api/getById")]
        public async Task<IActionResult> GetNote(int id)
        {
            try
            {
                var result = this.manager.GetNote(id);
                return Ok(result);
            }

            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete]
        [Route("api/delete")]
        public async Task<IActionResult> DeleteNote(int id)
        {
            try
            {
                this.manager.DeleteNote(id);
                return Ok(id);
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}



