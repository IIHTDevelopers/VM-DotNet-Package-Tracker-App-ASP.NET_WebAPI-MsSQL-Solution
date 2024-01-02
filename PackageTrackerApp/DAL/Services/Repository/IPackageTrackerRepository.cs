using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTrackerApp.DAL.Services.Repository
{
    public interface IPackageTrackerRepository
    {
        List<Package> GetAllPackages();
        Task<Package> CreatePackage(Package package);
        Task<Package> GetPackageById(long id);
        Task<bool> DeletePackageById(long id);
        Task<Package> UpdatePackage(Package model);
    }
}

