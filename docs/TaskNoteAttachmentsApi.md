# IO.Swagger.Api.TaskNoteAttachmentsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TaskNoteAttachmentsQuery**](TaskNoteAttachmentsApi.md#tasknoteattachmentsquery) | **POST** /V1.0/TaskNoteAttachments/query |
[**TaskNoteAttachmentsQueryCount**](TaskNoteAttachmentsApi.md#tasknoteattachmentsquerycount) | **POST** /V1.0/TaskNoteAttachments/query/count |
[**TaskNoteAttachmentsQueryEntityInformation**](TaskNoteAttachmentsApi.md#tasknoteattachmentsqueryentityinformation) | **GET** /V1.0/TaskNoteAttachments/entityInformation |
[**TaskNoteAttachmentsQueryFieldDefinitions**](TaskNoteAttachmentsApi.md#tasknoteattachmentsqueryfielddefinitions) | **GET** /V1.0/TaskNoteAttachments/entityInformation/fields |
[**TaskNoteAttachmentsQueryItem**](TaskNoteAttachmentsApi.md#tasknoteattachmentsqueryitem) | **GET** /V1.0/TaskNoteAttachments/{id} |
[**TaskNoteAttachmentsUrlParameterQuery**](TaskNoteAttachmentsApi.md#tasknoteattachmentsurlparameterquery) | **GET** /V1.0/TaskNoteAttachments/query |
[**TaskNoteAttachmentsUrlParameterQueryCount**](TaskNoteAttachmentsApi.md#tasknoteattachmentsurlparameterquerycount) | **GET** /V1.0/TaskNoteAttachments/query/count |


<a name="tasknoteattachmentsquery"></a>
# **TaskNoteAttachmentsQuery**
> TaskNoteAttachmentModel TaskNoteAttachmentsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TaskNoteAttachmentsQueryExample
    {
        public void main()
        {
            var apiInstance = new TaskNoteAttachmentsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                TaskNoteAttachmentModel result = apiInstance.TaskNoteAttachmentsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskNoteAttachmentsApi.TaskNoteAttachmentsQuery: " + e.Message );
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

[**TaskNoteAttachmentModel**](TaskNoteAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasknoteattachmentsquerycount"></a>
# **TaskNoteAttachmentsQueryCount**
> QueryCountResultModel TaskNoteAttachmentsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TaskNoteAttachmentsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new TaskNoteAttachmentsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.TaskNoteAttachmentsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskNoteAttachmentsApi.TaskNoteAttachmentsQueryCount: " + e.Message );
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

<a name="tasknoteattachmentsqueryentityinformation"></a>
# **TaskNoteAttachmentsQueryEntityInformation**
> EntityInformationResultModel TaskNoteAttachmentsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TaskNoteAttachmentsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new TaskNoteAttachmentsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.TaskNoteAttachmentsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskNoteAttachmentsApi.TaskNoteAttachmentsQueryEntityInformation: " + e.Message );
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

<a name="tasknoteattachmentsqueryfielddefinitions"></a>
# **TaskNoteAttachmentsQueryFieldDefinitions**
> FieldInformationResultModel TaskNoteAttachmentsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TaskNoteAttachmentsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new TaskNoteAttachmentsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.TaskNoteAttachmentsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskNoteAttachmentsApi.TaskNoteAttachmentsQueryFieldDefinitions: " + e.Message );
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

<a name="tasknoteattachmentsqueryitem"></a>
# **TaskNoteAttachmentsQueryItem**
> TaskNoteAttachmentModel TaskNoteAttachmentsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TaskNoteAttachmentsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new TaskNoteAttachmentsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                TaskNoteAttachmentModel result = apiInstance.TaskNoteAttachmentsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskNoteAttachmentsApi.TaskNoteAttachmentsQueryItem: " + e.Message );
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

[**TaskNoteAttachmentModel**](TaskNoteAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasknoteattachmentsurlparameterquery"></a>
# **TaskNoteAttachmentsUrlParameterQuery**
> TaskNoteAttachmentModel TaskNoteAttachmentsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TaskNoteAttachmentsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new TaskNoteAttachmentsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                TaskNoteAttachmentModel result = apiInstance.TaskNoteAttachmentsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskNoteAttachmentsApi.TaskNoteAttachmentsUrlParameterQuery: " + e.Message );
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

[**TaskNoteAttachmentModel**](TaskNoteAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasknoteattachmentsurlparameterquerycount"></a>
# **TaskNoteAttachmentsUrlParameterQueryCount**
> QueryCountResultModel TaskNoteAttachmentsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TaskNoteAttachmentsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new TaskNoteAttachmentsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.TaskNoteAttachmentsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskNoteAttachmentsApi.TaskNoteAttachmentsUrlParameterQueryCount: " + e.Message );
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

