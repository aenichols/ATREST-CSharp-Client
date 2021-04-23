# IO.Swagger.Api.ChecklistLibraryChecklistItemsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChecklistLibraryChecklistItemsQuery**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsquery) | **POST** /V1.0/ChecklistLibraryChecklistItems/query |
[**ChecklistLibraryChecklistItemsQueryCount**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsquerycount) | **POST** /V1.0/ChecklistLibraryChecklistItems/query/count |
[**ChecklistLibraryChecklistItemsQueryEntityInformation**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsqueryentityinformation) | **GET** /V1.0/ChecklistLibraryChecklistItems/entityInformation |
[**ChecklistLibraryChecklistItemsQueryFieldDefinitions**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsqueryfielddefinitions) | **GET** /V1.0/ChecklistLibraryChecklistItems/entityInformation/fields |
[**ChecklistLibraryChecklistItemsQueryItem**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsqueryitem) | **GET** /V1.0/ChecklistLibraryChecklistItems/{id} |
[**ChecklistLibraryChecklistItemsQueryUserDefinedFieldDefinitions**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsqueryuserdefinedfielddefinitions) | **GET** /V1.0/ChecklistLibraryChecklistItems/entityInformation/userDefinedFields |
[**ChecklistLibraryChecklistItemsUrlParameterQuery**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsurlparameterquery) | **GET** /V1.0/ChecklistLibraryChecklistItems/query |
[**ChecklistLibraryChecklistItemsUrlParameterQueryCount**](ChecklistLibraryChecklistItemsApi.md#checklistlibrarychecklistitemsurlparameterquerycount) | **GET** /V1.0/ChecklistLibraryChecklistItems/query/count |


<a name="checklistlibrarychecklistitemsquery"></a>
# **ChecklistLibraryChecklistItemsQuery**
> QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem ChecklistLibraryChecklistItemsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsQueryExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem result = apiInstance.ChecklistLibraryChecklistItemsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsQuery: " + e.Message );
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

[**QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem**](QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checklistlibrarychecklistitemsquerycount"></a>
# **ChecklistLibraryChecklistItemsQueryCount**
> QueryCountResultModel ChecklistLibraryChecklistItemsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ChecklistLibraryChecklistItemsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsQueryCount: " + e.Message );
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

<a name="checklistlibrarychecklistitemsqueryentityinformation"></a>
# **ChecklistLibraryChecklistItemsQueryEntityInformation**
> EntityInformationResultModel ChecklistLibraryChecklistItemsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ChecklistLibraryChecklistItemsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsQueryEntityInformation: " + e.Message );
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

<a name="checklistlibrarychecklistitemsqueryfielddefinitions"></a>
# **ChecklistLibraryChecklistItemsQueryFieldDefinitions**
> FieldInformationResultModel ChecklistLibraryChecklistItemsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ChecklistLibraryChecklistItemsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsQueryFieldDefinitions: " + e.Message );
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

<a name="checklistlibrarychecklistitemsqueryitem"></a>
# **ChecklistLibraryChecklistItemsQueryItem**
> ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem ChecklistLibraryChecklistItemsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem result = apiInstance.ChecklistLibraryChecklistItemsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsQueryItem: " + e.Message );
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

[**ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem**](ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checklistlibrarychecklistitemsqueryuserdefinedfielddefinitions"></a>
# **ChecklistLibraryChecklistItemsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ChecklistLibraryChecklistItemsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ChecklistLibraryChecklistItemsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="checklistlibrarychecklistitemsurlparameterquery"></a>
# **ChecklistLibraryChecklistItemsUrlParameterQuery**
> QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem ChecklistLibraryChecklistItemsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem result = apiInstance.ChecklistLibraryChecklistItemsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem**](QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checklistlibrarychecklistitemsurlparameterquerycount"></a>
# **ChecklistLibraryChecklistItemsUrlParameterQueryCount**
> QueryCountResultModel ChecklistLibraryChecklistItemsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ChecklistLibraryChecklistItemsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsApi.ChecklistLibraryChecklistItemsUrlParameterQueryCount: " + e.Message );
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

