using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAspNet45.Modules;
using System.Collections.Generic;
using TestAspNet45.Modules.Repository;
using TestAspNet45.Presenters;
using TestAspNet45.Presenters.Results;
using System.Linq;

namespace TestAspNet45_1_3_v3
{
    [TestClass]
    public class RSVPPresenterTests
    {
        class MockRepository : IRepository
        {
            private List<GuestResponse> mockData = new List<GuestResponse> {
                new GuestResponse {Name = "Person1", WillAttend = true},
                new GuestResponse {Name = "Person2", WillAttend = false},
            };

            public IEnumerable<GuestResponse> GetAllResponses()
            {
                return mockData;
            }

            public void AddResponse(GuestResponse response)
            {
                mockData.Add(response);
            }
        }


        [TestMethod]
        public void Adds_Object_To_Repository()
        {
            // Организация
            IRepository repo = new MockRepository();
            IPresenter<GuestResponse> target = new RSVPPresenter { repository = repo };
            GuestResponse dataObject =
                new GuestResponse { Name = "TEST", WillAttend = true };

            // Действие
            IResult result = target.GetResult(dataObject);

            // Утверждение
            Assert.AreEqual(repo.GetAllResponses().Count(), 3);
            Assert.AreEqual(repo.GetAllResponses().Last().Name, "TEST");
            Assert.AreEqual(repo.GetAllResponses().Last().WillAttend, true);
        }

        [TestMethod]
        public void Handles_WillAttend_Bool_Values()
        {
            // Arrange
            IRepository repo = new MockRepository();
            IPresenter<GuestResponse> target = new RSVPPresenter { repository = repo };
            bool?[] values = { true, false };

            // Act & Assert
            foreach (bool? testValue in values)
            {
                GuestResponse dataObject =
                    new GuestResponse { Name = "TEST", WillAttend = testValue };
                IResult result = target.GetResult(dataObject);
                Assert.IsInstanceOfType(result, typeof(RedirectResult));

            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Handles_WillAttend_Null_Values()
        {
            // Arrange
            IRepository repo = new MockRepository();
            IPresenter<GuestResponse> target = new RSVPPresenter { repository = repo };

            // Act

            GuestResponse dataObject = new GuestResponse { Name = "TEST", WillAttend = null };
            IResult result = target.GetResult(dataObject);
        }
    }
}
