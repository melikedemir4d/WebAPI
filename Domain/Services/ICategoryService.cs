using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.Models;
namespace WebApi.Domain.Services
{

    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }

}
