// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooApp.Controllers
{
    using Manager.IManager;
    using Microsoft.AspNetCore.Mvc;
    using Model.NoteModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// NoteController class extends Controller Base class 
    /// </summary>
    public class NoteController : ControllerBase
    {
        /// <summary>
        /// Instatntiation of Interface INoteManager
        /// </summary>
        private readonly INoteManager manager;

        /// <summary>
        /// Adding Dependency 
        /// </summary>
        /// <param name="noteManager"></param>
        public NoteController(INoteManager noteManager)
        {
            manager = noteManager;
        }

        /// <summary>
        /// AddNote method used add new note
        /// </summary>
        /// <param name="note"></param>
        /// <returns>
        /// added successfully
        /// </returns>
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

        /// <summary>
        /// UpdateNote method is used to update already added note
        /// </summary>
        /// <param name="note"></param>
        /// <returns>
        /// updated successfully
        /// </returns>
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

        /// <summary>
        /// GetAllNotes method is used to get all added notes
        /// </summary>
        /// <returns>
        /// list of notes
        /// </returns>
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

        /// <summary>
        /// GetNode by Id method is used to get a specific note by passing id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// note by id
        /// </returns>
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

        /// <summary>
        /// DeleteNote method used to delete note by specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Deleted Successfully
        /// </returns>
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