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
    ///  Class for testing ExpenseReportAttachmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExpenseReportAttachmentsApiTests
    {
        private ExpenseReportAttachmentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExpenseReportAttachmentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExpenseReportAttachmentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExpenseReportAttachmentsApi
            //Assert.IsInstanceOfType(typeof(ExpenseReportAttachmentsApi), instance, "instance is a ExpenseReportAttachmentsApi");
        }


        /// <summary>
        /// Test ExpenseReportAttachmentsQuery
        /// </summary>
        [Test]
        public void ExpenseReportAttachmentsQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ExpenseReportAttachmentsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ExpenseReportAttachmentModel> (response, "response is ExpenseReportAttachmentModel");
        }

        /// <summary>
        /// Test ExpenseReportAttachmentsQueryCount
        /// </summary>
        [Test]
        public void ExpenseReportAttachmentsQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ExpenseReportAttachmentsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test ExpenseReportAttachmentsQueryEntityInformation
        /// </summary>
        [Test]
        public void ExpenseReportAttachmentsQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ExpenseReportAttachmentsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ExpenseReportAttachmentsQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ExpenseReportAttachmentsQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ExpenseReportAttachmentsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ExpenseReportAttachmentsQueryItem
        /// </summary>
        [Test]
        public void ExpenseReportAttachmentsQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ExpenseReportAttachmentsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ExpenseReportAttachmentModel> (response, "response is ExpenseReportAttachmentModel");
        }

        /// <summary>
        /// Test ExpenseReportAttachmentsUrlParameterQuery
        /// </summary>
        [Test]
        public void ExpenseReportAttachmentsUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ExpenseReportAttachmentsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ExpenseReportAttachmentModel> (response, "response is ExpenseReportAttachmentModel");
        }

        /// <summary>
        /// Test ExpenseReportAttachmentsUrlParameterQueryCount
        /// </summary>
        [Test]
        public void ExpenseReportAttachmentsUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ExpenseReportAttachmentsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
