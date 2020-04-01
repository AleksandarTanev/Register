namespace Register.Data.Models
{
    using Register.Data.Common.Models;

    public class Member : BaseDeletableModel<int>
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string PIN { get; set; }

        public virtual RegionalAssociation RegionalAssociation { get; set; }
    }
}
