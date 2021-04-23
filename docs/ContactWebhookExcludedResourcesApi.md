# IO.Swagger.Api.ContactWebhookExcludedResourcesApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactWebhookExcludedResourcesQuery**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesquery) | **POST** /V1.0/ContactWebhookExcludedResources/query |
[**ContactWebhookExcludedResourcesQueryCount**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesquerycount) | **POST** /V1.0/ContactWebhookExcludedResources/query/count |
[**ContactWebhookExcludedResourcesQueryEntityInformation**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesqueryentityinformation) | **GET** /V1.0/ContactWebhookExcludedResources/entityInformation |
[**ContactWebhookExcludedResourcesQueryFieldDefinitions**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesqueryfielddefinitions) | **GET** /V1.0/ContactWebhookExcludedResources/entityInformation/fields |
[**ContactWebhookExcludedResourcesQueryItem**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesqueryitem) | **GET** /V1.0/ContactWebhookExcludedResources/{id} |
[**ContactWebhookExcludedResourcesQueryUserDefinedFieldDefinitions**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesqueryuserdefinedfielddefinitions) | **GET** /V1.0/ContactWebhookExcludedResources/entityInformation/userDefinedFields |
[**ContactWebhookExcludedResourcesUrlParameterQuery**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesurlparameterquery) | **GET** /V1.0/ContactWebhookExcludedResources/query |
[**ContactWebhookExcludedResourcesUrlParameterQueryCount**](ContactWebhookExcludedResourcesApi.md#contactwebhookexcludedresourcesurlparameterquerycount) | **GET** /V1.0/ContactWebhookExcludedResources/query/count |


<a name="contactwebhookexcludedresourcesquery"></a>
# **ContactWebhookExcludedResourcesQuery**
> QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource ContactWebhookExcludedResourcesQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesQueryExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource result = apiInstance.ContactWebhookExcludedResourcesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesQuery: " + e.Message );
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

[**QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource**](QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactwebhookexcludedresourcesquerycount"></a>
# **ContactWebhookExcludedResourcesQueryCount**
> QueryCountResultModel ContactWebhookExcludedResourcesQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContactWebhookExcludedResourcesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesQueryCount: " + e.Message );
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

<a name="contactwebhookexcludedresourcesqueryentityinformation"></a>
# **ContactWebhookExcludedResourcesQueryEntityInformation**
> EntityInformationResultModel ContactWebhookExcludedResourcesQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContactWebhookExcludedResourcesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesQueryEntityInformation: " + e.Message );
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

<a name="contactwebhookexcludedresourcesqueryfielddefinitions"></a>
# **ContactWebhookExcludedResourcesQueryFieldDefinitions**
> FieldInformationResultModel ContactWebhookExcludedResourcesQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContactWebhookExcludedResourcesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesQueryFieldDefinitions: " + e.Message );
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

<a name="contactwebhookexcludedresourcesqueryitem"></a>
# **ContactWebhookExcludedResourcesQueryItem**
> ItemQueryResultModelContactWebhookExcludedResourceModelContactWebhookExcludedResource ContactWebhookExcludedResourcesQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContactWebhookExcludedResourceModelContactWebhookExcludedResource result = apiInstance.ContactWebhookExcludedResourcesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesQueryItem: " + e.Message );
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

[**ItemQueryResultModelContactWebhookExcludedResourceModelContactWebhookExcludedResource**](ItemQueryResultModelContactWebhookExcludedResourceModelContactWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactwebhookexcludedresourcesqueryuserdefinedfielddefinitions"></a>
# **ContactWebhookExcludedResourcesQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContactWebhookExcludedResourcesQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContactWebhookExcludedResourcesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="contactwebhookexcludedresourcesurlparameterquery"></a>
# **ContactWebhookExcludedResourcesUrlParameterQuery**
> QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource ContactWebhookExcludedResourcesUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource result = apiInstance.ContactWebhookExcludedResourcesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesUrlParameterQuery: " + e.Message );
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

[**QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource**](QueryActionResultContactWebhookExcludedResourceModelContactWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactwebhookexcludedresourcesurlparameterquerycount"></a>
# **ContactWebhookExcludedResourcesUrlParameterQueryCount**
> QueryCountResultModel ContactWebhookExcludedResourcesUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookExcludedResourcesUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookExcludedResourcesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContactWebhookExcludedResourcesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookExcludedResourcesApi.ContactWebhookExcludedResourcesUrlParameterQueryCount: " + e.Message );
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

