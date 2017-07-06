﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 07/06/2017 15:31:17
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Shoppingcontent v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages product items, inventory, and Merchant Center accounts for Google Shopping.
// API Documentation Link https://developers.google.com/shopping-content
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Shoppingcontent/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Shoppingcontent.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Shoppingcontent.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Shoppingcontent.v2;
using Google.Apis.Shoppingcontent.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Shoppingcontentv2.Methods
{
  
    public static class DatafeedsSample
    {

        public class DatafeedsCustombatchOptionalParms
        {
            /// Flag to run the request in dry-run mode.
            public bool? DryRun { get; set; }  
        
        }
 
        /// <summary>
        /// NA 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeeds/custombatch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DatafeedsCustomBatchResponseResponse</returns>
        public static DatafeedsCustomBatchResponse Custombatch(ShoppingcontentService service, DatafeedsCustomBatchRequest body, DatafeedsCustombatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Datafeeds.Custombatch(body);

                // Applying optional parameters to the request.                
                request = (DatafeedsResource.CustombatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeeds.Custombatch failed.", ex);
            }
        }
        public class DatafeedsDeleteOptionalParms
        {
            /// Flag to run the request in dry-run mode.
            public bool? DryRun { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a datafeed configuration from your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeeds/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">NA</param>
        /// <param name="datafeedId">NA</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(ShoppingcontentService service, string merchantId, string datafeedId, DatafeedsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (datafeedId == null)
                    throw new ArgumentNullException(datafeedId);

                // Building the initial request.
                var request = service.Datafeeds.Delete(merchantId, datafeedId);

                // Applying optional parameters to the request.                
                request = (DatafeedsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeeds.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a datafeed configuration from your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeeds/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">NA</param>
        /// <param name="datafeedId">NA</param>
        /// <returns>DatafeedResponse</returns>
        public static Datafeed Get(ShoppingcontentService service, string merchantId, string datafeedId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (datafeedId == null)
                    throw new ArgumentNullException(datafeedId);

                // Make the request.
                return service.Datafeeds.Get(merchantId, datafeedId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeeds.Get failed.", ex);
            }
        }
        public class DatafeedsInsertOptionalParms
        {
            /// Flag to run the request in dry-run mode.
            public bool? DryRun { get; set; }  
        
        }
 
        /// <summary>
        /// Registers a datafeed configuration with your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeeds/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">NA</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DatafeedResponse</returns>
        public static Datafeed Insert(ShoppingcontentService service, string merchantId, Datafeed body, DatafeedsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);

                // Building the initial request.
                var request = service.Datafeeds.Insert(body, merchantId);

                // Applying optional parameters to the request.                
                request = (DatafeedsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeeds.Insert failed.", ex);
            }
        }
        public class DatafeedsListOptionalParms
        {
            /// The maximum number of products to return in the response, used for paging.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the datafeeds in your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeeds/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">The ID of the managing account.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DatafeedsListResponseResponse</returns>
        public static DatafeedsListResponse List(ShoppingcontentService service, string merchantId, DatafeedsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);

                // Building the initial request.
                var request = service.Datafeeds.List(merchantId);

                // Applying optional parameters to the request.                
                request = (DatafeedsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeeds.List failed.", ex);
            }
        }
        public class DatafeedsPatchOptionalParms
        {
            /// Flag to run the request in dry-run mode.
            public bool? DryRun { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a datafeed configuration of your Merchant Center account. This method can only be called for non-multi-client accounts. This method supports patch semantics. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeeds/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">NA</param>
        /// <param name="datafeedId">NA</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DatafeedResponse</returns>
        public static Datafeed Patch(ShoppingcontentService service, string merchantId, string datafeedId, Datafeed body, DatafeedsPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (datafeedId == null)
                    throw new ArgumentNullException(datafeedId);

                // Building the initial request.
                var request = service.Datafeeds.Patch(body, merchantId, datafeedId);

                // Applying optional parameters to the request.                
                request = (DatafeedsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeeds.Patch failed.", ex);
            }
        }
        public class DatafeedsUpdateOptionalParms
        {
            /// Flag to run the request in dry-run mode.
            public bool? DryRun { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a datafeed configuration of your Merchant Center account. This method can only be called for non-multi-client accounts. 
        /// Documentation https://developers.google.com/shoppingcontent/v2/reference/datafeeds/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Shoppingcontent service.</param>  
        /// <param name="merchantId">NA</param>
        /// <param name="datafeedId">NA</param>
        /// <param name="body">A valid Shoppingcontent v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DatafeedResponse</returns>
        public static Datafeed Update(ShoppingcontentService service, string merchantId, string datafeedId, Datafeed body, DatafeedsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (merchantId == null)
                    throw new ArgumentNullException(merchantId);
                if (datafeedId == null)
                    throw new ArgumentNullException(datafeedId);

                // Building the initial request.
                var request = service.Datafeeds.Update(body, merchantId, datafeedId);

                // Applying optional parameters to the request.                
                request = (DatafeedsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Datafeeds.Update failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}