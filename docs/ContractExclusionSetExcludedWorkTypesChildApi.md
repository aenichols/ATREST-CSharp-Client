# IO.Swagger.Api.ContractExclusionSetExcludedWorkTypesChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractExclusionSetExcludedWorkTypesChildCreateEntity**](ContractExclusionSetExcludedWorkTypesChildApi.md#contractexclusionsetexcludedworktypeschildcreateentity) | **POST** /V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes |
[**ContractExclusionSetExcludedWorkTypesChildDeleteEntity**](ContractExclusionSetExcludedWorkTypesChildApi.md#contractexclusionsetexcludedworktypeschilddeleteentity) | **DELETE** /V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/{id} |
[**ContractExclusionSetExcludedWorkTypesChildQuery**](ContractExclusionSetExcludedWorkTypesChildApi.md#contractexclusionsetexcludedworktypeschildquery) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes |
[**ContractExclusionSetExcludedWorkTypesChildQueryEntityInformation**](ContractExclusionSetExcludedWorkTypesChildApi.md#contractexclusionsetexcludedworktypeschildqueryentityinformation) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/entityInformation |
[**ContractExclusionSetExcludedWorkTypesChildQueryFieldDefinitions**](ContractExclusionSetExcludedWorkTypesChildApi.md#contractexclusionsetexcludedworktypeschildqueryfielddefinitions) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/entityInformation/fields |
[**ContractExclusionSetExcludedWorkTypesChildQueryItem**](ContractExclusionSetExcludedWorkTypesChildApi.md#contractexclusionsetexcludedworktypeschildqueryitem) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/{id} |
[**ContractExclusionSetExcludedWorkTypesChildQueryUserDefinedFieldDefinitions**](ContractExclusionSetExcludedWorkTypesChildApi.md#contractexclusionsetexcludedworktypeschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedWorkTypes/entityInformation/userDefinedFields |


<a name="contractexclusionsetexcludedworktypeschildcreateentity"></a>
# **ContractExclusionSetExcludedWorkTypesChildCreateEntity**
> OperationResultModel ContractExclusionSetExcludedWorkTypesChildCreateEntity (long? parentId, ContractExclusionSetExcludedWorkTypeModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ContractExclusionSetExcludedWorkTypeModel(); // ContractExclusionSetExcludedWorkTypeModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesChildApi.ContractExclusionSetExcludedWorkTypesChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ContractExclusionSetExcludedWorkTypeModel**](ContractExclusionSetExcludedWorkTypeModel.md)|  |
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

<a name="contractexclusionsetexcludedworktypeschilddeleteentity"></a>
# **ContractExclusionSetExcludedWorkTypesChildDeleteEntity**
> OperationResultModel ContractExclusionSetExcludedWorkTypesChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesChildApi.ContractExclusionSetExcludedWorkTypesChildDeleteEntity: " + e.Message );
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

<a name="contractexclusionsetexcludedworktypeschildquery"></a>
# **ContractExclusionSetExcludedWorkTypesChildQuery**
> QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType ContractExclusionSetExcludedWorkTypesChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType result = apiInstance.ContractExclusionSetExcludedWorkTypesChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesChildApi.ContractExclusionSetExcludedWorkTypesChildQuery: " + e.Message );
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

[**QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType**](QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedworktypeschildqueryentityinformation"></a>
# **ContractExclusionSetExcludedWorkTypesChildQueryEntityInformation**
> EntityInformationResultModel ContractExclusionSetExcludedWorkTypesChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesChildApi.ContractExclusionSetExcludedWorkTypesChildQueryEntityInformation: " + e.Message );
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

<a name="contractexclusionsetexcludedworktypeschildqueryfielddefinitions"></a>
# **ContractExclusionSetExcludedWorkTypesChildQueryFieldDefinitions**
> FieldInformationResultModel ContractExclusionSetExcludedWorkTypesChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesChildApi.ContractExclusionSetExcludedWorkTypesChildQueryFieldDefinitions: " + e.Message );
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

<a name="contractexclusionsetexcludedworktypeschildqueryitem"></a>
# **ContractExclusionSetExcludedWorkTypesChildQueryItem**
> ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType ContractExclusionSetExcludedWorkTypesChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType result = apiInstance.ContractExclusionSetExcludedWorkTypesChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesChildApi.ContractExclusionSetExcludedWorkTypesChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType**](ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedworktypeschildqueryuserdefinedfielddefinitions"></a>
# **ContractExclusionSetExcludedWorkTypesChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContractExclusionSetExcludedWorkTypesChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesChildApi.ContractExclusionSetExcludedWorkTypesChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

