using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Services.Data
{
    public interface IMembersService
    {
        IEnumerable<T> GetAll<T>();
    }
}
