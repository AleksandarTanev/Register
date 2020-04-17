namespace Register.Services.Data.Interfaces
{
    using System.Collections.Generic;

    public interface IPlacesOfResidenceService
    {
        IEnumerable<T> GetAll<T>();
    }
}
