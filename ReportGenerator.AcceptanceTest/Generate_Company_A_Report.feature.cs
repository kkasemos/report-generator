﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ReportGenerator.AcceptanceTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Generate Company A Report")]
    public partial class GenerateCompanyAReportFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Generate_Company_A_Report.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Generate Company A Report", "In order to forecast demand for our products from Company A\r\nAs a product manager" +
                    "\r\nI want to know how many our products Company A sell every day grouped by produ" +
                    "ct name", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No duplicate record")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public virtual void NoDuplicateRecord()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No duplicate record", new string[] {
                        "HappyPath"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product Name",
                        "Amount"});
            table1.AddRow(new string[] {
                        "Product A",
                        "100"});
            table1.AddRow(new string[] {
                        "Product B",
                        "200"});
            table1.AddRow(new string[] {
                        "Product C",
                        "300"});
#line 8
 testRunner.Given("Input is", ((string)(null)), table1, "Given ");
#line 13
 testRunner.When("It generates a report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product Name",
                        "Amount",
                        "Qty"});
            table2.AddRow(new string[] {
                        "Product A",
                        "100",
                        "1"});
            table2.AddRow(new string[] {
                        "Product B",
                        "200",
                        "1"});
            table2.AddRow(new string[] {
                        "Product C",
                        "300",
                        "1"});
#line 14
 testRunner.Then("Output is", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Have duplicate records")]
        public virtual void HaveDuplicateRecords()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Have duplicate records", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product Name",
                        "Amount"});
            table3.AddRow(new string[] {
                        "Product A",
                        "100"});
            table3.AddRow(new string[] {
                        "Product B",
                        "200"});
            table3.AddRow(new string[] {
                        "Product C",
                        "300"});
            table3.AddRow(new string[] {
                        "Product B",
                        "200"});
            table3.AddRow(new string[] {
                        "Product A",
                        "100"});
#line 21
 testRunner.Given("Input is", ((string)(null)), table3, "Given ");
#line 28
 testRunner.When("It generates a report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product Name",
                        "Amount",
                        "Qty"});
            table4.AddRow(new string[] {
                        "Product A",
                        "100",
                        "2"});
            table4.AddRow(new string[] {
                        "Product B",
                        "200",
                        "2"});
            table4.AddRow(new string[] {
                        "Product C",
                        "300",
                        "1"});
#line 29
 testRunner.Then("Output is", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The same product name has different amounts")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        public virtual void TheSameProductNameHasDifferentAmounts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The same product name has different amounts", new string[] {
                        "HappyPath"});
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product Name",
                        "Amount"});
            table5.AddRow(new string[] {
                        "Product A",
                        "100"});
            table5.AddRow(new string[] {
                        "Product B",
                        "100"});
            table5.AddRow(new string[] {
                        "Product C",
                        "300"});
            table5.AddRow(new string[] {
                        "Product B",
                        "200"});
            table5.AddRow(new string[] {
                        "Product A",
                        "100"});
#line 37
 testRunner.Given("Input is", ((string)(null)), table5, "Given ");
#line 44
 testRunner.When("It generates a report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Product Name",
                        "Amount",
                        "Qty"});
            table6.AddRow(new string[] {
                        "Product A",
                        "100",
                        "2"});
            table6.AddRow(new string[] {
                        "Product C",
                        "300",
                        "1"});
#line 45
 testRunner.Then("Output is", ((string)(null)), table6, "Then ");
#line hidden
#line 49
 testRunner.And("Error log file contains", "Product A records have different amounts", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion