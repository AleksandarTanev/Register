namespace Register.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Register.Data.Common.Repositories;
    using Register.Data.Models;
    using Register.Services.Data.Interfaces;
    using Register.Services.Mapping;

    public class RegionalAssociationsService : IRegionalAssociationsService
    {
        private readonly IDeletableEntityRepository<RegionalAssociation> regionalAssociationsRepository;

        public RegionalAssociationsService(IDeletableEntityRepository<RegionalAssociation> regionalAssociationsRepository)
        {
            this.regionalAssociationsRepository = regionalAssociationsRepository;
        }

        public T GetById<T>(int? id)
        {
            if (id == null)
            {
                return default(T);
            }

            var regionalAssociation = this.regionalAssociationsRepository.All().Where(x => x.Id == id).To<T>().FirstOrDefault();

            return regionalAssociation;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.regionalAssociationsRepository.All().To<T>().ToList();
        }

        public async Task Create<T>(T inputModel)
        {
            RegionalAssociation newRegionalAssociation = AutoMapperConfig.MapperInstance.Map<RegionalAssociation>(inputModel);

            await this.regionalAssociationsRepository.AddAsync(newRegionalAssociation);
            await this.regionalAssociationsRepository.SaveChangesAsync();
        }

        public async Task Edit<T>(T inputModel)
        {
            RegionalAssociation newRegionalAssociation = AutoMapperConfig.MapperInstance.Map<RegionalAssociation>(inputModel);

            this.regionalAssociationsRepository.Update(newRegionalAssociation);

            await this.regionalAssociationsRepository.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var regionalAssociation = this.regionalAssociationsRepository.All().Where(x => x.Id == id).FirstOrDefault();

            if (regionalAssociation == null)
            {
                return;
            }

            this.regionalAssociationsRepository.Delete(regionalAssociation);

            await this.regionalAssociationsRepository.SaveChangesAsync();
        }

        public bool Any(int id)
        {
            return this.regionalAssociationsRepository.All().Any(x => x.Id == id);
        }
    }
}
