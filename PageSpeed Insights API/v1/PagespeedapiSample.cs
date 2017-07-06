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
//     Build date: 07/06/2017 15:31:21
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Pagespeedonline v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Analyzes the performance of a web page and provides tailored suggestions to make that page faster.
// API Documentation Link https://developers.google.com/speed/docs/insights/v1/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Pagespeedonline/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Pagespeedonline.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Pagespeedonline.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Pagespeedonline.v1;
using Google.Apis.Pagespeedonline.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Pagespeedonlinev1.Methods
{
  
    public static class PagespeedapiSample
    {

        public class PagespeedapiRunpagespeedOptionalParms
        {
            /// Indicates if third party resources should be filtered out before PageSpeed analysis.
            public bool? Filter_third_party_resources { get; set; }  
            /// The locale used to localize formatted results
            public string Locale { get; set; }  
            /// A PageSpeed rule to run; if none are given, all rules are run
            public string Rule { get; set; }  
            /// Indicates if binary data containing a screenshot should be included
            public bool? Screenshot { get; set; }  
            /// The analysis strategy to use
            public string Strategy { get; set; }  
        
        }
 
        /// <summary>
        /// Runs PageSpeed analysis on the page at the specified URL, and returns a PageSpeed score, a list of suggestions to make that page faster, and other information. 
        /// Documentation https://developers.google.com/pagespeedonline/v1/reference/pagespeedapi/runpagespeed
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Pagespeedonline service.</param>  
        /// <param name="url">The URL to fetch and analyze</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ResultResponse</returns>
        public static Result Runpagespeed(PagespeedonlineService service, string url, PagespeedapiRunpagespeedOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (url == null)
                    throw new ArgumentNullException(url);

                // Building the initial request.
                var request = service.Pagespeedapi.Runpagespeed(url);

                // Applying optional parameters to the request.                
                request = (PagespeedapiResource.RunpagespeedRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Pagespeedapi.Runpagespeed failed.", ex);
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