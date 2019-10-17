using BetSports.Web.Data.Entities;
using BetSports.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetSports.Web.Data.Repositories
{
    public class BankingRepository : GenericRepository<Banking>, IBankingRepository
    {
        private readonly DataContext _dataContext;

        public BankingRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        //public BankingViewModel GetMaxIdBancking(int? idType)
        //{
        //    //int Document = (from b in _dataContext.Bankings select b.Id).Max();
        //    //var document = _dataContext.Bankings.Where(c => c.IdType == idType).Select(c => c.Id).Max();
        //    //var document = _dataContext.Bankings.Select(p => p.Id).Max();
        //    int document = _dataContext.Bankings.Select(p => p.Id).Cast<int?>().Max() ?? 0;

        //    return new BankingViewModel
        //    {
        //        Document = $"{document}"
        //    };
        //}

        //public async Task<BankingViewModel> GetMaxIdBancking()
        //{
        //    return new BankingViewModel
        //    {
        //        Document = product.Id,
        //        IsAvailabe = product.IsAvailabe,
        //        LastPurchase = product.LastPurchase,
        //        LastSale = product.LastSale,
        //        ImageUrl = product.ImageUrl,
        //        Name = product.Name,
        //        Price = product.Price,
        //        Stock = product.Stock,
        //        User = product.User
        //    };

        //    return document;
        //}


        //private ProductViewModel ToProductViewModel(Product product)
        //{
        //    return new ProductViewModel
        //    {
        //        Id = product.Id,
        //        IsAvailabe = product.IsAvailabe,
        //        LastPurchase = product.LastPurchase,
        //        LastSale = product.LastSale,
        //        ImageUrl = product.ImageUrl,
        //        Name = product.Name,
        //        Price = product.Price,
        //        Stock = product.Stock,
        //        User = product.User
        //    };
        //}
    }
}
