using Site.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Data.Repositories.Interfaces
{
    public interface IContactUsRepository
    {
        void Save(ContactUsFormModel contactUsForm);
    }
}
