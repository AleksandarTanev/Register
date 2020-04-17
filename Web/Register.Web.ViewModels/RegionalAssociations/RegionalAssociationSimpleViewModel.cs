namespace Register.Web.ViewModels.RegionalAssociations
{
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class RegionalAssociationSimpleViewModel : IMapFrom<RegionalAssociation>
    {
        public int Id { get; set; }

        public string AssociationName { get; set; }
    }
}
