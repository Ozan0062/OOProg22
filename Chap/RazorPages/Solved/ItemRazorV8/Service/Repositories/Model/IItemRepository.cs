﻿using ItemRazorV1.Models;
using ItemRazorV1.Service.Repositories.Interfaces;

namespace ItemRazorV1.Service.Repositories.Model
{
    public interface IItemRepository : IRepository<Item>
    {
        IEnumerable<Item> PriceFilter(int maxPrice, int minPrice = 0);
    }
}
