﻿using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IServices<T> where T : BaseEntity
    {
        void Create(Product entity);
        void Update(Product entity);
        bool Delete(Product entity);
        IEnumerable<Product> GetAll();
        Product GetProducBytId(string Id);


        //Task<IEnumerable<T>> GetAll();
        //Task<T> GetById(int id);
        //Task Add(T entity);
        //Task Update(T entity);
        //Task Delete(int id);
    }
}
