using BlazorDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Service
{
    interface ICustomerDetailService
    {
        IList<CustomerDetailModel> GetList();
    }
}
