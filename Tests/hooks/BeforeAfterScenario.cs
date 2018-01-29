using TechTalk.SpecFlow;
using TestStackFramework.framework;

namespace Tests.hooks
{
    [Binding]
    public class BeforeAfterScenario
    {
        [AfterScenario]
        public void CloseApp()
        {
            Scope.Application.Kill();
        }
    }
}
