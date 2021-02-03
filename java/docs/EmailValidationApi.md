# EmailValidationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**emailValidationSingleValidationGet**](EmailValidationApi.md#emailValidationSingleValidationGet) | **GET** /v1/validation/single/{email} | 
[**emailValidationSingleValidationPost**](EmailValidationApi.md#emailValidationSingleValidationPost) | **POST** /v1/validation/single | 

<a name="emailValidationSingleValidationGet"></a>
# **emailValidationSingleValidationGet**
> EmailResponse emailValidationSingleValidationGet(email, resultType)



POST request contains additional parameters for detailed configuration

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EmailValidationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: AuthKey
ApiKeyAuth AuthKey = (ApiKeyAuth) defaultClient.getAuthentication("AuthKey");
AuthKey.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//AuthKey.setApiKeyPrefix("Token");

// Configure API key authorization: RapidApiKey
ApiKeyAuth RapidApiKey = (ApiKeyAuth) defaultClient.getAuthentication("RapidApiKey");
RapidApiKey.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//RapidApiKey.setApiKeyPrefix("Token");

// Configure API key authorization: RapidApiSecret
ApiKeyAuth RapidApiSecret = (ApiKeyAuth) defaultClient.getAuthentication("RapidApiSecret");
RapidApiSecret.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//RapidApiSecret.setApiKeyPrefix("Token");

EmailValidationApi apiInstance = new EmailValidationApi();
String email = "email_example"; // String | 
ResultType resultType = new ResultType(); // ResultType | ResultTypeDescription
try {
    EmailResponse result = apiInstance.emailValidationSingleValidationGet(email, resultType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EmailValidationApi#emailValidationSingleValidationGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **String**|  |
 **resultType** | [**ResultType**](.md)| ResultTypeDescription | [optional]

### Return type

[**EmailResponse**](EmailResponse.md)

### Authorization

[AuthKey](../README.md#AuthKey)[RapidApiKey](../README.md#RapidApiKey)[RapidApiSecret](../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="emailValidationSingleValidationPost"></a>
# **emailValidationSingleValidationPost**
> EmailResponse emailValidationSingleValidationPost(body)



### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EmailValidationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: AuthKey
ApiKeyAuth AuthKey = (ApiKeyAuth) defaultClient.getAuthentication("AuthKey");
AuthKey.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//AuthKey.setApiKeyPrefix("Token");

// Configure API key authorization: RapidApiKey
ApiKeyAuth RapidApiKey = (ApiKeyAuth) defaultClient.getAuthentication("RapidApiKey");
RapidApiKey.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//RapidApiKey.setApiKeyPrefix("Token");

// Configure API key authorization: RapidApiSecret
ApiKeyAuth RapidApiSecret = (ApiKeyAuth) defaultClient.getAuthentication("RapidApiSecret");
RapidApiSecret.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//RapidApiSecret.setApiKeyPrefix("Token");

EmailValidationApi apiInstance = new EmailValidationApi();
EmailRequest body = new EmailRequest(); // EmailRequest | 
try {
    EmailResponse result = apiInstance.emailValidationSingleValidationPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EmailValidationApi#emailValidationSingleValidationPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailRequest**](EmailRequest.md)|  |

### Return type

[**EmailResponse**](EmailResponse.md)

### Authorization

[AuthKey](../README.md#AuthKey)[RapidApiKey](../README.md#RapidApiKey)[RapidApiSecret](../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

