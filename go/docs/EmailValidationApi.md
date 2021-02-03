# {{classname}}

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmailValidationSingleValidationGet**](EmailValidationApi.md#EmailValidationSingleValidationGet) | **Get** /v1/validation/single/{email} | 
[**EmailValidationSingleValidationPost**](EmailValidationApi.md#EmailValidationSingleValidationPost) | **Post** /v1/validation/single | 

# **EmailValidationSingleValidationGet**
> EmailResponse EmailValidationSingleValidationGet(ctx, email, optional)


POST request contains additional parameters for detailed configuration

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **email** | **string**|  | 
 **optional** | ***EmailValidationApiEmailValidationSingleValidationGetOpts** | optional parameters | nil if no parameters

### Optional Parameters
Optional parameters are passed through a pointer to a EmailValidationApiEmailValidationSingleValidationGetOpts struct
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **resultType** | [**optional.Interface of ResultType**](.md)| ResultTypeDescription | 

### Return type

[**EmailResponse**](EmailResponse.md)

### Authorization

[AuthKey](../README.md#AuthKey), [RapidApiKey](../README.md#RapidApiKey), [RapidApiSecret](../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **EmailValidationSingleValidationPost**
> EmailResponse EmailValidationSingleValidationPost(ctx, body)


### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**EmailRequest**](EmailRequest.md)|  | 

### Return type

[**EmailResponse**](EmailResponse.md)

### Authorization

[AuthKey](../README.md#AuthKey), [RapidApiKey](../README.md#RapidApiKey), [RapidApiSecret](../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

