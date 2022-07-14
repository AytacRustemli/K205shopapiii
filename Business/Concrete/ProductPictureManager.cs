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
    public class ProductPictureManager : IProductPictureManager
    {
        private readonly IProductPictureDal _productPictureDal;

        public ProductPictureManager(IProductPictureDal productPictureDal)
        {
            _productPictureDal = productPictureDal;
        }

        public void AddProductPicture(ProductPictureDTO productPicture)
        {
            ProductPicture picture = new()
            {
                ProductId = productPicture.ProductId,
                PhotoURL = productPicture.PhotoURL,
            };
            _productPictureDal.Add(picture);
             
        }

        
    }
}
