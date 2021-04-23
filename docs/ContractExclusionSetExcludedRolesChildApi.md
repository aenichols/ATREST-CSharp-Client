# IO.Swagger.Api.ContractExclusionSetExcludedRolesChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractExclusionSetExcludedRolesChildCreateEntity**](ContractExclusionSetExcludedRolesChildApi.md#contractexclusionsetexcludedroleschildcreateentity) | **POST** /V1.0/ContractExclusionSets/{parentId}/ExcludedRoles |
[**ContractExclusionSetExcludedRolesChildDeleteEntity**](ContractExclusionSetExcludedRolesChildApi.md#contractexclusionsetexcludedroleschilddeleteentity) | **DELETE** /V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/{id} |
[**ContractExclusionSetExcludedRolesChildQuery**](ContractExclusionSetExcludedRolesChildApi.md#contractexclusionsetexcludedroleschildquery) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedRoles |
[**ContractExclusionSetExcludedRolesChildQueryEntityInformation**](ContractExclusionSetExcludedRolesChildApi.md#contractexclusionsetexcludedroleschildqueryentityinformation) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/entityInformation |
[**ContractExclusionSetExcludedRolesChildQueryFieldDefinitions**](ContractExclusionSetExcludedRolesChildApi.md#contractexclusionsetexcludedroleschildqueryfielddefinitions) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/entityInformation/fields |
[**ContractExclusionSetExcludedRolesChildQueryItem**](ContractExclusionSetExcludedRolesChildApi.md#contractexclusionsetexcludedroleschildqueryitem) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/{id} |
[**ContractExclusionSetExcludedRolesChildQueryUserDefinedFieldDefinitions**](ContractExclusionSetExcludedRolesChildApi.md#contractexclusionsetexcludedroleschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ContractExclusionSets/{parentId}/ExcludedRoles/entityInformation/userDefinedFields |


<a name="contractexclusionsetexcludedroleschildcreateentity"></a>
# **ContractExclusionSetExcludedRolesChildCreateEntity**
> OperationResultModel ContractExclusionSetExcludedRolesChildCreateEntity (long? parentId, ContractExclusionSetExcludedRoleModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ContractExclusionSetExcludedRoleModel(); // ContractExclusionSetExcludedRoleModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractExclusionSetExcludedRolesChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesChildApi.ContractExclusionSetExcludedRolesChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ContractExclusionSetExcludedRoleModel**](ContractExclusionSetExcludedRoleModel.md)|  |
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

<a name="contractexclusionsetexcludedroleschilddeleteentity"></a>
# **ContractExclusionSetExcludedRolesChildDeleteEntity**
> OperationResultModel ContractExclusionSetExcludedRolesChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContractExclusionSetExcludedRolesChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesChildApi.ContractExclusionSetExcludedRolesChildDeleteEntity: " + e.Message );
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

<a name="contractexclusionsetexcludedroleschildquery"></a>
# **ContractExclusionSetExcludedRolesChildQuery**
> QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole ContractExclusionSetExcludedRolesChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole result = apiInstance.ContractExclusionSetExcludedRolesChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesChildApi.ContractExclusionSetExcludedRolesChildQuery: " + e.Message );
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

[**QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole**](QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedroleschildqueryentityinformation"></a>
# **ContractExclusionSetExcludedRolesChildQueryEntityInformation**
> EntityInformationResultModel ContractExclusionSetExcludedRolesChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContractExclusionSetExcludedRolesChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesChildApi.ContractExclusionSetExcludedRolesChildQueryEntityInformation: " + e.Message );
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

<a name="contractexclusionsetexcludedroleschildqueryfielddefinitions"></a>
# **ContractExclusionSetExcludedRolesChildQueryFieldDefinitions**
> FieldInformationResultModel ContractExclusionSetExcludedRolesChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedRolesChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesChildApi.ContractExclusionSetExcludedRolesChildQueryFieldDefinitions: " + e.Message );
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

<a name="contractexclusionsetexcludedroleschildqueryitem"></a>
# **ContractExclusionSetExcludedRolesChildQueryItem**
> ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole ContractExclusionSetExcludedRolesChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole result = apiInstance.ContractExclusionSetExcludedRolesChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesChildApi.ContractExclusionSetExcludedRolesChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole**](ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedroleschildqueryuserdefinedfielddefinitions"></a>
# **ContractExclusionSetExcludedRolesChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContractExclusionSetExcludedRolesChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedRolesChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesChildApi.ContractExclusionSetExcludedRolesChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

