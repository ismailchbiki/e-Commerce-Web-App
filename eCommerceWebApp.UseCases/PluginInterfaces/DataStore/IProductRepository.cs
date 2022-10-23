using System;
using System.Collections.Generic;
using eCommerceWebApp.CoreBusiness.Models;

namespace eCommerceWebApp.UseCases.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        //the implementation of these interfaces is inside the plugin folder
        IEnumerable<Product> GetProducts(string filter);
        Product GetProduct(int id);
    }
}

