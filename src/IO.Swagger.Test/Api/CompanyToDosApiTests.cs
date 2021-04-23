/*
 * Datto|Autotask PSA Rest API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing CompanyToDosApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CompanyToDosApiTests
    {
        private CompanyToDosApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompanyToDosApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompanyToDosApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CompanyToDosApi
            //Assert.IsInstanceOfType(typeof(CompanyToDosApi), instance, "instance is a CompanyToDosApi");
        }


        /// <summary>
        /// Test CompanyToDosQuery
        /// </summary>
        [Test]
        public void CompanyToDosQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultCompanyToDoModelAccountToDo> (response, "response is QueryActionResultCompanyToDoModelAccountToDo");
        }

        /// <summary>
        /// Test CompanyToDosQueryCount
        /// </summary>
        [Test]
        public void CompanyToDosQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test CompanyToDosQueryEntityInformation
        /// </summary>
        [Test]
        public void CompanyToDosQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test CompanyToDosQueryFieldDefinitions
        /// </summary>
        [Test]
        public void CompanyToDosQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test CompanyToDosQueryItem
        /// </summary>
        [Test]
        public void CompanyToDosQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelCompanyToDoModelAccountToDo> (response, "response is ItemQueryResultModelCompanyToDoModelAccountToDo");
        }

        /// <summary>
        /// Test CompanyToDosQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void CompanyToDosQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test CompanyToDosUrlParameterQuery
        /// </summary>
        [Test]
        public void CompanyToDosUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultCompanyToDoModelAccountToDo> (response, "response is QueryActionResultCompanyToDoModelAccountToDo");
        }

        /// <summary>
        /// Test CompanyToDosUrlParameterQueryCount
        /// </summary>
        [Test]
        public void CompanyToDosUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.CompanyToDosUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
