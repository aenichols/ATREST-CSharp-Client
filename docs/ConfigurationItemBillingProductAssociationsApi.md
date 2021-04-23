# IO.Swagger.Api.ConfigurationItemBillingProductAssociationsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemBillingProductAssociationsQuery**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsquery) | **POST** /V1.0/ConfigurationItemBillingProductAssociations/query |
[**ConfigurationItemBillingProductAssociationsQueryCount**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsquerycount) | **POST** /V1.0/ConfigurationItemBillingProductAssociations/query/count |
[**ConfigurationItemBillingProductAssociationsQueryEntityInformation**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsqueryentityinformation) | **GET** /V1.0/ConfigurationItemBillingProductAssociations/entityInformation |
[**ConfigurationItemBillingProductAssociationsQueryFieldDefinitions**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsqueryfielddefinitions) | **GET** /V1.0/ConfigurationItemBillingProductAssociations/entityInformation/fields |
[**ConfigurationItemBillingProductAssociationsQueryItem**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsqueryitem) | **GET** /V1.0/ConfigurationItemBillingProductAssociations/{id} |
[**ConfigurationItemBillingProductAssociationsQueryUserDefinedFieldDefinitions**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItemBillingProductAssociations/entityInformation/userDefinedFields |
[**ConfigurationItemBillingProductAssociationsUrlParameterQuery**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsurlparameterquery) | **GET** /V1.0/ConfigurationItemBillingProductAssociations/query |
[**ConfigurationItemBillingProductAssociationsUrlParameterQueryCount**](ConfigurationItemBillingProductAssociationsApi.md#configurationitembillingproductassociationsurlparameterquerycount) | **GET** /V1.0/ConfigurationItemBillingProductAssociations/query/count |


<a name="configurationitembillingproductassociationsquery"></a>
# **ConfigurationItemBillingProductAssociationsQuery**
> QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation ConfigurationItemBillingProductAssociationsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation result = apiInstance.ConfigurationItemBillingProductAssociationsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation**](QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitembillingproductassociationsquerycount"></a>
# **ConfigurationItemBillingProductAssociationsQueryCount**
> QueryCountResultModel ConfigurationItemBillingProductAssociationsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsQueryCount: " + e.Message );
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

<a name="configurationitembillingproductassociationsqueryentityinformation"></a>
# **ConfigurationItemBillingProductAssociationsQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemBillingProductAssociationsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsQueryEntityInformation: " + e.Message );
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

<a name="configurationitembillingproductassociationsqueryfielddefinitions"></a>
# **ConfigurationItemBillingProductAssociationsQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemBillingProductAssociationsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitembillingproductassociationsqueryitem"></a>
# **ConfigurationItemBillingProductAssociationsQueryItem**
> ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation ConfigurationItemBillingProductAssociationsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation result = apiInstance.ConfigurationItemBillingProductAssociationsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation**](ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitembillingproductassociationsqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemBillingProductAssociationsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemBillingProductAssociationsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="configurationitembillingproductassociationsurlparameterquery"></a>
# **ConfigurationItemBillingProductAssociationsUrlParameterQuery**
> QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation ConfigurationItemBillingProductAssociationsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation result = apiInstance.ConfigurationItemBillingProductAssociationsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation**](QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitembillingproductassociationsurlparameterquerycount"></a>
# **ConfigurationItemBillingProductAssociationsUrlParameterQueryCount**
> QueryCountResultModel ConfigurationItemBillingProductAssociationsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsApi.ConfigurationItemBillingProductAssociationsUrlParameterQueryCount: " + e.Message );
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

