using System;

namespace TechSivaram.DocScan.Registration
{
    public partial class RegistrationDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int StatusId { get; set; }
        public string PaymentId { get; set; }
        public string PatientCounty { get; set; }
        public int? PatientRace { get; set; }
        public string PhotoFileId { get; set; }
        public string InsuredFileId { get; set; }
        public string InsuredFileBackId { get; set; }
        public string ReasonForSeekingTest { get; set; }
        public DateTime? SymptomOnsetDate { get; set; }
        public string HouseholdTravel { get; set; }
        public string HouseholdExposure { get; set; }
        public string PreviouslySwabTested { get; set; }
        public DateTime? DateOfLastSwabTest { get; set; }
        public string LastSwabTestPerformedByLab { get; set; }
        public bool? ResultOfLastSwabTest { get; set; }
        public string PreviouslyTestedAntibody { get; set; }
        public DateTime? DateOfLastAntibodyTest { get; set; }
        public bool? ResultLastAntibody { get; set; }
        public string AntibodyTested { get; set; }
        public int? TestingRequestId { get; set; }
        public string InsuranceName { get; set; }
        public string InsurancePolicyId { get; set; }
        public string NameInsured { get; set; }
        public string RelationInsured { get; set; }
        public string InsuranceAddress1 { get; set; }
        public string InsuranceAddress2 { get; set; }
        public string InsuranceCity { get; set; }
        public string InsuranceState { get; set; }
        public string InsuranceZipCode { get; set; }
        public bool Hadtravelledoutside { get; set; }
        public bool Hadpastcovidtest { get; set; }
        public bool Hadantibodytest { get; set; }
        public bool HadContactWithCovidPatients { get; set; }
        public string OtherSymptoms { get; set; }
        public string OtherMedicalConditions { get; set; }
        public string OtherMedications { get; set; }
        public string AstAntibodyTestPerformedByLab { get; set; }
        public string InsuranceGroupId { get; set; }
        public string InsuredDOB { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPositiveResult { get; set; }
        public string LocationCode { get; set; }
    }
}