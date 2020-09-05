using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication18.Models
{
     public interface IUnitOfWork:IDisposable
    {
      
        ICompanyRepository Company { get; }
        IApplicationUserRepository ApplicationUser { get; }
     

        void Save();
    }
}
