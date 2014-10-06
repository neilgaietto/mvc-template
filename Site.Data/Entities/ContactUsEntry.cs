using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Data.Entities
{
    public partial class ContactUsEntry : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }

    }
}
