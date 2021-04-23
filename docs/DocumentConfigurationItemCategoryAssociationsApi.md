# IO.Swagger.Api.DocumentConfigurationItemCategoryAssociationsApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentConfigurationItemCategoryAssociationsQuery**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsquery) | **POST** /V1.0/DocumentConfigurationItemCategoryAssociations/query |
[**DocumentConfigurationItemCategoryAssociationsQueryCount**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsquerycount) | **POST** /V1.0/DocumentConfigurationItemCategoryAssociations/query/count |
[**DocumentConfigurationItemCategoryAssociationsQueryEntityInformation**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsqueryentityinformation) | **GET** /V1.0/DocumentConfigurationItemCategoryAssociations/entityInformation |
[**DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitions**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsqueryfielddefinitions) | **GET** /V1.0/DocumentConfigurationItemCategoryAssociations/entityInformation/fields |
[**DocumentConfigurationItemCategoryAssociationsQueryItem**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsqueryitem) | **GET** /V1.0/DocumentConfigurationItemCategoryAssociations/{id} |
[**DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitions**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsqueryuserdefinedfielddefinitions) | **GET** /V1.0/DocumentConfigurationItemCategoryAssociations/entityInformation/userDefinedFields |
[**DocumentConfigurationItemCategoryAssociationsUrlParameterQuery**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsurlparameterquery) | **GET** /V1.0/DocumentConfigurationItemCategoryAssociations/query |
[**DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCount**](DocumentConfigurationItemCategoryAssociationsApi.md#documentconfigurationitemcategoryassociationsurlparameterquerycount) | **GET** /V1.0/DocumentConfigurationItemCategoryAssociations/query/count |


<a name="documentconfigurationitemcategoryassociationsquery"></a>
# **DocumentConfigurationItemCategoryAssociationsQuery**
> QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation DocumentConfigurationItemCategoryAssociationsQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation result = apiInstance.DocumentConfigurationItemCategoryAssociationsQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsQuery: " + e.Message );
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

[**QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation**](QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentconfigurationitemcategoryassociationsquerycount"></a>
# **DocumentConfigurationItemCategoryAssociationsQueryCount**
> QueryCountResultModel DocumentConfigurationItemCategoryAssociationsQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsQueryCountExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsQueryCount: " + e.Message );
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

<a name="documentconfigurationitemcategoryassociationsqueryentityinformation"></a>
# **DocumentConfigurationItemCategoryAssociationsQueryEntityInformation**
> EntityInformationResultModel DocumentConfigurationItemCategoryAssociationsQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsQueryEntityInformation: " + e.Message );
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

<a name="documentconfigurationitemcategoryassociationsqueryfielddefinitions"></a>
# **DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitions**
> FieldInformationResultModel DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsQueryFieldDefinitions: " + e.Message );
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

<a name="documentconfigurationitemcategoryassociationsqueryitem"></a>
# **DocumentConfigurationItemCategoryAssociationsQueryItem**
> ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation DocumentConfigurationItemCategoryAssociationsQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsQueryItemExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation result = apiInstance.DocumentConfigurationItemCategoryAssociationsQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsQueryItem: " + e.Message );
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

[**ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation**](ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentconfigurationitemcategoryassociationsqueryuserdefinedfielddefinitions"></a>
# **DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="documentconfigurationitemcategoryassociationsurlparameterquery"></a>
# **DocumentConfigurationItemCategoryAssociationsUrlParameterQuery**
> QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation DocumentConfigurationItemCategoryAssociationsUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation result = apiInstance.DocumentConfigurationItemCategoryAssociationsUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsUrlParameterQuery: " + e.Message );
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

[**QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation**](QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentconfigurationitemcategoryassociationsurlparameterquerycount"></a>
# **DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCount**
> QueryCountResultModel DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsApi.DocumentConfigurationItemCategoryAssociationsUrlParameterQueryCount: " + e.Message );
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

