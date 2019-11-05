using Domain.Models;
using Domain.Repositories.Interfaces;
using Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class SecurityUpdateService : ISecurityUpdateService
    {
        private readonly ISecurityUpdateRepository repository;
        public SecurityUpdateService(ISecurityUpdateRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException("repositoty");
        }

        public SecurityUpdate FindById(string id)
        {
            return repository.FindById(id);
        }

        public IEnumerable<SecurityUpdate> GetAll()
        {
            return repository.GetAll();
        }

        public SecurityUpdate Insert(SecurityUpdate entity)
        {
            return repository.Insert(entity);
        }
    }
}
