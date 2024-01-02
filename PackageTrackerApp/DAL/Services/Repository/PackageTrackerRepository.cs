using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PackageTrackerApp.DAL.Services.Repository
{
    public class PackageTrackerRepository : IPackageTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public PackageTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Package> CreatePackage(Package package)
        {
            try
            {
                var result = _dbContext.Packages.Add(package);
                await _dbContext.SaveChangesAsync();
                return package;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeletePackageById(long id)
        {
            try
            {
                _dbContext.Packages.Remove(_dbContext.Packages.Single(a => a.Id == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Package> GetAllPackages()
        {
            try
            {
                var result = _dbContext.Packages.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Package> GetPackageById(long id)
        {
            try
            {
                return await _dbContext.Packages.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }       

        public async Task<Package> UpdatePackage(Package model)
        {
            var ex = await _dbContext.Packages.FindAsync(model.Id);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}