# IO.Swagger.Api.ConfigurationItemWebhookExcludedResourcesChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemWebhookExcludedResourcesChildCreateEntity**](ConfigurationItemWebhookExcludedResourcesChildApi.md#configurationitemwebhookexcludedresourceschildcreateentity) | **POST** /V1.0/ConfigurationItemWebhooks/{parentId}/ExcludedResources |
[**ConfigurationItemWebhookExcludedResourcesChildDeleteEntity**](ConfigurationItemWebhookExcludedResourcesChildApi.md#configurationitemwebhookexcludedresourceschilddeleteentity) | **DELETE** /V1.0/ConfigurationItemWebhooks/{parentId}/ExcludedResources/{id} |
[**ConfigurationItemWebhookExcludedResourcesChildQuery**](ConfigurationItemWebhookExcludedResourcesChildApi.md#configurationitemwebhookexcludedresourceschildquery) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/ExcludedResources |
[**ConfigurationItemWebhookExcludedResourcesChildQueryEntityInformation**](ConfigurationItemWebhookExcludedResourcesChildApi.md#configurationitemwebhookexcludedresourceschildqueryentityinformation) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/ExcludedResources/entityInformation |
[**ConfigurationItemWebhookExcludedResourcesChildQueryFieldDefinitions**](ConfigurationItemWebhookExcludedResourcesChildApi.md#configurationitemwebhookexcludedresourceschildqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/ExcludedResources/entityInformation/fields |
[**ConfigurationItemWebhookExcludedResourcesChildQueryItem**](ConfigurationItemWebhookExcludedResourcesChildApi.md#configurationitemwebhookexcludedresourceschildqueryitem) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/ExcludedResources/{id} |
[**ConfigurationItemWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions**](ConfigurationItemWebhookExcludedResourcesChildApi.md#configurationitemwebhookexcludedresourceschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/ExcludedResources/entityInformation/userDefinedFields |


<a name="configurationitemwebhookexcludedresourceschildcreateentity"></a>
# **ConfigurationItemWebhookExcludedResourcesChildCreateEntity**
> OperationResultModel ConfigurationItemWebhookExcludedResourcesChildCreateEntity (long? parentId, ConfigurationItemWebhookExcludedResourceModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemWebhookExcludedResourceModel(); // ConfigurationItemWebhookExcludedResourceModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesChildApi.ConfigurationItemWebhookExcludedResourcesChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemWebhookExcludedResourceModel**](ConfigurationItemWebhookExcludedResourceModel.md)|  |
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

<a name="configurationitemwebhookexcludedresourceschilddeleteentity"></a>
# **ConfigurationItemWebhookExcludedResourcesChildDeleteEntity**
> OperationResultModel ConfigurationItemWebhookExcludedResourcesChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesChildApi.ConfigurationItemWebhookExcludedResourcesChildDeleteEntity: " + e.Message );
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

<a name="configurationitemwebhookexcludedresourceschildquery"></a>
# **ConfigurationItemWebhookExcludedResourcesChildQuery**
> QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource ConfigurationItemWebhookExcludedResourcesChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource result = apiInstance.ConfigurationItemWebhookExcludedResourcesChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesChildApi.ConfigurationItemWebhookExcludedResourcesChildQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource**](QueryActionResultConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourceschildqueryentityinformation"></a>
# **ConfigurationItemWebhookExcludedResourcesChildQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemWebhookExcludedResourcesChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesChildApi.ConfigurationItemWebhookExcludedResourcesChildQueryEntityInformation: " + e.Message );
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

<a name="configurationitemwebhookexcludedresourceschildqueryfielddefinitions"></a>
# **ConfigurationItemWebhookExcludedResourcesChildQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemWebhookExcludedResourcesChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesChildApi.ConfigurationItemWebhookExcludedResourcesChildQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitemwebhookexcludedresourceschildqueryitem"></a>
# **ConfigurationItemWebhookExcludedResourcesChildQueryItem**
> ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource ConfigurationItemWebhookExcludedResourcesChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource result = apiInstance.ConfigurationItemWebhookExcludedResourcesChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesChildApi.ConfigurationItemWebhookExcludedResourcesChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource**](ItemQueryResultModelConfigurationItemWebhookExcludedResourceModelInstalledProductWebhookExcludedResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookexcludedresourceschildqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookExcludedResourcesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookExcludedResourcesChildApi.ConfigurationItemWebhookExcludedResourcesChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

