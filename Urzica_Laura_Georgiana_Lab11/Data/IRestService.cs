using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urzica_Laura_Georgiana_Lab11.Models;

namespace Urzica_Laura_Georgiana_Lab11.Data
{
    internal interface IRestService
    {
        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }
    }
}
