﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence.Repository;
using System.Collections.Generic;
using Persistence;
using Effort;
using System.Data.Entity.Core.EntityClient;

namespace Testing
{
    [TestClass]
    public class UserRepoTest
    {
        private ISSEntities2 _context;
        private RepoUserDB _repository;
        [TestInitialize]
        public void MyTestInitialize()
        {
            EffortProviderFactory.ResetDb();
            EntityConnection connection = EntityConnectionFactory.CreateTransient("name=ISSEntities2");
            //var connection = DbConnectionFactory.CreateTransient();
            _context = new ISSEntities2(connection);
            _repository = new RepoUserDB(_context);
        }
        private void PrepareData()
        {
            Model.User userTest = new Model.User(2, "test", "test1", "Test", "Affiliation", "email@yahoo.com", false, "www.website.com");

            _repository.Add(userTest);
        }
        [TestMethod]
        public void TestMethod1()
        {
            PrepareData();
            List<Model.User> allUsers = _repository.GetAll();
            foreach (Model.User user in allUsers)
                Assert.AreEqual(user.Name, "Test");
        }
    }
}
