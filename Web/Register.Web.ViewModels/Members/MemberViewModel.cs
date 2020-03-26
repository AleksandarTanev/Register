namespace Register.Web.ViewModels.Members
{
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class MemberViewModel : IMapFrom<Member>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string PIN { get; set; }
    }
}
