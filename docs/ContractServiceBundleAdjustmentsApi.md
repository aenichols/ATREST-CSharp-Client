# IO.Swagger.Api.ContractServiceBundleAdjustmentsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractServiceBundleAdjustmentsCreateEntity**](ContractServiceBundleAdjustmentsApi.md#contractservicebundleadjustmentscreateentity) | **POST** /V1.0/ContractServiceBundleAdjustments |
[**ContractServiceBundleAdjustmentsQueryEntityInformation**](ContractServiceBundleAdjustmentsApi.md#contractservicebundleadjustmentsqueryentityinformation) | **GET** /V1.0/ContractServiceBundleAdjustments/entityInformation |
[**ContractServiceBundleAdjustmentsQueryFieldDefinitions**](ContractServiceBundleAdjustmentsApi.md#contractservicebundleadjustmentsqueryfielddefinitions) | **GET** /V1.0/ContractServiceBundleAdjustments/entityInformation/fields |
[**ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitions**](ContractServiceBundleAdjustmentsApi.md#contractservicebundleadjustmentsqueryuserdefinedfielddefinitions) | **GET** /V1.0/ContractServiceBundleAdjustments/entityInformation/userDefinedFields |


<a name="contractservicebundleadjustmentscreateentity"></a>
# **ContractServiceBundleAdjustmentsCreateEntity**
> OperationResultModel ContractServiceBundleAdjustmentsCreateEntity (ContractServiceBundleAdjustmentModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsApi();
            var restModelInput = new ContractServiceBundleAdjustmentModel(); // ContractServiceBundleAdjustmentModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractServiceBundleAdjustmentsCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsApi.ContractServiceBundleAdjustmentsCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="contractservicebundleadjustmentsqueryentityinformation"></a>
# **ContractServiceBundleAdjustmentsQueryEntityInformation**
> EntityInformationResultModel ContractServiceBundleAdjustmentsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContractServiceBundleAdjustmentsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsApi.ContractServiceBundleAdjustmentsQueryEntityInformation: " + e.Message );
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

<a name="contractservicebundleadjustmentsqueryfielddefinitions"></a>
# **ContractServiceBundleAdjustmentsQueryFieldDefinitions**
> FieldInformationResultModel ContractServiceBundleAdjustmentsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContractServiceBundleAdjustmentsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsApi.ContractServiceBundleAdjustmentsQueryFieldDefinitions: " + e.Message );
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

<a name="contractservicebundleadjustmentsqueryuserdefinedfielddefinitions"></a>
# **ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractServiceBundleAdjustmentsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractServiceBundleAdjustmentsApi.ContractServiceBundleAdjustmentsQueryUserDefinedFieldDefinitions: " + e.Message );
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

