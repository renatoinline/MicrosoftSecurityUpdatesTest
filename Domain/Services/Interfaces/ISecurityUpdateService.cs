using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.Interfaces
{
    public interface ISecurityUpdateService
    {
        SecurityUpdate FindById(string id);
        IEnumerable<SecurityUpdate> GetAll();
        SecurityUpdate Insert(SecurityUpdate entity);
    }
}
