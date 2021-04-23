# IO.Swagger.Api.MetadataApiIntegrationApi

All URIs are relative to *https://webservices5.autotask.net/ATServicesRest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MetadataApiIntegrationQueryEntityInformation**](MetadataApiIntegrationApi.md#metadataapiintegrationqueryentityinformation) | **GET** /V1.0/EntityInformation |


<a name="metadataapiintegrationqueryentityinformation"></a>
# **MetadataApiIntegrationQueryEntityInformation**
> GlobalEntityInformationResultModel MetadataApiIntegrationQueryEntityInformation (string apiIntegrationCode, string userName, string secret, string impersonationResourceId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;using Object = IO.Swagger.Model.Object;

namespace Example
{
    public class MetadataApiIntegrationQueryEntityInformationExample
    {
        public void main()
        {
            var apiInstance = new MetadataApiIntegrationApi();
            var apiIntegrationCode = apiIntegrationCode_example;  // string | API Integration Code
            var userName = userName_example;  // string | User Name
            var secret = secret_example;  // string | Secret
            var impersonationResourceId = impersonationResourceId_example;  // string | Impersonation Resource Key (optional)

            try
            {
                GlobalEntityInformationResultModel result = apiInstance.MetadataApiIntegrationQueryEntityInformation(apiIntegrationCode, userName, secret, impersonationResourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetadataApiIntegrationApi.MetadataApiIntegrationQueryEntityInformation: " + e.Message );
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

[**GlobalEntityInformationResultModel**](GlobalEntityInformationResultModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

