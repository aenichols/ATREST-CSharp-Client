# IO.Swagger.Api.OpportunityAttachmentsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OpportunityAttachmentsChildCreateEntity**](OpportunityAttachmentsChildApi.md#opportunityattachmentschildcreateentity) | **POST** /V1.0/Opportunities/{parentId}/Attachments |
[**OpportunityAttachmentsChildDeleteEntity**](OpportunityAttachmentsChildApi.md#opportunityattachmentschilddeleteentity) | **DELETE** /V1.0/Opportunities/{parentId}/Attachments/{id} |
[**OpportunityAttachmentsChildQuery**](OpportunityAttachmentsChildApi.md#opportunityattachmentschildquery) | **GET** /V1.0/Opportunities/{parentId}/Attachments |
[**OpportunityAttachmentsChildQueryItem**](OpportunityAttachmentsChildApi.md#opportunityattachmentschildqueryitem) | **GET** /V1.0/Opportunities/{parentId}/Attachments/{id} |


<a name="opportunityattachmentschildcreateentity"></a>
# **OpportunityAttachmentsChildCreateEntity**
> OperationResultModel OpportunityAttachmentsChildCreateEntity (OpportunityAttachmentModel restModelInput, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OpportunityAttachmentsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new OpportunityAttachmentsChildApi();
            var restModelInput = new OpportunityAttachmentModel(); // OpportunityAttachmentModel |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.OpportunityAttachmentsChildCreateEntity(restModelInput, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityAttachmentsChildApi.OpportunityAttachmentsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**OpportunityAttachmentModel**](OpportunityAttachmentModel.md)|  |
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

<a name="opportunityattachmentschilddeleteentity"></a>
# **OpportunityAttachmentsChildDeleteEntity**
> OperationResultModel OpportunityAttachmentsChildDeleteEntity (long? id, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OpportunityAttachmentsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new OpportunityAttachmentsChildApi();
            var id = 789;  // long? |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.OpportunityAttachmentsChildDeleteEntity(id, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityAttachmentsChildApi.OpportunityAttachmentsChildDeleteEntity: " + e.Message );
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

<a name="opportunityattachmentschildquery"></a>
# **OpportunityAttachmentsChildQuery**
> OpportunityAttachmentModel OpportunityAttachmentsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OpportunityAttachmentsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new OpportunityAttachmentsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OpportunityAttachmentModel result = apiInstance.OpportunityAttachmentsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityAttachmentsChildApi.OpportunityAttachmentsChildQuery: " + e.Message );
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

[**OpportunityAttachmentModel**](OpportunityAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunityattachmentschildqueryitem"></a>
# **OpportunityAttachmentsChildQueryItem**
> OpportunityAttachmentModel OpportunityAttachmentsChildQueryItem (long? id, long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OpportunityAttachmentsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new OpportunityAttachmentsChildApi();
            var id = 789;  // long? |
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OpportunityAttachmentModel result = apiInstance.OpportunityAttachmentsChildQueryItem(id, parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityAttachmentsChildApi.OpportunityAttachmentsChildQueryItem: " + e.Message );
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

[**OpportunityAttachmentModel**](OpportunityAttachmentModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

