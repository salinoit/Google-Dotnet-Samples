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
//     Build date: 07/06/2017 15:31:12
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Adsense v1.4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses AdSense publishers' inventory and generates performance reports.
// API Documentation Link https://developers.google.com/adsense/management/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Adsense/v1_4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Adsense.v1_4/ 
// Install Command: PM>  Install-Package Google.Apis.Adsense.v1_4
//
//------------------------------------------------------------------------------  
using Google.Apis.Adsense.v1_4;
using Google.Apis.Adsense.v1_4.Data;
using System;

namespace GoogleSamplecSharpSample.Adsensev1_4.Methods
{
  
    public static class SavedSample
    {

        public class SavedGenerateOptionalParms
        {
            /// Optional locale to use for translating report output to a local language. Defaults to "en_US" if not specified.
            public string Locale { get; set; }  
            /// The maximum number of rows of report data to return.
            public int? MaxResults { get; set; }  
            /// Index of the first row of report data to return.
            public int? StartIndex { get; set; }  
        
        }
 
        /// <summary>
        /// Generate an AdSense report based on the saved report ID sent in the query parameters. 
        /// Documentation https://developers.google.com/adsense/v1.4/reference/saved/generate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adsense service.</param>  
        /// <param name="savedReportId">The saved report to retrieve.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AdsenseReportsGenerateResponseResponse</returns>
        public static AdsenseReportsGenerateResponse Generate(AdsenseService service, string savedReportId, SavedGenerateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (savedReportId == null)
                    throw new ArgumentNullException(savedReportId);

                // Building the initial request.
                var request = service.Saved.Generate(savedReportId);

                // Applying optional parameters to the request.                
                request = (SavedResource.GenerateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Saved.Generate failed.", ex);
            }
        }
        public class SavedListOptionalParms
        {
            /// The maximum number of saved reports to include in the response, used for paging.
            public int? MaxResults { get; set; }  
            /// A continuation token, used to page through saved reports. To retrieve the next page, set this parameter to the value of "nextPageToken" from the previous response.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List all saved reports in this AdSense account. 
        /// Documentation https://developers.google.com/adsense/v1.4/reference/saved/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adsense service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>SavedReportsResponse</returns>
        public static SavedReports List(AdsenseService service, SavedListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Saved.List();

                // Applying optional parameters to the request.                
                request = (SavedResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Saved.List failed.", ex);
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