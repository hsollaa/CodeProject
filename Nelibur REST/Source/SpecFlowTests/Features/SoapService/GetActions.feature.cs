﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowTests.Features.SoapService
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class GetSoapActionsFeature : Xunit.IUseFixture<GetSoapActionsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetActions.feature"
#line hidden
        
        public GetSoapActionsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Get soap actions", "In order to find an object instance accordingly with CRUD and message based parad" +
                    "igm\r\nAs a developer\r\nI want to use Get action", ProgrammingLanguage.CSharp, new string[] {
                        "SoapService"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(GetSoapActionsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Get soap actions")]
        [Xunit.TraitAttribute("Description", "Get data with response")]
        public virtual void GetDataWithResponse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get data with response", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("the Soap service was started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table1.AddRow(new string[] {
                        "107",
                        "105",
                        "5B1706AC-F33C-43B5-8ACF-BAEB2E73BB95"});
#line 9
 testRunner.And("I sent data thru Post action", ((string)(null)), table1, "And ");
#line 12
 testRunner.When("I request data by Id \'107\' thru Get action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table2.AddRow(new string[] {
                        "107",
                        "105",
                        "5B1706AC-F33C-43B5-8ACF-BAEB2E73BB95"});
#line 13
 testRunner.Then("I get data", ((string)(null)), table2, "Then ");
#line 16
 testRunner.And("the Soap service was stopped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Get soap actions")]
        [Xunit.TraitAttribute("Description", "GetAsync data with response")]
        public virtual void GetAsyncDataWithResponse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetAsync data with response", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("the Soap service was started", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table3.AddRow(new string[] {
                        "2",
                        "7",
                        "5695F19D-2DFF-401A-8F34-EBC161A6EBB5"});
#line 20
 testRunner.And("I sent data thru Post action", ((string)(null)), table3, "And ");
#line 23
 testRunner.When("I request data by Id \'2\' thru GetAsync action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Quantity",
                        "ProductId"});
            table4.AddRow(new string[] {
                        "2",
                        "7",
                        "5695F19D-2DFF-401A-8F34-EBC161A6EBB5"});
#line 24
 testRunner.Then("I get data", ((string)(null)), table4, "Then ");
#line 27
 testRunner.And("the Soap service was stopped", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                GetSoapActionsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GetSoapActionsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
