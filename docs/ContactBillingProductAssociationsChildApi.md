# IO.Swagger.Api.ContactBillingProductAssociationsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContactBillingProductAssociationsChildCreateEntity**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildcreateentity) | **POST** /V1.0/Contacts/{parentId}/BillingProductAssociations |
[**ContactBillingProductAssociationsChildDeleteEntity**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschilddeleteentity) | **DELETE** /V1.0/Contacts/{parentId}/BillingProductAssociations/{id} |
[**ContactBillingProductAssociationsChildPatchEntity**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildpatchentity) | **PATCH** /V1.0/Contacts/{parentId}/BillingProductAssociations |
[**ContactBillingProductAssociationsChildQuery**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildquery) | **GET** /V1.0/Contacts/{parentId}/BillingProductAssociations |
[**ContactBillingProductAssociationsChildQueryEntityInformation**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildqueryentityinformation) | **GET** /V1.0/Contacts/{parentId}/BillingProductAssociations/entityInformation |
[**ContactBillingProductAssociationsChildQueryFieldDefinitions**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildqueryfielddefinitions) | **GET** /V1.0/Contacts/{parentId}/BillingProductAssociations/entityInformation/fields |
[**ContactBillingProductAssociationsChildQueryItem**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildqueryitem) | **GET** /V1.0/Contacts/{parentId}/BillingProductAssociations/{id} |
[**ContactBillingProductAssociationsChildQueryUserDefinedFieldDefinitions**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/Contacts/{parentId}/BillingProductAssociations/entityInformation/userDefinedFields |
[**ContactBillingProductAssociationsChildUpdateEntity**](ContactBillingProductAssociationsChildApi.md#contactbillingproductassociationschildupdateentity) | **PUT** /V1.0/Contacts/{parentId}/BillingProductAssociations |


<a name="contactbillingproductassociationschildcreateentity"></a>
# **ContactBillingProductAssociationsChildCreateEntity**
> OperationResultModel ContactBillingProductAssociationsChildCreateEntity (long? parentId, ContactBillingProductAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ContactBillingProductAssociationModel(); // ContactBillingProductAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContactBillingProductAssociationsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ContactBillingProductAssociationModel**](ContactBillingProductAssociationModel.md)|  |
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

<a name="contactbillingproductassociationschilddeleteentity"></a>
# **ContactBillingProductAssociationsChildDeleteEntity**
> OperationResultModel ContactBillingProductAssociationsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContactBillingProductAssociationsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildDeleteEntity: " + e.Message );
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

<a name="contactbillingproductassociationschildpatchentity"></a>
# **ContactBillingProductAssociationsChildPatchEntity**
> OperationResultModel ContactBillingProductAssociationsChildPatchEntity (long? parentId, ContactBillingProductAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ContactBillingProductAssociationModel(); // ContactBillingProductAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContactBillingProductAssociationsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ContactBillingProductAssociationModel**](ContactBillingProductAssociationModel.md)|  |
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

<a name="contactbillingproductassociationschildquery"></a>
# **ContactBillingProductAssociationsChildQuery**
> QueryActionResultContactBillingProductAssociationModelContactBillingProductAssociation ContactBillingProductAssociationsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultContactBillingProductAssociationModelContactBillingProductAssociation result = apiInstance.ContactBillingProductAssociationsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildQuery: " + e.Message );
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

[**QueryActionResultContactBillingProductAssociationModelContactBillingProductAssociation**](QueryActionResultContactBillingProductAssociationModelContactBillingProductAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactbillingproductassociationschildqueryentityinformation"></a>
# **ContactBillingProductAssociationsChildQueryEntityInformation**
> EntityInformationResultModel ContactBillingProductAssociationsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ContactBillingProductAssociationsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildQueryEntityInformation: " + e.Message );
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

<a name="contactbillingproductassociationschildqueryfielddefinitions"></a>
# **ContactBillingProductAssociationsChildQueryFieldDefinitions**
> FieldInformationResultModel ContactBillingProductAssociationsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ContactBillingProductAssociationsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildQueryFieldDefinitions: " + e.Message );
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

<a name="contactbillingproductassociationschildqueryitem"></a>
# **ContactBillingProductAssociationsChildQueryItem**
> ItemQueryResultModelContactBillingProductAssociationModelContactBillingProductAssociation ContactBillingProductAssociationsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelContactBillingProductAssociationModelContactBillingProductAssociation result = apiInstance.ContactBillingProductAssociationsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelContactBillingProductAssociationModelContactBillingProductAssociation**](ItemQueryResultModelContactBillingProductAssociationModelContactBillingProductAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contactbillingproductassociationschildqueryuserdefinedfielddefinitions"></a>
# **ContactBillingProductAssociationsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ContactBillingProductAssociationsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ContactBillingProductAssociationsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="contactbillingproductassociationschildupdateentity"></a>
# **ContactBillingProductAssociationsChildUpdateEntity**
> OperationResultModel ContactBillingProductAssociationsChildUpdateEntity (long? parentId, ContactBillingProductAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ContactBillingProductAssociationsChildUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new ContactBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ContactBillingProductAssociationModel(); // ContactBillingProductAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ContactBillingProductAssociationsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactBillingProductAssociationsChildApi.ContactBillingProductAssociationsChildUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ContactBillingProductAssociationModel**](ContactBillingProductAssociationModel.md)|  |
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

