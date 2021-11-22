using Core.DataAccess.EntityFrameworkCore;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EFCBasketDetailDal : EFCEntityRepositoryBase<BasketDetail, AnindaKapindaDbContext>, IBasketDetailDal
    {

    }
}
