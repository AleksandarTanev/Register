namespace Register.Web.ViewModels.RegionalAssociations
{
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class RegionalAssociationViewModel : IMapFrom<RegionalAssociation>
    {
        public int Id { get; set; }

        public string AssociationName { get; set; }

        public string Bulstat { get; set; }

        public string WorkAddress { get; set; }

        public string ContactAddress { get; set; }

        public int RegionCode { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string BankName { get; set; }

        public string BranchName { get; set; }

        public string BankAddress { get; set; }

        public string BIC { get; set; }

        public string IBAN { get; set; }
    }
}
