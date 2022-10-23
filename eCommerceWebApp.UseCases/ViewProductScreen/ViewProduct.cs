using System;
using eCommerceWebApp.CoreBusiness.Models;
using eCommerceWebApp.UseCases.PluginInterfaces.DataStore;

namespace eCommerceWebApp.UseCases.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {

        private readonly IProductRepository _productRepository;
        public ViewProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }


        public Product Execute(int id)
        {
            return _productRepository.GetProduct(id);
        }
    }
}

