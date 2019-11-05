using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class SecurityUpdateViewModel
    {
        public SecurityUpdateViewModel(SecurityUpdate update)
        {
            this.Id = update.Id;
            this.Alias = update.Alias;
            this.DocumentTitle = update.DocumentTitle;
            this.Severity = update.Severity;
            this.InitialReleaseDate = update.InitialReleaseDate.ToString("dd/MM/yyyy");
            this.CurrentReleaseDate = update.CurrentReleaseDate.ToString("dd/MM/yyyy");
            this.CvrfUrl = update.CvrfUrl;
        }

        public string Id { get; set; }
        public string Alias { get; set; }
        public string DocumentTitle { get; set; }
        public string Severity { get; set; }
        public string InitialReleaseDate { get; set; }
        public string CurrentReleaseDate { get; set; }
        public string CvrfUrl { get; set; }
    }
}
