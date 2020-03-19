// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryClasses
{
    using global::Repository.Context;
    using global::Repository.IRepository;
    using Model.NoteModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// NoteRepository class is used to implement INoteRepository
    /// </summary>
    public class NoteRepository : INoteRepository
    {
        private readonly UserContext context;


        public NoteRepository(UserContext context)
        {
            this.context = context;
        }
        public NoteRepository()
        {
        }

        /// <summary>
        /// Add Note method is used to add notes
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public Task AddNotes(NoteModel note)
        {
            NoteModel noteModel = new NoteModel()
            {
                Title = note.Title,
                Description=note.Description,
                Email=note.Email,
                Date=note.Date,
                ModifiedDate=note.ModifiedDate,
                Archive=note.Archive,
                Pin=note.Pin,
                ChangeColor=note.ChangeColor,
                AddImage=note.AddImage,
                Reminder=note.Reminder,
                Trash=note.Trash
            };
            this.context.Notes.Add(noteModel);
            return Task.Run(() => context.SaveChanges());
        }

        /// <summary>
        /// DeleteNote method is used to delete note by using specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeleteNote(int id)
        {
            var notes = this.context.Notes.Where(option => option.Id == id).SingleOrDefault();
            if(notes != null)
            {
                context.Notes.Remove(notes);
                context.SaveChanges();
                return Task.Run(() => context.SaveChanges());
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// GetAllNotes method is used to get all notes
        /// </summary>
        /// <returns></returns>
        public List<NoteModel> GetAllNotes()
        {
            return this.context.Notes.ToList();
        }

        /// <summary>
        /// GetNote method is used to get note by specific id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<NoteModel> GetNote(int id)
        {
            var note = this.context.Notes.Where(option => option.Id == id).SingleOrDefault();
            if(note!=null)
            {
                return context.Notes.Where(option => option.Id == id).ToList();
            }
            return null;
        }

        /// <summary>
        /// Update Note is used to update note by specific id
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public Task UpdateNote(NoteModel note)
        {
            var notes = context.Notes.Where(option => option.Id == note.Id).SingleOrDefault();
            if (notes != null)
            {
                notes.Email = note.Email;
                notes.Title = note.Title;
                notes.Description = note.Description;
                notes.Date = note.Date;
                notes.ModifiedDate = note.ModifiedDate;
                return Task.Run(() => context.SaveChanges());
            }
            else
            return default;
        }
    }
}