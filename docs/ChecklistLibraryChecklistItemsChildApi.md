# IO.Swagger.Api.ChecklistLibraryChecklistItemsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChecklistLibraryChecklistItemsChildCreateEntity**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildcreateentity) | **POST** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems |
[**ChecklistLibraryChecklistItemsChildDeleteEntity**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschilddeleteentity) | **DELETE** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems/{id} |
[**ChecklistLibraryChecklistItemsChildPatchEntity**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildpatchentity) | **PATCH** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems |
[**ChecklistLibraryChecklistItemsChildQuery**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildquery) | **GET** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems |
[**ChecklistLibraryChecklistItemsChildQueryEntityInformation**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildqueryentityinformation) | **GET** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems/entityInformation |
[**ChecklistLibraryChecklistItemsChildQueryFieldDefinitions**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildqueryfielddefinitions) | **GET** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems/entityInformation/fields |
[**ChecklistLibraryChecklistItemsChildQueryItem**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildqueryitem) | **GET** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems/{id} |
[**ChecklistLibraryChecklistItemsChildQueryUserDefinedFieldDefinitions**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems/entityInformation/userDefinedFields |
[**ChecklistLibraryChecklistItemsChildUpdateEntity**](ChecklistLibraryChecklistItemsChildApi.md#checklistlibrarychecklistitemschildupdateentity) | **PUT** /V1.0/ChecklistLibraries/{parentId}/ChecklistItems |


<a name="checklistlibrarychecklistitemschildcreateentity"></a>
# **ChecklistLibraryChecklistItemsChildCreateEntity**
> OperationResultModel ChecklistLibraryChecklistItemsChildCreateEntity (long? parentId, ChecklistLibraryChecklistItemModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ChecklistLibraryChecklistItemModel(); // ChecklistLibraryChecklistItemModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ChecklistLibraryChecklistItemsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ChecklistLibraryChecklistItemModel**](ChecklistLibraryChecklistItemModel.md)|  |
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

<a name="checklistlibrarychecklistitemschilddeleteentity"></a>
# **ChecklistLibraryChecklistItemsChildDeleteEntity**
> OperationResultModel ChecklistLibraryChecklistItemsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ChecklistLibraryChecklistItemsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildDeleteEntity: " + e.Message );
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

<a name="checklistlibrarychecklistitemschildpatchentity"></a>
# **ChecklistLibraryChecklistItemsChildPatchEntity**
> OperationResultModel ChecklistLibraryChecklistItemsChildPatchEntity (long? parentId, ChecklistLibraryChecklistItemModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ChecklistLibraryChecklistItemModel(); // ChecklistLibraryChecklistItemModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ChecklistLibraryChecklistItemsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ChecklistLibraryChecklistItemModel**](ChecklistLibraryChecklistItemModel.md)|  |
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

<a name="checklistlibrarychecklistitemschildquery"></a>
# **ChecklistLibraryChecklistItemsChildQuery**
> QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem ChecklistLibraryChecklistItemsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem result = apiInstance.ChecklistLibraryChecklistItemsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildQuery: " + e.Message );
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

[**QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem**](QueryActionResultChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checklistlibrarychecklistitemschildqueryentityinformation"></a>
# **ChecklistLibraryChecklistItemsChildQueryEntityInformation**
> EntityInformationResultModel ChecklistLibraryChecklistItemsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ChecklistLibraryChecklistItemsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildQueryEntityInformation: " + e.Message );
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

<a name="checklistlibrarychecklistitemschildqueryfielddefinitions"></a>
# **ChecklistLibraryChecklistItemsChildQueryFieldDefinitions**
> FieldInformationResultModel ChecklistLibraryChecklistItemsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ChecklistLibraryChecklistItemsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildQueryFieldDefinitions: " + e.Message );
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

<a name="checklistlibrarychecklistitemschildqueryitem"></a>
# **ChecklistLibraryChecklistItemsChildQueryItem**
> ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem ChecklistLibraryChecklistItemsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem result = apiInstance.ChecklistLibraryChecklistItemsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem**](ItemQueryResultModelChecklistLibraryChecklistItemModelChecklistLibraryChecklistItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checklistlibrarychecklistitemschildqueryuserdefinedfielddefinitions"></a>
# **ChecklistLibraryChecklistItemsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ChecklistLibraryChecklistItemsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ChecklistLibraryChecklistItemsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="checklistlibrarychecklistitemschildupdateentity"></a>
# **ChecklistLibraryChecklistItemsChildUpdateEntity**
> OperationResultModel ChecklistLibraryChecklistItemsChildUpdateEntity (long? parentId, ChecklistLibraryChecklistItemModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ChecklistLibraryChecklistItemsChildUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new ChecklistLibraryChecklistItemsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ChecklistLibraryChecklistItemModel(); // ChecklistLibraryChecklistItemModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ChecklistLibraryChecklistItemsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChecklistLibraryChecklistItemsChildApi.ChecklistLibraryChecklistItemsChildUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ChecklistLibraryChecklistItemModel**](ChecklistLibraryChecklistItemModel.md)|  |
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

