﻿using amir_apparel_demo_api_dotnet_5.API.QueryParams;
using amir_apparel_demo_api_dotnet_5.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace amir_apparel_demo_api_dotnet_5.Data.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(PaginationQueryParams paginationQueryParams);
    }
}