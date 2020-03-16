namespace Manager.IManager
{
    using Model.NoteModel;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface INoteManager
    {
        Task AddNotes(NoteModel note);
        Task DeleteNote(int id);
        List<NoteModel> GetNote(int id);
        Task UpdateNote(NoteModel note);
        List<NoteModel> GetAllNotes();
    }
}