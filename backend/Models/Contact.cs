namespace API.Models
{
    public class Contact
    {
        //Create a Contact model that has properties Id if type Guid, firstname, lastname, physical address and delivery address
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhysicalAddress { get; set; }
        public string DeliveryAddress { get; set; }
        
    }
}
