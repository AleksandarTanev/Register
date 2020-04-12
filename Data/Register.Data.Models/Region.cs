namespace Register.Data.Models
{
    using System.Collections.Generic;

    using Register.Data.Common.Models;

    public class Region : BaseDeletableModel<int>
    {
        public string RegionName { get; set; }

        public string RegionEmail { get; set; }

        public string RegionCode { get; set; }

        public virtual ICollection<Municipality> Municipalities { get; set; }
    }
}
