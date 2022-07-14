using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entitties.Concrete;
using Entitties.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDal _productDal;
        private readonly IProductPictureManager _productPictureManager;

        public ProductManager(IProductDal productDal, IProductPictureManager productPictureManager)
        {
            _productDal = productDal;
            _productPictureManager = productPictureManager;
        }

        public void AddProduct(AddProductDTO productDTO)
        {
            Product product = new()
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                CategoryId = productDTO.CategoryId,
                Price = productDTO.Price,
                SKU = productDTO.SKU,
                Summary = productDTO.Summary,
                CoverPhoto = productDTO.CoverPhoto,

            };

            _productDal.Add(product);

            for (int i = 0; i < productDTO.ProductPicture.Count; i++)
            {
                productDTO.ProductPicture[i].ProductId = product.Id;
                _productPictureManager.AddProductPicture(productDTO.ProductPicture[i]);
            }
        }

        public List<ProductDTO> GetAllProductList()
        {
            return _productDal.GetAllProduct();
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public ProductDTO GetProductById(int id)
        {
            return _productDal.FindById(id);
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(AddProductDTO product, int id)
        {
            var current = _productDal.Get(x => x.Id == id);
            current.Name = product.Name;
            current.Description = product.Description;
            current.Price = product.Price;
            current.CoverPhoto = product.CoverPhoto;
            current.IsSlider = product.IsSlider;
            current.SKU = product.SKU;
            current.Summary = product.Summary;
            _productDal.Update(current);
        }
    }
}
