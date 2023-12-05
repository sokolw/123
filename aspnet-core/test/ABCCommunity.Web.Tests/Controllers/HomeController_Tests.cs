using System.Threading.Tasks;
using ABCCommunity.Models.TokenAuth;
using ABCCommunity.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABCCommunity.Web.Tests.Controllers
{
    public class HomeController_Tests: ABCCommunityWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}