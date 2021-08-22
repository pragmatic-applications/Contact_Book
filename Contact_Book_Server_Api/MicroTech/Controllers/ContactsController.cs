using AppConfigSettings;

using Domain;

using Interfaces;

using Lib_Email;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Threading.Tasks;

namespace Controllers
{
    public class ContactsController : ApiBaseController
    {
        public ContactsController(AppSettings options, IUnitOfWork unitOfWork) : base(options, unitOfWork)
        {
        }

        // GET: api/Contacts/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<AppModel>> Get(int id) => await this.GetEntity(id);

        // POST: api/Contacts
        [HttpPost]
        public Task<ActionResult<AppContact>> Post(AppContact item) => this.PostEntity(item, true);

        protected async Task<ActionResult<AppModel>> GetEntity(int id)
        {
            try
            {
                var item = await this.UnitOfWork.AppRepository.FindAsync(id);

                return item == null ? this.NotFound() : item;
            }
            catch(Exception)
            {
                return this.StatusCode(500, "Internal server error");
            }
        }

        private void SendEmail(AppContact model, EmailInfo emailInfo)
        {
            var lineBreak = "<br />";

            Email.EmailUserPersonalDetails = lineBreak + model.Title + " " + model.FirstName + " " + model.LastName + lineBreak;
            Email.EmailUserPersonalDetails += lineBreak + " Email: " + model.Email + lineBreak;

            var messageBody = lineBreak + "Contact Details:"
            + lineBreak + "Date:" + DateTime.Now.ToString();

            messageBody += lineBreak + "User's Details: " + Email.EmailUserPersonalDetails
            + lineBreak + "Query or Message: " + model.Message;

            Email.EmailSubject = " Enquiry";
            Email.EmailBody = messageBody;
            Email.SendEmail(emailInfo.SmtpServer, emailInfo.MailServerUserName, emailInfo.MailServerUserPassword, emailInfo.ToEmailAddress);
        }

        protected async Task<ActionResult<AppContact>> PostEntity(AppContact item, bool isDeveloperEmail = true)
        {
            try
            {
                var id = 1;
                var model = await this.UnitOfWork.AppRepository.FindAsync(id);
                var devData = await this.UnitOfWork.DevUserRepository.FindAsync(id);

                if(item == null) { return this.NotFound(); }

                if(isDeveloperEmail)
                {
                    this.SendEmail
                    (
                        item,
                        new EmailInfo
                        (
                            model.SmtpServer,
                            model.MailServerUserName,
                            model.MailServerUserPassword,
                            devData.ToEmailAddress
                        )
                    );
                }
                else
                {
                    this.SendEmail
                    (
                        item, new EmailInfo
                        (
                            model.SmtpServer,
                            model.MailServerUserName,
                            model.MailServerUserPassword,
                            model.ToEmailAddress
                        )
                    );
                }

                return this.Ok();
            }
            catch(Exception)
            {

                return this.StatusCode(500, "Internal server error");
            }
        }
    }
}
