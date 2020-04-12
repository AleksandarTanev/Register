namespace Register.Data.Models
{
    using Register.Data.Common.Models;

    public class PlaceOfResidence : BaseDeletableModel<int>
    {
        public int UprcCode { get; set; }

        public string PlaceOfResidenceName { get; set; }

        public string PostalCode { get; set; }

        public string PhoneCode { get; set; }

        public string PlaceOfResidenceType { get; set; }

        public int MunicipalityId { get; set; }

        public virtual Municipality Municipality { get; set; }
    }
}
