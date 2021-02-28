using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Code Refactoring
    public interface IProductDal : IEntityRepository<Product>
    {
       
    }
}
