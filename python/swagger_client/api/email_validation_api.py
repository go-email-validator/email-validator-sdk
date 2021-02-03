# coding: utf-8

"""
    Email Validator

    All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds.   # noqa: E501

    OpenAPI spec version: 0.0.1
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from swagger_client.api_client import ApiClient


class EmailValidationApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def email_validation_single_validation_get(self, email, **kwargs):  # noqa: E501
        """email_validation_single_validation_get  # noqa: E501

        POST request contains additional parameters for detailed configuration  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.email_validation_single_validation_get(email, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str email: (required)
        :param ResultType result_type: ResultTypeDescription
        :return: EmailResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.email_validation_single_validation_get_with_http_info(email, **kwargs)  # noqa: E501
        else:
            (data) = self.email_validation_single_validation_get_with_http_info(email, **kwargs)  # noqa: E501
            return data

    def email_validation_single_validation_get_with_http_info(self, email, **kwargs):  # noqa: E501
        """email_validation_single_validation_get  # noqa: E501

        POST request contains additional parameters for detailed configuration  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.email_validation_single_validation_get_with_http_info(email, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str email: (required)
        :param ResultType result_type: ResultTypeDescription
        :return: EmailResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['email', 'result_type']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method email_validation_single_validation_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'email' is set
        if ('email' not in params or
                params['email'] is None):
            raise ValueError("Missing the required parameter `email` when calling `email_validation_single_validation_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'email' in params:
            path_params['email'] = params['email']  # noqa: E501

        query_params = []
        if 'result_type' in params:
            query_params.append(('result_type', params['result_type']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['AuthKey', 'RapidApiKey', 'RapidApiSecret']  # noqa: E501

        return self.api_client.call_api(
            '/v1/validation/single/{email}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='EmailResponse',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def email_validation_single_validation_post(self, body, **kwargs):  # noqa: E501
        """email_validation_single_validation_post  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.email_validation_single_validation_post(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param EmailRequest body: (required)
        :return: EmailResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.email_validation_single_validation_post_with_http_info(body, **kwargs)  # noqa: E501
        else:
            (data) = self.email_validation_single_validation_post_with_http_info(body, **kwargs)  # noqa: E501
            return data

    def email_validation_single_validation_post_with_http_info(self, body, **kwargs):  # noqa: E501
        """email_validation_single_validation_post  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.email_validation_single_validation_post_with_http_info(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param EmailRequest body: (required)
        :return: EmailResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method email_validation_single_validation_post" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `email_validation_single_validation_post`")  # noqa: E501

        collection_formats = {}

        path_params = {}

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['AuthKey', 'RapidApiKey', 'RapidApiSecret']  # noqa: E501

        return self.api_client.call_api(
            '/v1/validation/single', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='EmailResponse',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)
