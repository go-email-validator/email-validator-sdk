# swagger_client.EmailValidationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**email_validation_single_validation_get**](EmailValidationApi.md#email_validation_single_validation_get) | **GET** /v1/validation/single/{email} | 
[**email_validation_single_validation_post**](EmailValidationApi.md#email_validation_single_validation_post) | **POST** /v1/validation/single | 

# **email_validation_single_validation_get**
> EmailResponse email_validation_single_validation_get(email, result_type=result_type)



POST request contains additional parameters for detailed configuration

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: AuthKey
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'
# Configure API key authorization: RapidApiKey
configuration = swagger_client.Configuration()
configuration.api_key['X-RapidAPI-Key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['X-RapidAPI-Key'] = 'Bearer'
# Configure API key authorization: RapidApiSecret
configuration = swagger_client.Configuration()
configuration.api_key['X-RapidAPI-Proxy-Secret'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['X-RapidAPI-Proxy-Secret'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.EmailValidationApi(swagger_client.ApiClient(configuration))
email = 'email_example' # str | 
result_type = swagger_client.ResultType() # ResultType | ResultTypeDescription (optional)

try:
    api_response = api_instance.email_validation_single_validation_get(email, result_type=result_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailValidationApi->email_validation_single_validation_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **str**|  | 
 **result_type** | [**ResultType**](.md)| ResultTypeDescription | [optional] 

### Return type

[**EmailResponse**](EmailResponse.md)

### Authorization

[AuthKey](../README.md#AuthKey), [RapidApiKey](../README.md#RapidApiKey), [RapidApiSecret](../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **email_validation_single_validation_post**
> EmailResponse email_validation_single_validation_post(body)



### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: AuthKey
configuration = swagger_client.Configuration()
configuration.api_key['Authorization'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['Authorization'] = 'Bearer'
# Configure API key authorization: RapidApiKey
configuration = swagger_client.Configuration()
configuration.api_key['X-RapidAPI-Key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['X-RapidAPI-Key'] = 'Bearer'
# Configure API key authorization: RapidApiSecret
configuration = swagger_client.Configuration()
configuration.api_key['X-RapidAPI-Proxy-Secret'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['X-RapidAPI-Proxy-Secret'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.EmailValidationApi(swagger_client.ApiClient(configuration))
body = swagger_client.EmailRequest() # EmailRequest | 

try:
    api_response = api_instance.email_validation_single_validation_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailValidationApi->email_validation_single_validation_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailRequest**](EmailRequest.md)|  | 

### Return type

[**EmailResponse**](EmailResponse.md)

### Authorization

[AuthKey](../README.md#AuthKey), [RapidApiKey](../README.md#RapidApiKey), [RapidApiSecret](../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

