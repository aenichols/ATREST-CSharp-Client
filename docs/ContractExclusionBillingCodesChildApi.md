# IO.Swagger.Api.ContractExclusionBillingCodesChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractExclusionBillingCodesChildCreateEntity**](ContractExclusionBillingCodesChildApi.md#contractexclusionbillingcodeschildcreateentity) | **POST** /V1.0/Contracts/{parentId}/ExclusionBillingCodes |
[**ContractExclusionBillingCodesChildDeleteEntity**](ContractExclusionBillingCodesChildApi.md#contractexclusionbillingcodeschilddeleteentity) | **DELETE** /V1.0/Contracts/{parentId}/ExclusionBillingCodes/{id} |
[**ContractExclusionBillingCodesChildQuery**](ContractExclusionBillingCodesChildApi.md#contractexclusionbillingcodeschildquery) | **GET** /V1.0/Contracts/{parentId}/ExclusionBillingCodes |
[**ContractExclusionBillingCodesChildQueryEntityInformation**](ContractExclusionBillingCodesChildApi.md#contractexclusionbillingcodeschildqueryentityinformation) | **GET** /V1.0/Contracts/{parentId}/ExclusionBillingCodes/entityInformation |
[**ContractExclusionBillingCodesChildQueryFieldDefinitions**](ContractExclusionBillingCodesChildApi.md#contractexclusionbillingcodeschildqueryfielddefinitions) | **GET** /V1.0/Contracts/{parentId}/ExclusionBillingCodes/entityInformation/fields |
[**ContractExclusionBillingCodesChildQueryItem**](ContractExclusionBillingCodesChildApi.md#contractexclusionbillingcodeschildqueryitem) | **GET** /V1.0/Contracts/{parentId}/ExclusionBillingCodes/{id} |
[**ContractExclusionBillingCodesChildQueryUserDefinedFieldDefinitions**](ContractExclusionBillingCodesChildApi.md#contractexclusionbillingcodeschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/Contracts/{parentId}/ExclusionBillingCodes/entityInformation/userDefinedFields |


<a name="contractexclusionbillingcodeschildcreateentity"></a>
# **ContractExclusionBillingCodesChildCreateEntity**
> OperationResultModel ContractExclusionBillingCodesChildCreateEntity (long? parentId, ContractExclusionBillingCodeModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionBillingCodesChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionBillingCodesChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ContractExclusionBillingCodeModel(); // ContractExclusionBillingCodeModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractExclusionBillingCodesChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionBillingCodesChildApi.ContractExclusionBillingCodesChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ContractExclusionBillingCodeModel**](ContractExclusionBillingCodeModel.md)|  |
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

<a name="contractexclusionbillingcodeschilddeleteentity"></a>
# **ContractExclusionBillingCodesChildDeleteEntity**
> OperationResultModel ContractExclusionBillingCodesChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionBillingCodesChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionBillingCodesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractExclusionBillingCodesChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionBillingCodesChildApi.ContractExclusionBillingCodesChildDeleteEntity: " + e.Message );
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

[**OperationResultModel**](OperationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionbillingcodeschildquery"></a>
# **ContractExclusionBillingCodesChildQuery**
> QueryActionResultContractExclusionBillingCodeModelContractExclusionAllocationCode ContractExclusionBillingCodesChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionBillingCodesChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionBillingCodesChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContractExclusionBillingCodeModelContractExclusionAllocationCode result = apiInstance.ContractExclusionBillingCodesChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionBillingCodesChildApi.ContractExclusionBillingCodesChildQuery: " + e.Message );
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

[**QueryActionResultContractExclusionBillingCodeModelContractExclusionAllocationCode**](QueryActionResultContractExclusionBillingCodeModelContractExclusionAllocationCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionbillingcodeschildqueryentityinformation"></a>
# **ContractExclusionBillingCodesChildQueryEntityInformation**
> EntityInformationResultModel ContractExclusionBillingCodesChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionBillingCodesChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionBillingCodesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContractExclusionBillingCodesChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionBillingCodesChildApi.ContractExclusionBillingCodesChildQueryEntityInformation: " + e.Message );
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

<a name="contractexclusionbillingcodeschildqueryfielddefinitions"></a>
# **ContractExclusionBillingCodesChildQueryFieldDefinitions**
> FieldInformationResultModel ContractExclusionBillingCodesChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionBillingCodesChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionBillingCodesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContractExclusionBillingCodesChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionBillingCodesChildApi.ContractExclusionBillingCodesChildQueryFieldDefinitions: " + e.Message );
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

<a name="contractexclusionbillingcodeschildqueryitem"></a>
# **ContractExclusionBillingCodesChildQueryItem**
> ItemQueryResultModelContractExclusionBillingCodeModelContractExclusionAllocationCode ContractExclusionBillingCodesChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionBillingCodesChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionBillingCodesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContractExclusionBillingCodeModelContractExclusionAllocationCode result = apiInstance.ContractExclusionBillingCodesChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionBillingCodesChildApi.ContractExclusionBillingCodesChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelContractExclusionBillingCodeModelContractExclusionAllocationCode**](ItemQueryResultModelContractExclusionBillingCodeModelContractExclusionAllocationCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionbillingcodeschildqueryuserdefinedfielddefinitions"></a>
# **ContractExclusionBillingCodesChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContractExclusionBillingCodesChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionBillingCodesChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionBillingCodesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContractExclusionBillingCodesChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionBillingCodesChildApi.ContractExclusionBillingCodesChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

