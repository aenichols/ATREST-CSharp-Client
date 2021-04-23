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
    ///  Class for testing ServiceLevelAgreementResultsChildApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ServiceLevelAgreementResultsChildApiTests
    {
        private ServiceLevelAgreementResultsChildApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServiceLevelAgreementResultsChildApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ServiceLevelAgreementResultsChildApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ServiceLevelAgreementResultsChildApi
            //Assert.IsInstanceOfType(typeof(ServiceLevelAgreementResultsChildApi), instance, "instance is a ServiceLevelAgreementResultsChildApi");
        }


        /// <summary>
        /// Test ServiceLevelAgreementResultsChildQuery
        /// </summary>
        [Test]
        public void ServiceLevelAgreementResultsChildQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ServiceLevelAgreementResultsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults> (response, "response is QueryActionResultServiceLevelAgreementResultsModelServiceLevelAgreementResults");
        }

        /// <summary>
        /// Test ServiceLevelAgreementResultsChildQueryEntityInformation
        /// </summary>
        [Test]
        public void ServiceLevelAgreementResultsChildQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ServiceLevelAgreementResultsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ServiceLevelAgreementResultsChildQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ServiceLevelAgreementResultsChildQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ServiceLevelAgreementResultsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ServiceLevelAgreementResultsChildQueryItem
        /// </summary>
        [Test]
        public void ServiceLevelAgreementResultsChildQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ServiceLevelAgreementResultsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelServiceLevelAgreementResultsModelServiceLevelAgreementResults> (response, "response is ItemQueryResultModelServiceLevelAgreementResultsModelServiceLevelAgreementResults");
        }

        /// <summary>
        /// Test ServiceLevelAgreementResultsChildQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ServiceLevelAgreementResultsChildQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ServiceLevelAgreementResultsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

    }

}
