# IO.Swagger.Api.ContractExclusionSetExcludedRolesApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractExclusionSetExcludedRolesQuery**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesquery) | **POST** /V1.0/ContractExclusionSetExcludedRoles/query |
[**ContractExclusionSetExcludedRolesQueryCount**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesquerycount) | **POST** /V1.0/ContractExclusionSetExcludedRoles/query/count |
[**ContractExclusionSetExcludedRolesQueryEntityInformation**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesqueryentityinformation) | **GET** /V1.0/ContractExclusionSetExcludedRoles/entityInformation |
[**ContractExclusionSetExcludedRolesQueryFieldDefinitions**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesqueryfielddefinitions) | **GET** /V1.0/ContractExclusionSetExcludedRoles/entityInformation/fields |
[**ContractExclusionSetExcludedRolesQueryItem**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesqueryitem) | **GET** /V1.0/ContractExclusionSetExcludedRoles/{id} |
[**ContractExclusionSetExcludedRolesQueryUserDefinedFieldDefinitions**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesqueryuserdefinedfielddefinitions) | **GET** /V1.0/ContractExclusionSetExcludedRoles/entityInformation/userDefinedFields |
[**ContractExclusionSetExcludedRolesUrlParameterQuery**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesurlparameterquery) | **GET** /V1.0/ContractExclusionSetExcludedRoles/query |
[**ContractExclusionSetExcludedRolesUrlParameterQueryCount**](ContractExclusionSetExcludedRolesApi.md#contractexclusionsetexcludedrolesurlparameterquerycount) | **GET** /V1.0/ContractExclusionSetExcludedRoles/query/count |


<a name="contractexclusionsetexcludedrolesquery"></a>
# **ContractExclusionSetExcludedRolesQuery**
> QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole ContractExclusionSetExcludedRolesQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesQueryExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole result = apiInstance.ContractExclusionSetExcludedRolesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesQuery: " + e.Message );
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

[**QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole**](QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedrolesquerycount"></a>
# **ContractExclusionSetExcludedRolesQueryCount**
> QueryCountResultModel ContractExclusionSetExcludedRolesQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContractExclusionSetExcludedRolesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesQueryCount: " + e.Message );
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

<a name="contractexclusionsetexcludedrolesqueryentityinformation"></a>
# **ContractExclusionSetExcludedRolesQueryEntityInformation**
> EntityInformationResultModel ContractExclusionSetExcludedRolesQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContractExclusionSetExcludedRolesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesQueryEntityInformation: " + e.Message );
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

<a name="contractexclusionsetexcludedrolesqueryfielddefinitions"></a>
# **ContractExclusionSetExcludedRolesQueryFieldDefinitions**
> FieldInformationResultModel ContractExclusionSetExcludedRolesQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedRolesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesQueryFieldDefinitions: " + e.Message );
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

<a name="contractexclusionsetexcludedrolesqueryitem"></a>
# **ContractExclusionSetExcludedRolesQueryItem**
> ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole ContractExclusionSetExcludedRolesQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole result = apiInstance.ContractExclusionSetExcludedRolesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesQueryItem: " + e.Message );
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

[**ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole**](ItemQueryResultModelContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedrolesqueryuserdefinedfielddefinitions"></a>
# **ContractExclusionSetExcludedRolesQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContractExclusionSetExcludedRolesQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedRolesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="contractexclusionsetexcludedrolesurlparameterquery"></a>
# **ContractExclusionSetExcludedRolesUrlParameterQuery**
> QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole ContractExclusionSetExcludedRolesUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole result = apiInstance.ContractExclusionSetExcludedRolesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesUrlParameterQuery: " + e.Message );
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

[**QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole**](QueryActionResultContractExclusionSetExcludedRoleModelContractExclusionSetExcludedRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedrolesurlparameterquerycount"></a>
# **ContractExclusionSetExcludedRolesUrlParameterQueryCount**
> QueryCountResultModel ContractExclusionSetExcludedRolesUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedRolesUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedRolesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContractExclusionSetExcludedRolesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedRolesApi.ContractExclusionSetExcludedRolesUrlParameterQueryCount: " + e.Message );
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

