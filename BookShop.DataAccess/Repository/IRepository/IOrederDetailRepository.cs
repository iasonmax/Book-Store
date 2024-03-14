using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccess.Repository.IRepository
{
    public interface IOrederDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);
    }
}
