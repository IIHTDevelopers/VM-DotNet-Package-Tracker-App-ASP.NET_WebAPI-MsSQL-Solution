using PackageTrackerApp.DAL.Interrfaces;
using PackageTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PackageTrackerApp.Controllers
{
    public class PackageController : ApiController
    {
        private readonly IPackageTrackerService _service;
        public PackageController(IPackageTrackerService service)
        {
            _service = service;
        }
        public PackageController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Package/CreatePackage")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreatePackage([FromBody] Package model)
        {
            var leaveExists = await _service.GetPackageById(model.Id);
            var result = await _service.CreatePackage(model);
            return Ok(new Response { Status = "Success", Message = "Package created successfully!" });
        }


        [HttpPut]
        [Route("api/Package/UpdatePackage")]
        public async Task<IHttpActionResult> UpdatePackage([FromBody] Package model)
        {
            var result = await _service.UpdatePackage(model);
            return Ok(new Response { Status = "Success", Message = "Package updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Package/DeletePackage")]
        public async Task<IHttpActionResult> DeletePackage(long id)
        {
            var result = await _service.DeletePackageById(id);
            return Ok(new Response { Status = "Success", Message = "Package deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Package/GetPackageById")]
        public async Task<IHttpActionResult> GetPackageById(long id)
        {
            var expense = await _service.GetPackageById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Package/GetAllPackages")]
        public async Task<IEnumerable<Package>> GetAllPackages()
        {
            return _service.GetAllPackages();
        }
    }
}
