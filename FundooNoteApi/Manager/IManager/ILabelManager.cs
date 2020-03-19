﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Manager.IManager
{
    using Model.LabelModels;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Label Manager interface consists of abstract methods
    /// </summary>
    public interface ILabelManager
    {
        /// <summary>
        /// Adds the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string AddLabel(LabelModel labelModel);

        /// <summary>
        /// Updates the specified label model.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string UpdateLabel(int id, string name);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        string DeleteLabel(int id);

        /// <summary>
        /// Gets all list.
        /// </summary>
        /// <returns></returns>
        List<LabelModel> GetAllLabels();

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        List<LabelModel> GetLabel(int id);
    }
}