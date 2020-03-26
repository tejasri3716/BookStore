// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooApp.Controllers
{
    using Manager.IManager;
    using Microsoft.AspNetCore.Mvc;
    using Model.Collaborators;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Collaborator Controller extends Controller base 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class CollaboratorController : ControllerBase
    {
        private readonly ICollaboratorManager collaborator;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorController"/> class.
        /// </summary>
        /// <param name="collaboratorManager">The collaborator Manager.</param>
        public CollaboratorController(ICollaboratorManager collaboratorManager)
        {
            this.collaborator = collaboratorManager;
        }

        /// <summary>
        /// Adds the specified collaborators model.
        /// </summary>
        /// <param name="collaborator">The collaborators model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/addColloborator")]
        public async Task<IActionResult> AddColloborator([FromBody]Collaborator collaborator)
        {
            try
            {
                var result = this.collaborator.AddCollaborator(collaborator);
                return this.Ok(new { result });
            }
            catch(Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }


        /// <summary>
        /// Deletes the specified collaborators model.
        /// </summary>
        /// <param name="collaboratorsModel">The collaborators model.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/deleteCollaborator")]
        public async Task<IActionResult> DeleteCollaborator(int id)
        {
            try
            {
                var result = this.collaborator.DeleteCollaborator(id);
                return this.Ok(new { result });
            }
            catch(Exception exception)
            {
                return this.BadRequest(exception.Message);
            }
        }
    }
}