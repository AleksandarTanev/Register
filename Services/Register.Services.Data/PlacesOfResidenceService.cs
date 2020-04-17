namespace Register.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Register.Data.Common.Repositories;
    using Register.Data.Models;
    using Register.Services.Data.Interfaces;
    using Register.Services.Mapping;

    public class PlacesOfResidenceService : IPlacesOfResidenceService
    {
        private readonly IDeletableEntityRepository<PlaceOfResidence> placesOfResidenceRepository;

        public PlacesOfResidenceService(IDeletableEntityRepository<PlaceOfResidence> placesOfResidenceRepository)
        {
            this.placesOfResidenceRepository = placesOfResidenceRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.placesOfResidenceRepository.All().To<T>().ToList();
        }
    }
}
