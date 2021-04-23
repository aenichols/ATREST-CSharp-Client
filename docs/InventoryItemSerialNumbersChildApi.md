# IO.Swagger.Api.InventoryItemSerialNumbersChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InventoryItemSerialNumbersChildCreateEntity**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildcreateentity) | **POST** /V1.0/InventoryItems/{parentId}/SerialNumbers |
[**InventoryItemSerialNumbersChildPatchEntity**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildpatchentity) | **PATCH** /V1.0/InventoryItems/{parentId}/SerialNumbers |
[**InventoryItemSerialNumbersChildQuery**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildquery) | **GET** /V1.0/InventoryItems/{parentId}/SerialNumbers |
[**InventoryItemSerialNumbersChildQueryEntityInformation**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildqueryentityinformation) | **GET** /V1.0/InventoryItems/{parentId}/SerialNumbers/entityInformation |
[**InventoryItemSerialNumbersChildQueryFieldDefinitions**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildqueryfielddefinitions) | **GET** /V1.0/InventoryItems/{parentId}/SerialNumbers/entityInformation/fields |
[**InventoryItemSerialNumbersChildQueryItem**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildqueryitem) | **GET** /V1.0/InventoryItems/{parentId}/SerialNumbers/{id} |
[**InventoryItemSerialNumbersChildQueryUserDefinedFieldDefinitions**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/InventoryItems/{parentId}/SerialNumbers/entityInformation/userDefinedFields |
[**InventoryItemSerialNumbersChildUpdateEntity**](InventoryItemSerialNumbersChildApi.md#inventoryitemserialnumberschildupdateentity) | **PUT** /V1.0/InventoryItems/{parentId}/SerialNumbers |


<a name="inventoryitemserialnumberschildcreateentity"></a>
# **InventoryItemSerialNumbersChildCreateEntity**
> OperationResultModel InventoryItemSerialNumbersChildCreateEntity (long? parentId, InventoryItemSerialNumberModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new InventoryItemSerialNumberModel(); // InventoryItemSerialNumberModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.InventoryItemSerialNumbersChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**InventoryItemSerialNumberModel**](InventoryItemSerialNumberModel.md)|  |
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

<a name="inventoryitemserialnumberschildpatchentity"></a>
# **InventoryItemSerialNumbersChildPatchEntity**
> OperationResultModel InventoryItemSerialNumbersChildPatchEntity (long? parentId, InventoryItemSerialNumberModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new InventoryItemSerialNumberModel(); // InventoryItemSerialNumberModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.InventoryItemSerialNumbersChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**InventoryItemSerialNumberModel**](InventoryItemSerialNumberModel.md)|  |
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

<a name="inventoryitemserialnumberschildquery"></a>
# **InventoryItemSerialNumbersChildQuery**
> QueryActionResultInventoryItemSerialNumberModelInventoryItemSerialNumber InventoryItemSerialNumbersChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildQueryExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultInventoryItemSerialNumberModelInventoryItemSerialNumber result = apiInstance.InventoryItemSerialNumbersChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildQuery: " + e.Message );
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

[**QueryActionResultInventoryItemSerialNumberModelInventoryItemSerialNumber**](QueryActionResultInventoryItemSerialNumberModelInventoryItemSerialNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryitemserialnumberschildqueryentityinformation"></a>
# **InventoryItemSerialNumbersChildQueryEntityInformation**
> EntityInformationResultModel InventoryItemSerialNumbersChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.InventoryItemSerialNumbersChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildQueryEntityInformation: " + e.Message );
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

<a name="inventoryitemserialnumberschildqueryfielddefinitions"></a>
# **InventoryItemSerialNumbersChildQueryFieldDefinitions**
> FieldInformationResultModel InventoryItemSerialNumbersChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.InventoryItemSerialNumbersChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildQueryFieldDefinitions: " + e.Message );
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

<a name="inventoryitemserialnumberschildqueryitem"></a>
# **InventoryItemSerialNumbersChildQueryItem**
> ItemQueryResultModelInventoryItemSerialNumberModelInventoryItemSerialNumber InventoryItemSerialNumbersChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelInventoryItemSerialNumberModelInventoryItemSerialNumber result = apiInstance.InventoryItemSerialNumbersChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelInventoryItemSerialNumberModelInventoryItemSerialNumber**](ItemQueryResultModelInventoryItemSerialNumberModelInventoryItemSerialNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inventoryitemserialnumberschildqueryuserdefinedfielddefinitions"></a>
# **InventoryItemSerialNumbersChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel InventoryItemSerialNumbersChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.InventoryItemSerialNumbersChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="inventoryitemserialnumberschildupdateentity"></a>
# **InventoryItemSerialNumbersChildUpdateEntity**
> OperationResultModel InventoryItemSerialNumbersChildUpdateEntity (long? parentId, InventoryItemSerialNumberModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class InventoryItemSerialNumbersChildUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new InventoryItemSerialNumbersChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new InventoryItemSerialNumberModel(); // InventoryItemSerialNumberModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.InventoryItemSerialNumbersChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryItemSerialNumbersChildApi.InventoryItemSerialNumbersChildUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**InventoryItemSerialNumberModel**](InventoryItemSerialNumberModel.md)|  |
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

