# IO.Swagger.Api.ConfigurationItemCategoryUdfAssociationsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemCategoryUdfAssociationsQuery**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsquery) | **POST** /V1.0/ConfigurationItemCategoryUdfAssociations/query |
[**ConfigurationItemCategoryUdfAssociationsQueryCount**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsquerycount) | **POST** /V1.0/ConfigurationItemCategoryUdfAssociations/query/count |
[**ConfigurationItemCategoryUdfAssociationsQueryEntityInformation**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsqueryentityinformation) | **GET** /V1.0/ConfigurationItemCategoryUdfAssociations/entityInformation |
[**ConfigurationItemCategoryUdfAssociationsQueryFieldDefinitions**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemCategoryUdfAssociations/entityInformation/fields |
[**ConfigurationItemCategoryUdfAssociationsQueryItem**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsqueryitem) | **GET** /V1.0/ConfigurationItemCategoryUdfAssociations/{id} |
[**ConfigurationItemCategoryUdfAssociationsQueryUserDefinedFieldDefinitions**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemCategoryUdfAssociations/entityInformation/userDefinedFields |
[**ConfigurationItemCategoryUdfAssociationsUrlParameterQuery**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsurlparameterquery) | **GET** /V1.0/ConfigurationItemCategoryUdfAssociations/query |
[**ConfigurationItemCategoryUdfAssociationsUrlParameterQueryCount**](ConfigurationItemCategoryUdfAssociationsApi.md#configurationitemcategoryudfassociationsurlparameterquerycount) | **GET** /V1.0/ConfigurationItemCategoryUdfAssociations/query/count |


<a name="configurationitemcategoryudfassociationsquery"></a>
# **ConfigurationItemCategoryUdfAssociationsQuery**
> QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation ConfigurationItemCategoryUdfAssociationsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation result = apiInstance.ConfigurationItemCategoryUdfAssociationsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation**](QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemcategoryudfassociationsquerycount"></a>
# **ConfigurationItemCategoryUdfAssociationsQueryCount**
> QueryCountResultModel ConfigurationItemCategoryUdfAssociationsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemCategoryUdfAssociationsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsQueryCount: " + e.Message );
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

<a name="configurationitemcategoryudfassociationsqueryentityinformation"></a>
# **ConfigurationItemCategoryUdfAssociationsQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemCategoryUdfAssociationsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemCategoryUdfAssociationsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsQueryEntityInformation: " + e.Message );
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

<a name="configurationitemcategoryudfassociationsqueryfielddefinitions"></a>
# **ConfigurationItemCategoryUdfAssociationsQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemCategoryUdfAssociationsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemCategoryUdfAssociationsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitemcategoryudfassociationsqueryitem"></a>
# **ConfigurationItemCategoryUdfAssociationsQueryItem**
> ItemQueryResultModelConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation ConfigurationItemCategoryUdfAssociationsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation result = apiInstance.ConfigurationItemCategoryUdfAssociationsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation**](ItemQueryResultModelConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemcategoryudfassociationsqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemCategoryUdfAssociationsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemCategoryUdfAssociationsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemCategoryUdfAssociationsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="configurationitemcategoryudfassociationsurlparameterquery"></a>
# **ConfigurationItemCategoryUdfAssociationsUrlParameterQuery**
> QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation ConfigurationItemCategoryUdfAssociationsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation result = apiInstance.ConfigurationItemCategoryUdfAssociationsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation**](QueryActionResultConfigurationItemCategoryUdfAssociationModelInstalledProductCategoryUdfAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitemcategoryudfassociationsurlparameterquerycount"></a>
# **ConfigurationItemCategoryUdfAssociationsUrlParameterQueryCount**
> QueryCountResultModel ConfigurationItemCategoryUdfAssociationsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemCategoryUdfAssociationsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemCategoryUdfAssociationsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemCategoryUdfAssociationsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemCategoryUdfAssociationsApi.ConfigurationItemCategoryUdfAssociationsUrlParameterQueryCount: " + e.Message );
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

