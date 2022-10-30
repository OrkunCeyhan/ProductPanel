using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfProductDal:GenericRepository<Product>, IProductDal //sadece bu entitiye ait metodlar girilebilcek
    {
    }
}
