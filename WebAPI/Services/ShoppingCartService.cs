using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        ShoppingItem IShoppingCartService.Add(ShoppingItem newItem)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ShoppingItem> IShoppingCartService.GetAll()
        {
            throw new NotImplementedException();
        }

        ShoppingItem IShoppingCartService.GetShoppingItemById(Guid id)
        {
            throw new NotImplementedException();
        }

        void IShoppingCartService.Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
