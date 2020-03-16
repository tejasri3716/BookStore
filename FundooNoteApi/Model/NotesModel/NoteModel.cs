namespace Model.NoteModel
{
    using System;
    public class NoteModel
    {
        private int id;
        private string title;
        private string description;
        private string email;
        private DateTime? date;
        private DateTime? modifiedDate;
        private bool archive;
        private bool pin;
        private string changeColor;
        private string addImage;
        private string reminder;
        private bool trash;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Email { get => email; set => email = value; }
        public DateTime? Date { get => date; set => date = value; }
        public DateTime? ModifiedDate { get => modifiedDate; set => modifiedDate = value; }
        public bool Archive { get => archive; set => archive = value; }
        public bool Pin { get => pin; set => pin = value; }
        public string ChangeColor { get => changeColor; set => changeColor = value; }
        public string AddImage { get => addImage; set => addImage = value; }
        public string Reminder { get => reminder; set => reminder = value; }
        public bool Trash { get => trash; set => trash = value; }
    }
}