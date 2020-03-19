// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ILabelRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Repository.IRepository
{
    using Model.LabelModels;
    using System.Collections.Generic;

    /// <summary>
    /// ILabel Repository interface is used to define abstract methods
    /// </summary>
    public interface ILabelRepository
    {
        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>
        /// 
        /// </returns>
        string AddLabel(LabelModel labelModel);

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns></returns>
        string UpdateLabel(int id, string name);

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// 
        /// </returns>
        string DeleteLabel(int id);

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        List<LabelModel> GetAllLabels();

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// 
        /// </returns>
        List<LabelModel> GetLabel(int id);
    }
}