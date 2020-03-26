// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.Context
{
    using Microsoft.EntityFrameworkCore;
    using Model.Collaborators;
    using Model.LabelModels;
    using Model.NoteModel;
    using Model.UserModel;

    /// <summary>
    /// UserContext class is used to get connected with the database
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        /// <param name="contextOptions">The context options.</param>
        public UserContext(DbContextOptions<UserContext> contextOptions) : base(contextOptions)
        {
                
        }

        /// <summary>
        /// Gets or sets the accountregister.
        /// </summary>
        /// <value>
        /// The accountregister.
        /// </value>
        public DbSet<RegisterModel> Accountregister { get; set; }

        /// <summary>
        /// Gets or sets the Notes.
        /// </summary>
        /// <value>
        /// The Notes.
        /// </value>
        public DbSet<NoteModel> Notes { get; set; }

        /// <summary>
        /// Gets or sets the Labels.
        /// </summary>
        /// <value>
        /// The Labels.
        /// </value>
        public DbSet<LabelModel> Labels { get; set; }

        /// <summary>
        /// Gets or sets the Collaborator.
        /// </summary>
        /// <value>
        /// The Collaborators.
        /// </value>
        public DbSet<Collaborator> Collaborators { get; set; }
    }
}