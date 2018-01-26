using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
