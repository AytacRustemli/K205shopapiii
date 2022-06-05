using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties.Concrete;
using Entitties.DTOs;

namespace Business.Abstract
{
    public interface IProductManager
    {
        void AddProduct(AddProductDTO product);
        void Remove(Product product);
        void Update(UpdateProductDTO product);
        List<Product> GetAllProducts();
        List<ProductDTO> GetAllProductList();
        ProductDTO GetProductById(int id);
    }
}
