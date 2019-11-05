using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{    
    public class SecurityUpdate
     {
        /*         
            "ID": "2016-Apr",
            "Alias": "2016-Apr",
            "DocumentTitle": "April 2016 Security Updates",
            "Severity": null,
            "InitialReleaseDate": "2016-04-12T14:00:00Z",
            "CurrentReleaseDate": "2018-04-10T14:00:00Z",
            "CvrfUrl": "https://api.msrc.microsoft.com/cvrf/2016-Apr?api-Version=2019"
            */
        public string Id { get; set; }
        public string Alias { get; set; }
        public string DocumentTitle { get; set; }
        public string Severity { get; set; }
        public DateTime InitialReleaseDate { get; set; }
        public DateTime CurrentReleaseDate { get; set; }
        public string CvrfUrl { get; set; }
    }
}
