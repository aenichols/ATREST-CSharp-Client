# IO.Swagger.Api.CompanyWebhookExcludedResourcesChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompanyWebhookExcludedResourcesChildCreateEntity**](CompanyWebhookExcludedResourcesChildApi.md#companywebhookexcludedresourceschildcreateentity) | **POST** /V1.0/CompanyWebhooks/{parentId}/ExcludedResources |
[**CompanyWebhookExcludedResourcesChildDeleteEntity**](CompanyWebhookExcludedResourcesChildApi.md#companywebhookexcludedresourceschilddeleteentity) | **DELETE** /V1.0/CompanyWebhooks/{parentId}/ExcludedResources/{id} |
[**CompanyWebhookExcludedResourcesChildQuery**](CompanyWebhookExcludedResourcesChildApi.md#companywebhookexcludedresourceschildquery) | **GET** /V1.0/CompanyWebhooks/{parentId}/ExcludedResources |
[**CompanyWebhookExcludedResourcesChildQueryEntityInformation**](CompanyWebhookExcludedResourcesChildApi.md#companywebhookexcludedresourceschildqueryentityinformation) | **GET** /V1.0/CompanyWebhooks/{parentId}/ExcludedResources/entityInformation |
[**CompanyWebhookExcludedResourcesChildQueryFieldDefinitions**](CompanyWebhookExcludedResourcesChildApi.md#companywebhookexcludedresourceschildqueryfielddefinitions) | **GET** /V1.0/CompanyWebhooks/{parentId}/ExcludedResources/entityInformation/fields |
[**CompanyWebhookExcludedResourcesChildQueryItem**](CompanyWebhookExcludedResourcesChildApi.md#companywebhookexcludedresourceschildqueryitem) | **GET** /V1.0/CompanyWebhooks/{parentId}/ExcludedResources/{id} |
[**CompanyWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions**](CompanyWebhookExcludedResourcesChildApi.md#companywebhookexcludedresourceschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/CompanyWebhooks/{parentId}/ExcludedResources/entityInformation/userDefinedFields |


<a name="companywebhookexcludedresourceschildcreateentity"></a>
# **CompanyWebhookExcludedResourcesChildCreateEntity**
> OperationResultModel CompanyWebhookExcludedResourcesChildCreateEntity (long? parentId, CompanyWebhookExcludedResourceModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new CompanyWebhookExcludedResourceModel(); // CompanyWebhookExcludedResourceModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.CompanyWebhookExcludedResourcesChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesChildApi.CompanyWebhookExcludedResourcesChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**CompanyWebhookExcludedResourceModel**](CompanyWebhookExcludedResourceModel.md)|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**OperationResultModel**](OperationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companywebhookexcludedresourceschilddeleteentity"></a>
# **CompanyWebhookExcludedResourcesChildDeleteEntity**
> OperationResultModel CompanyWebhookExcludedResourcesChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.CompanyWebhookExcludedResourcesChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesChildApi.CompanyWebhookExcludedResourcesChildDeleteEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **id** | **long?**|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**OperationResultModel**](OperationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companywebhookexcludedresourceschildquery"></a>
# **CompanyWebhookExcludedResourcesChildQuery**
> QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource CompanyWebhookExcludedResourcesChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesChildQueryExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource result = apiInstance.CompanyWebhookExcludedResourcesChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesChildApi.CompanyWebhookExcludedResourcesChildQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
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

<a name="companywebhookexcludedresourceschildqueryentityinformation"></a>
# **CompanyWebhookExcludedResourcesChildQueryEntityInformation**
> EntityInformationResultModel CompanyWebhookExcludedResourcesChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.CompanyWebhookExcludedResourcesChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesChildApi.CompanyWebhookExcludedResourcesChildQueryEntityInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **string**|  |
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

<a name="companywebhookexcludedresourceschildqueryfielddefinitions"></a>
# **CompanyWebhookExcludedResourcesChildQueryFieldDefinitions**
> FieldInformationResultModel CompanyWebhookExcludedResourcesChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.CompanyWebhookExcludedResourcesChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesChildApi.CompanyWebhookExcludedResourcesChildQueryFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **string**|  |
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

<a name="companywebhookexcludedresourceschildqueryitem"></a>
# **CompanyWebhookExcludedResourcesChildQueryItem**
> ItemQueryResultModelCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource CompanyWebhookExcludedResourcesChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelCompanyWebhookExcludedResourceModelAccountWebhookExcludedResource result = apiInstance.CompanyWebhookExcludedResourcesChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesChildApi.CompanyWebhookExcludedResourcesChildQueryItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
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

<a name="companywebhookexcludedresourceschildqueryuserdefinedfielddefinitions"></a>
# **CompanyWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel CompanyWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookExcludedResourcesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.CompanyWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookExcludedResourcesChildApi.CompanyWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **string**|  |
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

