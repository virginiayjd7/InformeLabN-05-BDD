using CoreBDD;
using Xunit;

namespace Demobdd
{
    public class LoginToWebsiteScenario: LoginFeature
    {
        [Scenario("LoginToWebsite Description")]
        public void LoginToWebsite()
        {
            Given($"I have ....",   () => { });
            When($"I ...",          () => { });
            Then($"I ...",			() => { });
        }
    }
}