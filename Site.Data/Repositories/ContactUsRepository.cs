using Site.Data.Context;
using Site.Data.Repositories.Interfaces;
using Site.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Data.Repositories
{
    public class ContactUsRepository : IContactUsRepository
    {
        public void Save(ContactUsFormModel contactUsForm)
        {
            //TODO: Save to DB
            throw new NotImplementedException();
        }
    }
}
