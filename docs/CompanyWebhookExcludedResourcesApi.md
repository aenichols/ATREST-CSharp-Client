# IO.Swagger.Api.CompanyWebhookExcludedResourcesApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompanyWebhookExcludedResourcesQuery**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesquery) | **POST** /V1.0/CompanyWebhookExcludedResources/query |
[**CompanyWebhookExcludedResourcesQueryCount**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesquerycount) | **POST** /V1.0/CompanyWebhookExcludedResources/query/count |
[**CompanyWebhookExcludedResourcesQueryEntityInformation**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesqueryentityinformation) | **GET** /V1.0/CompanyWebhookExcludedResources/entityInformation |
[**CompanyWebhookExcludedResourcesQueryFieldDefinitions**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesqueryfielddefinitions) | **GET** /V1.0/CompanyWebhookExcludedResources/entityInformation/fields |
[**CompanyWebhookExcludedResourcesQueryItem**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesqueryitem) | **GET** /V1.0/CompanyWebhookExcludedResources/{id} |
[**CompanyWebhookExcludedResourcesQueryUserDefinedFieldDefinitions**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesqueryuserdefinedfielddefinitions) | **GET** /V1.0/CompanyWebhookExcludedResources/entityInformation/userDefinedFields |
[**CompanyWebhookExcludedResourcesUrlParameterQuery**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesurlparameterquery) | **GET** /V1.0/CompanyWebhookExcludedResources/query |
[**CompanyWebhookExcludedResourcesUrlParameterQueryCount**](CompanyWebhookExcludedResourcesApi.md#companywebhookexcludedresourcesurlparameterquerycount) | **GET** /V1.0/CompanyWebhookExcludedResources/query/count |


<a name="companywebhookexcludedresourcesquery"></a>
# **CompanyWebhookExcludedResourcesQuery**
> QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource CompanyWebhookExcludedResourcesQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesQueryExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource result = apiInstance.CompanyWebhookExcludedResourcesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesQuery: " + e.Message );
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

[**QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource**](QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companywebhookexcludedresourcesquerycount"></a>
# **CompanyWebhookExcludedResourcesQueryCount**
> QueryCountResultModel CompanyWebhookExcludedResourcesQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesQueryCountExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.CompanyWebhookExcludedResourcesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesQueryCount: " + e.Message );
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

<a name="companywebhookexcludedresourcesqueryentityinformation"></a>
# **CompanyWebhookExcludedResourcesQueryEntityInformation**
> EntityInformationResultModel CompanyWebhookExcludedResourcesQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.CompanyWebhookExcludedResourcesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesQueryEntityInformation: " + e.Message );
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

<a name="companywebhookexcludedresourcesqueryfielddefinitions"></a>
# **CompanyWebhookExcludedResourcesQueryFieldDefinitions**
> FieldInformationResultModel CompanyWebhookExcludedResourcesQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.CompanyWebhookExcludedResourcesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesQueryFieldDefinitions: " + e.Message );
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

<a name="companywebhookexcludedresourcesqueryitem"></a>
# **CompanyWebhookExcludedResourcesQueryItem**
> ItemQueryResultModelCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource CompanyWebhookExcludedResourcesQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesQueryItemExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource result = apiInstance.CompanyWebhookExcludedResourcesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesQueryItem: " + e.Message );
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

[**ItemQueryResultModelCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource**](ItemQueryResultModelCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companywebhookexcludedresourcesqueryuserdefinedfielddefinitions"></a>
# **CompanyWebhookExcludedResourcesQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel CompanyWebhookExcludedResourcesQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.CompanyWebhookExcludedResourcesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="companywebhookexcludedresourcesurlparameterquery"></a>
# **CompanyWebhookExcludedResourcesUrlParameterQuery**
> QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource CompanyWebhookExcludedResourcesUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource result = apiInstance.CompanyWebhookExcludedResourcesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesUrlParameterQuery: " + e.Message );
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

[**QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource**](QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companywebhookexcludedresourcesurlparameterquerycount"></a>
# **CompanyWebhookExcludedResourcesUrlParameterQueryCount**
> QueryCountResultModel CompanyWebhookExcludedResourcesUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.CompanyWebhookExcludedResourcesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesApi.CompanyWebhookExcludedResourcesUrlParameterQueryCount: " + e.Message );
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

