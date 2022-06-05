using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entitties.Concrete;
using Entitties.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
       List<ProductDTO> GetAllProduct();
       ProductDTO FindById(int id);
    }
}
