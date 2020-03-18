// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.IManager
{
    using Model.NoteModel;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// INoteManager interface used to create abstract methods of notes
    /// </summary>
    public interface INoteManager
    {
        /// <summary>
        /// AddNotes method is used to add note 
        /// </summary>
        /// <param name="note"></param>
        /// <returns>
        /// added successfully
        /// </returns>
        Task<string> AddNotes(NoteModel note);

        /// <summary>
        /// DeleteNote is used to delete note by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// deleted successfully
        /// </returns>
        Task<string> DeleteNote(int id);

        /// <summary>
        /// GetNote method is used get a specific note by using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// a specific note 
        /// </returns>
        List<NoteModel> GetNote(int id);

        /// <summary>
        /// UpdateNote method is used to update already existing note
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        Task<string> UpdateNote(NoteModel note);

        /// <summary>
        /// GetAllNotes method is used to get all notes
        /// </summary>
        /// <returns>
        /// list of notes
        /// </returns>
        List<NoteModel> GetAllNotes();
    }
}