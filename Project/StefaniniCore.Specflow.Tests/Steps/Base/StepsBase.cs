using StefaniniCore.Specflow.Tests.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;

namespace StefaniniCore.Specflow.Tests.Steps.Base
{
    /// <summary>
    ///  Class to initialize SpecFlow.
    /// </summary>
    public abstract class StepsBase
    {
        protected static string _scenarioTitle = string.Empty;
        protected static Dictionary<int, TestCaseSteps> _dictionarySteps = new Dictionary<int, TestCaseSteps>();
        protected readonly ScenarioContext _scenarioContext;

        private const string TAG = "##";
        private static int _indexDictionary = 0;

        protected StepsBase(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        protected void InitializeScenario(ScenarioContext scenarioContext)
        {
            _scenarioTitle = scenarioContext.ScenarioInfo.Title;
        }

        [BeforeStep]
        protected void InitializeStep()
        {
            StepDefinitionType currentStepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType;

            if (!_dictionarySteps.Any())
            {
                if (currentStepType == StepDefinitionType.Given
                    || currentStepType == StepDefinitionType.When)
                {
                    AddSteps(EnumStepType.ACTION, null);
                }
                else
                {
                    AddSteps(EnumStepType.EXPECTED_RESULT, null);
                }
            }
            else
            {
                TestCaseSteps lastDictionaryIndex = _dictionarySteps.LastOrDefault().Value;

                if ((currentStepType == StepDefinitionType.Given)
                    || (currentStepType == StepDefinitionType.When))
                {
                    AddSteps(EnumStepType.ACTION, lastDictionaryIndex);
                }
                else
                {
                    AddSteps(EnumStepType.EXPECTED_RESULT, lastDictionaryIndex);
                }
            }
        }

        /// <summary>
        /// Get the data table on text format.
        /// </summary>
        /// <param name="table"></param>
        private string GetTableTextFromTable(Table table)
        {
            if ((table == null || (table.Header == null) || (table.Rows == null)))
                throw new Exception("Table data invalid to be used.");

            string headerTable = $"| {string.Join(" | ", table.Header)} |\r\n";
            string bodyTable = string.Empty;

            foreach (var row in table.Rows)
            {
                bodyTable += $"| {string.Join(" | ", row.Values)} |\r\n";
            }
            string newTextToAddOnStep = $"{headerTable}{bodyTable}";

            return newTextToAddOnStep;
        }

        private void AddSteps(EnumStepType enumStepType, TestCaseSteps lastTestCaseSteps)
        {
            TestCaseSteps testCaseSteps = new TestCaseSteps();

            // table from parameter of Step method.
            Table table = ScenarioStepContext.Current.StepInfo.Table;
            string tableStr = string.Empty;

            if (table != null)
                tableStr = $"\r\n{GetTableTextFromTable(table)}";

            if (EnumStepType.ACTION == enumStepType)
            {
                string action = GetTextFormatted(lastTestCaseSteps);
                string expectedResult = null;

                if ((lastTestCaseSteps != null) && (!string.IsNullOrEmpty(lastTestCaseSteps.Action)))
                {
                    if (lastTestCaseSteps.StepDefinition == ScenarioStepContext.Current.StepInfo.StepDefinitionType)
                    {
                        action = $"{lastTestCaseSteps.Action}\r\n{action}";
                        expectedResult = lastTestCaseSteps.ExpectedResult;

                        _dictionarySteps.Remove(_indexDictionary);
                        _indexDictionary--;
                    }
                }

                action += tableStr;

                testCaseSteps = new TestCaseSteps()
                {
                    StepDefinition = ScenarioStepContext.Current.StepInfo.StepDefinitionType,
                    Action = action,
                    ExpectedResult = expectedResult
                };
            }
            else if (EnumStepType.EXPECTED_RESULT == enumStepType)
            {
                string expectedResult = GetTextFormatted(lastTestCaseSteps);

                if (lastTestCaseSteps.StepDefinition == StepDefinitionType.Then)
                    expectedResult = $"{lastTestCaseSteps.ExpectedResult}\r\n{expectedResult}";

                expectedResult += tableStr;

                testCaseSteps = new TestCaseSteps()
                {
                    StepDefinition = ScenarioStepContext.Current.StepInfo.StepDefinitionType,
                    Action = _dictionarySteps.LastOrDefault().Value.Action,
                    ExpectedResult = expectedResult
                };

                _dictionarySteps.Remove(_indexDictionary);
                _indexDictionary--;
            }

            _indexDictionary++;
            _dictionarySteps.Add(_indexDictionary, testCaseSteps);
        }

        /// <summary>
        /// Change the Step Type to 'And' if needed.
        /// </summary>
        /// <param name="lastTestCaseSteps"></param>
        private string GetTextFormatted(TestCaseSteps lastTestCaseSteps)
        {
            string currentStep = $"{TAG}{ScenarioStepContext.Current.StepInfo.StepDefinitionType}{TAG}"
                                + $" {ScenarioStepContext.Current.StepInfo.Text}";

            if ((lastTestCaseSteps != null)
                && (lastTestCaseSteps.StepDefinition == ScenarioStepContext.Current.StepInfo.StepDefinitionType))
            {
                Regex regexPattern = new Regex($@"{TAG}\w*{TAG}");
                Match match = regexPattern.Match(currentStep);

                string[] arrayText = match.Value.Split(new string[] { TAG }, StringSplitOptions.None);

                currentStep = currentStep.Replace(arrayText[1], "And");
            }
            return currentStep;
        }

        [AfterScenario]
        protected void CloseScenario()
        {
            // TODO
        }

        public class TestCaseSteps
        {
            public StepDefinitionType StepDefinition { get; set; }
            public string Action { get; set; }
            public string ExpectedResult { get; set; }
        }
    }
}
