﻿using E_Commerce.Core.Entities;
using E_Commerce.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Repositories.Contract
{
    public interface IUnitOfWork
    {
        IGenericRepository<Product> ProductRepo { get; set; }
        IGenericRepository<Category> CategoryRepo { get; set; }
        IGenericRepository<Seller> SellerRepo { get; set; }
        IReviewRepository<Review> ReviewRepo { get; set; }

        IGenericRepositoryUser<AppUser> UserRepo { get; set; }

        IColorRepository ColotRepo { get; set; }
    }
}
