# IO.Swagger.Api.ContractExclusionSetExcludedWorkTypesApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractExclusionSetExcludedWorkTypesQuery**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesquery) | **POST** /V1.0/ContractExclusionSetExcludedWorkTypes/query |
[**ContractExclusionSetExcludedWorkTypesQueryCount**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesquerycount) | **POST** /V1.0/ContractExclusionSetExcludedWorkTypes/query/count |
[**ContractExclusionSetExcludedWorkTypesQueryEntityInformation**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesqueryentityinformation) | **GET** /V1.0/ContractExclusionSetExcludedWorkTypes/entityInformation |
[**ContractExclusionSetExcludedWorkTypesQueryFieldDefinitions**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesqueryfielddefinitions) | **GET** /V1.0/ContractExclusionSetExcludedWorkTypes/entityInformation/fields |
[**ContractExclusionSetExcludedWorkTypesQueryItem**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesqueryitem) | **GET** /V1.0/ContractExclusionSetExcludedWorkTypes/{id} |
[**ContractExclusionSetExcludedWorkTypesQueryUserDefinedFieldDefinitions**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesqueryuserdefinedfielddefinitions) | **GET** /V1.0/ContractExclusionSetExcludedWorkTypes/entityInformation/userDefinedFields |
[**ContractExclusionSetExcludedWorkTypesUrlParameterQuery**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesurlparameterquery) | **GET** /V1.0/ContractExclusionSetExcludedWorkTypes/query |
[**ContractExclusionSetExcludedWorkTypesUrlParameterQueryCount**](ContractExclusionSetExcludedWorkTypesApi.md#contractexclusionsetexcludedworktypesurlparameterquerycount) | **GET** /V1.0/ContractExclusionSetExcludedWorkTypes/query/count |


<a name="contractexclusionsetexcludedworktypesquery"></a>
# **ContractExclusionSetExcludedWorkTypesQuery**
> QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType ContractExclusionSetExcludedWorkTypesQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesQueryExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType result = apiInstance.ContractExclusionSetExcludedWorkTypesQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesQuery: " + e.Message );
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

[**QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType**](QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedworktypesquerycount"></a>
# **ContractExclusionSetExcludedWorkTypesQueryCount**
> QueryCountResultModel ContractExclusionSetExcludedWorkTypesQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesQueryCount: " + e.Message );
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

<a name="contractexclusionsetexcludedworktypesqueryentityinformation"></a>
# **ContractExclusionSetExcludedWorkTypesQueryEntityInformation**
> EntityInformationResultModel ContractExclusionSetExcludedWorkTypesQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesQueryEntityInformation: " + e.Message );
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

<a name="contractexclusionsetexcludedworktypesqueryfielddefinitions"></a>
# **ContractExclusionSetExcludedWorkTypesQueryFieldDefinitions**
> FieldInformationResultModel ContractExclusionSetExcludedWorkTypesQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesQueryFieldDefinitions: " + e.Message );
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

<a name="contractexclusionsetexcludedworktypesqueryitem"></a>
# **ContractExclusionSetExcludedWorkTypesQueryItem**
> ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType ContractExclusionSetExcludedWorkTypesQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType result = apiInstance.ContractExclusionSetExcludedWorkTypesQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesQueryItem: " + e.Message );
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

[**ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType**](ItemQueryResultModelContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedworktypesqueryuserdefinedfielddefinitions"></a>
# **ContractExclusionSetExcludedWorkTypesQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContractExclusionSetExcludedWorkTypesQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="contractexclusionsetexcludedworktypesurlparameterquery"></a>
# **ContractExclusionSetExcludedWorkTypesUrlParameterQuery**
> QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType ContractExclusionSetExcludedWorkTypesUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType result = apiInstance.ContractExclusionSetExcludedWorkTypesUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesUrlParameterQuery: " + e.Message );
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

[**QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType**](QueryActionResultContractExclusionSetExcludedWorkTypeModelContractExclusionSetExcludedWorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractexclusionsetexcludedworktypesurlparameterquerycount"></a>
# **ContractExclusionSetExcludedWorkTypesUrlParameterQueryCount**
> QueryCountResultModel ContractExclusionSetExcludedWorkTypesUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContractExclusionSetExcludedWorkTypesUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ContractExclusionSetExcludedWorkTypesApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ContractExclusionSetExcludedWorkTypesUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractExclusionSetExcludedWorkTypesApi.ContractExclusionSetExcludedWorkTypesUrlParameterQueryCount: " + e.Message );
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

