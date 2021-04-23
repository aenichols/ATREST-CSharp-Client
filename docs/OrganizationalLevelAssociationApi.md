# IO.Swagger.Api.OrganizationalLevelAssociationApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganizationalLevelAssociationCreateEntity**](OrganizationalLevelAssociationApi.md#organizationallevelassociationcreateentity) | **POST** /V1.0/OrganizationalLevelAssociations |
[**OrganizationalLevelAssociationPatchEntity**](OrganizationalLevelAssociationApi.md#organizationallevelassociationpatchentity) | **PATCH** /V1.0/OrganizationalLevelAssociations |
[**OrganizationalLevelAssociationQuery**](OrganizationalLevelAssociationApi.md#organizationallevelassociationquery) | **POST** /V1.0/OrganizationalLevelAssociations/query |
[**OrganizationalLevelAssociationQueryCount**](OrganizationalLevelAssociationApi.md#organizationallevelassociationquerycount) | **POST** /V1.0/OrganizationalLevelAssociations/query/count |
[**OrganizationalLevelAssociationQueryEntityInformation**](OrganizationalLevelAssociationApi.md#organizationallevelassociationqueryentityinformation) | **GET** /V1.0/OrganizationalLevelAssociations/entityInformation |
[**OrganizationalLevelAssociationQueryFieldDefinitions**](OrganizationalLevelAssociationApi.md#organizationallevelassociationqueryfielddefinitions) | **GET** /V1.0/OrganizationalLevelAssociations/entityInformation/fields |
[**OrganizationalLevelAssociationQueryItem**](OrganizationalLevelAssociationApi.md#organizationallevelassociationqueryitem) | **GET** /V1.0/OrganizationalLevelAssociations/{id} |
[**OrganizationalLevelAssociationQueryUserDefinedFieldDefinitions**](OrganizationalLevelAssociationApi.md#organizationallevelassociationqueryuserdefinedfielddefinitions) | **GET** /V1.0/OrganizationalLevelAssociations/entityInformation/userDefinedFields |
[**OrganizationalLevelAssociationUpdateEntity**](OrganizationalLevelAssociationApi.md#organizationallevelassociationupdateentity) | **PUT** /V1.0/OrganizationalLevelAssociations |
[**OrganizationalLevelAssociationUrlParameterQuery**](OrganizationalLevelAssociationApi.md#organizationallevelassociationurlparameterquery) | **GET** /V1.0/OrganizationalLevelAssociations/query |
[**OrganizationalLevelAssociationUrlParameterQueryCount**](OrganizationalLevelAssociationApi.md#organizationallevelassociationurlparameterquerycount) | **GET** /V1.0/OrganizationalLevelAssociations/query/count |


<a name="organizationallevelassociationcreateentity"></a>
# **OrganizationalLevelAssociationCreateEntity**
> OperationResultModel OrganizationalLevelAssociationCreateEntity (OrganizationalLevelAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationCreateEntityExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var restModelInput = new OrganizationalLevelAssociationModel(); // OrganizationalLevelAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.OrganizationalLevelAssociationCreateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationCreateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**OrganizationalLevelAssociationModel**](OrganizationalLevelAssociationModel.md)|  |
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

<a name="organizationallevelassociationpatchentity"></a>
# **OrganizationalLevelAssociationPatchEntity**
> OperationResultModel OrganizationalLevelAssociationPatchEntity (OrganizationalLevelAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationPatchEntityExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var restModelInput = new OrganizationalLevelAssociationModel(); // OrganizationalLevelAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.OrganizationalLevelAssociationPatchEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationPatchEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**OrganizationalLevelAssociationModel**](OrganizationalLevelAssociationModel.md)|  |
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

<a name="organizationallevelassociationquery"></a>
# **OrganizationalLevelAssociationQuery**
> QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision OrganizationalLevelAssociationQuery (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationQueryExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision result = apiInstance.OrganizationalLevelAssociationQuery(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationQuery: " + e.Message );
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

[**QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision**](QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organizationallevelassociationquerycount"></a>
# **OrganizationalLevelAssociationQueryCount**
> QueryCountResultModel OrganizationalLevelAssociationQueryCount (QueryModel queryModel, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationQueryCountExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var queryModel = new QueryModel(); // QueryModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.OrganizationalLevelAssociationQueryCount(queryModel, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationQueryCount: " + e.Message );
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

<a name="organizationallevelassociationqueryentityinformation"></a>
# **OrganizationalLevelAssociationQueryEntityInformation**
> EntityInformationResultModel OrganizationalLevelAssociationQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                EntityInformationResultModel result = apiInstance.OrganizationalLevelAssociationQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationQueryEntityInformation: " + e.Message );
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

<a name="organizationallevelassociationqueryfielddefinitions"></a>
# **OrganizationalLevelAssociationQueryFieldDefinitions**
> FieldInformationResultModel OrganizationalLevelAssociationQueryFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationQueryFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                FieldInformationResultModel result = apiInstance.OrganizationalLevelAssociationQueryFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationQueryFieldDefinitions: " + e.Message );
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

<a name="organizationallevelassociationqueryitem"></a>
# **OrganizationalLevelAssociationQueryItem**
> ItemQueryResultModelOrganizationalLevelAssociationModelBusinessDivisionSubdivision OrganizationalLevelAssociationQueryItem (long? id, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationQueryItemExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var id = 789;  // long? |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                ItemQueryResultModelOrganizationalLevelAssociationModelBusinessDivisionSubdivision result = apiInstance.OrganizationalLevelAssociationQueryItem(id, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationQueryItem: " + e.Message );
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

[**ItemQueryResultModelOrganizationalLevelAssociationModelBusinessDivisionSubdivision**](ItemQueryResultModelOrganizationalLevelAssociationModelBusinessDivisionSubdivision.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organizationallevelassociationqueryuserdefinedfielddefinitions"></a>
# **OrganizationalLevelAssociationQueryUserDefinedFieldDefinitions**
> UserDefinedFieldInformationResultModel OrganizationalLevelAssociationQueryUserDefinedFieldDefinitions (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationQueryUserDefinedFieldDefinitionsExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                UserDefinedFieldInformationResultModel result = apiInstance.OrganizationalLevelAssociationQueryUserDefinedFieldDefinitions(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationQueryUserDefinedFieldDefinitions: " + e.Message );
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

<a name="organizationallevelassociationupdateentity"></a>
# **OrganizationalLevelAssociationUpdateEntity**
> OperationResultModel OrganizationalLevelAssociationUpdateEntity (OrganizationalLevelAssociationModel restModelInput, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationUpdateEntityExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var restModelInput = new OrganizationalLevelAssociationModel(); // OrganizationalLevelAssociationModel |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                OperationResultModel result = apiInstance.OrganizationalLevelAssociationUpdateEntity(restModelInput, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationUpdateEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **restModelInput** | [**OrganizationalLevelAssociationModel**](OrganizationalLevelAssociationModel.md)|  |
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

<a name="organizationallevelassociationurlparameterquery"></a>
# **OrganizationalLevelAssociationUrlParameterQuery**
> QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision OrganizationalLevelAssociationUrlParameterQuery (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationUrlParameterQueryExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision result = apiInstance.OrganizationalLevelAssociationUrlParameterQuery(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationUrlParameterQuery: " + e.Message );
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

[**QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision**](QueryActionResultOrganizationalLevelAssociationModelBusinessDivisionSubdivision.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organizationallevelassociationurlparameterquerycount"></a>
# **OrganizationalLevelAssociationUrlParameterQueryCount**
> QueryCountResultModel OrganizationalLevelAssociationUrlParameterQueryCount (string search, string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class OrganizationalLevelAssociationUrlParameterQueryCountExample
    {
        public void main()
        {
            var apiInstance = new OrganizationalLevelAssociationApi();
            var search = search_example;  // string |
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                QueryCountResultModel result = apiInstance.OrganizationalLevelAssociationUrlParameterQueryCount(search, apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationalLevelAssociationApi.OrganizationalLevelAssociationUrlParameterQueryCount: " + e.Message );
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

