using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties.Concrete;
using Entitties.DTOs;

namespace Business.Abstract
{
    public interface IProductPictureManager
    {
        void AddProductPicture(ProductPictureDTO productPicture);
        //void UpdateProductPicture(ProductPictureDTO productPicture);
    }
}
