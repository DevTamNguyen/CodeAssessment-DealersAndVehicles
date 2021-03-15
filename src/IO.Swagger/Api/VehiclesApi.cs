/* 
 * DealersAndVehicles
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
    public interface IVehiclesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of all vehicleids in dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>VehicleIdsResponse</returns>
        VehicleIdsResponse GetIds (string datasetId);

        /// <summary>
        /// Get a list of all vehicleids in dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>ApiResponse of VehicleIdsResponse</returns>
        ApiResponse<VehicleIdsResponse> GetIdsWithHttpInfo (string datasetId);
        /// <summary>
        /// Get information about a vehicle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>VehicleResponse</returns>
        VehicleResponse GetVehicle (string datasetId, int? vehicleid);

        /// <summary>
        /// Get information about a vehicle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>ApiResponse of VehicleResponse</returns>
        ApiResponse<VehicleResponse> GetVehicleWithHttpInfo (string datasetId, int? vehicleid);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of all vehicleids in dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of VehicleIdsResponse</returns>
        System.Threading.Tasks.Task<VehicleIdsResponse> GetIdsAsync (string datasetId);

        /// <summary>
        /// Get a list of all vehicleids in dataset
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of ApiResponse (VehicleIdsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VehicleIdsResponse>> GetIdsAsyncWithHttpInfo (string datasetId);
        /// <summary>
        /// Get information about a vehicle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>Task of VehicleResponse</returns>
        System.Threading.Tasks.Task<VehicleResponse> GetVehicleAsync (string datasetId, int? vehicleid);

        /// <summary>
        /// Get information about a vehicle
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>Task of ApiResponse (VehicleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VehicleResponse>> GetVehicleAsyncWithHttpInfo (string datasetId, int? vehicleid);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VehiclesApi : IVehiclesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehiclesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VehiclesApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VehiclesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VehiclesApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// Get a list of all vehicleids in dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>VehicleIdsResponse</returns>
        public VehicleIdsResponse GetIds (string datasetId)
        {
             ApiResponse<VehicleIdsResponse> localVarResponse = GetIdsWithHttpInfo(datasetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of all vehicleids in dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>ApiResponse of VehicleIdsResponse</returns>
        public ApiResponse< VehicleIdsResponse > GetIdsWithHttpInfo (string datasetId)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling VehiclesApi->GetIds");

            var localVarPath = "/api/{datasetId}/vehicles";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", this.Configuration.ApiClient.ParameterToString(datasetId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VehicleIdsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VehicleIdsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VehicleIdsResponse)));
        }

        /// <summary>
        /// Get a list of all vehicleids in dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of VehicleIdsResponse</returns>
        public async System.Threading.Tasks.Task<VehicleIdsResponse> GetIdsAsync (string datasetId)
        {
             ApiResponse<VehicleIdsResponse> localVarResponse = await GetIdsAsyncWithHttpInfo(datasetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of all vehicleids in dataset 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <returns>Task of ApiResponse (VehicleIdsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VehicleIdsResponse>> GetIdsAsyncWithHttpInfo (string datasetId)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling VehiclesApi->GetIds");

            var localVarPath = "/api/{datasetId}/vehicles";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", this.Configuration.ApiClient.ParameterToString(datasetId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetIds", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VehicleIdsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VehicleIdsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VehicleIdsResponse)));
        }

        /// <summary>
        /// Get information about a vehicle 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>VehicleResponse</returns>
        public VehicleResponse GetVehicle (string datasetId, int? vehicleid)
        {
             ApiResponse<VehicleResponse> localVarResponse = GetVehicleWithHttpInfo(datasetId, vehicleid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get information about a vehicle 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>ApiResponse of VehicleResponse</returns>
        public ApiResponse< VehicleResponse > GetVehicleWithHttpInfo (string datasetId, int? vehicleid)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling VehiclesApi->GetVehicle");
            // verify the required parameter 'vehicleid' is set
            if (vehicleid == null)
                throw new ApiException(400, "Missing required parameter 'vehicleid' when calling VehiclesApi->GetVehicle");

            var localVarPath = "/api/{datasetId}/vehicles/{vehicleid}";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", this.Configuration.ApiClient.ParameterToString(datasetId)); // path parameter
            if (vehicleid != null) localVarPathParams.Add("vehicleid", this.Configuration.ApiClient.ParameterToString(vehicleid)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVehicle", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VehicleResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VehicleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VehicleResponse)));
        }

        /// <summary>
        /// Get information about a vehicle 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>Task of VehicleResponse</returns>
        public async System.Threading.Tasks.Task<VehicleResponse> GetVehicleAsync (string datasetId, int? vehicleid)
        {
             ApiResponse<VehicleResponse> localVarResponse = await GetVehicleAsyncWithHttpInfo(datasetId, vehicleid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get information about a vehicle 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasetId"></param>
        /// <param name="vehicleid"></param>
        /// <returns>Task of ApiResponse (VehicleResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VehicleResponse>> GetVehicleAsyncWithHttpInfo (string datasetId, int? vehicleid)
        {
            // verify the required parameter 'datasetId' is set
            if (datasetId == null)
                throw new ApiException(400, "Missing required parameter 'datasetId' when calling VehiclesApi->GetVehicle");
            // verify the required parameter 'vehicleid' is set
            if (vehicleid == null)
                throw new ApiException(400, "Missing required parameter 'vehicleid' when calling VehiclesApi->GetVehicle");

            var localVarPath = "/api/{datasetId}/vehicles/{vehicleid}";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasetId != null) localVarPathParams.Add("datasetId", this.Configuration.ApiClient.ParameterToString(datasetId)); // path parameter
            if (vehicleid != null) localVarPathParams.Add("vehicleid", this.Configuration.ApiClient.ParameterToString(vehicleid)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVehicle", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VehicleResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VehicleResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VehicleResponse)));
        }

    }
}
