using Site.Data.Repositories.Interfaces;
using Site.Domain.Services.Interfaces;
using Site.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Domain.Services
{
    public class FormService : IFormService
    {
        private readonly IContactUsRepository _contactUsRepository;

        public FormService(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }

        public void ContactUs(ContactUsFormModel form)
        {
            try
            {
                _contactUsRepository.Save(form);
            }
            catch (Exception ex)
            {
                //TODO: Log Error
                throw;
            }
        }
    }
}
