// --------------------------------------------------------------------------------------------------------------------
// <copyright file=INoteManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.IManager
{
    using Microsoft.AspNetCore.Http;
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
        string AddNotes(NoteModel note);

        /// <summary>
        /// DeleteNote is used to delete note by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// deleted successfully
        /// </returns>
        string DeleteNote(int id);

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
        string UpdateNote(NoteModel note);

        /// <summary>
        /// GetAllNotes method is used to get all notes
        /// </summary>
        /// <returns>
        /// list of notes
        /// </returns>
        Task<List<NoteModel>> GetAllNotes();

        /// <summary>
        /// Trash method is used to send the note to trash
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        string Trash(int id);


        string EmptyTrash();

        /// <summary>
        /// Gets the archive list.
        /// </summary>
        /// <returns></returns>
        List<NoteModel> ArchiveList();

        /// <summary>
        /// Unpin method is used to unpin the note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string UnPin(int id);

        /// <summary>
        /// Changes the color.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        string ChangeColor(int id, string color);

        /// <summary>
        /// Determines whether [is archive] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string IsArchive(int id);

        /// <summary>
        /// Uns the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string UnArchive(int id);

        /// <summary>
        /// Restores the trashed note.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string Restore(int id);

        /// <summary>
        /// Restores all notes.
        /// </summary>
        /// <returns></returns>
        string RestoreAll();

        /// <summary>
        /// Determines whether is pin the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string IsPin(int id);

        /// <summary>
        /// Reminder method is used to set the reminder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="reminder">The reminder.</param>
        /// <returns></returns>
        string Reminder(int id, string reminder);

        /// <summary>
        /// DeleteReminder method is used to remove the reminder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="reminder">The reminder.</param>
        /// <returns></returns
        int DeleteRemainder(int id);
        /// <summary>
        /// Uploads the images.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        string UploadImage(IFormFile image, int id);

        /// <summary>
        /// Trashes the list.
        /// </summary>
        /// <returns></returns>
        List<NoteModel> TrashList();
    }
}