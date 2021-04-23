# IO.Swagger.Api.ConfigurationItemWebhookUdfFieldsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemWebhookUdfFieldsChildCreateEntity**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildcreateentity) | **POST** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields |
[**ConfigurationItemWebhookUdfFieldsChildDeleteEntity**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschilddeleteentity) | **DELETE** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields/{id} |
[**ConfigurationItemWebhookUdfFieldsChildPatchEntity**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildpatchentity) | **PATCH** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields |
[**ConfigurationItemWebhookUdfFieldsChildQuery**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildquery) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields |
[**ConfigurationItemWebhookUdfFieldsChildQueryEntityInformation**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildqueryentityinformation) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields/entityInformation |
[**ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitions**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields/entityInformation/fields |
[**ConfigurationItemWebhookUdfFieldsChildQueryItem**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildqueryitem) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields/{id} |
[**ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields/entityInformation/userDefinedFields |
[**ConfigurationItemWebhookUdfFieldsChildUpdateEntity**](ConfigurationItemWebhookUdfFieldsChildApi.md#configurationitemwebhookudffieldschildupdateentity) | **PUT** /V1.0/ConfigurationItemWebhooks/{parentId}/UdfFields |


<a name="configurationitemwebhookudffieldschildcreateentity"></a>
# **ConfigurationItemWebhookUdfFieldsChildCreateEntity**
> OperationResultModel ConfigurationItemWebhookUdfFieldsChildCreateEntity (long? parentId, ConfigurationItemWebhookUdfFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemWebhookUdfFieldModel(); // ConfigurationItemWebhookUdfFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemWebhookUdfFieldModel**](ConfigurationItemWebhookUdfFieldModel.md)|  |
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

<a name="configurationitemwebhookudffieldschilddeleteentity"></a>
# **ConfigurationItemWebhookUdfFieldsChildDeleteEntity**
> OperationResultModel ConfigurationItemWebhookUdfFieldsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildDeleteEntity: " + e.Message );
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

<a name="configurationitemwebhookudffieldschildpatchentity"></a>
# **ConfigurationItemWebhookUdfFieldsChildPatchEntity**
> OperationResultModel ConfigurationItemWebhookUdfFieldsChildPatchEntity (long? parentId, ConfigurationItemWebhookUdfFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemWebhookUdfFieldModel(); // ConfigurationItemWebhookUdfFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemWebhookUdfFieldModel**](ConfigurationItemWebhookUdfFieldModel.md)|  |
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

<a name="configurationitemwebhookudffieldschildquery"></a>
# **ConfigurationItemWebhookUdfFieldsChildQuery**
> QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField ConfigurationItemWebhookUdfFieldsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField result = apiInstance.ConfigurationItemWebhookUdfFieldsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField**](QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookudffieldschildqueryentityinformation"></a>
# **ConfigurationItemWebhookUdfFieldsChildQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemWebhookUdfFieldsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildQueryEntityInformation: " + e.Message );
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

<a name="configurationitemwebhookudffieldschildqueryfielddefinitions"></a>
# **ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitemwebhookudffieldschildqueryitem"></a>
# **ConfigurationItemWebhookUdfFieldsChildQueryItem**
> ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField ConfigurationItemWebhookUdfFieldsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField result = apiInstance.ConfigurationItemWebhookUdfFieldsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField**](ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookudffieldschildqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="configurationitemwebhookudffieldschildupdateentity"></a>
# **ConfigurationItemWebhookUdfFieldsChildUpdateEntity**
> OperationResultModel ConfigurationItemWebhookUdfFieldsChildUpdateEntity (long? parentId, ConfigurationItemWebhookUdfFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsChildUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemWebhookUdfFieldModel(); // ConfigurationItemWebhookUdfFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsChildApi.ConfigurationItemWebhookUdfFieldsChildUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemWebhookUdfFieldModel**](ConfigurationItemWebhookUdfFieldModel.md)|  |
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

