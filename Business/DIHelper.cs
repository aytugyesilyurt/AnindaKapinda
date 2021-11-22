using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class DIHelper
    {
        public static IServiceCollection AddDALDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserDal, EFCUserDal>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IProductDal, EFCProductDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryDal, EFCCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IEmployeeDal, EFCEmployeeDal>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IOrderDal, EFCOrderDal>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IAddressDal, EFCAddressDal>();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<ICreditCardDal, EFCCreditCardDal>();
            services.AddScoped<ICreditCardService, CreditCardManager>();
            services.AddScoped<IBasketDal, EFCBasketDal>();
            services.AddScoped<IBasketService, BasketManager>();
            services.AddScoped<IBasketDetailDal, EFCBasketDetailDal>();
            services.AddScoped<IBasketDetailService, BasketDetailManager>();


            return services;
        }
    }
}
