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
    ///  Class for testing ResourceSkillsChildApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ResourceSkillsChildApiTests
    {
        private ResourceSkillsChildApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResourceSkillsChildApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResourceSkillsChildApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ResourceSkillsChildApi
            //Assert.IsInstanceOfType(typeof(ResourceSkillsChildApi), instance, "instance is a ResourceSkillsChildApi");
        }


        /// <summary>
        /// Test ResourceSkillsChildPatchEntity
        /// </summary>
        [Test]
        public void ResourceSkillsChildPatchEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //ResourceSkillModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ResourceSkillsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

        /// <summary>
        /// Test ResourceSkillsChildQuery
        /// </summary>
        [Test]
        public void ResourceSkillsChildQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ResourceSkillsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<QueryActionResultResourceSkillModelResourceSkill> (response, "response is QueryActionResultResourceSkillModelResourceSkill");
        }

        /// <summary>
        /// Test ResourceSkillsChildQueryEntityInformation
        /// </summary>
        [Test]
        public void ResourceSkillsChildQueryEntityInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ResourceSkillsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<EntityInformationResultModel> (response, "response is EntityInformationResultModel");
        }

        /// <summary>
        /// Test ResourceSkillsChildQueryFieldDefinitions
        /// </summary>
        [Test]
        public void ResourceSkillsChildQueryFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ResourceSkillsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<FieldInformationResultModel> (response, "response is FieldInformationResultModel");
        }

        /// <summary>
        /// Test ResourceSkillsChildQueryItem
        /// </summary>
        [Test]
        public void ResourceSkillsChildQueryItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //long? id = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ResourceSkillsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<ItemQueryResultModelResourceSkillModelResourceSkill> (response, "response is ItemQueryResultModelResourceSkillModelResourceSkill");
        }

        /// <summary>
        /// Test ResourceSkillsChildQueryUserDefinedFieldDefinitions
        /// </summary>
        [Test]
        public void ResourceSkillsChildQueryUserDefinedFieldDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ResourceSkillsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<UserDefinedFieldInformationResultModel> (response, "response is UserDefinedFieldInformationResultModel");
        }

        /// <summary>
        /// Test ResourceSkillsChildUpdateEntity
        /// </summary>
        [Test]
        public void ResourceSkillsChildUpdateEntityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? parentId = null;
            //ResourceSkillModel restModelInput = null;
            //string apiIntegrationCode = null;
            //string userName = null;
            //string secret = null;
            //string impersonationResourceId = null;
            //var response = instance.ResourceSkillsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
            //Assert.IsInstanceOf<OperationResultModel> (response, "response is OperationResultModel");
        }

    }

}
