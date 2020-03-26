// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelRepository.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using Model.LabelModels;
using Repository.Context;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    /// <summary>
    /// Label Repository
    /// </summary>
    /// <seealso cref="Repository.Interface.ILabelRepository" />
    public class LabelRepository : ILabelRepository
    {
        /// <summary>
        /// The user context
        /// </summary>
        private readonly UserContext userContext;

        public LabelRepository()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelRepository"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public LabelRepository(UserContext user)
        {
            this.userContext = user;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public string AddLabel([FromBody]LabelModel labelModel)
        {
            try
            {
                LabelModel label = new LabelModel()
                {
                    LabelId = labelModel.LabelId,
                    LabelName = labelModel.LabelName,
                    NoteId=labelModel.NoteId,
                    Email = labelModel.Email
                };
                this.userContext.Labels.Add(label);
                var result = this.userContext.SaveChanges();
                return "Added Successfully";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string DeleteLabel(int id)
        {
            var label = userContext.Labels.Where(r => r.LabelId == id).SingleOrDefault();
            if (label != null)
            {
                userContext.Labels.Remove(label);
            }
            userContext.SaveChanges();
            return "Deleted Successfully";
        }

        /// <summary>
        /// Gets the list of all Labels.
        /// </summary>
        /// <returns></returns>
        public List<LabelModel> GetAllLabels()
        {
            return this.userContext.Labels.ToList<LabelModel>();
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public List<LabelModel> GetLabel(int id)
        {
            var note = userContext.Labels.Where(r => r.LabelId == id).SingleOrDefault();
            if (note != null)
            {
                return userContext.Labels.Where(r => r.LabelId == id).ToList();
            }
            return null;
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        public string UpdateLabel(int id, string name, string email)
        {
            var result = this.userContext.Labels.Where(op => op.LabelId == id).SingleOrDefault();
            if (result != null)
            {
                result.Email = email;
                result.LabelName = name;
                var res = this.userContext.SaveChanges();
                return "Updated Successfully";
            }
            return default;
        }
    }
}
