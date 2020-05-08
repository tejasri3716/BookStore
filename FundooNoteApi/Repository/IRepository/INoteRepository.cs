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
        string AddNotes(NoteModel note);
        string UpdateNote(NoteModel note);
        string DeleteNote(int id);
        Task<List<NoteModel>> GetAllNotes();
        List<NoteModel> GetNote(int id);
        string Trash(int id);
        string EmptyTrash();
        List<NoteModel> TrashList();
         string Restore(int id);
        string RestoreAll();
        string IsArchive(int id);
        string UnArchive(int id);
        List<NoteModel> ArchiveList();
        string Ispin(int id);
        string Unpin(int id);
        int Reminder(int id, string reminder);
        int DeleteRemainder(int id);
        string ChangeColor(int id, string color);
        string UploadImage(IFormFile image, int id);
    }
}