using Site.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Domain.Services.Interfaces
{
    public interface IFormService
    {
        void ContactUs(ContactUsFormModel form);
    }
}
