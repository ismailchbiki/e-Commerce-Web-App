using System.Collections.Generic;
using eCommerceWebApp.CoreBusiness.Models;

namespace eCommerceWebApp.UseCases.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}