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
//     Build date: 07/06/2017 15:31:13
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Analytics v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Views and manages your Google Analytics data.
// API Documentation Link https://developers.google.com/analytics/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Analytics/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Analytics.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Analytics.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Analyticsv3.Methods
{
  
    public static class WebPropertyAdWordsLinksSample
    {


        /// <summary>
        /// Deletes a web property-AdWords link. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webPropertyAdWordsLinks/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Analytics service.</param>  
        /// <param name="accountId">ID of the account which the given web property belongs to.</param>
        /// <param name="webPropertyId">Web property ID to delete the AdWords link for.</param>
        /// <param name="webPropertyAdWordsLinkId">Web property AdWords link ID.</param>
        public static void Delete(AnalyticsService service, string accountId, string webPropertyId, string webPropertyAdWordsLinkId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (webPropertyAdWordsLinkId == null)
                    throw new ArgumentNullException(webPropertyAdWordsLinkId);

                // Make the request.
                 service.WebPropertyAdWordsLinks.Delete(accountId, webPropertyId, webPropertyAdWordsLinkId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request WebPropertyAdWordsLinks.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Returns a web property-AdWords link to which the user has access. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webPropertyAdWordsLinks/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Analytics service.</param>  
        /// <param name="accountId">ID of the account which the given web property belongs to.</param>
        /// <param name="webPropertyId">Web property ID to retrieve the AdWords link for.</param>
        /// <param name="webPropertyAdWordsLinkId">Web property-AdWords link ID.</param>
        /// <returns>EntityAdWordsLinkResponse</returns>
        public static EntityAdWordsLink Get(AnalyticsService service, string accountId, string webPropertyId, string webPropertyAdWordsLinkId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (webPropertyAdWordsLinkId == null)
                    throw new ArgumentNullException(webPropertyAdWordsLinkId);

                // Make the request.
                return service.WebPropertyAdWordsLinks.Get(accountId, webPropertyId, webPropertyAdWordsLinkId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request WebPropertyAdWordsLinks.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates a webProperty-AdWords link. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webPropertyAdWordsLinks/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Analytics service.</param>  
        /// <param name="accountId">ID of the Google Analytics account to create the link for.</param>
        /// <param name="webPropertyId">Web property ID to create the link for.</param>
        /// <param name="body">A valid Analytics v3 body.</param>
        /// <returns>EntityAdWordsLinkResponse</returns>
        public static EntityAdWordsLink Insert(AnalyticsService service, string accountId, string webPropertyId, EntityAdWordsLink body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);

                // Make the request.
                return service.WebPropertyAdWordsLinks.Insert(body, accountId, webPropertyId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request WebPropertyAdWordsLinks.Insert failed.", ex);
            }
        }
        public class WebPropertyAdWordsLinksListOptionalParms
        {
            /// The maximum number of webProperty-AdWords links to include in this response.
            public int? Max-results { get; set; }  
            /// An index of the first webProperty-AdWords link to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.
            public int? Start-index { get; set; }  
        
        }
 
        /// <summary>
        /// Lists webProperty-AdWords links for a given web property. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webPropertyAdWordsLinks/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Analytics service.</param>  
        /// <param name="accountId">ID of the account which the given web property belongs to.</param>
        /// <param name="webPropertyId">Web property ID to retrieve the AdWords links for.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>EntityAdWordsLinksResponse</returns>
        public static EntityAdWordsLinks List(AnalyticsService service, string accountId, string webPropertyId, WebPropertyAdWordsLinksListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);

                // Building the initial request.
                var request = service.WebPropertyAdWordsLinks.List(accountId, webPropertyId);

                // Applying optional parameters to the request.                
                request = (WebPropertyAdWordsLinksResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request WebPropertyAdWordsLinks.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing webProperty-AdWords link. This method supports patch semantics. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webPropertyAdWordsLinks/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Analytics service.</param>  
        /// <param name="accountId">ID of the account which the given web property belongs to.</param>
        /// <param name="webPropertyId">Web property ID to retrieve the AdWords link for.</param>
        /// <param name="webPropertyAdWordsLinkId">Web property-AdWords link ID.</param>
        /// <param name="body">A valid Analytics v3 body.</param>
        /// <returns>EntityAdWordsLinkResponse</returns>
        public static EntityAdWordsLink Patch(AnalyticsService service, string accountId, string webPropertyId, string webPropertyAdWordsLinkId, EntityAdWordsLink body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (webPropertyAdWordsLinkId == null)
                    throw new ArgumentNullException(webPropertyAdWordsLinkId);

                // Make the request.
                return service.WebPropertyAdWordsLinks.Patch(body, accountId, webPropertyId, webPropertyAdWordsLinkId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request WebPropertyAdWordsLinks.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing webProperty-AdWords link. 
        /// Documentation https://developers.google.com/analytics/v3/reference/webPropertyAdWordsLinks/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Analytics service.</param>  
        /// <param name="accountId">ID of the account which the given web property belongs to.</param>
        /// <param name="webPropertyId">Web property ID to retrieve the AdWords link for.</param>
        /// <param name="webPropertyAdWordsLinkId">Web property-AdWords link ID.</param>
        /// <param name="body">A valid Analytics v3 body.</param>
        /// <returns>EntityAdWordsLinkResponse</returns>
        public static EntityAdWordsLink Update(AnalyticsService service, string accountId, string webPropertyId, string webPropertyAdWordsLinkId, EntityAdWordsLink body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (webPropertyId == null)
                    throw new ArgumentNullException(webPropertyId);
                if (webPropertyAdWordsLinkId == null)
                    throw new ArgumentNullException(webPropertyAdWordsLinkId);

                // Make the request.
                return service.WebPropertyAdWordsLinks.Update(body, accountId, webPropertyId, webPropertyAdWordsLinkId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request WebPropertyAdWordsLinks.Update failed.", ex);
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