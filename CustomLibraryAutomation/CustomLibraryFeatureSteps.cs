using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;
using TechTalk.SpecFlow;
using Telerik.WebAii.Controls.Html;

namespace CustomLibraryAutomation
{
    [Binding]
    public class CustomLibraryFeatureSteps 
    {       
        

        [Given(@"Enter (.*) and (.*) in first text box")]
        public void GivenEnterAndInFirstTextBox(int p0, int p1)
        {
            //_radTextBox = 
     

        [Then(@"Verify that result is (.*) in the result textbox")]
        public void ThenVerifyThatResultIsInTheResultTextbox(string p0)
        {
            ScenarioContext.Current.Pending();
        }    
    }
}
