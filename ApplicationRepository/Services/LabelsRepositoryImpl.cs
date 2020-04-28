﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelsRepositoryImpl.cs" company="Bridgelabz">
//   Copyright © 2020 Company
// </copyright>
// <creator Name="ASHOKKUMAR"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ApplicationRepository.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ApplicationRepository.Context;
    using ApplicationRepository.Interfaces;
    using Common.Models;

    /// <summary>
    /// this class implements the ILabelsRepository
    /// </summary>
    public class LabelsRepositoryImpl : ILabelsRepository
    {
        /// <summary>
        /// private Field for DbContext object
        /// </summary>
        private readonly AppDbContext context;

        /// <summary>
        /// Constructor injection of DbContext
        /// </summary>
        /// <param name="context">Injects the DbContext object</param>
        public LabelsRepositoryImpl(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the New Label
        /// </summary>
        /// <param name="model">From body</param>
        /// <returns>result</returns>
        public async Task<int> AddLabel(LabelsModel model)
        {
            //// checking wether the same labelmodel exists in the table
            var exists = this.context.Labels.FirstOrDefault(o => o.Id == model.Id);
            
            //// if not exists then adding the data to the table
            if(exists==null)
            {
                await this.context.Labels.AddAsync(model);
                return await this.context.SaveChangesAsync();
            }
            return 0;
        }

        /// <summary>
        /// Deltes the label based on Id
        /// </summary>
        /// <param name="id">from body</param>
        /// <returns>Resul</returns>
        public async Task<int> DeleteLabel(int id, string email)
        {
            var result = this.context.Labels.FirstOrDefault(o => o.Id == id && o.Email==email);
            if(result!=null)
            {
                this.context.Labels.Remove(result);
                return await this.context.SaveChangesAsync();
            }
            return 0;
        }

        /// <summary>
        /// Gets all the Labels
        /// </summary>
        /// <returns>Labels</returns>
        public IEnumerable<LabelsModel> GetAllLabels(string email)
        {
            return this.context.Labels.Where(o=> o.Email==email);
        }

        /// <summary>
        /// Gets particular label based on id
        /// </summary>
        /// <param name="id">from body</param>
        /// <returns>result</returns>
        public LabelsModel GetLabel(int id, string email)
        {
            var result = this.context.Labels.FirstOrDefault(o => o.Id== id);
            if(result!=null)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// update the Label if it exists
        /// </summary>
        /// <param name="id">from body</param>
        /// <param name="label">new label from body</param>
        /// <returns></returns>
        public async Task<int> UpdateLabel(LabelsModel model)
        {

            var Label = this.context.Labels.FirstOrDefault(o => o.Id== model.Id);
            if (Label != null)
            {
                Label.Label = model.Label;
                Label.Email = model.Email;
                this.context.Labels.Update(Label);
                return await this.context.SaveChangesAsync();
            }
            return 0;
        }
    }
}
