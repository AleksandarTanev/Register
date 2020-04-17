namespace Register.Web.ViewModels.Members
{
    using Register.Web.ViewModels.PlacesOfResidence;
    using Register.Web.ViewModels.RegionalAssociations;
    using System.Collections.Generic;

    public class CreateViewModel
    {
        public MemberInputModel memberInputModel;
        public IEnumerable<PlaceOfResidenceSimpleViewModel> placeOfResidenceSimpleViewModels;
        public IEnumerable<RegionalAssociationSimpleViewModel> regionalAssociationSimpleViewModels;

        public CreateViewModel(MemberInputModel memberInputModel, IEnumerable<PlaceOfResidenceSimpleViewModel> placeOfResidenceSimpleViewModel, IEnumerable<RegionalAssociationSimpleViewModel> regionalAssociationSimpleViewModels)
        {
            this.memberInputModel = memberInputModel;
            this.placeOfResidenceSimpleViewModels = placeOfResidenceSimpleViewModel;
            this.regionalAssociationSimpleViewModels = regionalAssociationSimpleViewModels;
        }
    }
}
