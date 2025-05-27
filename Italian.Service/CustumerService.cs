using Italian.Core.Models;
using Italian.Core.Services;
using Italyano.Core.Repositories;
using Italyano.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Italian.Service
{
    public class CustumerService
    {
        private readonly CustumerRepository _custumerRepository;

        public CustumerService(CustumerRepository custumerRepository)
        {
            _custumerRepository = custumerRepository;
        }

        public List<Custumer> GetAll()
        {
            // להוסיף לוגיקה עסקית.
            return _custumerRepository.GetCustumer();
        }
    }
}
