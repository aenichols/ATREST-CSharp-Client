# IO.Swagger.Api.PriceListWorkTypeModifiersApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PriceListWorkTypeModifiersPatchEntity**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifierspatchentity) | **PATCH** /V1.0/PriceListWorkTypeModifiers |
[**PriceListWorkTypeModifiersQuery**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersquery) | **POST** /V1.0/PriceListWorkTypeModifiers/query |
[**PriceListWorkTypeModifiersQueryCount**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersquerycount) | **POST** /V1.0/PriceListWorkTypeModifiers/query/count |
[**PriceListWorkTypeModifiersQueryEntityInformation**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersqueryentityinformation) | **GET** /V1.0/PriceListWorkTypeModifiers/entityInformation |
[**PriceListWorkTypeModifiersQueryFieldDefinitions**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersqueryfielddefinitions) | **GET** /V1.0/PriceListWorkTypeModifiers/entityInformation/fields |
[**PriceListWorkTypeModifiersQueryItem**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersqueryitem) | **GET** /V1.0/PriceListWorkTypeModifiers/{id} |
[**PriceListWorkTypeModifiersQueryUserDefinedFieldDefinitions**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersqueryuserdefinedfielddefinitions) | **GET** /V1.0/PriceListWorkTypeModifiers/entityInformation/userDefinedFields |
[**PriceListWorkTypeModifiersUpdateEntity**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersupdateentity) | **PUT** /V1.0/PriceListWorkTypeModifiers |
[**PriceListWorkTypeModifiersUrlParameterQuery**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersurlparameterquery) | **GET** /V1.0/PriceListWorkTypeModifiers/query |
[**PriceListWorkTypeModifiersUrlParameterQueryCount**](PriceListWorkTypeModifiersApi.md#pricelistworktypemodifiersurlparameterquerycount) | **GET** /V1.0/PriceListWorkTypeModifiers/query/count |


<a name="pricelistworktypemodifierspatchentity"></a>
# **PriceListWorkTypeModifiersPatchEntity**
> OperationResultModel PriceListWorkTypeModifiersPatchEntity (PriceListWorkTypeModifierModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var restModelInput = new PriceListWorkTypeModifierModel(); // PriceListWorkTypeModifierModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.PriceListWorkTypeModifiersPatchEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**PriceListWorkTypeModifierModel**](PriceListWorkTypeModifierModel.md)|  |
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

<a name="pricelistworktypemodifiersquery"></a>
# **PriceListWorkTypeModifiersQuery**
> QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier PriceListWorkTypeModifiersQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersQueryExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier result = apiInstance.PriceListWorkTypeModifiersQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersQuery: " + e.Message );
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

[**QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier**](QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricelistworktypemodifiersquerycount"></a>
# **PriceListWorkTypeModifiersQueryCount**
> QueryCountResultModel PriceListWorkTypeModifiersQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersQueryCountExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.PriceListWorkTypeModifiersQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersQueryCount: " + e.Message );
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

<a name="pricelistworktypemodifiersqueryentityinformation"></a>
# **PriceListWorkTypeModifiersQueryEntityInformation**
> EntityInformationResultModel PriceListWorkTypeModifiersQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.PriceListWorkTypeModifiersQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersQueryEntityInformation: " + e.Message );
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

<a name="pricelistworktypemodifiersqueryfielddefinitions"></a>
# **PriceListWorkTypeModifiersQueryFieldDefinitions**
> FieldInformationResultModel PriceListWorkTypeModifiersQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.PriceListWorkTypeModifiersQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersQueryFieldDefinitions: " + e.Message );
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

<a name="pricelistworktypemodifiersqueryitem"></a>
# **PriceListWorkTypeModifiersQueryItem**
> ItemQueryResultModelPriceListWorkTypeModifierModelPriceListWorkTypeModifier PriceListWorkTypeModifiersQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersQueryItemExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelPriceListWorkTypeModifierModelPriceListWorkTypeModifier result = apiInstance.PriceListWorkTypeModifiersQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersQueryItem: " + e.Message );
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

[**ItemQueryResultModelPriceListWorkTypeModifierModelPriceListWorkTypeModifier**](ItemQueryResultModelPriceListWorkTypeModifierModelPriceListWorkTypeModifier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricelistworktypemodifiersqueryuserdefinedfielddefinitions"></a>
# **PriceListWorkTypeModifiersQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel PriceListWorkTypeModifiersQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.PriceListWorkTypeModifiersQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="pricelistworktypemodifiersupdateentity"></a>
# **PriceListWorkTypeModifiersUpdateEntity**
> OperationResultModel PriceListWorkTypeModifiersUpdateEntity (PriceListWorkTypeModifierModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var restModelInput = new PriceListWorkTypeModifierModel(); // PriceListWorkTypeModifierModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.PriceListWorkTypeModifiersUpdateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**PriceListWorkTypeModifierModel**](PriceListWorkTypeModifierModel.md)|  |
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

<a name="pricelistworktypemodifiersurlparameterquery"></a>
# **PriceListWorkTypeModifiersUrlParameterQuery**
> QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier PriceListWorkTypeModifiersUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier result = apiInstance.PriceListWorkTypeModifiersUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersUrlParameterQuery: " + e.Message );
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

[**QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier**](QueryActionResultPriceListWorkTypeModifierModelPriceListWorkTypeModifier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricelistworktypemodifiersurlparameterquerycount"></a>
# **PriceListWorkTypeModifiersUrlParameterQueryCount**
> QueryCountResultModel PriceListWorkTypeModifiersUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class PriceListWorkTypeModifiersUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new PriceListWorkTypeModifiersApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.PriceListWorkTypeModifiersUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListWorkTypeModifiersApi.PriceListWorkTypeModifiersUrlParameterQueryCount: " + e.Message );
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

