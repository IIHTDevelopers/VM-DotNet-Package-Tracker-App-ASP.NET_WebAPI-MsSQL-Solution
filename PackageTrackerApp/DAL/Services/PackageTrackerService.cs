using PackageTrackerApp.DAL.Interrfaces;
using PackageTrackerApp.DAL.Services.Repository;
using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PackageTrackerApp.DAL.Services
{
    public class PackageTrackerService : IPackageTrackerService
    {
        private readonly IPackageTrackerRepository _repository;

        public PackageTrackerService(IPackageTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Package> CreatePackage(Package package)
        {
            return _repository.CreatePackage(package);
        }

        public Task<bool> DeletePackageById(long id)
        {
            return _repository.DeletePackageById(id);
        }

        public List<Package> GetAllPackages()
        {
            return _repository.GetAllPackages();
        }

        public Task<Package> GetPackageById(long id)
        {
            return _repository.GetPackageById(id);
        }

        public Task<Package> UpdatePackage(Package model)
        {
            return _repository.UpdatePackage(model);
        }
    }
}