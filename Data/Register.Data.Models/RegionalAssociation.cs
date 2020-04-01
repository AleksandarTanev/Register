namespace Register.Data.Models
{
    using System.Collections.Generic;
    using Register.Data.Common.Models;

    public class RegionalAssociation : BaseDeletableModel<int>
    {
        public RegionalAssociation()
        {
            this.Members = new HashSet<Member>();
        }

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

        public virtual ICollection<Member> Members { get; set; }
    }
}
