using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTrackerApp.DAL.Interrfaces
{
    public interface IPackageTrackerService
    {
        List<Package> GetAllPackages();
        Task<Package> CreatePackage(Package package);
        Task<Package> GetPackageById(long id);
        Task<bool> DeletePackageById(long id);
        Task<Package> UpdatePackage(Package model);
    }
}
