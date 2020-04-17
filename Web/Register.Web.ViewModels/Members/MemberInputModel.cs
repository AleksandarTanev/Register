namespace Register.Web.ViewModels.Members
{
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class MemberInputModel : IMapTo<Member>
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string PIN { get; set; }

        public int RegionalAssociationId { get; set; }

        public int PlaceOfResidenceId { get; set; }
    }
}
