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
    ///  Class for testing ContactWebhookFieldsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContactWebhookFieldsApiTests
    {
        private ContactWebhookFieldsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactWebhookFieldsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactWebhookFieldsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContactWebhookFieldsApi
            //Assert.IsInstanceOfType(typeof(ContactWebhookFieldsApi), instance, "instance is a ContactWebhookFieldsApi");
        }


        /// <summary>
        /// Test ContactWebhookFieldsQuery
        /// </summary>
        [Test]
        public void ContactWebhookFieldsQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultContactWebhookFieldModelContactWebhookField> (response, "response is QueryActionResultContactWebhookFieldModelContactWebhookField");
        }

        /// <summary>
        /// Test ContactWebhookFieldsQueryCount
        /// </summary>
        [Test]
        public void ContactWebhookFieldsQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test ContactWebhookFieldsQueryEntityInformation
        /// </summary>
        [Test]
        public void ContactWebhookFieldsQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ContactWebhookFieldsQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ContactWebhookFieldsQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ContactWebhookFieldsQueryItem
        /// </summary>
        [Test]
        public void ContactWebhookFieldsQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelContactWebhookFieldModelContactWebhookField> (response, "response is ItemQueryResultModelContactWebhookFieldModelContactWebhookField");
        }

        /// <summary>
        /// Test ContactWebhookFieldsQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ContactWebhookFieldsQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test ContactWebhookFieldsUrlParameterQuery
        /// </summary>
        [Test]
        public void ContactWebhookFieldsUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultContactWebhookFieldModelContactWebhookField> (response, "response is QueryActionResultContactWebhookFieldModelContactWebhookField");
        }

        /// <summary>
        /// Test ContactWebhookFieldsUrlParameterQueryCount
        /// </summary>
        [Test]
        public void ContactWebhookFieldsUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ContactWebhookFieldsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
