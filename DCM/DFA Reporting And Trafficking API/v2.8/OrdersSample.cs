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
//     Build date: 07/06/2017 15:31:19
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Dfareporting v2.8 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dfareporting/v2_8/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dfareporting.v2_8/ 
// Install Command: PM>  Install-Package Google.Apis.Dfareporting.v2_8
//
//------------------------------------------------------------------------------  
using Google.Apis.Dfareporting.v2_8;
using Google.Apis.Dfareporting.v2_8.Data;
using System;

namespace GoogleSamplecSharpSample.Dfareportingv2_8.Methods
{
  
    public static class OrdersSample
    {


        /// <summary>
        /// Gets one order by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/orders/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="projectId">Project ID for orders.</param>
        /// <param name="id">Order ID.</param>
        /// <returns>OrderResponse</returns>
        public static Order Get(DfareportingService service, string profileId, string projectId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Orders.Get(profileId, projectId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Get failed.", ex);
            }
        }
        public class OrdersListOptionalParms
        {
            /// Select only orders with these IDs.
            public string Ids { get; set; }  
            /// Maximum number of results to return.
            public int? MaxResults { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Allows searching for orders by name or ID. Wildcards (*) are allowed. For example, "order*2015" will return orders with names like "order June 2015", "order April 2015", or simply "order 2015". Most of the searches also add wildcards implicitly at the start and the end of the search string. For example, a search string of "order" will match orders with name "my order", "order 2015", or simply "order".
            public string SearchString { get; set; }  
            /// Select only orders that are associated with these site IDs.
            public string SiteId { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results.
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of orders, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.8/reference/orders/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="projectId">Project ID for orders.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OrdersListResponseResponse</returns>
        public static OrdersListResponse List(DfareportingService service, string profileId, string projectId, OrdersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Building the initial request.
                var request = service.Orders.List(profileId, projectId);

                // Applying optional parameters to the request.                
                request = (OrdersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.List failed.", ex);
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