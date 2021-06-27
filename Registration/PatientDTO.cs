using System;


namespace TechSivaram.DocScan.Registration
{
    public class PatientDTO
    {
        public PatientDTO()
        {

        }
        public int Id { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte GenderId { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string SitePhone { get; set; }
        public virtual RegistrationDTO Registration { get; set; }
        public string Symptoms { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
        public string ProviderNPI { get; set; }
    }
}