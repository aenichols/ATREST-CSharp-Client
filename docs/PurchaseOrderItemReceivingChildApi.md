# IO.Swagger.Api.PurchaseOrderItemReceivingChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PurchaseOrderItemReceivingChildCreateEntity**](PurchaseOrderItemReceivingChildApi.md#purchaseorderitemreceivingchildcreateentity) | **POST** /V1.0/PurchaseOrderItems/{parentId}/Receiving |
[**PurchaseOrderItemReceivingChildQuery**](PurchaseOrderItemReceivingChildApi.md#purchaseorderitemreceivingchildquery) | **GET** /V1.0/PurchaseOrderItems/{parentId}/Receiving |
[**PurchaseOrderItemReceivingChildQueryEntityInformation**](PurchaseOrderItemReceivingChildApi.md#purchaseorderitemreceivingchildqueryentityinformation) | **GET** /V1.0/PurchaseOrderItems/{parentId}/Receiving/entityInformation |
[**PurchaseOrderItemReceivingChildQueryFieldDefinitions**](PurchaseOrderItemReceivingChildApi.md#purchaseorderitemreceivingchildqueryfielddefinitions) | **GET** /V1.0/PurchaseOrderItems/{parentId}/Receiving/entityInformation/fields |
[**PurchaseOrderItemReceivingChildQueryItem**](PurchaseOrderItemReceivingChildApi.md#purchaseorderitemreceivingchildqueryitem) | **GET** /V1.0/PurchaseOrderItems/{parentId}/Receiving/{id} |
[**PurchaseOrderItemReceivingChildQueryUserDefinedFieldDefinitions**](PurchaseOrderItemReceivingChildApi.md#purchaseorderitemreceivingchildqueryuserdefinedfielddefinitions) | **GET** /V1.0/PurchaseOrderItems/{parentId}/Receiving/entityInformation/userDefinedFields |


<a name="purchaseorderitemreceivingchildcreateentity"></a>
# **PurchaseOrderItemReceivingChildCreateEntity**
> OperationResultModel PurchaseOrderItemReceivingChildCreateEntity (long? parentId, PurchaseOrderItemReceivingModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PurchaseOrderItemReceivingChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrderItemReceivingChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new PurchaseOrderItemReceivingModel(); // PurchaseOrderItemReceivingModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.PurchaseOrderItemReceivingChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderItemReceivingChildApi.PurchaseOrderItemReceivingChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**PurchaseOrderItemReceivingModel**](PurchaseOrderItemReceivingModel.md)|  |
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

<a name="purchaseorderitemreceivingchildquery"></a>
# **PurchaseOrderItemReceivingChildQuery**
> QueryActionResultPurchaseOrderItemReceivingModelPurchaseOrderReceive PurchaseOrderItemReceivingChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PurchaseOrderItemReceivingChildQueryExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrderItemReceivingChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultPurchaseOrderItemReceivingModelPurchaseOrderReceive result = apiInstance.PurchaseOrderItemReceivingChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderItemReceivingChildApi.PurchaseOrderItemReceivingChildQuery: " + e.Message );
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

[**QueryActionResultPurchaseOrderItemReceivingModelPurchaseOrderReceive**](QueryActionResultPurchaseOrderItemReceivingModelPurchaseOrderReceive.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseorderitemreceivingchildqueryentityinformation"></a>
# **PurchaseOrderItemReceivingChildQueryEntityInformation**
> EntityInformationResultModel PurchaseOrderItemReceivingChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PurchaseOrderItemReceivingChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrderItemReceivingChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.PurchaseOrderItemReceivingChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderItemReceivingChildApi.PurchaseOrderItemReceivingChildQueryEntityInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **string**|  |
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

<a name="purchaseorderitemreceivingchildqueryfielddefinitions"></a>
# **PurchaseOrderItemReceivingChildQueryFieldDefinitions**
> FieldInformationResultModel PurchaseOrderItemReceivingChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PurchaseOrderItemReceivingChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrderItemReceivingChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.PurchaseOrderItemReceivingChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderItemReceivingChildApi.PurchaseOrderItemReceivingChildQueryFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **string**|  |
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

<a name="purchaseorderitemreceivingchildqueryitem"></a>
# **PurchaseOrderItemReceivingChildQueryItem**
> ItemQueryResultModelPurchaseOrderItemReceivingModelPurchaseOrderReceive PurchaseOrderItemReceivingChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PurchaseOrderItemReceivingChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrderItemReceivingChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelPurchaseOrderItemReceivingModelPurchaseOrderReceive result = apiInstance.PurchaseOrderItemReceivingChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderItemReceivingChildApi.PurchaseOrderItemReceivingChildQueryItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **id** | **long?**|  |
 **apiIntegrationCode** | **string**| API Integration Code |
 **userName** | **string**| User Name |
 **secret** | **string**| Secret |
 **impersonationResourceId** | **string**| Impersonation Resource Key | [optional]

### Return type

[**ItemQueryResultModelPurchaseOrderItemReceivingModelPurchaseOrderReceive**](ItemQueryResultModelPurchaseOrderItemReceivingModelPurchaseOrderReceive.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseorderitemreceivingchildqueryuserdefinedfielddefinitions"></a>
# **PurchaseOrderItemReceivingChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel PurchaseOrderItemReceivingChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PurchaseOrderItemReceivingChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrderItemReceivingChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.PurchaseOrderItemReceivingChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrderItemReceivingChildApi.PurchaseOrderItemReceivingChildQueryUserDefinedFieldDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **string**|  |
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

