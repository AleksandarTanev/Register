namespace Register.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Register.Data.Common.Repositories;
    using Register.Data.Models;
    using Register.Services.Mapping;

    public class MembersService : IMembersService
    {
        private readonly IDeletableEntityRepository<Member> membersRepository;

        public MembersService(IDeletableEntityRepository<Member> settingsRepository)
        {
            this.membersRepository = settingsRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.membersRepository.All().To<T>().ToList();
        }
    }
}
