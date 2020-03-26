// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.IManager
{
    using Model.Collaborators;
    using System.Threading.Tasks;
    public interface ICollaboratorManager
    {
        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        /// <returns></returns>
        string AddCollaborator(Collaborator collaborator);

        /// <summary>
        /// Removes the collaborator.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        /// <returns></returns>
        string DeleteCollaborator(int id);
    }
}