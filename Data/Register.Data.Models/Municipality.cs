namespace Register.Data.Models
{
    using Register.Data.Common.Models;
    using System.Collections.Generic;

    public class Municipality : BaseDeletableModel<int>
    {
        public string NhifCode { get; set; }

        public string MunicipalityName { get; set; }

        public int RegionId { get; set; }

        public Region Region { get; set; }

        public virtual ICollection<PlaceOfResidence> PlacesOfResidence { get; set; }
    }
}
