# IO.Swagger.Api.DocumentConfigurationItemCategoryAssociationsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentConfigurationItemCategoryAssociationsChildCreateEntity**](DocumentConfigurationItemCategoryAssociationsChildApi.md#documentconfigurationitemcategoryassociationschildcreateentity) | **POST** /V1.0/Documents/{parentId}/ConfigurationItemCategoryAssociations |
[**DocumentConfigurationItemCategoryAssociationsChildDeleteEntity**](DocumentConfigurationItemCategoryAssociationsChildApi.md#documentconfigurationitemcategoryassociationschilddeleteentity) | **DELETE** /V1.0/Documents/{parentId}/ConfigurationItemCategoryAssociations/{id} |
[**DocumentConfigurationItemCategoryAssociationsChildQuery**](DocumentConfigurationItemCategoryAssociationsChildApi.md#documentconfigurationitemcategoryassociationschildquery) | **GET** /V1.0/Documents/{parentId}/ConfigurationItemCategoryAssociations |
[**DocumentConfigurationItemCategoryAssociationsChildQueryEntityInformation**](DocumentConfigurationItemCategoryAssociationsChildApi.md#documentconfigurationitemcategoryassociationschildqueryentityinformation) | **GET** /V1.0/Documents/{parentId}/ConfigurationItemCategoryAssociations/entityInformation |
[**DocumentConfigurationItemCategoryAssociationsChildQueryFieldDefinitions**](DocumentConfigurationItemCategoryAssociationsChildApi.md#documentconfigurationitemcategoryassociationschildqueryfielddefinitions) | **GET** /V1.0/Documents/{parentId}/ConfigurationItemCategoryAssociations/entityInformation/fields |
[**DocumentConfigurationItemCategoryAssociationsChildQueryItem**](DocumentConfigurationItemCategoryAssociationsChildApi.md#documentconfigurationitemcategoryassociationschildqueryitem) | **GET** /V1.0/Documents/{parentId}/ConfigurationItemCategoryAssociations/{id} |
[**DocumentConfigurationItemCategoryAssociationsChildQueryUserDefinedFieldDefinitions**](DocumentConfigurationItemCategoryAssociationsChildApi.md#documentconfigurationitemcategoryassociationschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/Documents/{parentId}/ConfigurationItemCategoryAssociations/entityInformation/userDefinedFields |


<a name="documentconfigurationitemcategoryassociationschildcreateentity"></a>
# **DocumentConfigurationItemCategoryAssociationsChildCreateEntity**
> OperationResultModel DocumentConfigurationItemCategoryAssociationsChildCreateEntity (long? parentId, DocumentConfigurationItemCategoryAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new DocumentConfigurationItemCategoryAssociationModel(); // DocumentConfigurationItemCategoryAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsChildApi.DocumentConfigurationItemCategoryAssociationsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**DocumentConfigurationItemCategoryAssociationModel**](DocumentConfigurationItemCategoryAssociationModel.md)|  |
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

<a name="documentconfigurationitemcategoryassociationschilddeleteentity"></a>
# **DocumentConfigurationItemCategoryAssociationsChildDeleteEntity**
> OperationResultModel DocumentConfigurationItemCategoryAssociationsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsChildApi.DocumentConfigurationItemCategoryAssociationsChildDeleteEntity: " + e.Message );
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

<a name="documentconfigurationitemcategoryassociationschildquery"></a>
# **DocumentConfigurationItemCategoryAssociationsChildQuery**
> QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation DocumentConfigurationItemCategoryAssociationsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation result = apiInstance.DocumentConfigurationItemCategoryAssociationsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsChildApi.DocumentConfigurationItemCategoryAssociationsChildQuery: " + e.Message );
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

[**QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation**](QueryActionResultDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentconfigurationitemcategoryassociationschildqueryentityinformation"></a>
# **DocumentConfigurationItemCategoryAssociationsChildQueryEntityInformation**
> EntityInformationResultModel DocumentConfigurationItemCategoryAssociationsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsChildApi.DocumentConfigurationItemCategoryAssociationsChildQueryEntityInformation: " + e.Message );
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

<a name="documentconfigurationitemcategoryassociationschildqueryfielddefinitions"></a>
# **DocumentConfigurationItemCategoryAssociationsChildQueryFieldDefinitions**
> FieldInformationResultModel DocumentConfigurationItemCategoryAssociationsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsChildApi.DocumentConfigurationItemCategoryAssociationsChildQueryFieldDefinitions: " + e.Message );
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

<a name="documentconfigurationitemcategoryassociationschildqueryitem"></a>
# **DocumentConfigurationItemCategoryAssociationsChildQueryItem**
> ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation DocumentConfigurationItemCategoryAssociationsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation result = apiInstance.DocumentConfigurationItemCategoryAssociationsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsChildApi.DocumentConfigurationItemCategoryAssociationsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation**](ItemQueryResultModelDocumentConfigurationItemCategoryAssociationModelDocumentInstalledProductCategoryAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documentconfigurationitemcategoryassociationschildqueryuserdefinedfielddefinitions"></a>
# **DocumentConfigurationItemCategoryAssociationsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel DocumentConfigurationItemCategoryAssociationsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentConfigurationItemCategoryAssociationsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new DocumentConfigurationItemCategoryAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.DocumentConfigurationItemCategoryAssociationsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentConfigurationItemCategoryAssociationsChildApi.DocumentConfigurationItemCategoryAssociationsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

