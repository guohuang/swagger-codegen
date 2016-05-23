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
    public interface IPetApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        void AddPet (Pet body);

        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddPetWithHttpInfo (Pet body);
        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns></returns>
        void DeletePet (long? petId, string apiKey = null);

        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePetWithHttpInfo (long? petId, string apiKey = null);
        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>
        /// Multiple status values can be provided with comma separated strings
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>List&lt;Pet&gt;</returns>
        List<Pet> FindPetsByStatus (List<string> status);

        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>
        /// Multiple status values can be provided with comma separated strings
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>ApiResponse of List&lt;Pet&gt;</returns>
        ApiResponse<List<Pet>> FindPetsByStatusWithHttpInfo (List<string> status);
        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>
        /// Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>List&lt;Pet&gt;</returns>
        List<Pet> FindPetsByTags (List<string> tags);

        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>
        /// Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>ApiResponse of List&lt;Pet&gt;</returns>
        ApiResponse<List<Pet>> FindPetsByTagsWithHttpInfo (List<string> tags);
        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>
        /// Returns a single pet
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>Pet</returns>
        Pet GetPetById (long? petId);

        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>
        /// Returns a single pet
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>ApiResponse of Pet</returns>
        ApiResponse<Pet> GetPetByIdWithHttpInfo (long? petId);
        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        void UpdatePet (Pet body);

        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdatePetWithHttpInfo (Pet body);
        /// <summary>
        /// Updates a pet in the store with form data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns></returns>
        void UpdatePetWithForm (long? petId, string name = null, string status = null);

        /// <summary>
        /// Updates a pet in the store with form data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdatePetWithFormWithHttpInfo (long? petId, string name = null, string status = null);
        /// <summary>
        /// uploads an image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>ApiResponse</returns>
        ApiResponse UploadFile (long? petId, string additionalMetadata = null, System.IO.Stream file = null);

        /// <summary>
        /// uploads an image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> UploadFileWithHttpInfo (long? petId, string additionalMetadata = null, System.IO.Stream file = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddPetAsync (Pet body);

        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddPetAsyncWithHttpInfo (Pet body);
        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePetAsync (long? petId, string apiKey = null);

        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePetAsyncWithHttpInfo (long? petId, string apiKey = null);
        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>
        /// Multiple status values can be provided with comma separated strings
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Task of List&lt;Pet&gt;</returns>
        System.Threading.Tasks.Task<List<Pet>> FindPetsByStatusAsync (List<string> status);

        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>
        /// Multiple status values can be provided with comma separated strings
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Task of ApiResponse (List&lt;Pet&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Pet>>> FindPetsByStatusAsyncWithHttpInfo (List<string> status);
        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>
        /// Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>Task of List&lt;Pet&gt;</returns>
        System.Threading.Tasks.Task<List<Pet>> FindPetsByTagsAsync (List<string> tags);

        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>
        /// Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>Task of ApiResponse (List&lt;Pet&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Pet>>> FindPetsByTagsAsyncWithHttpInfo (List<string> tags);
        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>
        /// Returns a single pet
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>Task of Pet</returns>
        System.Threading.Tasks.Task<Pet> GetPetByIdAsync (long? petId);

        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>
        /// Returns a single pet
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>Task of ApiResponse (Pet)</returns>
        System.Threading.Tasks.Task<ApiResponse<Pet>> GetPetByIdAsyncWithHttpInfo (long? petId);
        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdatePetAsync (Pet body);

        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePetAsyncWithHttpInfo (Pet body);
        /// <summary>
        /// Updates a pet in the store with form data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdatePetWithFormAsync (long? petId, string name = null, string status = null);

        /// <summary>
        /// Updates a pet in the store with form data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePetWithFormAsyncWithHttpInfo (long? petId, string name = null, string status = null);
        /// <summary>
        /// uploads an image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> UploadFileAsync (long? petId, string additionalMetadata = null, System.IO.Stream file = null);

        /// <summary>
        /// uploads an image
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> UploadFileAsyncWithHttpInfo (long? petId, string additionalMetadata = null, System.IO.Stream file = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PetApi : IPetApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PetApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PetApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Add a new pet to the store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        public void AddPet (Pet body)
        {
             AddPetWithHttpInfo(body);
        }

        /// <summary>
        /// Add a new pet to the store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddPetWithHttpInfo (Pet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PetApi->AddPet");


            var localVarPath = "/pet";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddPet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add a new pet to the store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddPetAsync (Pet body)
        {
             await AddPetAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Add a new pet to the store 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddPetAsyncWithHttpInfo (Pet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PetApi->AddPet");

            var localVarPath = "/pet";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddPet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Deletes a pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns></returns>
        public void DeletePet (long? petId, string apiKey = null)
        {
             DeletePetWithHttpInfo(petId, apiKey);
        }

        /// <summary>
        /// Deletes a pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePetWithHttpInfo (long? petId, string apiKey = null)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->DeletePet");



            var localVarPath = "/pet/{petId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", Configuration.ApiClient.ParameterToString(apiKey)); // header parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletePet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Deletes a pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePetAsync (long? petId, string apiKey = null)
        {
             await DeletePetAsyncWithHttpInfo(petId, apiKey);

        }

        /// <summary>
        /// Deletes a pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePetAsyncWithHttpInfo (long? petId, string apiKey = null)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->DeletePet");

            var localVarPath = "/pet/{petId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter
            if (apiKey != null) localVarHeaderParams.Add("api_key", Configuration.ApiClient.ParameterToString(apiKey)); // header parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletePet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Finds Pets by status Multiple status values can be provided with comma separated strings
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>List&lt;Pet&gt;</returns>
        public List<Pet> FindPetsByStatus (List<string> status)
        {
             ApiResponse<List<Pet>> localVarResponse = FindPetsByStatusWithHttpInfo(status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finds Pets by status Multiple status values can be provided with comma separated strings
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>ApiResponse of List&lt;Pet&gt;</returns>
        public ApiResponse< List<Pet> > FindPetsByStatusWithHttpInfo (List<string> status)
        {
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling PetApi->FindPetsByStatus");


            var localVarPath = "/pet/findByStatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Pet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pet>)));
            
        }

        /// <summary>
        /// Finds Pets by status Multiple status values can be provided with comma separated strings
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Task of List&lt;Pet&gt;</returns>
        public async System.Threading.Tasks.Task<List<Pet>> FindPetsByStatusAsync (List<string> status)
        {
             ApiResponse<List<Pet>> localVarResponse = await FindPetsByStatusAsyncWithHttpInfo(status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Finds Pets by status Multiple status values can be provided with comma separated strings
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <returns>Task of ApiResponse (List&lt;Pet&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Pet>>> FindPetsByStatusAsyncWithHttpInfo (List<string> status)
        {
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling PetApi->FindPetsByStatus");

            var localVarPath = "/pet/findByStatus";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Pet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pet>)));
            
        }

        /// <summary>
        /// Finds Pets by tags Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>List&lt;Pet&gt;</returns>
        public List<Pet> FindPetsByTags (List<string> tags)
        {
             ApiResponse<List<Pet>> localVarResponse = FindPetsByTagsWithHttpInfo(tags);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finds Pets by tags Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>ApiResponse of List&lt;Pet&gt;</returns>
        public ApiResponse< List<Pet> > FindPetsByTagsWithHttpInfo (List<string> tags)
        {
            // verify the required parameter 'tags' is set
            if (tags == null)
                throw new ApiException(400, "Missing required parameter 'tags' when calling PetApi->FindPetsByTags");


            var localVarPath = "/pet/findByTags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Pet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pet>)));
            
        }

        /// <summary>
        /// Finds Pets by tags Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>Task of List&lt;Pet&gt;</returns>
        public async System.Threading.Tasks.Task<List<Pet>> FindPetsByTagsAsync (List<string> tags)
        {
             ApiResponse<List<Pet>> localVarResponse = await FindPetsByTagsAsyncWithHttpInfo(tags);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Finds Pets by tags Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tags">Tags to filter by</param>
        /// <returns>Task of ApiResponse (List&lt;Pet&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Pet>>> FindPetsByTagsAsyncWithHttpInfo (List<string> tags)
        {
            // verify the required parameter 'tags' is set
            if (tags == null)
                throw new ApiException(400, "Missing required parameter 'tags' when calling PetApi->FindPetsByTags");

            var localVarPath = "/pet/findByTags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (tags != null) localVarQueryParams.Add("tags", Configuration.ApiClient.ParameterToString(tags)); // query parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling FindPetsByTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Pet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Pet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Pet>)));
            
        }

        /// <summary>
        /// Find pet by ID Returns a single pet
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>Pet</returns>
        public Pet GetPetById (long? petId)
        {
             ApiResponse<Pet> localVarResponse = GetPetByIdWithHttpInfo(petId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find pet by ID Returns a single pet
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>ApiResponse of Pet</returns>
        public ApiResponse< Pet > GetPetByIdWithHttpInfo (long? petId)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->GetPetById");


            var localVarPath = "/pet/{petId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Pet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pet)));
            
        }

        /// <summary>
        /// Find pet by ID Returns a single pet
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>Task of Pet</returns>
        public async System.Threading.Tasks.Task<Pet> GetPetByIdAsync (long? petId)
        {
             ApiResponse<Pet> localVarResponse = await GetPetByIdAsyncWithHttpInfo(petId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find pet by ID Returns a single pet
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to return</param>
        /// <returns>Task of ApiResponse (Pet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Pet>> GetPetByIdAsyncWithHttpInfo (long? petId)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->GetPetById");

            var localVarPath = "/pet/{petId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarHeaderParams["api_key"] = Configuration.GetApiKeyWithPrefix("api_key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Pet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Pet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Pet)));
            
        }

        /// <summary>
        /// Update an existing pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns></returns>
        public void UpdatePet (Pet body)
        {
             UpdatePetWithHttpInfo(body);
        }

        /// <summary>
        /// Update an existing pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdatePetWithHttpInfo (Pet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PetApi->UpdatePet");


            var localVarPath = "/pet";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update an existing pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdatePetAsync (Pet body)
        {
             await UpdatePetAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an existing pet 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePetAsyncWithHttpInfo (Pet body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PetApi->UpdatePet");

            var localVarPath = "/pet";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Updates a pet in the store with form data 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns></returns>
        public void UpdatePetWithForm (long? petId, string name = null, string status = null)
        {
             UpdatePetWithFormWithHttpInfo(petId, name, status);
        }

        /// <summary>
        /// Updates a pet in the store with form data 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdatePetWithFormWithHttpInfo (long? petId, string name = null, string status = null)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->UpdatePetWithForm");




            var localVarPath = "/pet/{petId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (status != null) localVarFormParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // form parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePetWithForm: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePetWithForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Updates a pet in the store with form data 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdatePetWithFormAsync (long? petId, string name = null, string status = null)
        {
             await UpdatePetWithFormAsyncWithHttpInfo(petId, name, status);

        }

        /// <summary>
        /// Updates a pet in the store with form data 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet that needs to be updated</param>
        /// <param name="name">Updated name of the pet (optional)</param>
        /// <param name="status">Updated status of the pet (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePetWithFormAsyncWithHttpInfo (long? petId, string name = null, string status = null)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->UpdatePetWithForm");

            var localVarPath = "/pet/{petId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter
            if (name != null) localVarFormParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // form parameter
            if (status != null) localVarFormParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // form parameter

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePetWithForm: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePetWithForm: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// uploads an image 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>ApiResponse</returns>
        public ApiResponse UploadFile (long? petId, string additionalMetadata = null, System.IO.Stream file = null)
        {
             ApiResponse<ApiResponse> localVarResponse = UploadFileWithHttpInfo(petId, additionalMetadata, file);
             return localVarResponse.Data;
        }

        /// <summary>
        /// uploads an image 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > UploadFileWithHttpInfo (long? petId, string additionalMetadata = null, System.IO.Stream file = null)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->UploadFile");




            var localVarPath = "/pet/{petId}/uploadImage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter
            if (additionalMetadata != null) localVarFormParams.Add("additionalMetadata", Configuration.ApiClient.ParameterToString(additionalMetadata)); // form parameter
            if (file != null) localVarFileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UploadFile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UploadFile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
            
        }

        /// <summary>
        /// uploads an image 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> UploadFileAsync (long? petId, string additionalMetadata = null, System.IO.Stream file = null)
        {
             ApiResponse<ApiResponse> localVarResponse = await UploadFileAsyncWithHttpInfo(petId, additionalMetadata, file);
             return localVarResponse.Data;

        }

        /// <summary>
        /// uploads an image 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="additionalMetadata">Additional data to pass to server (optional)</param>
        /// <param name="file">file to upload (optional)</param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> UploadFileAsyncWithHttpInfo (long? petId, string additionalMetadata = null, System.IO.Stream file = null)
        {
            // verify the required parameter 'petId' is set
            if (petId == null)
                throw new ApiException(400, "Missing required parameter 'petId' when calling PetApi->UploadFile");

            var localVarPath = "/pet/{petId}/uploadImage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (petId != null) localVarPathParams.Add("petId", Configuration.ApiClient.ParameterToString(petId)); // path parameter
            if (additionalMetadata != null) localVarFormParams.Add("additionalMetadata", Configuration.ApiClient.ParameterToString(additionalMetadata)); // form parameter
            if (file != null) localVarFileParams.Add("file", Configuration.ApiClient.ParameterToFile("file", file));

            // authentication (petstore_auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UploadFile: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UploadFile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
            
        }

    }
}
