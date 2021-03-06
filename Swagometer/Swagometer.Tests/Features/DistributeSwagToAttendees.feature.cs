﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Swagometer.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Distribute Swag To Attendees")]
    public partial class DistributeSwagToAttendeesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DistributeSwagToAttendees.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Distribute Swag To Attendees", "In order to ensure swag is distributed to meeting attendees in a fair way\r\nAs a u" +
                    "ser group organiser\r\nI want to be able to randomly choose members to receive swa" +
                    "g items", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Supplied by"});
            table1.AddRow(new string[] {
                        "Resharper",
                        "JetBrains"});
            table1.AddRow(new string[] {
                        "£10 Amazon Voucher",
                        "Spectrum IT"});
#line 7
 testRunner.Given("the following swag items", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "First Name",
                        "Last Name"});
            table2.AddRow(new string[] {
                        "Mark",
                        "Jones"});
            table2.AddRow(new string[] {
                        "Pete",
                        "Burgess"});
#line 11
 testRunner.And("the following meeting attendees", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Attendee is chosen to receive swag")]
        public virtual void AttendeeIsChosenToReceiveSwag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attendee is chosen to receive swag", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 17
 testRunner.When("I choose to give away swag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the supplier of the swag item should be clearly visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("the name of the swag item should be clearly visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("the name of the winning attendee should be clearly visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.And("the attendee should receive the swag item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("the swag item should be removed from the available swag list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Only loyal paying members should receive special swag")]
        [NUnit.Framework.TestCaseAttribute("XBox", "Developer South Coast", "member", "member", "should be", null)]
        [NUnit.Framework.TestCaseAttribute("eBook", "Manning", "non-member", "member", "should be", null)]
        [NUnit.Framework.TestCaseAttribute("XBox", "Developer South Coast", "member", "non-member", "should not be", null)]
        [NUnit.Framework.TestCaseAttribute("eBook", "Manning", "non-member", "non-member", "should be", null)]
        public virtual void OnlyLoyalPayingMembersShouldReceiveSpecialSwag(string swagName, string suppliedBy, string swagAvailability, string memberStatus, string eligibility, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only loyal paying members should receive special swag", exampleTags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 25
 testRunner.Given(string.Format("a swag item {0} with availability {1}", swagName, swagAvailability), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And(string.Format("an attendee with a status of \'{0}\'", memberStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("I choose to give away swag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then(string.Format("the attendee {0} eligible to win the swag", eligibility), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Attendee that has already received swag should not receive more swag")]
        public virtual void AttendeeThatHasAlreadyReceivedSwagShouldNotReceiveMoreSwag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attendee that has already received swag should not receive more swag", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 38
 testRunner.Given("\'Mark Jones\' has already received the \'Resharper\' swag item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When("I choose to give away swag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("\'Mark Jones\' should not be chosen to receive any more swag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And("\'Pete Burgess\' should receive the \'£10 Amazon Voucher\' swag item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An attendee that declines a swag item should not be chosen to win the same swag i" +
            "tem")]
        public virtual void AnAttendeeThatDeclinesASwagItemShouldNotBeChosenToWinTheSameSwagItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An attendee that declines a swag item should not be chosen to win the same swag i" +
                    "tem", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 44
 testRunner.Given("the \'Resharper\' swag item is the only swag left", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And("\'Mark Jones\' has previously declined receiving the \'Resharper\' swag item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.When("I choose to give away swag", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("\'Mark Jones\' should not be chosen to win", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.And("\'Pete Burgess\' should receive the \'Resharper\' swag item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
