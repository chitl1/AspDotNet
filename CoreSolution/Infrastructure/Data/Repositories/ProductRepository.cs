using Application.Data.Repositories;
using Application.Models;
using AutoMapper;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public Product GetProductById(string Id)
        {
            return _dbContext.Set<Product>().Find(Id);
        }
        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            var products = _dbContext.Set<Product>().ToList();
            return _mapper.Map<IEnumerable<ProductViewModel>>(products);
        }
    }
}
