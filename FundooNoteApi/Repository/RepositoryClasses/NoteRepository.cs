namespace Repository.RepositoryClasses
{
    using global::Repository.IRepository;
    using Model.NoteModel;
    using Repository.Context;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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

        public List<NoteModel> GetAllNotes()
        {
            return this.context.Notes.ToList();
        }

        public List<NoteModel> GetNote(int id)
        {
            var note = this.context.Notes.Where(option => option.Id == id).SingleOrDefault();
            if(note!=null)
            {
                return context.Notes.Where(option => option.Id == id).ToList();
            }
            return null;
        }

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