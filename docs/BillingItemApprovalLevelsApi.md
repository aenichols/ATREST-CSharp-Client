# IO.Swagger.Api.BillingItemApprovalLevelsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingItemApprovalLevelsCreateEntity**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelscreateentity) | **POST** /V1.0/BillingItemApprovalLevels |
[**BillingItemApprovalLevelsQuery**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsquery) | **POST** /V1.0/BillingItemApprovalLevels/query |
[**BillingItemApprovalLevelsQueryCount**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsquerycount) | **POST** /V1.0/BillingItemApprovalLevels/query/count |
[**BillingItemApprovalLevelsQueryEntityInformation**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsqueryentityinformation) | **GET** /V1.0/BillingItemApprovalLevels/entityInformation |
[**BillingItemApprovalLevelsQueryFieldDefinitions**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsqueryfielddefinitions) | **GET** /V1.0/BillingItemApprovalLevels/entityInformation/fields |
[**BillingItemApprovalLevelsQueryItem**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsqueryitem) | **GET** /V1.0/BillingItemApprovalLevels/{id} |
[**BillingItemApprovalLevelsQueryUserDefinedFieldDefinitions**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsqueryuserdefinedfielddefinitions) | **GET** /V1.0/BillingItemApprovalLevels/entityInformation/userDefinedFields |
[**BillingItemApprovalLevelsUrlParameterQuery**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsurlparameterquery) | **GET** /V1.0/BillingItemApprovalLevels/query |
[**BillingItemApprovalLevelsUrlParameterQueryCount**](BillingItemApprovalLevelsApi.md#billingitemapprovallevelsurlparameterquerycount) | **GET** /V1.0/BillingItemApprovalLevels/query/count |


<a name="billingitemapprovallevelscreateentity"></a>
# **BillingItemApprovalLevelsCreateEntity**
> OperationResultModel BillingItemApprovalLevelsCreateEntity (BillingItemApprovalLevelModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var restModelInput = new BillingItemApprovalLevelModel(); // BillingItemApprovalLevelModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.BillingItemApprovalLevelsCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**BillingItemApprovalLevelModel**](BillingItemApprovalLevelModel.md)|  |
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

<a name="billingitemapprovallevelsquery"></a>
# **BillingItemApprovalLevelsQuery**
> QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel BillingItemApprovalLevelsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsQueryExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel result = apiInstance.BillingItemApprovalLevelsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsQuery: " + e.Message );
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

[**QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel**](QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingitemapprovallevelsquerycount"></a>
# **BillingItemApprovalLevelsQueryCount**
> QueryCountResultModel BillingItemApprovalLevelsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.BillingItemApprovalLevelsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsQueryCount: " + e.Message );
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

<a name="billingitemapprovallevelsqueryentityinformation"></a>
# **BillingItemApprovalLevelsQueryEntityInformation**
> EntityInformationResultModel BillingItemApprovalLevelsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.BillingItemApprovalLevelsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsQueryEntityInformation: " + e.Message );
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

<a name="billingitemapprovallevelsqueryfielddefinitions"></a>
# **BillingItemApprovalLevelsQueryFieldDefinitions**
> FieldInformationResultModel BillingItemApprovalLevelsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.BillingItemApprovalLevelsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsQueryFieldDefinitions: " + e.Message );
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

<a name="billingitemapprovallevelsqueryitem"></a>
# **BillingItemApprovalLevelsQueryItem**
> ItemQueryResultModelBillingItemApprovalLevelModelBillingItemApprovalLevel BillingItemApprovalLevelsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelBillingItemApprovalLevelModelBillingItemApprovalLevel result = apiInstance.BillingItemApprovalLevelsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsQueryItem: " + e.Message );
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

[**ItemQueryResultModelBillingItemApprovalLevelModelBillingItemApprovalLevel**](ItemQueryResultModelBillingItemApprovalLevelModelBillingItemApprovalLevel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingitemapprovallevelsqueryuserdefinedfielddefinitions"></a>
# **BillingItemApprovalLevelsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel BillingItemApprovalLevelsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.BillingItemApprovalLevelsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="billingitemapprovallevelsurlparameterquery"></a>
# **BillingItemApprovalLevelsUrlParameterQuery**
> QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel BillingItemApprovalLevelsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel result = apiInstance.BillingItemApprovalLevelsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel**](QueryActionResultBillingItemApprovalLevelModelBillingItemApprovalLevel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billingitemapprovallevelsurlparameterquerycount"></a>
# **BillingItemApprovalLevelsUrlParameterQueryCount**
> QueryCountResultModel BillingItemApprovalLevelsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class BillingItemApprovalLevelsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new BillingItemApprovalLevelsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.BillingItemApprovalLevelsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingItemApprovalLevelsApi.BillingItemApprovalLevelsUrlParameterQueryCount: " + e.Message );
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

