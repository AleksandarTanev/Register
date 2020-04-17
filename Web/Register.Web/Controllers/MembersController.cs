namespace Register.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using Register.Services.Data;
    using Register.Services.Data.Interfaces;
    using Register.Web.ViewModels.Members;
    using Register.Web.ViewModels.PlacesOfResidence;

    public class MembersController : Controller
    {
        private readonly IMembersService service;
        private readonly IPlacesOfResidenceService placesOfResidenceService;

        public MembersController(IMembersService service, IPlacesOfResidenceService placesOfResidenceService)
        {
            this.service = service;
            this.placesOfResidenceService = placesOfResidenceService;
        }

        // GET: Members
        public IActionResult Index()
        {
            return this.View(this.service.GetAll<MemberViewModel>());
        }

        // GET: Members/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var member = this.service.GetById<MemberViewModel>(id);

            if (member == null)
            {
                return this.NotFound();
            }

            return this.View(member);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            return this.View(new CreateViewModel(new MemberInputModel(), this.placesOfResidenceService.GetAll<PlaceOfResidenceSimpleViewModel>()));
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] MemberInputModel member)
        {
            if (this.ModelState.IsValid)
            {
                await this.service.Create(member);

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(new CreateViewModel(member, this.placesOfResidenceService.GetAll<PlaceOfResidenceSimpleViewModel>()));
        }

        // GET: Members/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var member = this.service.GetById<MemberEditModel>(id);

            if (member == null)
            {
                return this.NotFound();
            }

            return this.View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind] MemberEditModel member)
        {
            if (id != member.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                await this.service.Edit(member);

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(member);
        }

        // GET: Members/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var member = this.service.GetById<MemberDeleteModel>(id);

            if (member == null)
            {
                return this.NotFound();
            }

            return this.View(member);
        }

        // POST: Members/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.service.DeleteById(id);

            return this.RedirectToAction(nameof(this.Index));
        }

        private bool MemberExists(int id)
        {
            return this.service.Any(id);
        }
    }
}
