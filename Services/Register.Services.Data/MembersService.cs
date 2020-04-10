namespace Register.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Register.Data.Common.Repositories;
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class MembersService : IMembersService
    {
        private readonly IDeletableEntityRepository<Member> membersRepository;

        public MembersService(IDeletableEntityRepository<Member> membersRepository)
        {
            this.membersRepository = membersRepository;
        }

        public T GetById<T>(int? id)
        {
            if (id == null)
            {
                return default(T);
            }

            var regionalAssociation = this.membersRepository.All().Where(x => x.Id == id).To<T>().FirstOrDefault();

            return regionalAssociation;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.membersRepository.All().To<T>().ToList();
        }

        public async Task Create<T>(T inputModel)
        {
            var newMember = AutoMapperConfig.MapperInstance.Map<Member>(inputModel);

            await this.membersRepository.AddAsync(newMember);
            await this.membersRepository.SaveChangesAsync();
        }

        public async Task Edit<T>(T inputModel)
        {
            var editMember = AutoMapperConfig.MapperInstance.Map<Member>(inputModel);

            this.membersRepository.Update(editMember);

            await this.membersRepository.SaveChangesAsync();
        }

        public async Task DeleteById(int id)
        {
            var regionalAssociation = this.membersRepository.All().Where(x => x.Id == id).FirstOrDefault();

            if (regionalAssociation == null)
            {
                return;
            }

            this.membersRepository.Delete(regionalAssociation);

            await this.membersRepository.SaveChangesAsync();
        }

        public bool Any(int id)
        {
            return this.membersRepository.All().Any(x => x.Id == id);
        }
    }
}
