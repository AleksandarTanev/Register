namespace Register.Web.ViewModels.Members
{
    using Register.Web.ViewModels.PlacesOfResidence;
    using System.Collections.Generic;

    public class CreateViewModel
    {
        public MemberInputModel memberInputModel;
        public IEnumerable<PlaceOfResidenceSimpleViewModel> placesOfResidenceSimpleViewModel;

        public CreateViewModel(MemberInputModel memberInputModel, IEnumerable<PlaceOfResidenceSimpleViewModel> placeOfResidenceSimpleViewModel)
        {
            this.memberInputModel = memberInputModel;
            this.placesOfResidenceSimpleViewModel = placeOfResidenceSimpleViewModel;
        }
    }
}
