using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestBook.Data.Context;
using GuestBook.Data.Dto;
using GuestBook.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace GuestBook.Controllers
{
    public class GuestBookController : Controller
    {
        private readonly DataContext _dataContext;

        public GuestBookController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            List<GuestNote> guestNotes = _dataContext.GuestNotes.ToList();
            return View(guestNotes);
        }
        public IActionResult Manage()
        {
            return View();
        }
        public IActionResult LoginAction([FromBody]GuestBookLoginDto guestBookLoginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Bizde yapardık zamanında");
            }
            if(guestBookLoginDto.Username == "admin" && guestBookLoginDto.Password == "12345678")
            {

            }

            return new JsonResult("ok");
        }
        public IActionResult SendAction([FromBody]GuestBookSendActionDto guestBookSendActionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Bizde yapardık zamanında");
            }
            GuestNote guestNote = new GuestNote
            {
                Name = guestBookSendActionDto.Name,
                Surname = guestBookSendActionDto.Surname,
                Email = guestBookSendActionDto.Email,
                Message = guestBookSendActionDto.Message,
                CreateDate = DateTime.Now
            };

            _dataContext.GuestNotes.Add(guestNote);
            _dataContext.SaveChanges();

            return new JsonResult("ok");
        }
    }
}