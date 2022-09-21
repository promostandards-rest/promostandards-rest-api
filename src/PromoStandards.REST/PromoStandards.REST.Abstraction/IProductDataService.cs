﻿using MongoDB.Bson;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.Abstraction
{
    public interface IProductDataService
    {
        Task<GetProductsResponse> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int page = 0, int pageSize = 20, Dictionary<string, string>? additionalParameters = null);
        Task<Product?> GetProduct(string id);
    }
}