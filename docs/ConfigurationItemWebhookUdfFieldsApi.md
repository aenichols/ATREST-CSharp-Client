# IO.Swagger.Api.ConfigurationItemWebhookUdfFieldsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemWebhookUdfFieldsQuery**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsquery) | **POST** /V1.0/ConfigurationItemWebhookUdfFields/query |
[**ConfigurationItemWebhookUdfFieldsQueryCount**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsquerycount) | **POST** /V1.0/ConfigurationItemWebhookUdfFields/query/count |
[**ConfigurationItemWebhookUdfFieldsQueryEntityInformation**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsqueryentityinformation) | **GET** /V1.0/ConfigurationItemWebhookUdfFields/entityInformation |
[**ConfigurationItemWebhookUdfFieldsQueryFieldDefinitions**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhookUdfFields/entityInformation/fields |
[**ConfigurationItemWebhookUdfFieldsQueryItem**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsqueryitem) | **GET** /V1.0/ConfigurationItemWebhookUdfFields/{id} |
[**ConfigurationItemWebhookUdfFieldsQueryUserDefinedFieldDefinitions**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemWebhookUdfFields/entityInformation/userDefinedFields |
[**ConfigurationItemWebhookUdfFieldsUrlParameterQuery**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsurlparameterquery) | **GET** /V1.0/ConfigurationItemWebhookUdfFields/query |
[**ConfigurationItemWebhookUdfFieldsUrlParameterQueryCount**](ConfigurationItemWebhookUdfFieldsApi.md#configurationitemwebhookudffieldsurlparameterquerycount) | **GET** /V1.0/ConfigurationItemWebhookUdfFields/query/count |


<a name="configurationitemwebhookudffieldsquery"></a>
# **ConfigurationItemWebhookUdfFieldsQuery**
> QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField ConfigurationItemWebhookUdfFieldsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField result = apiInstance.ConfigurationItemWebhookUdfFieldsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField**](QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookudffieldsquerycount"></a>
# **ConfigurationItemWebhookUdfFieldsQueryCount**
> QueryCountResultModel ConfigurationItemWebhookUdfFieldsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsQueryCount: " + e.Message );
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

<a name="configurationitemwebhookudffieldsqueryentityinformation"></a>
# **ConfigurationItemWebhookUdfFieldsQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemWebhookUdfFieldsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsQueryEntityInformation: " + e.Message );
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

<a name="configurationitemwebhookudffieldsqueryfielddefinitions"></a>
# **ConfigurationItemWebhookUdfFieldsQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemWebhookUdfFieldsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitemwebhookudffieldsqueryitem"></a>
# **ConfigurationItemWebhookUdfFieldsQueryItem**
> ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField ConfigurationItemWebhookUdfFieldsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField result = apiInstance.ConfigurationItemWebhookUdfFieldsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField**](ItemQueryResultModelConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookudffieldsqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemWebhookUdfFieldsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemWebhookUdfFieldsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="configurationitemwebhookudffieldsurlparameterquery"></a>
# **ConfigurationItemWebhookUdfFieldsUrlParameterQuery**
> QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField ConfigurationItemWebhookUdfFieldsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField result = apiInstance.ConfigurationItemWebhookUdfFieldsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField**](QueryActionResultConfigurationItemWebhookUdfFieldModelInstalledProductWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemwebhookudffieldsurlparameterquerycount"></a>
# **ConfigurationItemWebhookUdfFieldsUrlParameterQueryCount**
> QueryCountResultModel ConfigurationItemWebhookUdfFieldsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemWebhookUdfFieldsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemWebhookUdfFieldsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemWebhookUdfFieldsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemWebhookUdfFieldsApi.ConfigurationItemWebhookUdfFieldsUrlParameterQueryCount: " + e.Message );
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

