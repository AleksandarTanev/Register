namespace Register.Web.Controllers
{
    using System.Threading.Tasks;
    using Register.Services.Data.Interfaces;
    using Register.Web.ViewModels.RegionalAssociations;
    using Microsoft.AspNetCore.Mvc;

    public class RegionalAssociationsController : Controller
    {
        private readonly IRegionalAssociationsService service;

        public RegionalAssociationsController(IRegionalAssociationsService service)
        {
            this.service = service;
        }

        // GET: RegionalAssociations
        public IActionResult Index()
        {
            return this.View(this.service.GetAll<RegionalAssociationViewModel>());
        }

        // GET: RegionalAssociations/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var regionalAssociation = this.service.GetById<RegionalAssociationViewModel>(id);

            if (regionalAssociation == null)
            {
                return this.NotFound();
            }

            return this.View(regionalAssociation);
        }

        // GET: RegionalAssociations/Create
        public IActionResult Create()
        {
            return this.View(new RegionalAssociationInputModel());
        }

        // POST: RegionalAssociations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind] RegionalAssociationInputModel regionalAssociationInputModel)
        {
            if (this.ModelState.IsValid)
            {
                await this.service.Create(regionalAssociationInputModel);

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(regionalAssociationInputModel);
        }

        // GET: RegionalAssociations/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var regionalAssociation = this.service.GetById<RegionalAssociationEditModel>(id);

            if (regionalAssociation == null)
            {
                return this.NotFound();
            }

            return this.View(regionalAssociation);
        }

        // POST: RegionalAssociations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind]RegionalAssociationEditModel regionalAssociationInputModel)
        {
            if (id != regionalAssociationInputModel.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                await this.service.Edit(regionalAssociationInputModel);

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(regionalAssociationInputModel);
        }

        // GET: RegionalAssociations/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var regionalAssociation = this.service.GetById<RegionalAssociationDeleteModel>(id);

            if (regionalAssociation == null)
            {
                return this.NotFound();
            }

            return this.View(regionalAssociation);
        }

        // POST: RegionalAssociations/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.service.DeleteById(id);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
