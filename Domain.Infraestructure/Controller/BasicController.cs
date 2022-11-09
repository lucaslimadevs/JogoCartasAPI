using Domain.Infraestructure.Notification;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Infraestructure.Controller
{
    [ApiController]
    public class BasicController : ControllerBase
    {
        protected readonly INotification _notification;

        public BasicController(INotification notification) 
        {
            this._notification = notification;
        }

        protected void AddNotification(string message)
        {
            this._notification.Add(message);
        }

        protected bool IsNotifications()
        {
            return this._notification.IsNotifications();
        }

        protected List<string> ListAll()
        {
            return this._notification.ListAll();
        }

        protected bool IsModelValid() 
        {
            if (!ModelState.IsValid) 
            {
                foreach (var erro in ModelState.Values.SelectMany(v => v.Errors).Where(z => z.ErrorMessage != "").Select(e => e.ErrorMessage)) 
                {
                    AddNotification(erro);
                }
            }

            return !IsNotifications();
        }

        protected ActionResult CustomizeResponse(object response, string message = "") 
        {
            if (IsNotifications()) 
            {
                return BadRequest(new
                {
                    Errors = ListAll()
                });
            }

            return Ok(new { Response = response, message = message });        
        }
    }
}
