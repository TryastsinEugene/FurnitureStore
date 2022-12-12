using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Data.Service.WebService
{
    public class WebServiceRepository : IWebServiceRepository
    {
        private DataContext _context;
        public WebServiceRepository(DataContext context)
        {
            _context = context;
        }
        public object GetProduct(long id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
