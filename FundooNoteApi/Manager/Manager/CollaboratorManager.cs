// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.Manager
{
    using global::Manager.IManager;
    using Model.Collaborators;
    using Repository.IRepository;
    using System;

    /// <summary>
    /// Collaborator Manager class implements ICollaborator Manager
    /// </summary>
    public class CollaboratorManager : ICollaboratorManager
    {
        /// <summary>
        /// Instantiating ICollaborator interface
        /// </summary>
        private readonly ICollaboratorRepository collaborator;

        /// <summary>
        /// Collaborator Manager constructor used to add dependency
        /// </summary>
        /// <param name="collaborator"></param>
        public CollaboratorManager(ICollaboratorRepository collaborator)
        {
            this.collaborator = collaborator;
        }

        /// <summary>
        /// Adds the collaborator asynchronous.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        /// <returns>
        /// Added Successfully
        /// </returns>
        /// <exception cref="Exception"></exception>
        public string AddCollaborator(Collaborator collaborator)
        {
            try
            {
                 var result=this.collaborator.AddCollaboratorToNotes(collaborator);
                return result;
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Delete Collaborator method is used to delete collaborator using id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Delted Successfully
        /// </returns>
        /// <exception cref="Exception"></exception>
        public string DeleteCollaborator(int id)
        {
            try
            {
                 this.collaborator.DeleteCollaborator(id);
                return "Deleted Successfully";
            }
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}