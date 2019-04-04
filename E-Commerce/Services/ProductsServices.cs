﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using E_Commerce.Models;
using E_Commerce.Repositories;

namespace E_Commerce.Services
{
    public class ProductsService
    {
        private IProductsRepository productsRepository;

        public ProductsService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public List<Products> Get()
        {
            return this.productsRepository.Get();
        }

        public List<Products> Get(string key)
        {
            return this.productsRepository.Get(key);
        }
    }
}