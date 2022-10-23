using eCommerceWebApp.CoreBusiness.Models;

namespace eCommerceWebApp.UseCases.SearchProductScreen
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}