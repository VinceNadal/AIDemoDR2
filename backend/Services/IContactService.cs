using API.DTOs;

namespace API.Services
{
    public interface IContactService
    {
        // Use JsonRepository's Crud Methods 
        List<ReadContactDTO> GetAllContacts();
        ReadContactDTO GetContact(Guid id);
        ReadContactDTO AddContact(CreateContactDTO contact);
        ReadContactDTO UpdateContact(UpdateContactDTO contact);
        void DeleteContact(Guid id);
    }
}
