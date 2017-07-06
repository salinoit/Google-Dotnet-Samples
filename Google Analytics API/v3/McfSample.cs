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
  
    public static class McfSample
    {

        public class McfGetOptionalParms
        {
            /// A comma-separated list of Multi-Channel Funnels dimensions. E.g., 'mcf:source,mcf:medium'.
            public string Dimensions { get; set; }  
            /// A comma-separated list of dimension or metric filters to be applied to the Analytics data.
            public string Filters { get; set; }  
            /// The maximum number of entries to include in this feed.
            public int? Max-results { get; set; }  
            /// The desired sampling level.
            public string SamplingLevel { get; set; }  
            /// A comma-separated list of dimensions or metrics that determine the sort order for the Analytics data.
            public string Sort { get; set; }  
            /// An index of the first entity to retrieve. Use this parameter as a pagination mechanism along with the max-results parameter.
            public int? Start-index { get; set; }  
        
        }
 
        /// <summary>
        /// Returns Analytics Multi-Channel Funnels data for a view (profile). 
        /// Documentation https://developers.google.com/analytics/v3/reference/mcf/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Analytics service.</param>  
        /// <param name="ids">Unique table ID for retrieving Analytics data. Table ID is of the form ga:XXXX, where XXXX is the Analytics view (profile) ID.</param>
        /// <param name="start-date">Start date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or as a relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.</param>
        /// <param name="end-date">End date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or as a relative date (e.g., today, yesterday, or 7daysAgo). The default value is 7daysAgo.</param>
        /// <param name="metrics">A comma-separated list of Multi-Channel Funnels metrics. E.g., 'mcf:totalConversions,mcf:totalConversionValue'. At least one metric must be specified.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>McfDataResponse</returns>
        public static McfData Get(AnalyticsService service, string ids, string start-date, string end-date, string metrics, McfGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (ids == null)
                    throw new ArgumentNullException(ids);
                if (start-date == null)
                    throw new ArgumentNullException(start-date);
                if (end-date == null)
                    throw new ArgumentNullException(end-date);
                if (metrics == null)
                    throw new ArgumentNullException(metrics);

                // Building the initial request.
                var request = service.Mcf.Get(ids, start-date, end-date, metrics);

                // Applying optional parameters to the request.                
                request = (McfResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Mcf.Get failed.", ex);
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