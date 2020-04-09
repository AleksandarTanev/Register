namespace Register.Services.Data.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRegionalAssociationsService
    {
        T GetById<T>(int? id);

        IEnumerable<T> GetAll<T>();

        Task Create<T>(T inputModel);

        Task Edit<T>(T inputModel);

        Task DeleteById(int id);

        bool Any(int id);
    }
}
