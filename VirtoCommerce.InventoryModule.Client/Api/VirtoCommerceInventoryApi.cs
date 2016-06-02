using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using VirtoCommerce.InventoryModule.Client.Client;
using VirtoCommerce.InventoryModule.Client.Model;

namespace VirtoCommerce.InventoryModule.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVirtoCommerceInventoryApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get inventories of product
        /// </summary>
        /// <remarks>
        /// Get inventories of product for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>List&lt;InventoryInfo&gt;</returns>
        List<InventoryInfo> InventoryModuleGetProductInventories(string productId);

        /// <summary>
        /// Get inventories of product
        /// </summary>
        /// <remarks>
        /// Get inventories of product for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>ApiResponse of List&lt;InventoryInfo&gt;</returns>
        ApiResponse<List<InventoryInfo>> InventoryModuleGetProductInventoriesWithHttpInfo(string productId);
        /// <summary>
        /// Get inventories of products
        /// </summary>
        /// <remarks>
        /// Get inventory of products for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>List&lt;InventoryInfo&gt;</returns>
        List<InventoryInfo> InventoryModuleGetProductsInventories(List<string> ids);

        /// <summary>
        /// Get inventories of products
        /// </summary>
        /// <remarks>
        /// Get inventory of products for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>ApiResponse of List&lt;InventoryInfo&gt;</returns>
        ApiResponse<List<InventoryInfo>> InventoryModuleGetProductsInventoriesWithHttpInfo(List<string> ids);
        /// <summary>
        /// Upsert inventory
        /// </summary>
        /// <remarks>
        /// Upsert (add or update) given inventory of product.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>InventoryInfo</returns>
        InventoryInfo InventoryModuleUpsertProductInventory(InventoryInfo inventory, string productId);

        /// <summary>
        /// Upsert inventory
        /// </summary>
        /// <remarks>
        /// Upsert (add or update) given inventory of product.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>ApiResponse of InventoryInfo</returns>
        ApiResponse<InventoryInfo> InventoryModuleUpsertProductInventoryWithHttpInfo(InventoryInfo inventory, string productId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get inventories of product
        /// </summary>
        /// <remarks>
        /// Get inventories of product for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>Task of List&lt;InventoryInfo&gt;</returns>
        System.Threading.Tasks.Task<List<InventoryInfo>> InventoryModuleGetProductInventoriesAsync(string productId);

        /// <summary>
        /// Get inventories of product
        /// </summary>
        /// <remarks>
        /// Get inventories of product for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InventoryInfo>>> InventoryModuleGetProductInventoriesAsyncWithHttpInfo(string productId);
        /// <summary>
        /// Get inventories of products
        /// </summary>
        /// <remarks>
        /// Get inventory of products for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>Task of List&lt;InventoryInfo&gt;</returns>
        System.Threading.Tasks.Task<List<InventoryInfo>> InventoryModuleGetProductsInventoriesAsync(List<string> ids);

        /// <summary>
        /// Get inventories of products
        /// </summary>
        /// <remarks>
        /// Get inventory of products for each fulfillment center.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InventoryInfo>>> InventoryModuleGetProductsInventoriesAsyncWithHttpInfo(List<string> ids);
        /// <summary>
        /// Upsert inventory
        /// </summary>
        /// <remarks>
        /// Upsert (add or update) given inventory of product.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>Task of InventoryInfo</returns>
        System.Threading.Tasks.Task<InventoryInfo> InventoryModuleUpsertProductInventoryAsync(InventoryInfo inventory, string productId);

        /// <summary>
        /// Upsert inventory
        /// </summary>
        /// <remarks>
        /// Upsert (add or update) given inventory of product.
        /// </remarks>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>Task of ApiResponse (InventoryInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventoryInfo>> InventoryModuleUpsertProductInventoryAsyncWithHttpInfo(InventoryInfo inventory, string productId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VirtoCommerceInventoryApi : IVirtoCommerceInventoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtoCommerceInventoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="apiClient">An instance of ApiClient.</param>
        /// <returns></returns>
        public VirtoCommerceInventoryApi(ApiClient apiClient)
        {
            ApiClient = apiClient;
            Configuration = apiClient.Configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the API client object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Get inventories of product Get inventories of product for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>List&lt;InventoryInfo&gt;</returns>
        public List<InventoryInfo> InventoryModuleGetProductInventories(string productId)
        {
             ApiResponse<List<InventoryInfo>> localVarResponse = InventoryModuleGetProductInventoriesWithHttpInfo(productId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get inventories of product Get inventories of product for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>ApiResponse of List&lt;InventoryInfo&gt;</returns>
        public ApiResponse<List<InventoryInfo>> InventoryModuleGetProductInventoriesWithHttpInfo(string productId)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling VirtoCommerceInventoryApi->InventoryModuleGetProductInventories");

            var localVarPath = "/api/inventory/products/{productId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (productId != null) localVarPathParams.Add("productId", ApiClient.ParameterToString(productId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400 && (localVarStatusCode != 404 || Configuration.ThrowExceptionWhenStatusCodeIs404))
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductInventories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductInventories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventoryInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryInfo>)ApiClient.Deserialize(localVarResponse, typeof(List<InventoryInfo>)));
            
        }

        /// <summary>
        /// Get inventories of product Get inventories of product for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>Task of List&lt;InventoryInfo&gt;</returns>
        public async System.Threading.Tasks.Task<List<InventoryInfo>> InventoryModuleGetProductInventoriesAsync(string productId)
        {
             ApiResponse<List<InventoryInfo>> localVarResponse = await InventoryModuleGetProductInventoriesAsyncWithHttpInfo(productId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get inventories of product Get inventories of product for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">Product id</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InventoryInfo>>> InventoryModuleGetProductInventoriesAsyncWithHttpInfo(string productId)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling VirtoCommerceInventoryApi->InventoryModuleGetProductInventories");

            var localVarPath = "/api/inventory/products/{productId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (productId != null) localVarPathParams.Add("productId", ApiClient.ParameterToString(productId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400 && (localVarStatusCode != 404 || Configuration.ThrowExceptionWhenStatusCodeIs404))
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductInventories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductInventories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventoryInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryInfo>)ApiClient.Deserialize(localVarResponse, typeof(List<InventoryInfo>)));
            
        }
        /// <summary>
        /// Get inventories of products Get inventory of products for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>List&lt;InventoryInfo&gt;</returns>
        public List<InventoryInfo> InventoryModuleGetProductsInventories(List<string> ids)
        {
             ApiResponse<List<InventoryInfo>> localVarResponse = InventoryModuleGetProductsInventoriesWithHttpInfo(ids);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get inventories of products Get inventory of products for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>ApiResponse of List&lt;InventoryInfo&gt;</returns>
        public ApiResponse<List<InventoryInfo>> InventoryModuleGetProductsInventoriesWithHttpInfo(List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling VirtoCommerceInventoryApi->InventoryModuleGetProductsInventories");

            var localVarPath = "/api/inventory/products";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ids != null) localVarQueryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400 && (localVarStatusCode != 404 || Configuration.ThrowExceptionWhenStatusCodeIs404))
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductsInventories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductsInventories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventoryInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryInfo>)ApiClient.Deserialize(localVarResponse, typeof(List<InventoryInfo>)));
            
        }

        /// <summary>
        /// Get inventories of products Get inventory of products for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>Task of List&lt;InventoryInfo&gt;</returns>
        public async System.Threading.Tasks.Task<List<InventoryInfo>> InventoryModuleGetProductsInventoriesAsync(List<string> ids)
        {
             ApiResponse<List<InventoryInfo>> localVarResponse = await InventoryModuleGetProductsInventoriesAsyncWithHttpInfo(ids);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get inventories of products Get inventory of products for each fulfillment center.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Products ids</param>
        /// <returns>Task of ApiResponse (List&lt;InventoryInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InventoryInfo>>> InventoryModuleGetProductsInventoriesAsyncWithHttpInfo(List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling VirtoCommerceInventoryApi->InventoryModuleGetProductsInventories");

            var localVarPath = "/api/inventory/products";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ids != null) localVarQueryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400 && (localVarStatusCode != 404 || Configuration.ThrowExceptionWhenStatusCodeIs404))
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductsInventories: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleGetProductsInventories: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventoryInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventoryInfo>)ApiClient.Deserialize(localVarResponse, typeof(List<InventoryInfo>)));
            
        }
        /// <summary>
        /// Upsert inventory Upsert (add or update) given inventory of product.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>InventoryInfo</returns>
        public InventoryInfo InventoryModuleUpsertProductInventory(InventoryInfo inventory, string productId)
        {
             ApiResponse<InventoryInfo> localVarResponse = InventoryModuleUpsertProductInventoryWithHttpInfo(inventory, productId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert inventory Upsert (add or update) given inventory of product.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>ApiResponse of InventoryInfo</returns>
        public ApiResponse<InventoryInfo> InventoryModuleUpsertProductInventoryWithHttpInfo(InventoryInfo inventory, string productId)
        {
            // verify the required parameter 'inventory' is set
            if (inventory == null)
                throw new ApiException(400, "Missing required parameter 'inventory' when calling VirtoCommerceInventoryApi->InventoryModuleUpsertProductInventory");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling VirtoCommerceInventoryApi->InventoryModuleUpsertProductInventory");

            var localVarPath = "/api/inventory/products/{productId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (productId != null) localVarPathParams.Add("productId", ApiClient.ParameterToString(productId)); // path parameter
            if (inventory.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(inventory); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inventory; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400 && (localVarStatusCode != 404 || Configuration.ThrowExceptionWhenStatusCodeIs404))
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleUpsertProductInventory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleUpsertProductInventory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryInfo)ApiClient.Deserialize(localVarResponse, typeof(InventoryInfo)));
            
        }

        /// <summary>
        /// Upsert inventory Upsert (add or update) given inventory of product.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>Task of InventoryInfo</returns>
        public async System.Threading.Tasks.Task<InventoryInfo> InventoryModuleUpsertProductInventoryAsync(InventoryInfo inventory, string productId)
        {
             ApiResponse<InventoryInfo> localVarResponse = await InventoryModuleUpsertProductInventoryAsyncWithHttpInfo(inventory, productId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert inventory Upsert (add or update) given inventory of product.
        /// </summary>
        /// <exception cref="VirtoCommerce.InventoryModule.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventory">Inventory to upsert</param>
        /// <param name="productId"></param>
        /// <returns>Task of ApiResponse (InventoryInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventoryInfo>> InventoryModuleUpsertProductInventoryAsyncWithHttpInfo(InventoryInfo inventory, string productId)
        {
            // verify the required parameter 'inventory' is set
            if (inventory == null)
                throw new ApiException(400, "Missing required parameter 'inventory' when calling VirtoCommerceInventoryApi->InventoryModuleUpsertProductInventory");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling VirtoCommerceInventoryApi->InventoryModuleUpsertProductInventory");

            var localVarPath = "/api/inventory/products/{productId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            string localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            string localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (productId != null) localVarPathParams.Add("productId", ApiClient.ParameterToString(productId)); // path parameter
            if (inventory.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(inventory); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inventory; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400 && (localVarStatusCode != 404 || Configuration.ThrowExceptionWhenStatusCodeIs404))
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleUpsertProductInventory: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling InventoryModuleUpsertProductInventory: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventoryInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventoryInfo)ApiClient.Deserialize(localVarResponse, typeof(InventoryInfo)));
            
        }
    }
}
