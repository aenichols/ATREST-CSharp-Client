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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiIntegrationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>GlobalEntityInformationResultModel</returns>
        GlobalEntityInformationResultModel MetadataApiIntegrationQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>ApiResponse of GlobalEntityInformationResultModel</returns>
        ApiResponse<GlobalEntityInformationResultModel> MetadataApiIntegrationQueryEntityInformationWithHttpInfo (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>Task of GlobalEntityInformationResultModel</returns>
        System.Threading.Tasks.Task<GlobalEntityInformationResultModel> MetadataApiIntegrationQueryEntityInformationAsync (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>Task of ApiResponse (GlobalEntityInformationResultModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalEntityInformationResultModel>> MetadataApiIntegrationQueryEntityInformationAsyncWithHttpInfo (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MetadataApiIntegrationApi : IMetadataApiIntegrationApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApiIntegrationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApiIntegrationApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApiIntegrationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetadataApiIntegrationApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>GlobalEntityInformationResultModel</returns>
        public GlobalEntityInformationResultModel MetadataApiIntegrationQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)
        {
             ApiResponse<GlobalEntityInformationResultModel> localVarResponse = MetadataApiIntegrationQueryEntityInformationWithHttpInfo(apiIntegrationCode, userName, secret, impersonationResourceId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>ApiResponse of GlobalEntityInformationResultModel</returns>
        public ApiResponse< GlobalEntityInformationResultModel > MetadataApiIntegrationQueryEntityInformationWithHttpInfo (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)
        {
            // verify the required parameter 'apiIntegrationCode' is set
            if (apiIntegrationCode == null)
                throw new ApiException(400, "Missing required parameter 'apiIntegrationCode' when calling MetadataApiIntegrationApi->MetadataApiIntegrationQueryEntityInformation");
            // verify the required parameter 'userName' is set
            if (userName == null)
                throw new ApiException(400, "Missing required parameter 'userName' when calling MetadataApiIntegrationApi->MetadataApiIntegrationQueryEntityInformation");
            // verify the required parameter 'secret' is set
            if (secret == null)
                throw new ApiException(400, "Missing required parameter 'secret' when calling MetadataApiIntegrationApi->MetadataApiIntegrationQueryEntityInformation");

            var localVarPath = "/V1.0/EntityInformation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiIntegrationCode != null) localVarHeaderParams.Add("ApiIntegrationCode", this.Configuration.ApiClient.ParameterToString(apiIntegrationCode)); // header parameter
            if (userName != null) localVarHeaderParams.Add("UserName", this.Configuration.ApiClient.ParameterToString(userName)); // header parameter
            if (secret != null) localVarHeaderParams.Add("Secret", this.Configuration.ApiClient.ParameterToString(secret)); // header parameter
            if (impersonationResourceId != null) localVarHeaderParams.Add("ImpersonationResourceId", this.Configuration.ApiClient.ParameterToString(impersonationResourceId)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MetadataApiIntegrationQueryEntityInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GlobalEntityInformationResultModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalEntityInformationResultModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GlobalEntityInformationResultModel)));
        }

        /// <summary>
        ///
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>Task of GlobalEntityInformationResultModel</returns>
        public async System.Threading.Tasks.Task<GlobalEntityInformationResultModel> MetadataApiIntegrationQueryEntityInformationAsync (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)
        {
             ApiResponse<GlobalEntityInformationResultModel> localVarResponse = await MetadataApiIntegrationQueryEntityInformationAsyncWithHttpInfo(apiIntegrationCode, userName, secret, impersonationResourceId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiIntegrationCode">API Integration Code</param>
        /// <param name="userName">User Name</param>
        /// <param name="secret">Secret</param>
        /// <param name="impersonationResourceId">Impersonation Resource Key (optional)</param>
        /// <returns>Task of ApiResponse (GlobalEntityInformationResultModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalEntityInformationResultModel>> MetadataApiIntegrationQueryEntityInformationAsyncWithHttpInfo (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)
        {
            // verify the required parameter 'apiIntegrationCode' is set
            if (apiIntegrationCode == null)
                throw new ApiException(400, "Missing required parameter 'apiIntegrationCode' when calling MetadataApiIntegrationApi->MetadataApiIntegrationQueryEntityInformation");
            // verify the required parameter 'userName' is set
            if (userName == null)
                throw new ApiException(400, "Missing required parameter 'userName' when calling MetadataApiIntegrationApi->MetadataApiIntegrationQueryEntityInformation");
            // verify the required parameter 'secret' is set
            if (secret == null)
                throw new ApiException(400, "Missing required parameter 'secret' when calling MetadataApiIntegrationApi->MetadataApiIntegrationQueryEntityInformation");

            var localVarPath = "/V1.0/EntityInformation";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiIntegrationCode != null) localVarHeaderParams.Add("ApiIntegrationCode", this.Configuration.ApiClient.ParameterToString(apiIntegrationCode)); // header parameter
            if (userName != null) localVarHeaderParams.Add("UserName", this.Configuration.ApiClient.ParameterToString(userName)); // header parameter
            if (secret != null) localVarHeaderParams.Add("Secret", this.Configuration.ApiClient.ParameterToString(secret)); // header parameter
            if (impersonationResourceId != null) localVarHeaderParams.Add("ImpersonationResourceId", this.Configuration.ApiClient.ParameterToString(impersonationResourceId)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MetadataApiIntegrationQueryEntityInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GlobalEntityInformationResultModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalEntityInformationResultModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GlobalEntityInformationResultModel)));
        }

    }
}
