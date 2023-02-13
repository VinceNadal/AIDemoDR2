using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        // Inject JsonContactService
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET api/contacts
        [HttpGet]
        public ActionResult GetAllContacts()
        {
            var contacts = _contactService.GetAllContacts();
            return Ok(contacts);
        }

        // GET api/contacts/{id}   
        [HttpGet("{id}")]
        public ActionResult GetContact(Guid id)
        {
            var contact = _contactService.GetContact(id);
            return Ok(contact);
        }

        // Create a create contact http post request handler
        // POST api/contacts
        [HttpPost]
        public ActionResult Post(CreateContactDTO contactDTO)
        {
            var contact = _contactService.AddContact(contactDTO);
            return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
        }

        // Create an update contact http put request handler
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, UpdateContactDTO updateContactDTO)
        {
            var contact = _contactService.UpdateContact(updateContactDTO);
            return NoContent();
        }

        // Create a delete contact http delete request handler
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _contactService.DeleteContact(id);
            return NoContent();
        }
    }
}
