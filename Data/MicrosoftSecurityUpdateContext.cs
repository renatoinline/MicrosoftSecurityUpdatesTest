using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class MicrosoftSecurityUpdateContext : DbContext
    {
        public MicrosoftSecurityUpdateContext(DbContextOptions<MicrosoftSecurityUpdateContext> options)
            :base(options)
        {

        }

        public DbSet<SecurityUpdate> SecurityUpdates { get; set; }
    }
}
