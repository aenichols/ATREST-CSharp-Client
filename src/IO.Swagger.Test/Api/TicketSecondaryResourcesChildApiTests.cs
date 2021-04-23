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
    ///  Class for testing TicketSecondaryResourcesChildApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TicketSecondaryResourcesChildApiTests
    {
        private TicketSecondaryResourcesChildApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TicketSecondaryResourcesChildApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TicketSecondaryResourcesChildApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TicketSecondaryResourcesChildApi
            //Assert.IsInstanceOfType(typeof(TicketSecondaryResourcesChildApi), instance, "instance is a TicketSecondaryResourcesChildApi");
        }


        /// <summary>
        /// Test TicketSecondaryResourcesChildCreateEntity
        /// </summary>
        [Test]
        public void TicketSecondaryResourcesChildCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //TicketSecondaryResourceModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketSecondaryResourcesChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test TicketSecondaryResourcesChildDeleteEntity
        /// </summary>
        [Test]
        public void TicketSecondaryResourcesChildDeleteEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketSecondaryResourcesChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test TicketSecondaryResourcesChildQuery
        /// </summary>
        [Test]
        public void TicketSecondaryResourcesChildQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketSecondaryResourcesChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultTicketSecondaryResourceModelTicketSecondaryResource> (response, "response is QueryActionResultTicketSecondaryResourceModelTicketSecondaryResource");
        }

        /// <summary>
        /// Test TicketSecondaryResourcesChildQueryEntityInformation
        /// </summary>
        [Test]
        public void TicketSecondaryResourcesChildQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketSecondaryResourcesChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test TicketSecondaryResourcesChildQueryFieldDefinitions
        /// </summary>
        [Test]
        public void TicketSecondaryResourcesChildQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketSecondaryResourcesChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test TicketSecondaryResourcesChildQueryItem
        /// </summary>
        [Test]
        public void TicketSecondaryResourcesChildQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketSecondaryResourcesChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelTicketSecondaryResourceModelTicketSecondaryResource> (response, "response is ItemQueryResultModelTicketSecondaryResourceModelTicketSecondaryResource");
        }

        /// <summary>
        /// Test TicketSecondaryResourcesChildQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void TicketSecondaryResourcesChildQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.TicketSecondaryResourcesChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

    }

}