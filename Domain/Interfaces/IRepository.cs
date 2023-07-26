﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class

    {

        Task<int> CreateAsync(T entity);

        Task<int> EditAsync(T entity);
    }
}
