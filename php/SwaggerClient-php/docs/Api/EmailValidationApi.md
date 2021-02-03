# Swagger\Client\EmailValidationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**emailValidationSingleValidationGet**](EmailValidationApi.md#emailvalidationsinglevalidationget) | **GET** /v1/validation/single/{email} | 
[**emailValidationSingleValidationPost**](EmailValidationApi.md#emailvalidationsinglevalidationpost) | **POST** /v1/validation/single | 

# **emailValidationSingleValidationGet**
> \Swagger\Client\Model\EmailResponse emailValidationSingleValidationGet($email, $result_type)



POST request contains additional parameters for detailed configuration

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: AuthKey
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');// Configure API key authorization: RapidApiKey
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-RapidAPI-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-RapidAPI-Key', 'Bearer');// Configure API key authorization: RapidApiSecret
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-RapidAPI-Proxy-Secret', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-RapidAPI-Proxy-Secret', 'Bearer');

$apiInstance = new Swagger\Client\Api\EmailValidationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$email = "email_example"; // string | 
$result_type = new \Swagger\Client\Model\ResultType(); // \Swagger\Client\Model\ResultType | ResultTypeDescription

try {
    $result = $apiInstance->emailValidationSingleValidationGet($email, $result_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EmailValidationApi->emailValidationSingleValidationGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  |
 **result_type** | [**\Swagger\Client\Model\ResultType**](../Model/.md)| ResultTypeDescription | [optional]

### Return type

[**\Swagger\Client\Model\EmailResponse**](../Model/EmailResponse.md)

### Authorization

[AuthKey](../../README.md#AuthKey), [RapidApiKey](../../README.md#RapidApiKey), [RapidApiSecret](../../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **emailValidationSingleValidationPost**
> \Swagger\Client\Model\EmailResponse emailValidationSingleValidationPost($body)



### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: AuthKey
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('Authorization', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('Authorization', 'Bearer');// Configure API key authorization: RapidApiKey
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-RapidAPI-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-RapidAPI-Key', 'Bearer');// Configure API key authorization: RapidApiSecret
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('X-RapidAPI-Proxy-Secret', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-RapidAPI-Proxy-Secret', 'Bearer');

$apiInstance = new Swagger\Client\Api\EmailValidationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\EmailRequest(); // \Swagger\Client\Model\EmailRequest | 

try {
    $result = $apiInstance->emailValidationSingleValidationPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EmailValidationApi->emailValidationSingleValidationPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\EmailRequest**](../Model/EmailRequest.md)|  |

### Return type

[**\Swagger\Client\Model\EmailResponse**](../Model/EmailResponse.md)

### Authorization

[AuthKey](../../README.md#AuthKey), [RapidApiKey](../../README.md#RapidApiKey), [RapidApiSecret](../../README.md#RapidApiSecret)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

