// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryClasses
{
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using global::Repository.Context;
    using global::Repository.IRepository;
    using Microsoft.AspNetCore.Http;
    using Model.NoteModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
                Description = note.Description,
                Email = note.Email,
                Date = note.Date,
                ModifiedDate = note.ModifiedDate,
                Archive = note.Archive,
                Pin = note.Pin,
                ChangeColor = note.ChangeColor,
                AddImage = note.AddImage,
                Reminder = note.Reminder,
                Trash = note.Trash
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
            if (notes != null)
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
            if (note != null)
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

        /// <summary>
        /// Trash method is used to send the note to Trash
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Trash(int id)
        {
            var result = this.context.Notes.Where(note => note.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.Trash = true;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// Empty Trash method is used to empty the trash
        /// </summary>
        /// <returns></returns>
        public Task EmptyTrash()
        {
            var result = from notes in this.context.Notes where notes.Trash == true select notes;
            if (result != null)
            {
                foreach (var note in result)
                {
                    this.context.Notes.Remove(note);
                }
                var res = Task.Run(() => this.context.SaveChanges());
                return res;
            }
            return default;
        }

        /// <summary>
        /// Trash List method is used get all notes that are sent to trash
        /// </summary>
        /// <returns></returns>
        public List<NoteModel> TrashList()
        {
            try
            {
                var trashlist = from notes in this.context.Notes where notes.Trash == true select notes;
                if (trashlist != null)
                {
                    return this.context.Notes.Where(list => list.Trash == true).ToList<NoteModel>();
                }
                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Restore method is used to get back the specific note that is sent to trash
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Restore(int id)
        {
            var result = this.context.Notes.Where(note => note.Id == id && note.Trash == true).SingleOrDefault();
            if (result != null)
            {
                result.Trash = false;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// Restore All method is used to get back all notes that sent to trash
        /// </summary>
        /// <returns></returns>
        public Task RestoreAll()
        {
            var list = from notes in context.Notes where notes.Trash == true select notes;
            if (list != null)
            {
                foreach (var note in list)
                {
                    note.Trash = false;
                }
                return Task.Run(() => this.context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// IsArchive method is send the note to archive list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task IsArchive(int id)
        {
            var result = this.context.Notes.Where(note => note.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.Archive = true;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// UnArchive method is used to retrieve the note from Archive list 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task UnArchive(int id)
        {
            var result = this.context.Notes.Where(note => note.Id == id && note.Archive == true).SingleOrDefault();
            if (result != null)
            {
                result.Archive = false;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// Archive List method is used to get the list of notes that are archived
        /// </summary>
        /// <returns></returns>
        public List<NoteModel> ArchiveList()
        {
            var result = from notes in context.Notes where notes.Archive == true select notes;
            if (result != null)
            {
                return context.Notes.Where(list => list.Archive == true).ToList();
            }
            return null;
        }

        /// <summary>
        /// Is Pin method is used to pin the specific note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Ispin(int id)
        {
            var result = this.context.Notes.Where(note => note.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.Pin = true;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// Unpin method is used to un pin the note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task Unpin(int id)
        {
            var result = this.context.Notes.Where(note => note.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.Pin = false;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// Reminder method is used to set the reminder to the note
        /// </summary>
        /// <param name="id"></param>
        /// <param name="reminder"></param>
        /// <returns></returns>
        public int Reminder(int id, string reminder)
        {
            var remind = this.context.Notes.Where(note => note.Id == id).SingleOrDefault();
            if (remind != null)
            {
                remind.Reminder = reminder.ToString();
                return context.SaveChanges();
            }
            return 0;
        }

        /// <summary>
        /// Change color method is used to change the color of note
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public Task ChangeColor(int id, string color)
        {
            var result = this.context.Notes.Where(note => note.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.ChangeColor = color;
                return Task.Run(() => context.SaveChanges());
            }
            return null;
        }

        /// <summary>
        /// Upload Image method is used to Upload image to the note 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string UploadImage(IFormFile file, int id)
        {
            /*if (file == null)
            {
                return "Empty";
            }*/
            var stream = file.OpenReadStream();
            var name = file.FileName;
            Account account = new Account("tejasribridgelabz", "285435776433534", "mWcaxa7Td4ihtHyRuPXNS0CNmdo");
            Cloudinary cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(name, stream)
            };
            ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            cloudinary.Api.UrlImgUp.BuildUrl(String.Format("{0}.{1}", uploadResult.PublicId, uploadResult.Format));
            var data = this.context.Notes.Where(t => t.Id == id).SingleOrDefault();
            data.AddImage = uploadResult.Uri.ToString();
            try
            {
                var result = this.context.SaveChanges();
                return data.AddImage;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}