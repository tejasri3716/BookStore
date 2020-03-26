﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.RepositoryClasses
{
    using global::Repository.Context;
    using global::Repository.IRepository;
    using Model.Collaborators;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Collaboratory Repository class extends ICollaborator interface
    /// </summary>
    /// <seealso cref="Repository.IRepository.ICollaborator" />
    public class CollaboratorRepository : ICollaboratorRepository
    {
        /// <summary>
        /// UserContext private readonly variable
        /// </summary>
        private readonly UserContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        public CollaboratorRepository(UserContext userContext)
        {
            this.context = userContext;
        }

        /// <summary>
        /// Adds the collaborators to notes.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string AddCollaboratorToNotes(Collaborator collaborator)
        {
            try
            {
                bool result = this.context.Notes.Any(option => option.Email == collaborator.SenderEmail && option.Id == collaborator.NoteId);
                if (result)
                {
                    var user = this.context.Accountregister.Where(usr => usr.Email == collaborator.ReceiverEmail).SingleOrDefault();
                    {
                        var addCollaborator = new Collaborator()
                        {
                            NoteId = collaborator.NoteId,
                            SenderEmail = collaborator.SenderEmail,
                            ReceiverEmail = collaborator.ReceiverEmail
                        };
                        context.Collaborators.Add(collaborator);
                    }
                }
                Task.Run(() => context.SaveChanges());
                return "Added Successfully";
                
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the collaborator.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string DeleteCollaborator(int id)
        {
            try
            {
                var result = this.context.Collaborators.Where(op => op.Id == id).SingleOrDefault();
                if (result != null)
                {
                    this.context.Collaborators.Remove(result);
                }
                 Task.Run(() => context.SaveChanges());
                return "Deleted Successfully";
            }   
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}