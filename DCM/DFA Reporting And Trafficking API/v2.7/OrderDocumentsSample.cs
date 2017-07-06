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
//     Build date: 07/06/2017 15:31:18
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Dfareporting v2.7 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your DoubleClick Campaign Manager ad campaigns and reports.
// API Documentation Link https://developers.google.com/doubleclick-advertisers/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dfareporting/v2_7/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dfareporting.v2_7/ 
// Install Command: PM>  Install-Package Google.Apis.Dfareporting.v2_7
//
//------------------------------------------------------------------------------  
using Google.Apis.Dfareporting.v2_7;
using Google.Apis.Dfareporting.v2_7.Data;
using System;

namespace GoogleSamplecSharpSample.Dfareportingv2_7.Methods
{
  
    public static class OrderDocumentsSample
    {


        /// <summary>
        /// Gets one order document by ID. 
        /// Documentation https://developers.google.com/dfareporting/v2.7/reference/orderDocuments/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="projectId">Project ID for order documents.</param>
        /// <param name="id">Order document ID.</param>
        /// <returns>OrderDocumentResponse</returns>
        public static OrderDocument Get(DfareportingService service, string profileId, string projectId, string id)
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
                return service.OrderDocuments.Get(profileId, projectId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request OrderDocuments.Get failed.", ex);
            }
        }
        public class OrderDocumentsListOptionalParms
        {
            /// Select only order documents that have been approved by at least one user.
            public bool? Approved { get; set; }  
            /// Select only order documents with these IDs.
            public string Ids { get; set; }  
            /// Maximum number of results to return.
            public int? MaxResults { get; set; }  
            /// Select only order documents for specified orders.
            public string OrderId { get; set; }  
            /// Value of the nextPageToken from the previous result page.
            public string PageToken { get; set; }  
            /// Allows searching for order documents by name or ID. Wildcards (*) are allowed. For example, "orderdocument*2015" will return order documents with names like "orderdocument June 2015", "orderdocument April 2015", or simply "orderdocument 2015". Most of the searches also add wildcards implicitly at the start and the end of the search string. For example, a search string of "orderdocument" will match order documents with name "my orderdocument", "orderdocument 2015", or simply "orderdocument".
            public string SearchString { get; set; }  
            /// Select only order documents that are associated with these sites.
            public string SiteId { get; set; }  
            /// Field by which to sort the list.
            public string SortField { get; set; }  
            /// Order of sorted results.
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of order documents, possibly filtered. This method supports paging. 
        /// Documentation https://developers.google.com/dfareporting/v2.7/reference/orderDocuments/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="projectId">Project ID for order documents.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OrderDocumentsListResponseResponse</returns>
        public static OrderDocumentsListResponse List(DfareportingService service, string profileId, string projectId, OrderDocumentsListOptionalParms optional = null)
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
                var request = service.OrderDocuments.List(profileId, projectId);

                // Applying optional parameters to the request.                
                request = (OrderDocumentsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request OrderDocuments.List failed.", ex);
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