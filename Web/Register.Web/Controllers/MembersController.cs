namespace Register.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Register.Services.Data;
    using Register.Web.ViewModels.Members;

    public class MembersController : Controller
    {
        private readonly IMembersService membersService;

        public MembersController(IMembersService membersService)
        {
            this.membersService = membersService;
        }

        public IActionResult Index()
        {
            return this.View(this.membersService.GetAll<MemberViewModel>());
        }
    }
}