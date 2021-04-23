# IO.Swagger.Api.DocumentTagAssociationsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentTagAssociationsChildCreateEntity**](DocumentTagAssociationsChildApi.md#documenttagassociationschildcreateentity) | **POST** /V1.0/Documents/{parentId}/TagAssociations |
[**DocumentTagAssociationsChildDeleteEntity**](DocumentTagAssociationsChildApi.md#documenttagassociationschilddeleteentity) | **DELETE** /V1.0/Documents/{parentId}/TagAssociations/{id} |
[**DocumentTagAssociationsChildQuery**](DocumentTagAssociationsChildApi.md#documenttagassociationschildquery) | **GET** /V1.0/Documents/{parentId}/TagAssociations |
[**DocumentTagAssociationsChildQueryEntityInformation**](DocumentTagAssociationsChildApi.md#documenttagassociationschildqueryentityinformation) | **GET** /V1.0/Documents/{parentId}/TagAssociations/entityInformation |
[**DocumentTagAssociationsChildQueryFieldDefinitions**](DocumentTagAssociationsChildApi.md#documenttagassociationschildqueryfielddefinitions) | **GET** /V1.0/Documents/{parentId}/TagAssociations/entityInformation/fields |
[**DocumentTagAssociationsChildQueryItem**](DocumentTagAssociationsChildApi.md#documenttagassociationschildqueryitem) | **GET** /V1.0/Documents/{parentId}/TagAssociations/{id} |
[**DocumentTagAssociationsChildQueryUserDefinedFieldDefinitions**](DocumentTagAssociationsChildApi.md#documenttagassociationschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/Documents/{parentId}/TagAssociations/entityInformation/userDefinedFields |


<a name="documenttagassociationschildcreateentity"></a>
# **DocumentTagAssociationsChildCreateEntity**
> OperationResultModel DocumentTagAssociationsChildCreateEntity (long? parentId, DocumentTagAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentTagAssociationsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new DocumentTagAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new DocumentTagAssociationModel(); // DocumentTagAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.DocumentTagAssociationsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTagAssociationsChildApi.DocumentTagAssociationsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**DocumentTagAssociationModel**](DocumentTagAssociationModel.md)|  |
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

<a name="documenttagassociationschilddeleteentity"></a>
# **DocumentTagAssociationsChildDeleteEntity**
> OperationResultModel DocumentTagAssociationsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentTagAssociationsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new DocumentTagAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.DocumentTagAssociationsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTagAssociationsChildApi.DocumentTagAssociationsChildDeleteEntity: " + e.Message );
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

<a name="documenttagassociationschildquery"></a>
# **DocumentTagAssociationsChildQuery**
> QueryActionResultDocumentTagAssociationModelDocumentTagAssociation DocumentTagAssociationsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentTagAssociationsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new DocumentTagAssociationsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultDocumentTagAssociationModelDocumentTagAssociation result = apiInstance.DocumentTagAssociationsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTagAssociationsChildApi.DocumentTagAssociationsChildQuery: " + e.Message );
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

[**QueryActionResultDocumentTagAssociationModelDocumentTagAssociation**](QueryActionResultDocumentTagAssociationModelDocumentTagAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttagassociationschildqueryentityinformation"></a>
# **DocumentTagAssociationsChildQueryEntityInformation**
> EntityInformationResultModel DocumentTagAssociationsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentTagAssociationsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new DocumentTagAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.DocumentTagAssociationsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTagAssociationsChildApi.DocumentTagAssociationsChildQueryEntityInformation: " + e.Message );
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

<a name="documenttagassociationschildqueryfielddefinitions"></a>
# **DocumentTagAssociationsChildQueryFieldDefinitions**
> FieldInformationResultModel DocumentTagAssociationsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentTagAssociationsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new DocumentTagAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.DocumentTagAssociationsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTagAssociationsChildApi.DocumentTagAssociationsChildQueryFieldDefinitions: " + e.Message );
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

<a name="documenttagassociationschildqueryitem"></a>
# **DocumentTagAssociationsChildQueryItem**
> ItemQueryResultModelDocumentTagAssociationModelDocumentTagAssociation DocumentTagAssociationsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentTagAssociationsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new DocumentTagAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelDocumentTagAssociationModelDocumentTagAssociation result = apiInstance.DocumentTagAssociationsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTagAssociationsChildApi.DocumentTagAssociationsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelDocumentTagAssociationModelDocumentTagAssociation**](ItemQueryResultModelDocumentTagAssociationModelDocumentTagAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="documenttagassociationschildqueryuserdefinedfielddefinitions"></a>
# **DocumentTagAssociationsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel DocumentTagAssociationsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class DocumentTagAssociationsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new DocumentTagAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.DocumentTagAssociationsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DocumentTagAssociationsChildApi.DocumentTagAssociationsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

