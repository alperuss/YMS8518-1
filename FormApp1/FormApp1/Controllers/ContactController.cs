using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FormApp1.Controllers
{
    
    public class ContactController : Controller
    {
        public IActionResult Send([FromBody]FormApp1.Data.ContactSendDto contactSendDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Hayırdır?");
            }
            return new JsonResult("ok");
        }
    }
}