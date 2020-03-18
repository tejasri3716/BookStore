namespace Manager.IManager
{
    using Model.NoteModel;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface INoteManager
    {
        Task<string> AddNotes(NoteModel note);
        Task<string> DeleteNote(int id);
        List<NoteModel> GetNote(int id);
        Task<string> UpdateNote(NoteModel note);
        List<NoteModel> GetAllNotes();
    }
}