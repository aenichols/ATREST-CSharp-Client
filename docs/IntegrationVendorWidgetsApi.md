# IO.Swagger.Api.IntegrationVendorWidgetsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IntegrationVendorWidgetsCreateEntity**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetscreateentity) | **POST** /V1.0/IntegrationVendorWidgets |
[**IntegrationVendorWidgetsDeleteEntity**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsdeleteentity) | **DELETE** /V1.0/IntegrationVendorWidgets/{id} |
[**IntegrationVendorWidgetsPatchEntity**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetspatchentity) | **PATCH** /V1.0/IntegrationVendorWidgets |
[**IntegrationVendorWidgetsQuery**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsquery) | **POST** /V1.0/IntegrationVendorWidgets/query |
[**IntegrationVendorWidgetsQueryCount**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsquerycount) | **POST** /V1.0/IntegrationVendorWidgets/query/count |
[**IntegrationVendorWidgetsQueryEntityInformation**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsqueryentityinformation) | **GET** /V1.0/IntegrationVendorWidgets/entityInformation |
[**IntegrationVendorWidgetsQueryFieldDefinitions**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsqueryfielddefinitions) | **GET** /V1.0/IntegrationVendorWidgets/entityInformation/fields |
[**IntegrationVendorWidgetsQueryItem**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsqueryitem) | **GET** /V1.0/IntegrationVendorWidgets/{id} |
[**IntegrationVendorWidgetsQueryUserDefinedFieldDefinitions**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsqueryuserdefinedfielddefinitions) | **GET** /V1.0/IntegrationVendorWidgets/entityInformation/userDefinedFields |
[**IntegrationVendorWidgetsUpdateEntity**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsupdateentity) | **PUT** /V1.0/IntegrationVendorWidgets |
[**IntegrationVendorWidgetsUrlParameterQuery**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsurlparameterquery) | **GET** /V1.0/IntegrationVendorWidgets/query |
[**IntegrationVendorWidgetsUrlParameterQueryCount**](IntegrationVendorWidgetsApi.md#integrationvendorwidgetsurlparameterquerycount) | **GET** /V1.0/IntegrationVendorWidgets/query/count |


<a name="integrationvendorwidgetscreateentity"></a>
# **IntegrationVendorWidgetsCreateEntity**
> OperationResultModel IntegrationVendorWidgetsCreateEntity (IntegrationVendorWidgetModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var restModelInput = new IntegrationVendorWidgetModel(); // IntegrationVendorWidgetModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.IntegrationVendorWidgetsCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**IntegrationVendorWidgetModel**](IntegrationVendorWidgetModel.md)|  |
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

<a name="integrationvendorwidgetsdeleteentity"></a>
# **IntegrationVendorWidgetsDeleteEntity**
> OperationResultModel IntegrationVendorWidgetsDeleteEntity (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.IntegrationVendorWidgetsDeleteEntity(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsDeleteEntity: " + e.Message );
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

[**OperationResultModel**](OperationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationvendorwidgetspatchentity"></a>
# **IntegrationVendorWidgetsPatchEntity**
> OperationResultModel IntegrationVendorWidgetsPatchEntity (IntegrationVendorWidgetModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var restModelInput = new IntegrationVendorWidgetModel(); // IntegrationVendorWidgetModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.IntegrationVendorWidgetsPatchEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**IntegrationVendorWidgetModel**](IntegrationVendorWidgetModel.md)|  |
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

<a name="integrationvendorwidgetsquery"></a>
# **IntegrationVendorWidgetsQuery**
> QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget IntegrationVendorWidgetsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsQueryExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget result = apiInstance.IntegrationVendorWidgetsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsQuery: " + e.Message );
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

[**QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget**](QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationvendorwidgetsquerycount"></a>
# **IntegrationVendorWidgetsQueryCount**
> QueryCountResultModel IntegrationVendorWidgetsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.IntegrationVendorWidgetsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsQueryCount: " + e.Message );
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

<a name="integrationvendorwidgetsqueryentityinformation"></a>
# **IntegrationVendorWidgetsQueryEntityInformation**
> EntityInformationResultModel IntegrationVendorWidgetsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.IntegrationVendorWidgetsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsQueryEntityInformation: " + e.Message );
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

<a name="integrationvendorwidgetsqueryfielddefinitions"></a>
# **IntegrationVendorWidgetsQueryFieldDefinitions**
> FieldInformationResultModel IntegrationVendorWidgetsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.IntegrationVendorWidgetsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsQueryFieldDefinitions: " + e.Message );
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

<a name="integrationvendorwidgetsqueryitem"></a>
# **IntegrationVendorWidgetsQueryItem**
> ItemQueryResultModelIntegrationVendorWidgetModelIntegrationVendorWidget IntegrationVendorWidgetsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelIntegrationVendorWidgetModelIntegrationVendorWidget result = apiInstance.IntegrationVendorWidgetsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsQueryItem: " + e.Message );
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

[**ItemQueryResultModelIntegrationVendorWidgetModelIntegrationVendorWidget**](ItemQueryResultModelIntegrationVendorWidgetModelIntegrationVendorWidget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationvendorwidgetsqueryuserdefinedfielddefinitions"></a>
# **IntegrationVendorWidgetsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel IntegrationVendorWidgetsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.IntegrationVendorWidgetsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="integrationvendorwidgetsupdateentity"></a>
# **IntegrationVendorWidgetsUpdateEntity**
> OperationResultModel IntegrationVendorWidgetsUpdateEntity (IntegrationVendorWidgetModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var restModelInput = new IntegrationVendorWidgetModel(); // IntegrationVendorWidgetModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.IntegrationVendorWidgetsUpdateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**IntegrationVendorWidgetModel**](IntegrationVendorWidgetModel.md)|  |
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

<a name="integrationvendorwidgetsurlparameterquery"></a>
# **IntegrationVendorWidgetsUrlParameterQuery**
> QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget IntegrationVendorWidgetsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget result = apiInstance.IntegrationVendorWidgetsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget**](QueryActionResultIntegrationVendorWidgetModelIntegrationVendorWidget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationvendorwidgetsurlparameterquerycount"></a>
# **IntegrationVendorWidgetsUrlParameterQueryCount**
> QueryCountResultModel IntegrationVendorWidgetsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class IntegrationVendorWidgetsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new IntegrationVendorWidgetsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.IntegrationVendorWidgetsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationVendorWidgetsApi.IntegrationVendorWidgetsUrlParameterQueryCount: " + e.Message );
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

