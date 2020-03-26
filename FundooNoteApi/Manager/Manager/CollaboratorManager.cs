// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
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
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class CollaboratorManager : ICollaboratorManager
    {
        private readonly ICollaborator collaborator;

        public CollaboratorManager(ICollaborator collaborator)
        {
            this.collaborator = collaborator;
        }

        /// <summary>
        /// Adds the collaborator asynchronous.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        /// <returns></returns>
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