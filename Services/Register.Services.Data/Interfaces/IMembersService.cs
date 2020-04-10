namespace Register.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IMembersService
    {
        IEnumerable<T> GetAll<T>();

        T GetById<T>(int? id);

        Task Create<T>(T inputModel);

        Task Edit<T>(T inputModel);

        Task DeleteById(int id);

        bool Any(int id);
    }
}
