using Contact.API.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(contactService.GetContactById(id));
        }
    }
}
