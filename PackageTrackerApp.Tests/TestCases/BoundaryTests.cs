
using PackageTrackerApp.DAL.Interrfaces;
using PackageTrackerApp.DAL.Services;
using PackageTrackerApp.DAL.Services.Repository;
using PackageTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace PackageTrackerApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IPackageTrackerService _PackageService;
        public readonly Mock<IPackageTrackerRepository> Packageservice = new Mock<IPackageTrackerRepository>();

        private readonly Package _Package;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _PackageService = new PackageTrackerService(Packageservice.Object);

            _output = output;

            _Package = new Package
            {
                Id= 1,
                TrackingNumber="1234",
                Destination="Mumbai",
                LastUpdated= DateTime.Now,
                Status="Pending"
            };
        }

        [Fact]
        public async Task<bool> Testfor_TrackingNumber_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Packageservice.Setup(repo => repo.CreatePackage(_Package)).ReturnsAsync(_Package);
                var result = await _PackageService.CreatePackage(_Package);
                var actualLength = _Package.TrackingNumber.ToString().Length;
                if (result.TrackingNumber.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_PackageId_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Packageservice.Setup(repo => repo.CreatePackage(_Package)).ReturnsAsync(_Package);
                var result = await _PackageService.CreatePackage(_Package);
                var actualLength = _Package.Id.ToString().Length;
                if (result.Id.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_PackageDate_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Packageservice.Setup(repo => repo.CreatePackage(_Package)).ReturnsAsync(_Package);
                var result = await _PackageService.CreatePackage(_Package);
                var actualLength = _Package.LastUpdated.ToString().Length;
                if (result.LastUpdated.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Destination_NotEmpty()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                Packageservice.Setup(repo => repo.CreatePackage(_Package)).ReturnsAsync(_Package);
                var result = await _PackageService.CreatePackage(_Package);
                var actualLength = _Package.Destination.ToString().Length;
                if (result.Destination.ToString().Length == actualLength)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
       
    }
}