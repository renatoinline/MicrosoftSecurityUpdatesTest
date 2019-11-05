using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories.Interfaces
{
    public interface ISecurityUpdateRepository
    {
        SecurityUpdate FindById(string id);
        IEnumerable<SecurityUpdate> GetAll();
        SecurityUpdate Insert(SecurityUpdate entity);
    }
}
