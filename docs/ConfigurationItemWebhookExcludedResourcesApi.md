# IO.Swagger.Api.ConfigurationItemWebhookExcludedResourcesApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemWebhookExcludedResourcesQuery**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesquery) | **POST** /V1.0/ConfigurationItemWebhookExcludedResources/query |
[**ConfigurationItemWebhookExcludedResourcesQueryCount**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesquerycount) | **POST** /V1.0/ConfigurationItemWebhookExcludedResources/query/count |
[**ConfigurationItemWebhookExcludedResourcesQueryEntityInformation**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesqueryentityinformation) | **GET** /V1.0/ConfigurationItemWebhookExcludedResources/entityInformation |
[**ConfigurationItemWebhookExcludedResourcesQueryFieldDefinitions**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhookExcludedResources/entityInformation/fields |
[**ConfigurationItemWebhookExcludedResourcesQueryItem**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesqueryitem) | **GET** /V1.0/ConfigurationItemWebhookExcludedResources/{id} |
[**ConfigurationItemWebhookExcludedResourcesQueryUserDefinedFieldDefinitions**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhookExcludedResources/entityInformation/userDefinedFields |
[**ConfigurationItemWebhookExcludedResourcesUrlParameterQuery**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesurlparameterquery) | **GET** /V1.0/ConfigurationItemWebhookExcludedResources/query |
[**ConfigurationItemWebhookExcludedResourcesUrlParameterQueryCount**](ConfigurationItemWebhookExcludedResourcesApi.md#configurationitemwebhookexcludedresourcesurlparameterquerycount) | **GET** /V1.0/ConfigurationItemWebhookExcludedResources/query/count |


<a name="configurationitemwebhookexcludedresourcesquery"></a>
# **ConfigurationItemWebhookExcludedResourcesQuery**
> QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource ConfigurationItemWebhookExcludedResourcesQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource result = apiInstance.ConfigurationItemWebhookExcludedResourcesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryModel** | [**QueryModel**](QueryModel.md)|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource**](QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourcesquerycount"></a>
# **ConfigurationItemWebhookExcludedResourcesQueryCount**
> QueryCountResultModel ConfigurationItemWebhookExcludedResourcesQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesQueryCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryModel** | [**QueryModel**](QueryModel.md)|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**QueryCountResultModel**](QueryCountResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourcesqueryentityinformation"></a>
# **ConfigurationItemWebhookExcludedResourcesQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemWebhookExcludedResourcesQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesQueryEntityInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**EntityInformationResultModel**](EntityInformationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourcesqueryfielddefinitions"></a>
# **ConfigurationItemWebhookExcludedResourcesQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemWebhookExcludedResourcesQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesQueryFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**FieldInformationResultModel**](FieldInformationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourcesqueryitem"></a>
# **ConfigurationItemWebhookExcludedResourcesQueryItem**
> ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource ConfigurationItemWebhookExcludedResourcesQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource result = apiInstance.ConfigurationItemWebhookExcludedResourcesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesQueryItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource**](ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourcesqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemWebhookExcludedResourcesQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemWebhookExcludedResourcesQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesQueryUserDefinedFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**UserDefinedFieldInformationResultModel**](UserDefinedFieldInformationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourcesurlparameterquery"></a>
# **ConfigurationItemWebhookExcludedResourcesUrlParameterQuery**
> QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource ConfigurationItemWebhookExcludedResourcesUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource result = apiInstance.ConfigurationItemWebhookExcludedResourcesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesUrlParameterQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource**](QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourcesurlparameterquerycount"></a>
# **ConfigurationItemWebhookExcludedResourcesUrlParameterQueryCount**
> QueryCountResultModel ConfigurationItemWebhookExcludedResourcesUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesApi.ConfigurationItemWebhookExcludedResourcesUrlParameterQueryCount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search** | **string**|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**QueryCountResultModel**](QueryCountResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

