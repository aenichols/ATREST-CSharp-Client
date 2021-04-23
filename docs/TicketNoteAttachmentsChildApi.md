# IO.Swagger.Api.TicketNoteAttachmentsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TicketNoteAttachmentsChildCreateEntity**](TicketNoteAttachmentsChildApi.md#ticketnoteattachmentschildcreateentity) | **POST** /V1.0/TicketNotes/{parentId}/Attachments |
[**TicketNoteAttachmentsChildDeleteEntity**](TicketNoteAttachmentsChildApi.md#ticketnoteattachmentschilddeleteentity) | **DELETE** /V1.0/TicketNotes/{parentId}/Attachments/{id} |
[**TicketNoteAttachmentsChildQuery**](TicketNoteAttachmentsChildApi.md#ticketnoteattachmentschildquery) | **GET** /V1.0/TicketNotes/{parentId}/Attachments |
[**TicketNoteAttachmentsChildQueryItem**](TicketNoteAttachmentsChildApi.md#ticketnoteattachmentschildqueryitem) | **GET** /V1.0/TicketNotes/{parentId}/Attachments/{id} |


<a name="ticketnoteattachmentschildcreateentity"></a>
# **TicketNoteAttachmentsChildCreateEntity**
> OperationResultModel TicketNoteAttachmentsChildCreateEntity (TicketNoteAttachmentModel restModelInput, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TicketNoteAttachmentsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new TicketNoteAttachmentsChildApi();
            var restModelInput = new TicketNoteAttachmentModel(); // TicketNoteAttachmentModel |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.TicketNoteAttachmentsChildCreateEntity(restModelInput, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketNoteAttachmentsChildApi.TicketNoteAttachmentsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**TicketNoteAttachmentModel**](TicketNoteAttachmentModel.md)|  |
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

<a name="ticketnoteattachmentschilddeleteentity"></a>
# **TicketNoteAttachmentsChildDeleteEntity**
> OperationResultModel TicketNoteAttachmentsChildDeleteEntity (long? id, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TicketNoteAttachmentsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new TicketNoteAttachmentsChildApi();
            var id = 789;  // long? |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.TicketNoteAttachmentsChildDeleteEntity(id, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketNoteAttachmentsChildApi.TicketNoteAttachmentsChildDeleteEntity: " + e.Message );
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

<a name="ticketnoteattachmentschildquery"></a>
# **TicketNoteAttachmentsChildQuery**
> TicketNoteAttachmentModel TicketNoteAttachmentsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TicketNoteAttachmentsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new TicketNoteAttachmentsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                TicketNoteAttachmentModel result = apiInstance.TicketNoteAttachmentsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketNoteAttachmentsChildApi.TicketNoteAttachmentsChildQuery: " + e.Message );
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

[**TicketNoteAttachmentModel**](TicketNoteAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ticketnoteattachmentschildqueryitem"></a>
# **TicketNoteAttachmentsChildQueryItem**
> TicketNoteAttachmentModel TicketNoteAttachmentsChildQueryItem (long? id, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class TicketNoteAttachmentsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new TicketNoteAttachmentsChildApi();
            var id = 789;  // long? |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                TicketNoteAttachmentModel result = apiInstance.TicketNoteAttachmentsChildQueryItem(id, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TicketNoteAttachmentsChildApi.TicketNoteAttachmentsChildQueryItem: " + e.Message );
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

[**TicketNoteAttachmentModel**](TicketNoteAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

