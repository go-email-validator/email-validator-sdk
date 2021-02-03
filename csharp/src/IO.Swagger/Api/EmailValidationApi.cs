/* 
 * Email Validator
 *
 * All timeouts are set in seconds with nanosecond precision. For example, 1.505402 is 1 second, 505 milliseconds and 402 microseconds. 
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IEmailValidationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// POST request contains additional parameters for detailed configuration
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>EmailResponse</returns>
        EmailResponse EmailValidationSingleValidationGet (string email, ResultType resultType = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// POST request contains additional parameters for detailed configuration
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>ApiResponse of EmailResponse</returns>
        ApiResponse<EmailResponse> EmailValidationSingleValidationGetWithHttpInfo (string email, ResultType resultType = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>EmailResponse</returns>
        EmailResponse EmailValidationSingleValidationPost (EmailRequest body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmailResponse</returns>
        ApiResponse<EmailResponse> EmailValidationSingleValidationPostWithHttpInfo (EmailRequest body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// POST request contains additional parameters for detailed configuration
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>Task of EmailResponse</returns>
        System.Threading.Tasks.Task<EmailResponse> EmailValidationSingleValidationGetAsync (string email, ResultType resultType = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// POST request contains additional parameters for detailed configuration
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>Task of ApiResponse (EmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailResponse>> EmailValidationSingleValidationGetAsyncWithHttpInfo (string email, ResultType resultType = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of EmailResponse</returns>
        System.Threading.Tasks.Task<EmailResponse> EmailValidationSingleValidationPostAsync (EmailRequest body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EmailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailResponse>> EmailValidationSingleValidationPostAsyncWithHttpInfo (EmailRequest body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class EmailValidationApi : IEmailValidationApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailValidationApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationApi"/> class
        /// </summary>
        /// <returns></returns>
        public EmailValidationApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailValidationApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  POST request contains additional parameters for detailed configuration
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>EmailResponse</returns>
        public EmailResponse EmailValidationSingleValidationGet (string email, ResultType resultType = null)
        {
             ApiResponse<EmailResponse> localVarResponse = EmailValidationSingleValidationGetWithHttpInfo(email, resultType);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  POST request contains additional parameters for detailed configuration
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>ApiResponse of EmailResponse</returns>
        public ApiResponse< EmailResponse > EmailValidationSingleValidationGetWithHttpInfo (string email, ResultType resultType = null)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling EmailValidationApi->EmailValidationSingleValidationGet");

            var localVarPath = "/v1/validation/single/{email}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (email != null) localVarPathParams.Add("email", this.Configuration.ApiClient.ParameterToString(email)); // path parameter
            if (resultType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "result_type", resultType)); // query parameter
            // authentication (AuthKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }
            // authentication (RapidApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key")))
            {
                localVarHeaderParams["X-RapidAPI-Key"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key");
            }
            // authentication (RapidApiSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret")))
            {
                localVarHeaderParams["X-RapidAPI-Proxy-Secret"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EmailValidationSingleValidationGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailResponse)));
        }

        /// <summary>
        ///  POST request contains additional parameters for detailed configuration
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>Task of EmailResponse</returns>
        public async System.Threading.Tasks.Task<EmailResponse> EmailValidationSingleValidationGetAsync (string email, ResultType resultType = null)
        {
             ApiResponse<EmailResponse> localVarResponse = await EmailValidationSingleValidationGetAsyncWithHttpInfo(email, resultType);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  POST request contains additional parameters for detailed configuration
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email"></param>
        /// <param name="resultType">ResultTypeDescription (optional)</param>
        /// <returns>Task of ApiResponse (EmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailResponse>> EmailValidationSingleValidationGetAsyncWithHttpInfo (string email, ResultType resultType = null)
        {
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling EmailValidationApi->EmailValidationSingleValidationGet");

            var localVarPath = "/v1/validation/single/{email}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (email != null) localVarPathParams.Add("email", this.Configuration.ApiClient.ParameterToString(email)); // path parameter
            if (resultType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "result_type", resultType)); // query parameter
            // authentication (AuthKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }
            // authentication (RapidApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key")))
            {
                localVarHeaderParams["X-RapidAPI-Key"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key");
            }
            // authentication (RapidApiSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret")))
            {
                localVarHeaderParams["X-RapidAPI-Proxy-Secret"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EmailValidationSingleValidationGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>EmailResponse</returns>
        public EmailResponse EmailValidationSingleValidationPost (EmailRequest body)
        {
             ApiResponse<EmailResponse> localVarResponse = EmailValidationSingleValidationPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of EmailResponse</returns>
        public ApiResponse< EmailResponse > EmailValidationSingleValidationPostWithHttpInfo (EmailRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmailValidationApi->EmailValidationSingleValidationPost");

            var localVarPath = "/v1/validation/single";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (AuthKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }
            // authentication (RapidApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key")))
            {
                localVarHeaderParams["X-RapidAPI-Key"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key");
            }
            // authentication (RapidApiSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret")))
            {
                localVarHeaderParams["X-RapidAPI-Proxy-Secret"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EmailValidationSingleValidationPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of EmailResponse</returns>
        public async System.Threading.Tasks.Task<EmailResponse> EmailValidationSingleValidationPostAsync (EmailRequest body)
        {
             ApiResponse<EmailResponse> localVarResponse = await EmailValidationSingleValidationPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (EmailResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailResponse>> EmailValidationSingleValidationPostAsyncWithHttpInfo (EmailRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmailValidationApi->EmailValidationSingleValidationPost");

            var localVarPath = "/v1/validation/single";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (AuthKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }
            // authentication (RapidApiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key")))
            {
                localVarHeaderParams["X-RapidAPI-Key"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Key");
            }
            // authentication (RapidApiSecret) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret")))
            {
                localVarHeaderParams["X-RapidAPI-Proxy-Secret"] = this.Configuration.GetApiKeyWithPrefix("X-RapidAPI-Proxy-Secret");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EmailValidationSingleValidationPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EmailResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EmailResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailResponse)));
        }

    }
}