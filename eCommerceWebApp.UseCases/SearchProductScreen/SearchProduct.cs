using System;
using System.Collections.Generic;
using eCommerceWebApp.CoreBusiness.Models;
using eCommerceWebApp.UseCases.PluginInterfaces.DataStore;

namespace eCommerceWebApp.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        //ProductRepository Data class, will be served from the UI infrastructure
        //through dependency injection (IoC)

        private readonly IProductRepository _productRepository;
        public SearchProduct(IProductRepository productRepository)
        {
            this._productRepository = productRepository;

        }


        public IEnumerable<Product> Execute(string filter)
        {

            return _productRepository.GetProducts(filter);
        }
    }
}
