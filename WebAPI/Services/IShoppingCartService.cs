using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IShoppingCartService
    {
        IEnumerable<ShoppingItem> GetAll();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetShoppingItemById(Guid id);
        void Remove(Guid id);

    }
}
