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
    ///  Class for testing TicketAdditionalContactsChildApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TicketAdditionalContactsChildApiTests
    {
        private TicketAdditionalContactsChildApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TicketAdditionalContactsChildApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TicketAdditionalContactsChildApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TicketAdditionalContactsChildApi
            //Assert.IsInstanceOfType(typeof(TicketAdditionalContactsChildApi), instance, "instance is a TicketAdditionalContactsChildApi");
        }


        /// <summary>
        /// Test TicketAdditionalContactsChildCreateEntity
        /// </summary>
        [Test]
        public void TicketAdditionalContactsChildCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //TicketAdditionalContactModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketAdditionalContactsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test TicketAdditionalContactsChildDeleteEntity
        /// </summary>
        [Test]
        public void TicketAdditionalContactsChildDeleteEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketAdditionalContactsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test TicketAdditionalContactsChildQuery
        /// </summary>
        [Test]
        public void TicketAdditionalContactsChildQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketAdditionalContactsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultTicketAdditionalContactModelTicketAdditionalContact> (response, "response is QueryActionResultTicketAdditionalContactModelTicketAdditionalContact");
        }

        /// <summary>
        /// Test TicketAdditionalContactsChildQueryEntityInformation
        /// </summary>
        [Test]
        public void TicketAdditionalContactsChildQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketAdditionalContactsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test TicketAdditionalContactsChildQueryFieldDefinitions
        /// </summary>
        [Test]
        public void TicketAdditionalContactsChildQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketAdditionalContactsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test TicketAdditionalContactsChildQueryItem
        /// </summary>
        [Test]
        public void TicketAdditionalContactsChildQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketAdditionalContactsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelTicketAdditionalContactModelTicketAdditionalContact> (response, "response is ItemQueryResultModelTicketAdditionalContactModelTicketAdditionalContact");
        }

        /// <summary>
        /// Test TicketAdditionalContactsChildQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void TicketAdditionalContactsChildQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketAdditionalContactsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

    }

}
