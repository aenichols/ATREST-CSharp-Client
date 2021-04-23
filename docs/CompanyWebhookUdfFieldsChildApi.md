# IO.Swagger.Api.CompanyWebhookUdfFieldsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompanyWebhookUdfFieldsChildCreateEntity**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildcreateentity) | **POST** /V1.0/CompanyWebhooks/{parentId}/UdfFields |
[**CompanyWebhookUdfFieldsChildDeleteEntity**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschilddeleteentity) | **DELETE** /V1.0/CompanyWebhooks/{parentId}/UdfFields/{id} |
[**CompanyWebhookUdfFieldsChildPatchEntity**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildpatchentity) | **PATCH** /V1.0/CompanyWebhooks/{parentId}/UdfFields |
[**CompanyWebhookUdfFieldsChildQuery**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildquery) | **GET** /V1.0/CompanyWebhooks/{parentId}/UdfFields |
[**CompanyWebhookUdfFieldsChildQueryEntityInformation**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildqueryentityinformation) | **GET** /V1.0/CompanyWebhooks/{parentId}/UdfFields/entityInformation |
[**CompanyWebhookUdfFieldsChildQueryFieldDefinitions**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildqueryfielddefinitions) | **GET** /V1.0/CompanyWebhooks/{parentId}/UdfFields/entityInformation/fields |
[**CompanyWebhookUdfFieldsChildQueryItem**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildqueryitem) | **GET** /V1.0/CompanyWebhooks/{parentId}/UdfFields/{id} |
[**CompanyWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/CompanyWebhooks/{parentId}/UdfFields/entityInformation/userDefinedFields |
[**CompanyWebhookUdfFieldsChildUpdateEntity**](CompanyWebhookUdfFieldsChildApi.md#companywebhookudffieldschildupdateentity) | **PUT** /V1.0/CompanyWebhooks/{parentId}/UdfFields |


<a name="companywebhookudffieldschildcreateentity"></a>
# **CompanyWebhookUdfFieldsChildCreateEntity**
> OperationResultModel CompanyWebhookUdfFieldsChildCreateEntity (long? parentId, CompanyWebhookUdfFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new CompanyWebhookUdfFieldModel(); // CompanyWebhookUdfFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.CompanyWebhookUdfFieldsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**CompanyWebhookUdfFieldModel**](CompanyWebhookUdfFieldModel.md)|  |
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

<a name="companywebhookudffieldschilddeleteentity"></a>
# **CompanyWebhookUdfFieldsChildDeleteEntity**
> OperationResultModel CompanyWebhookUdfFieldsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.CompanyWebhookUdfFieldsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildDeleteEntity: " + e.Message );
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

<a name="companywebhookudffieldschildpatchentity"></a>
# **CompanyWebhookUdfFieldsChildPatchEntity**
> OperationResultModel CompanyWebhookUdfFieldsChildPatchEntity (long? parentId, CompanyWebhookUdfFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new CompanyWebhookUdfFieldModel(); // CompanyWebhookUdfFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.CompanyWebhookUdfFieldsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**CompanyWebhookUdfFieldModel**](CompanyWebhookUdfFieldModel.md)|  |
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

<a name="companywebhookudffieldschildquery"></a>
# **CompanyWebhookUdfFieldsChildQuery**
> QueryActionResultCompanyWebhookUdfFieldModelAccountWebhookUdfField CompanyWebhookUdfFieldsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultCompanyWebhookUdfFieldModelAccountWebhookUdfField result = apiInstance.CompanyWebhookUdfFieldsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildQuery: " + e.Message );
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

[**QueryActionResultCompanyWebhookUdfFieldModelAccountWebhookUdfField**](QueryActionResultCompanyWebhookUdfFieldModelAccountWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companywebhookudffieldschildqueryentityinformation"></a>
# **CompanyWebhookUdfFieldsChildQueryEntityInformation**
> EntityInformationResultModel CompanyWebhookUdfFieldsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.CompanyWebhookUdfFieldsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildQueryEntityInformation: " + e.Message );
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

<a name="companywebhookudffieldschildqueryfielddefinitions"></a>
# **CompanyWebhookUdfFieldsChildQueryFieldDefinitions**
> FieldInformationResultModel CompanyWebhookUdfFieldsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.CompanyWebhookUdfFieldsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildQueryFieldDefinitions: " + e.Message );
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

<a name="companywebhookudffieldschildqueryitem"></a>
# **CompanyWebhookUdfFieldsChildQueryItem**
> ItemQueryResultModelCompanyWebhookUdfFieldModelAccountWebhookUdfField CompanyWebhookUdfFieldsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelCompanyWebhookUdfFieldModelAccountWebhookUdfField result = apiInstance.CompanyWebhookUdfFieldsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelCompanyWebhookUdfFieldModelAccountWebhookUdfField**](ItemQueryResultModelCompanyWebhookUdfFieldModelAccountWebhookUdfField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companywebhookudffieldschildqueryuserdefinedfielddefinitions"></a>
# **CompanyWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel CompanyWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.CompanyWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="companywebhookudffieldschildupdateentity"></a>
# **CompanyWebhookUdfFieldsChildUpdateEntity**
> OperationResultModel CompanyWebhookUdfFieldsChildUpdateEntity (long? parentId, CompanyWebhookUdfFieldModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class CompanyWebhookUdfFieldsChildUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new CompanyWebhookUdfFieldsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new CompanyWebhookUdfFieldModel(); // CompanyWebhookUdfFieldModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.CompanyWebhookUdfFieldsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyWebhookUdfFieldsChildApi.CompanyWebhookUdfFieldsChildUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**CompanyWebhookUdfFieldModel**](CompanyWebhookUdfFieldModel.md)|  |
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

