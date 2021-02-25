using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Domain.Services.Services;
using StefaniniCore.Specflow.Tests.Steps.Base;
using System;
using TechTalk.SpecFlow;

namespace StefaniniCore.Specflow.Tests.Steps
{
    [Binding]
    public class UserSystemSteps : StepsBase
    {
        private const string USER_NAME_KEY = "userName";
        private const string PASSWORD_KEY = "password";
        private const string RESULT_KEY = "result";

        #region .: CONSTRUCTOR :.
        private readonly IUserSystemService _userSystemService;
        private readonly Mock<IUserSystemRepository> mockUserSystemRepository;

        public UserSystemSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            mockUserSystemRepository = new Mock<IUserSystemRepository>();
            _userSystemService = new UserSystemService(mockUserSystemRepository.Object);
        }
        #endregion

        [Given(@"that user inform UserName '(.*)' and Password '(.*)'")]
        public void GivenThatUserInformUserNameAndPassword(string userName, string password)
        {
            _scenarioContext.Add(USER_NAME_KEY, userName);
            _scenarioContext.Add(PASSWORD_KEY, password);
        }

        [When(@"checks if the user exists")]
        public void WhenChecksIfTheUserExists()
        {
            string userName = _scenarioContext[USER_NAME_KEY].ToString();
            string password = _scenarioContext[PASSWORD_KEY].ToString();

            Mock<UserSystem> mockExpectedProfileType = new Mock<UserSystem>();
            mockExpectedProfileType.SetupGet(f => f.Id).Returns(1);
            mockExpectedProfileType.SetupGet(f => f.UserName).Returns(userName);
            mockExpectedProfileType.SetupGet(f => f.Password).Returns(password);
            mockExpectedProfileType.SetupGet(f => f.ProfileTypeId).Returns(2);
            mockExpectedProfileType.SetupGet(f => f.IsActive).Returns(true);
            mockExpectedProfileType.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
            mockExpectedProfileType.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);

            mockUserSystemRepository.Setup(f => f.GetSignIn(userName, password)).Returns(mockExpectedProfileType.Object);
            var userSystemResult = _userSystemService.GetSignIn(userName, password);

            _scenarioContext.Add(RESULT_KEY, userSystemResult);
        }

        [Then(@"should be returned the user data")]
        public void ThenShouldBeReturnedTheUserData()
        {
            var result = (UserSystem)_scenarioContext[RESULT_KEY];

            Assert.IsNotNull(result);
            Assert.AreEqual(_scenarioContext[USER_NAME_KEY], result.UserName);
            Assert.AreEqual(_scenarioContext[PASSWORD_KEY], result.Password);
        }
    }
}
