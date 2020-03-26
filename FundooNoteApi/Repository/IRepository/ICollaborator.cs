// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.IRepository
{
    using Model.Collaborators;
    using System.Threading.Tasks;

    /// <summary>
    /// ICollaborator interface consists of abstract methods
    /// </summary>
    public interface ICollaborator
    {
        /// <summary>
        /// Adds the collaborators to notes.
        /// </summary>
        /// <param name="collaborator">The collaborator .</param>
        /// <returns></returns>
        string AddCollaboratorToNotes(Collaborator collaborator);

        /// <summary>
        /// Deletes the collaborator.
        /// </summary>
        /// <param name="collaborator">The collaborator .</param>
        /// <returns></returns>
        string DeleteCollaborator(int id);
    }
}
