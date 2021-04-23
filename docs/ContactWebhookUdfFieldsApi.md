# IO.Swagger.Api.ContactWebhookUdfFieldsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactWebhookUdfFieldsQuery**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsquery) | **POST** /V1.0/ContactWebhookUdfFields/query |
[**ContactWebhookUdfFieldsQueryCount**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsquerycount) | **POST** /V1.0/ContactWebhookUdfFields/query/count |
[**ContactWebhookUdfFieldsQueryEntityInformation**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsqueryentityinformation) | **GET** /V1.0/ContactWebhookUdfFields/entityInformation |
[**ContactWebhookUdfFieldsQueryFieldDefinitions**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsqueryfielddefinitions) | **GET** /V1.0/ContactWebhookUdfFields/entityInformation/fields |
[**ContactWebhookUdfFieldsQueryItem**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsqueryitem) | **GET** /V1.0/ContactWebhookUdfFields/{id} |
[**ContactWebhookUdfFieldsQueryUserDefinedFieldDefinitions**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsqueryuserdefinedfielddefinitions) | **GET** /V1.0/ContactWebhookUdfFields/entityInformation/userDefinedFields |
[**ContactWebhookUdfFieldsUrlParameterQuery**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsurlparameterquery) | **GET** /V1.0/ContactWebhookUdfFields/query |
[**ContactWebhookUdfFieldsUrlParameterQueryCount**](ContactWebhookUdfFieldsApi.md#contactwebhookudffieldsurlparameterquerycount) | **GET** /V1.0/ContactWebhookUdfFields/query/count |


<a name="contactwebhookudffieldsquery"></a>
# **ContactWebhookUdfFieldsQuery**
> QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField ContactWebhookUdfFieldsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsQueryExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField result = apiInstance.ContactWebhookUdfFieldsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsQuery: " + e.Message );
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

[**QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField**](QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactwebhookudffieldsquerycount"></a>
# **ContactWebhookUdfFieldsQueryCount**
> QueryCountResultModel ContactWebhookUdfFieldsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContactWebhookUdfFieldsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsQueryCount: " + e.Message );
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

<a name="contactwebhookudffieldsqueryentityinformation"></a>
# **ContactWebhookUdfFieldsQueryEntityInformation**
> EntityInformationResultModel ContactWebhookUdfFieldsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContactWebhookUdfFieldsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsQueryEntityInformation: " + e.Message );
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

<a name="contactwebhookudffieldsqueryfielddefinitions"></a>
# **ContactWebhookUdfFieldsQueryFieldDefinitions**
> FieldInformationResultModel ContactWebhookUdfFieldsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContactWebhookUdfFieldsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsQueryFieldDefinitions: " + e.Message );
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

<a name="contactwebhookudffieldsqueryitem"></a>
# **ContactWebhookUdfFieldsQueryItem**
> ItemQueryResultModelContactWebhookUdfFieldModelContactWebhookUdfField ContactWebhookUdfFieldsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContactWebhookUdfFieldModelContactWebhookUdfField result = apiInstance.ContactWebhookUdfFieldsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsQueryItem: " + e.Message );
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

[**ItemQueryResultModelContactWebhookUdfFieldModelContactWebhookUdfField**](ItemQueryResultModelContactWebhookUdfFieldModelContactWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactwebhookudffieldsqueryuserdefinedfielddefinitions"></a>
# **ContactWebhookUdfFieldsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContactWebhookUdfFieldsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContactWebhookUdfFieldsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="contactwebhookudffieldsurlparameterquery"></a>
# **ContactWebhookUdfFieldsUrlParameterQuery**
> QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField ContactWebhookUdfFieldsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField result = apiInstance.ContactWebhookUdfFieldsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField**](QueryActionResultContactWebhookUdfFieldModelContactWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactwebhookudffieldsurlparameterquerycount"></a>
# **ContactWebhookUdfFieldsUrlParameterQueryCount**
> QueryCountResultModel ContactWebhookUdfFieldsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactWebhookUdfFieldsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContactWebhookUdfFieldsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContactWebhookUdfFieldsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactWebhookUdfFieldsApi.ContactWebhookUdfFieldsUrlParameterQueryCount: " + e.Message );
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

