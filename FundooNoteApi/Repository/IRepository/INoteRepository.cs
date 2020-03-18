// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.IRepository
{
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
    }
}