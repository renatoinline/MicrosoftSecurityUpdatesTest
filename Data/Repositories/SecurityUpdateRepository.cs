using Domain.Models;
using Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class SecurityUpdateRepository : ISecurityUpdateRepository
    {
        private readonly MicrosoftSecurityUpdateContext context;

        public SecurityUpdateRepository(MicrosoftSecurityUpdateContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public SecurityUpdate FindById(string id)
        {
            return context.SecurityUpdates.Find(id);
        }

        public IEnumerable<SecurityUpdate> GetAll()
        {
            return context.SecurityUpdates;
        }

        public SecurityUpdate Insert(SecurityUpdate entity)
        {
            context.SecurityUpdates.Add(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
