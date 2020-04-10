namespace Register.Web.ViewModels.Members
{
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class MemberEditModel : IMapTo<Member>, IMapFrom<Member>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string PIN { get; set; }
    }
}
