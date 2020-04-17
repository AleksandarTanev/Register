namespace Register.Web.ViewModels.PlacesOfResidence
{
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class PlaceOfResidenceSimpleViewModel : IMapFrom<PlaceOfResidence>
    {
        public int Id { get; set; }

        public string PlaceOfResidenceName { get; set; }
    }
}
