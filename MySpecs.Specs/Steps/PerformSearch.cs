using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MySpecs.Specs.Steps
{
    [Binding]
    public class PerformSearch
    {
        [Given("I am on the home page")]
        public void given_i_am_on_the_home_page()
        {
            WebBrowser.Current.GoTo("http://www.google.com");
        }

        [Given("I have entered (.*) into the keyword textbox")]
        public void and_i_have_entered(string keyword)
        {
            var field = WebBrowser.Current.TextField(tf => tf.Name == "q");
            field.TypeText(keyword);
        }

        [When("I press the (.*) button")]
        public void when_i_press_the_button(string buttonName)
        {
            var button = WebBrowser.Current.Button(b => b.Name == buttonName);

            button.Click();

            WebBrowser.Current.WaitForComplete();
        }

        [Then("I should see a list of articles related to (.*)")]
        public void then_i_should_see_a_list_articles_related_to(string keyword)
        {
            WebBrowser.Current.WaitUntilContainsText("resultados (");

            var searchDiv = WebBrowser.Current.Div("resultStats");

            Assert.IsTrue(searchDiv.Children().Count == 1);
        }
    }
}
