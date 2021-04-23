# IO.Swagger.Api.ConfigurationItemSslSubjectAlternativeNamesChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemSslSubjectAlternativeNamesChildDeleteEntity**](ConfigurationItemSslSubjectAlternativeNamesChildApi.md#configurationitemsslsubjectalternativenameschilddeleteentity) | **DELETE** /V1.0/ConfigurationItems/{parentId}/SslSubjectAlternativeNames/{id} |
[**ConfigurationItemSslSubjectAlternativeNamesChildQuery**](ConfigurationItemSslSubjectAlternativeNamesChildApi.md#configurationitemsslsubjectalternativenameschildquery) | **GET** /V1.0/ConfigurationItems/{parentId}/SslSubjectAlternativeNames |
[**ConfigurationItemSslSubjectAlternativeNamesChildQueryEntityInformation**](ConfigurationItemSslSubjectAlternativeNamesChildApi.md#configurationitemsslsubjectalternativenameschildqueryentityinformation) | **GET** /V1.0/ConfigurationItems/{parentId}/SslSubjectAlternativeNames/entityInformation |
[**ConfigurationItemSslSubjectAlternativeNamesChildQueryFieldDefinitions**](ConfigurationItemSslSubjectAlternativeNamesChildApi.md#configurationitemsslsubjectalternativenameschildqueryfielddefinitions) | **GET** /V1.0/ConfigurationItems/{parentId}/SslSubjectAlternativeNames/entityInformation/fields |
[**ConfigurationItemSslSubjectAlternativeNamesChildQueryItem**](ConfigurationItemSslSubjectAlternativeNamesChildApi.md#configurationitemsslsubjectalternativenameschildqueryitem) | **GET** /V1.0/ConfigurationItems/{parentId}/SslSubjectAlternativeNames/{id} |
[**ConfigurationItemSslSubjectAlternativeNamesChildQueryUserDefinedFieldDefinitions**](ConfigurationItemSslSubjectAlternativeNamesChildApi.md#configurationitemsslsubjectalternativenameschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItems/{parentId}/SslSubjectAlternativeNames/entityInformation/userDefinedFields |


<a name="configurationitemsslsubjectalternativenameschilddeleteentity"></a>
# **ConfigurationItemSslSubjectAlternativeNamesChildDeleteEntity**
> OperationResultModel ConfigurationItemSslSubjectAlternativeNamesChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesChildApi.ConfigurationItemSslSubjectAlternativeNamesChildDeleteEntity: " + e.Message );
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

<a name="configurationitemsslsubjectalternativenameschildquery"></a>
# **ConfigurationItemSslSubjectAlternativeNamesChildQuery**
> QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName ConfigurationItemSslSubjectAlternativeNamesChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesChildApi.ConfigurationItemSslSubjectAlternativeNamesChildQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName**](QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemsslsubjectalternativenameschildqueryentityinformation"></a>
# **ConfigurationItemSslSubjectAlternativeNamesChildQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemSslSubjectAlternativeNamesChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesChildApi.ConfigurationItemSslSubjectAlternativeNamesChildQueryEntityInformation: " + e.Message );
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

<a name="configurationitemsslsubjectalternativenameschildqueryfielddefinitions"></a>
# **ConfigurationItemSslSubjectAlternativeNamesChildQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemSslSubjectAlternativeNamesChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesChildApi.ConfigurationItemSslSubjectAlternativeNamesChildQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitemsslsubjectalternativenameschildqueryitem"></a>
# **ConfigurationItemSslSubjectAlternativeNamesChildQueryItem**
> ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName ConfigurationItemSslSubjectAlternativeNamesChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesChildApi.ConfigurationItemSslSubjectAlternativeNamesChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName**](ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemsslsubjectalternativenameschildqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemSslSubjectAlternativeNamesChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemSslSubjectAlternativeNamesChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesChildApi.ConfigurationItemSslSubjectAlternativeNamesChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

