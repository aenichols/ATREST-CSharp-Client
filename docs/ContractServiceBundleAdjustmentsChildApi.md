# IO.Swagger.Api.ContractServiceBundleAdjustmentsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractServiceBundleAdjustmentsChildCreateEntity**](ContractServiceBundleAdjustmentsChildApi.md#contractservicebundleadjustmentschildcreateentity) | **POST** /V1.0/Contracts/{parentId}/ServiceBundleAdjustments |
[**ContractServiceBundleAdjustmentsChildQueryEntityInformation**](ContractServiceBundleAdjustmentsChildApi.md#contractservicebundleadjustmentschildqueryentityinformation) | **GET** /V1.0/Contracts/{parentId}/ServiceBundleAdjustments/entityInformation |
[**ContractServiceBundleAdjustmentsChildQueryFieldDefinitions**](ContractServiceBundleAdjustmentsChildApi.md#contractservicebundleadjustmentschildqueryfielddefinitions) | **GET** /V1.0/Contracts/{parentId}/ServiceBundleAdjustments/entityInformation/fields |
[**ContractServiceBundleAdjustmentsChildQueryUserDefinedFieldDefinitions**](ContractServiceBundleAdjustmentsChildApi.md#contractservicebundleadjustmentschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/Contracts/{parentId}/ServiceBundleAdjustments/entityInformation/userDefinedFields |


<a name="contractservicebundleadjustmentschildcreateentity"></a>
# **ContractServiceBundleAdjustmentsChildCreateEntity**
> OperationResultModel ContractServiceBundleAdjustmentsChildCreateEntity (long? parentId, ContractServiceBundleAdjustmentModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ContractServiceBundleAdjustmentModel(); // ContractServiceBundleAdjustmentModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractServiceBundleAdjustmentsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsChildApi.ContractServiceBundleAdjustmentsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ContractServiceBundleAdjustmentModel**](ContractServiceBundleAdjustmentModel.md)|  |
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

<a name="contractservicebundleadjustmentschildqueryentityinformation"></a>
# **ContractServiceBundleAdjustmentsChildQueryEntityInformation**
> EntityInformationResultModel ContractServiceBundleAdjustmentsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContractServiceBundleAdjustmentsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsChildApi.ContractServiceBundleAdjustmentsChildQueryEntityInformation: " + e.Message );
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

<a name="contractservicebundleadjustmentschildqueryfielddefinitions"></a>
# **ContractServiceBundleAdjustmentsChildQueryFieldDefinitions**
> FieldInformationResultModel ContractServiceBundleAdjustmentsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContractServiceBundleAdjustmentsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsChildApi.ContractServiceBundleAdjustmentsChildQueryFieldDefinitions: " + e.Message );
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

<a name="contractservicebundleadjustmentschildqueryuserdefinedfielddefinitions"></a>
# **ContractServiceBundleAdjustmentsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContractServiceBundleAdjustmentsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContractServiceBundleAdjustmentsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsChildApi.ContractServiceBundleAdjustmentsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

