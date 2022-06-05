using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitties.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class CommentDal : EfEntityRepositoryBase<Comment, ShopDbContext>, ICommentDal
    {
    }
}
