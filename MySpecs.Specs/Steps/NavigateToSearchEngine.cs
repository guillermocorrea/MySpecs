using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WatiN.Core;
using NUnit.Framework;

namespace MySpecs.Specs.Steps
{
    [Binding]
    public class NavigateToSearchEngine
    {
        [When("I enter (.*) in the address bar")]
        public void when_i_enter_the_url(string url)
        {
            WebBrowser.Current.GoTo(url);
        }

        [Then("I should be on the home page")]
        public void then_i_should_be_on_the_home_page()
        {
            Assert.AreEqual(WebBrowser.Current.Title, "Google");
            Assert.IsTrue(WebBrowser.Current.TextFields.Exists(tf => tf.Name == "q"));
        }
    }
}
