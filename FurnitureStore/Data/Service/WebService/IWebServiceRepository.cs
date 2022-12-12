using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Data.Service.WebService
{
    public interface IWebServiceRepository
    {
        object GetProduct(long id);
    }
}
