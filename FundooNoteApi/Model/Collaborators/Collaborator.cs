// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Collaborator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.Collaborators
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Collaborator class is used as model class for Collaborator
    /// </summary>
    public class Collaborator
    {
        /// <summary>
        /// Id of the collaborator
        /// </summary>
        private int id;
        
        /// <summary>
        /// Note ID 
        /// </summary>
        private int noteId;

        /// <summary>
        /// Email of the sender 
        /// </summary>
        private string senderEmail;

        /// <summary>
        /// Receiver Email
        /// </summary>
        private string receiverEmail;

        /// <summary>
        /// Note Id property
        /// </summary>
        public int NoteId { get => this.noteId; set => this.noteId = value; }

        /// <summary>
        /// Sender Email property
        /// </summary>
        public string SenderEmail { get => this.senderEmail; set => this.senderEmail = value; }

        /// <summary>
        /// Receiver Email property
        /// </summary>
        public string ReceiverEmail { get => this.receiverEmail; set => this.receiverEmail = value; }

        /// <summary>
        /// Id property is considered as primary key
        /// </summary>
        [Key]
        public int Id { get => this.id; set => this.id = value; }
    }
}