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
    ///  Class for testing OrganizationalLevelAssociationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganizationalLevelAssociationApiTests
    {
        private OrganizationalLevelAssociationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationalLevelAssociationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationalLevelAssociationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrganizationalLevelAssociationApi
            //Assert.IsInstanceOfType(typeof(OrganizationalLevelAssociationApi), instance, "instance is a OrganizationalLevelAssociationApi");
        }


        /// <summary>
        /// Test OrganizationalLevelAssociationCreateEntity
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationCreateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrganizationalLevelAssociationModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationPatchEntity
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationPatchEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrganizationalLevelAssociationModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationPatchEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationQuery
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision> (response, "response is QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationQueryCount
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QueryModel queryModel = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationQueryEntityInformation
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationQueryFieldDefinitions
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationQueryItem
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelOrganizationalLevelAssociationModelBusinessDivisionSubdivision> (response, "response is ItemQueryResultModelOrganizationalLevelAssociationModelBusinessDivisionSubdivision");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationUpdateEntity
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationUpdateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrganizationalLevelAssociationModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationUpdateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationUrlParameterQuery
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationUrlParameterQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision> (response, "response is QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision");
        }

        /// <summary>
        /// Test OrganizationalLevelAssociationUrlParameterQueryCount
        /// </summary>
        [Test]
        public void OrganizationalLevelAssociationUrlParameterQueryCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.OrganizationalLevelAssociationUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryCountResultModel> (response, "response is QueryCountResultModel");
        }

    }

}
