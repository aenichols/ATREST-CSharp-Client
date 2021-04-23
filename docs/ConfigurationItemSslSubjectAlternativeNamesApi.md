# IO.Swagger.Api.ConfigurationItemSslSubjectAlternativeNamesApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemSslSubjectAlternativeNamesQuery**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesquery) | **POST** /V1.0/ConfigurationItemSslSubjectAlternativeNames/query |
[**ConfigurationItemSslSubjectAlternativeNamesQueryCount**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesquerycount) | **POST** /V1.0/ConfigurationItemSslSubjectAlternativeNames/query/count |
[**ConfigurationItemSslSubjectAlternativeNamesQueryEntityInformation**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesqueryentityinformation) | **GET** /V1.0/ConfigurationItemSslSubjectAlternativeNames/entityInformation |
[**ConfigurationItemSslSubjectAlternativeNamesQueryFieldDefinitions**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemSslSubjectAlternativeNames/entityInformation/fields |
[**ConfigurationItemSslSubjectAlternativeNamesQueryItem**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesqueryitem) | **GET** /V1.0/ConfigurationItemSslSubjectAlternativeNames/{id} |
[**ConfigurationItemSslSubjectAlternativeNamesQueryUserDefinedFieldDefinitions**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemSslSubjectAlternativeNames/entityInformation/userDefinedFields |
[**ConfigurationItemSslSubjectAlternativeNamesUrlParameterQuery**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesurlparameterquery) | **GET** /V1.0/ConfigurationItemSslSubjectAlternativeNames/query |
[**ConfigurationItemSslSubjectAlternativeNamesUrlParameterQueryCount**](ConfigurationItemSslSubjectAlternativeNamesApi.md#configurationitemsslsubjectalternativenamesurlparameterquerycount) | **GET** /V1.0/ConfigurationItemSslSubjectAlternativeNames/query/count |


<a name="configurationitemsslsubjectalternativenamesquery"></a>
# **ConfigurationItemSslSubjectAlternativeNamesQuery**
> QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName ConfigurationItemSslSubjectAlternativeNamesQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName**](QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemsslsubjectalternativenamesquerycount"></a>
# **ConfigurationItemSslSubjectAlternativeNamesQueryCount**
> QueryCountResultModel ConfigurationItemSslSubjectAlternativeNamesQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesQueryCount: " + e.Message );
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

<a name="configurationitemsslsubjectalternativenamesqueryentityinformation"></a>
# **ConfigurationItemSslSubjectAlternativeNamesQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemSslSubjectAlternativeNamesQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesQueryEntityInformation: " + e.Message );
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

<a name="configurationitemsslsubjectalternativenamesqueryfielddefinitions"></a>
# **ConfigurationItemSslSubjectAlternativeNamesQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemSslSubjectAlternativeNamesQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitemsslsubjectalternativenamesqueryitem"></a>
# **ConfigurationItemSslSubjectAlternativeNamesQueryItem**
> ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName ConfigurationItemSslSubjectAlternativeNamesQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName**](ItemQueryResultModelConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemsslsubjectalternativenamesqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemSslSubjectAlternativeNamesQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemSslSubjectAlternativeNamesQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="configurationitemsslsubjectalternativenamesurlparameterquery"></a>
# **ConfigurationItemSslSubjectAlternativeNamesUrlParameterQuery**
> QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName ConfigurationItemSslSubjectAlternativeNamesUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesUrlParameterQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName**](QueryActionResultConfigurationItemSslSubjectAlternativeNameModelInstalledProductSslSubjectAlternativeName.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemsslsubjectalternativenamesurlparameterquerycount"></a>
# **ConfigurationItemSslSubjectAlternativeNamesUrlParameterQueryCount**
> QueryCountResultModel ConfigurationItemSslSubjectAlternativeNamesUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemSslSubjectAlternativeNamesUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemSslSubjectAlternativeNamesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemSslSubjectAlternativeNamesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemSslSubjectAlternativeNamesApi.ConfigurationItemSslSubjectAlternativeNamesUrlParameterQueryCount: " + e.Message );
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

