using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class UpdatesViewModel
    {
        public UpdatesViewModel(IEnumerable<SecurityUpdateViewModel> updates)
        {
            this.Updates = updates;
        }

        public IEnumerable<SecurityUpdateViewModel> Updates { get; set; }
    }
}
