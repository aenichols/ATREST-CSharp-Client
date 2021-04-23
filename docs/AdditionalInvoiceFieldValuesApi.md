# IO.Swagger.Api.AdditionalInvoiceFieldValuesApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdditionalInvoiceFieldValuesQuery**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesquery) | **POST** /V1.0/AdditionalInvoiceFieldValues/query |
[**AdditionalInvoiceFieldValuesQueryCount**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesquerycount) | **POST** /V1.0/AdditionalInvoiceFieldValues/query/count |
[**AdditionalInvoiceFieldValuesQueryEntityInformation**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesqueryentityinformation) | **GET** /V1.0/AdditionalInvoiceFieldValues/entityInformation |
[**AdditionalInvoiceFieldValuesQueryFieldDefinitions**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesqueryfielddefinitions) | **GET** /V1.0/AdditionalInvoiceFieldValues/entityInformation/fields |
[**AdditionalInvoiceFieldValuesQueryItem**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesqueryitem) | **GET** /V1.0/AdditionalInvoiceFieldValues/{id} |
[**AdditionalInvoiceFieldValuesQueryUserDefinedFieldDefinitions**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesqueryuserdefinedfielddefinitions) | **GET** /V1.0/AdditionalInvoiceFieldValues/entityInformation/userDefinedFields |
[**AdditionalInvoiceFieldValuesUrlParameterQuery**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesurlparameterquery) | **GET** /V1.0/AdditionalInvoiceFieldValues/query |
[**AdditionalInvoiceFieldValuesUrlParameterQueryCount**](AdditionalInvoiceFieldValuesApi.md#additionalinvoicefieldvaluesurlparameterquerycount) | **GET** /V1.0/AdditionalInvoiceFieldValues/query/count |


<a name="additionalinvoicefieldvaluesquery"></a>
# **AdditionalInvoiceFieldValuesQuery**
> QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue AdditionalInvoiceFieldValuesQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesQueryExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue result = apiInstance.AdditionalInvoiceFieldValuesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesQuery: " + e.Message );
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

[**QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue**](QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additionalinvoicefieldvaluesquerycount"></a>
# **AdditionalInvoiceFieldValuesQueryCount**
> QueryCountResultModel AdditionalInvoiceFieldValuesQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesQueryCountExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.AdditionalInvoiceFieldValuesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesQueryCount: " + e.Message );
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

<a name="additionalinvoicefieldvaluesqueryentityinformation"></a>
# **AdditionalInvoiceFieldValuesQueryEntityInformation**
> EntityInformationResultModel AdditionalInvoiceFieldValuesQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.AdditionalInvoiceFieldValuesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesQueryEntityInformation: " + e.Message );
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

<a name="additionalinvoicefieldvaluesqueryfielddefinitions"></a>
# **AdditionalInvoiceFieldValuesQueryFieldDefinitions**
> FieldInformationResultModel AdditionalInvoiceFieldValuesQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.AdditionalInvoiceFieldValuesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesQueryFieldDefinitions: " + e.Message );
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

<a name="additionalinvoicefieldvaluesqueryitem"></a>
# **AdditionalInvoiceFieldValuesQueryItem**
> ItemQueryResultModelAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue AdditionalInvoiceFieldValuesQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesQueryItemExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue result = apiInstance.AdditionalInvoiceFieldValuesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesQueryItem: " + e.Message );
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

[**ItemQueryResultModelAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue**](ItemQueryResultModelAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additionalinvoicefieldvaluesqueryuserdefinedfielddefinitions"></a>
# **AdditionalInvoiceFieldValuesQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel AdditionalInvoiceFieldValuesQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.AdditionalInvoiceFieldValuesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="additionalinvoicefieldvaluesurlparameterquery"></a>
# **AdditionalInvoiceFieldValuesUrlParameterQuery**
> QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue AdditionalInvoiceFieldValuesUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue result = apiInstance.AdditionalInvoiceFieldValuesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesUrlParameterQuery: " + e.Message );
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

[**QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue**](QueryActionResultAdditionalInvoiceFieldValueModelAdditionalInvoiceFieldValue.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="additionalinvoicefieldvaluesurlparameterquerycount"></a>
# **AdditionalInvoiceFieldValuesUrlParameterQueryCount**
> QueryCountResultModel AdditionalInvoiceFieldValuesUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class AdditionalInvoiceFieldValuesUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new AdditionalInvoiceFieldValuesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.AdditionalInvoiceFieldValuesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdditionalInvoiceFieldValuesApi.AdditionalInvoiceFieldValuesUrlParameterQueryCount: " + e.Message );
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

