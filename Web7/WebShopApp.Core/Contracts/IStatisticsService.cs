using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Core.Contracts
{
    public interface IStatisticsService
    {
        int CountProduct();
        int CountClient();
        int CountOrders();
        decimal SumOrders();
    }
}
