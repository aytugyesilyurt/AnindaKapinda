using Core.DataAccess.EntityFrameworkCore;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EFCAddressDal : EFCEntityRepositoryBase<Address, AnindaKapindaDbContext>, IAddressDal
    {

    }
}
