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
        [Key]
        public string SenderEmail { get => this.senderEmail; set => this.senderEmail = value; }

        /// <summary>
        /// Receiver Email property
        /// </summary>
        public string ReceiverEmail { get => this.receiverEmail; set => this.receiverEmail = value; }
    }
}