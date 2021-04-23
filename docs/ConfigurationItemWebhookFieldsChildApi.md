# IO.Swagger.Api.ConfigurationItemWebhookFieldsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemWebhookFieldsChildCreateEntity**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildcreateentity) | **POST** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields |
[**ConfigurationItemWebhookFieldsChildDeleteEntity**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschilddeleteentity) | **DELETE** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields/{id} |
[**ConfigurationItemWebhookFieldsChildPatchEntity**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildpatchentity) | **PATCH** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields |
[**ConfigurationItemWebhookFieldsChildQuery**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildquery) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields |
[**ConfigurationItemWebhookFieldsChildQueryEntityInformation**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildqueryentityinformation) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields/entityInformation |
[**ConfigurationItemWebhookFieldsChildQueryFieldDefinitions**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields/entityInformation/fields |
[**ConfigurationItemWebhookFieldsChildQueryItem**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildqueryitem) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields/{id} |
[**ConfigurationItemWebhookFieldsChildQueryUserDefinedFieldDefinitions**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields/entityInformation/userDefinedFields |
[**ConfigurationItemWebhookFieldsChildUpdateEntity**](ConfigurationItemWebhookFieldsChildApi.md#configurationitemwebhookfieldschildupdateentity) | **PUT** /V1.0/ConfigurationItemWebhooks/{parentId}/Fields |


<a name="configurationitemwebhookfieldschildcreateentity"></a>
# **ConfigurationItemWebhookFieldsChildCreateEntity**
> OperationResultModel ConfigurationItemWebhookFieldsChildCreateEntity (long? parentId, ConfigurationItemWebhookFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemWebhookFieldModel(); // ConfigurationItemWebhookFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookFieldsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemWebhookFieldModel**](ConfigurationItemWebhookFieldModel.md)|  |
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

<a name="configurationitemwebhookfieldschilddeleteentity"></a>
# **ConfigurationItemWebhookFieldsChildDeleteEntity**
> OperationResultModel ConfigurationItemWebhookFieldsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookFieldsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildDeleteEntity: " + e.Message );
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

<a name="configurationitemwebhookfieldschildpatchentity"></a>
# **ConfigurationItemWebhookFieldsChildPatchEntity**
> OperationResultModel ConfigurationItemWebhookFieldsChildPatchEntity (long? parentId, ConfigurationItemWebhookFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemWebhookFieldModel(); // ConfigurationItemWebhookFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookFieldsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemWebhookFieldModel**](ConfigurationItemWebhookFieldModel.md)|  |
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

<a name="configurationitemwebhookfieldschildquery"></a>
# **ConfigurationItemWebhookFieldsChildQuery**
> QueryActionResultConfigurationItemWebhookFieldModelInstalledProductWebhookField ConfigurationItemWebhookFieldsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemWebhookFieldModelInstalledProductWebhookField result = apiInstance.ConfigurationItemWebhookFieldsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemWebhookFieldModelInstalledProductWebhookField**](QueryActionResultConfigurationItemWebhookFieldModelInstalledProductWebhookField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookfieldschildqueryentityinformation"></a>
# **ConfigurationItemWebhookFieldsChildQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemWebhookFieldsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemWebhookFieldsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildQueryEntityInformation: " + e.Message );
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

<a name="configurationitemwebhookfieldschildqueryfielddefinitions"></a>
# **ConfigurationItemWebhookFieldsChildQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemWebhookFieldsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemWebhookFieldsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitemwebhookfieldschildqueryitem"></a>
# **ConfigurationItemWebhookFieldsChildQueryItem**
> ItemQueryResultModelConfigurationItemWebhookFieldModelInstalledProductWebhookField ConfigurationItemWebhookFieldsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemWebhookFieldModelInstalledProductWebhookField result = apiInstance.ConfigurationItemWebhookFieldsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemWebhookFieldModelInstalledProductWebhookField**](ItemQueryResultModelConfigurationItemWebhookFieldModelInstalledProductWebhookField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookfieldschildqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemWebhookFieldsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemWebhookFieldsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemWebhookFieldsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="configurationitemwebhookfieldschildupdateentity"></a>
# **ConfigurationItemWebhookFieldsChildUpdateEntity**
> OperationResultModel ConfigurationItemWebhookFieldsChildUpdateEntity (long? parentId, ConfigurationItemWebhookFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookFieldsChildUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemWebhookFieldModel(); // ConfigurationItemWebhookFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookFieldsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookFieldsChildApi.ConfigurationItemWebhookFieldsChildUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemWebhookFieldModel**](ConfigurationItemWebhookFieldModel.md)|  |
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

