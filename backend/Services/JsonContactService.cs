using API.Data;
using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.Services
{
    // Use JsonRepository to implement the interface
    public class JsonContactService : IContactService
    {
        private readonly JsonRepository _repository;
        private readonly IMapper _mapper;

        public JsonContactService(JsonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<ReadContactDTO> GetAllContacts()
        {
            var contacts = _repository.GetAllContacts();
            return _mapper.Map<List<ReadContactDTO>>(contacts);
        }

        public ReadContactDTO GetContact(Guid id)
        {
            var contact = _repository.GetContact(id);
            return _mapper.Map<ReadContactDTO>(contact);
        }

        public ReadContactDTO AddContact(CreateContactDTO contact)
        {
            var contactModel = _mapper.Map<Contact>(contact);
            _repository.AddContact(contactModel);
            _repository.SaveChanges();
            return _mapper.Map<ReadContactDTO>(contactModel);
        }

        public ReadContactDTO UpdateContact(UpdateContactDTO contact)
        {
            var contactModel = _mapper.Map<Contact>(contact);
            _repository.UpdateContact(contactModel);
            _repository.SaveChanges();
            return _mapper.Map<ReadContactDTO>(contactModel);
        }

        public void DeleteContact(Guid id)
        {
            _repository.DeleteContact(id);
            _repository.SaveChanges();
        }
    }
}
