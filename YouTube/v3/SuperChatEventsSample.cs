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
//     Build date: 07/06/2017 15:31:24
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Youtube v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Supports core YouTube features, such as uploading videos, creating and managing playlists, searching for content, and much more.
// API Documentation Link https://developers.google.com/youtube/v3
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Youtube/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Youtube.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Youtube.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Youtube.v3;
using Google.Apis.Youtube.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Youtubev3.Methods
{
  
    public static class SuperChatEventsSample
    {

        public class SuperChatEventsListOptionalParms
        {
            /// The hl parameter instructs the API to retrieve localized resource metadata for a specific application language that the YouTube website supports. The parameter value must be a language code included in the list returned by the i18nLanguages.list method.If localized resource details are available in that language, the resource's snippet.localized object will contain the localized values. However, if localized details are not available, the snippet.localized object will contain resource details in the resource's default language.
            public string Hl { get; set; }  
            /// The maxResults parameter specifies the maximum number of items that should be returned in the result set.
            public int? MaxResults { get; set; }  
            /// The pageToken parameter identifies a specific page in the result set that should be returned. In an API response, the nextPageToken and prevPageToken properties identify other pages that could be retrieved.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists Super Chat events for a channel. 
        /// Documentation https://developers.google.com/youtube/v3/reference/superChatEvents/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter specifies the superChatEvent resource parts that the API response will include. Supported values are id and snippet.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>SuperChatEventListResponseResponse</returns>
        public static SuperChatEventListResponse List(YoutubeService service, string part, SuperChatEventsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Building the initial request.
                var request = service.SuperChatEvents.List(part);

                // Applying optional parameters to the request.                
                request = (SuperChatEventsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SuperChatEvents.List failed.", ex);
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