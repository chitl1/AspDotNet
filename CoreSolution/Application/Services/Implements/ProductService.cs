using Application.Data.Repositories;
using Application.Models;
using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implements
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper, IProductRepository productRepository, IRepository<Product> repository)
        {
            _productRepository = productRepository;
            _repository = repository;
            _mapper = mapper;
        }

        public void Create(Product entity)
        {
            _repository.Create(entity);
            _repository.SaveChanges();
        }

        public bool Delete(Product entity)
        {
            var productObj = _productRepository.GetProductById(entity.Id);
            if (productObj != null)
            {
                _repository.Delete(productObj);
                _repository.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<ProductModel> GetAllProduct()
        {
            //return _productRepository.GetAllProducts();
            //return _repository.GetAll();
            var products = _repository.GetAll();
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }

        public Product GetProducBytId(string Id)
        {
            return _repository.GetById(Id);
        }

        public void Update(Product entity)
        {
            _repository.Update(entity);
            _repository.SaveChanges();
        }
    }
}
