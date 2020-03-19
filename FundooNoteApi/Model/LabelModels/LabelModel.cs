// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.LabelModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// LabelModel class is used as model class
    /// </summary>
    public class LabelModel
    {
        /// <summary>
        /// Label Id
        /// </summary>
        private int labelId;

        /// <summary>
        /// Note Id
        /// </summary>
        private int noteId;

        /// <summary>
        /// Label Name
        /// </summary>
        private string labelName;
        
        /// <summary>
        /// Label Id property
        /// </summary>
        [Key]
        public int LabelId { get => this.labelId; set => this.labelId = value; }

        /// <summary>
        /// Note Id property
        /// </summary>
        public int NoteId { get => this.noteId; set => this.noteId = value; }

        /// <summary>
        /// Label Name property
        /// </summary>
        public string LabelName { get => this.labelName; set => this.labelName = value; }
    }
}