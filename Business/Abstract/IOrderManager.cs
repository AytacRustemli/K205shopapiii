using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties.Concrete;
using Entitties.DTOs;

namespace Business.Abstract
{
    public interface IOrderManager
    {
        void Add(Order order);
        void Remove(Order order);
        void Update(Order order);
        List<Order> GetOrderById(int userId);
        List<OrderDTO> GetAll(int userId);
    }
}
