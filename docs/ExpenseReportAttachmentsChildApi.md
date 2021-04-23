# IO.Swagger.Api.ExpenseReportAttachmentsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExpenseReportAttachmentsChildCreateEntity**](ExpenseReportAttachmentsChildApi.md#expensereportattachmentschildcreateentity) | **POST** /V1.0/ExpenseReports/{parentId}/Attachments |
[**ExpenseReportAttachmentsChildDeleteEntity**](ExpenseReportAttachmentsChildApi.md#expensereportattachmentschilddeleteentity) | **DELETE** /V1.0/ExpenseReports/{parentId}/Attachments/{id} |
[**ExpenseReportAttachmentsChildQuery**](ExpenseReportAttachmentsChildApi.md#expensereportattachmentschildquery) | **GET** /V1.0/ExpenseReports/{parentId}/Attachments |
[**ExpenseReportAttachmentsChildQueryItem**](ExpenseReportAttachmentsChildApi.md#expensereportattachmentschildqueryitem) | **GET** /V1.0/ExpenseReports/{parentId}/Attachments/{id} |


<a name="expensereportattachmentschildcreateentity"></a>
# **ExpenseReportAttachmentsChildCreateEntity**
> OperationResultModel ExpenseReportAttachmentsChildCreateEntity (ExpenseReportAttachmentModel restModelInput, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ExpenseReportAttachmentsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ExpenseReportAttachmentsChildApi();
            var restModelInput = new ExpenseReportAttachmentModel(); // ExpenseReportAttachmentModel |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ExpenseReportAttachmentsChildCreateEntity(restModelInput, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseReportAttachmentsChildApi.ExpenseReportAttachmentsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**ExpenseReportAttachmentModel**](ExpenseReportAttachmentModel.md)|  |
 **parentId** | **long?**|  |
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

<a name="expensereportattachmentschilddeleteentity"></a>
# **ExpenseReportAttachmentsChildDeleteEntity**
> OperationResultModel ExpenseReportAttachmentsChildDeleteEntity (long? id, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ExpenseReportAttachmentsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ExpenseReportAttachmentsChildApi();
            var id = 789;  // long? |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ExpenseReportAttachmentsChildDeleteEntity(id, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseReportAttachmentsChildApi.ExpenseReportAttachmentsChildDeleteEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  |
 **parentId** | **long?**|  |
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

<a name="expensereportattachmentschildquery"></a>
# **ExpenseReportAttachmentsChildQuery**
> ExpenseReportAttachmentModel ExpenseReportAttachmentsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ExpenseReportAttachmentsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ExpenseReportAttachmentsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ExpenseReportAttachmentModel result = apiInstance.ExpenseReportAttachmentsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseReportAttachmentsChildApi.ExpenseReportAttachmentsChildQuery: " + e.Message );
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

[**ExpenseReportAttachmentModel**](ExpenseReportAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expensereportattachmentschildqueryitem"></a>
# **ExpenseReportAttachmentsChildQueryItem**
> ExpenseReportAttachmentModel ExpenseReportAttachmentsChildQueryItem (long? id, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ExpenseReportAttachmentsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ExpenseReportAttachmentsChildApi();
            var id = 789;  // long? |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ExpenseReportAttachmentModel result = apiInstance.ExpenseReportAttachmentsChildQueryItem(id, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseReportAttachmentsChildApi.ExpenseReportAttachmentsChildQueryItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  |
 **parentId** | **long?**|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**ExpenseReportAttachmentModel**](ExpenseReportAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

