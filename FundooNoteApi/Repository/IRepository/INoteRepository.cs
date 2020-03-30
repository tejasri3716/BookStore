// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.IRepository
{
    using Microsoft.AspNetCore.Http;
    using Model.NoteModel;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface INoteRepository
    {
        Task AddNotes(NoteModel note);
        Task UpdateNote(NoteModel note);
        Task DeleteNote(int id);
        List<NoteModel> GetAllNotes();
        List<NoteModel> GetNote(int id);
        Task Trash(int id);
        Task EmptyTrash();
        List<NoteModel> TrashList();
         Task Restore(int id);
        Task RestoreAll();
        Task IsArchive(int id);
        Task UnArchive(int id);
        List<NoteModel> ArchiveList();
        Task Ispin(int id);
        Task Unpin(int id);
        int Reminder(int id, string reminder);
        Task ChangeColor(int id, string color);
        string UploadImage(IFormFile image, int id);
    }
}