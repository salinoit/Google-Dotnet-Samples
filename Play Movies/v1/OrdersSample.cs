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
//     Build date: 07/06/2017 15:31:22
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Playmovies v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Gets the delivery status of titles for Google Play Movies Partners.
// API Documentation Link https://developers.google.com/playmoviespartner/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Playmovies/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Playmovies.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Playmovies.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Playmovies.v1;
using Google.Apis.Playmovies.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Playmoviesv1.Methods
{
  
    public static class OrdersSample
    {

        public class OrdersListOptionalParms
        {
            /// Filter that matches Orders with a `name`, `show`, `season` or `episode`that contains the given case-insensitive name.
            public string Name { get; set; }  
            /// See _List methods rules_ for info about this field.
            public string StudioNames { get; set; }  
            /// Filter Orders that match any of the given `video_id`s.
            public string VideoIds { get; set; }  
            /// Filter Orders that match a case-insensitive, partner-specific custom id.
            public string CustomId { get; set; }  
            /// See _List methods rules_ for info about this field.
            public string PageToken { get; set; }  
            /// See _List methods rules_ for info about this field.
            public int? PageSize { get; set; }  
            /// See _List methods rules_ for info about this field.
            public string PphNames { get; set; }  
            /// Filter Orders that match one of the given status.
            public string Status { get; set; }  
        
        }
 
        /// <summary>
        /// List Orders owned or managed by the partner.See _Authentication and Authorization rules_ and_List methods rules_ for more information about this method. 
        /// Documentation https://developers.google.com/playmovies/v1/reference/orders/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Playmovies service.</param>  
        /// <param name="accountId">REQUIRED. See _General rules_ for more information about this field.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListOrdersResponseResponse</returns>
        public static ListOrdersResponse List(PlaymoviesService service, string accountId, OrdersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);

                // Building the initial request.
                var request = service.Orders.List(accountId);

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

        /// <summary>
        /// Get an Order given its id.See _Authentication and Authorization rules_ and_Get methods rules_ for more information about this method. 
        /// Documentation https://developers.google.com/playmovies/v1/reference/orders/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Playmovies service.</param>  
        /// <param name="accountId">REQUIRED. See _General rules_ for more information about this field.</param>
        /// <param name="orderId">REQUIRED. Order ID.</param>
        /// <returns>OrderResponse</returns>
        public static Order Get(PlaymoviesService service, string accountId, string orderId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (orderId == null)
                    throw new ArgumentNullException(orderId);

                // Make the request.
                return service.Orders.Get(accountId, orderId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Orders.Get failed.", ex);
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