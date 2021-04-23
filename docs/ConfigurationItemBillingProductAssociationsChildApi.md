# IO.Swagger.Api.ConfigurationItemBillingProductAssociationsChildApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfigurationItemBillingProductAssociationsChildCreateEntity**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildcreateentity) | **POST** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations |
[**ConfigurationItemBillingProductAssociationsChildDeleteEntity**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschilddeleteentity) | **DELETE** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/{id} |
[**ConfigurationItemBillingProductAssociationsChildPatchEntity**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildpatchentity) | **PATCH** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations |
[**ConfigurationItemBillingProductAssociationsChildQuery**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildquery) | **GET** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations |
[**ConfigurationItemBillingProductAssociationsChildQueryEntityInformation**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildqueryentityinformation) | **GET** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/entityInformation |
[**ConfigurationItemBillingProductAssociationsChildQueryFieldDefinitions**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildqueryfielddefinitions) | **GET** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/entityInformation/fields |
[**ConfigurationItemBillingProductAssociationsChildQueryItem**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildqueryitem) | **GET** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/{id} |
[**ConfigurationItemBillingProductAssociationsChildQueryUserDefinedFieldDefinitions**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildqueryuserdefinedfielddefinitions) | **GET** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations/entityInformation/userDefinedFields |
[**ConfigurationItemBillingProductAssociationsChildUpdateEntity**](ConfigurationItemBillingProductAssociationsChildApi.md#configurationitembillingproductassociationschildupdateentity) | **PUT** /V1.0/ConfigurationItems/{parentId}/BillingProductAssociations |


<a name="configurationitembillingproductassociationschildcreateentity"></a>
# **ConfigurationItemBillingProductAssociationsChildCreateEntity**
> OperationResultModel ConfigurationItemBillingProductAssociationsChildCreateEntity (long? parentId, ConfigurationItemBillingProductAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemBillingProductAssociationModel(); // ConfigurationItemBillingProductAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsChildCreateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemBillingProductAssociationModel**](ConfigurationItemBillingProductAssociationModel.md)|  |
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

<a name="configurationitembillingproductassociationschilddeleteentity"></a>
# **ConfigurationItemBillingProductAssociationsChildDeleteEntity**
> OperationResultModel ConfigurationItemBillingProductAssociationsChildDeleteEntity (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildDeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsChildDeleteEntity(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildDeleteEntity: " + e.Message );
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

<a name="configurationitembillingproductassociationschildpatchentity"></a>
# **ConfigurationItemBillingProductAssociationsChildPatchEntity**
> OperationResultModel ConfigurationItemBillingProductAssociationsChildPatchEntity (long? parentId, ConfigurationItemBillingProductAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemBillingProductAssociationModel(); // ConfigurationItemBillingProductAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsChildPatchEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemBillingProductAssociationModel**](ConfigurationItemBillingProductAssociationModel.md)|  |
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

<a name="configurationitembillingproductassociationschildquery"></a>
# **ConfigurationItemBillingProductAssociationsChildQuery**
> QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation ConfigurationItemBillingProductAssociationsChildQuery (long? parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildQueryExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation result = apiInstance.ConfigurationItemBillingProductAssociationsChildQuery(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildQuery: " + e.Message );
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

[**QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation**](QueryActionResultConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitembillingproductassociationschildqueryentityinformation"></a>
# **ConfigurationItemBillingProductAssociationsChildQueryEntityInformation**
> EntityInformationResultModel ConfigurationItemBillingProductAssociationsChildQueryEntityInformation (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsChildQueryEntityInformation(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildQueryEntityInformation: " + e.Message );
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

<a name="configurationitembillingproductassociationschildqueryfielddefinitions"></a>
# **ConfigurationItemBillingProductAssociationsChildQueryFieldDefinitions**
> FieldInformationResultModel ConfigurationItemBillingProductAssociationsChildQueryFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsChildQueryFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildQueryFieldDefinitions: " + e.Message );
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

<a name="configurationitembillingproductassociationschildqueryitem"></a>
# **ConfigurationItemBillingProductAssociationsChildQueryItem**
> ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation ConfigurationItemBillingProductAssociationsChildQueryItem (long? parentId, long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildQueryItemExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation result = apiInstance.ConfigurationItemBillingProductAssociationsChildQueryItem(parentId, id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildQueryItem: " + e.Message );
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

[**ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation**](ItemQueryResultModelConfigurationItemBillingProductAssociationModelInstalledProductBillingProductAssociation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="configurationitembillingproductassociationschildqueryuserdefinedfielddefinitions"></a>
# **ConfigurationItemBillingProductAssociationsChildQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel ConfigurationItemBillingProductAssociationsChildQueryUserDefinedFieldDefinitions (string parentId, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = parentId_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsChildQueryUserDefinedFieldDefinitions(parentId, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="configurationitembillingproductassociationschildupdateentity"></a>
# **ConfigurationItemBillingProductAssociationsChildUpdateEntity**
> OperationResultModel ConfigurationItemBillingProductAssociationsChildUpdateEntity (long? parentId, ConfigurationItemBillingProductAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class ConfigurationItemBillingProductAssociationsChildUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new ConfigurationItemBillingProductAssociationsChildApi();
            var parentId = 789;  // long? |
            var restModelInput = new ConfigurationItemBillingProductAssociationModel(); // ConfigurationItemBillingProductAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.ConfigurationItemBillingProductAssociationsChildUpdateEntity(parentId, restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigurationItemBillingProductAssociationsChildApi.ConfigurationItemBillingProductAssociationsChildUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **parentId** | **long?**|  |
 **restModelInput** | [**ConfigurationItemBillingProductAssociationModel**](ConfigurationItemBillingProductAssociationModel.md)|  |
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

