using BlazorDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Service
{
    public class CustomerDetailService : ICustomerDetailService
    {
        private readonly CustomerDetailRepo _repo = new CustomerDetailRepo("Data Source=127.0.0.1,1432;Initial Catalog=CustomerOrderViewer;User ID=sa;Password=Olaide+6690");

        public IList<CustomerDetailModel> GetList()
        {
            return _repo.GetList();
        }
    }
}
