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
// Unoffical sample for the Youtubeanalytics v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Retrieves your YouTube Analytics data.
// API Documentation Link http://developers.google.com/youtube/analytics/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Youtubeanalytics/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Youtubeanalytics.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Youtubeanalytics.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Youtubeanalytics.v1;
using Google.Apis.Youtubeanalytics.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Youtubeanalyticsv1.Methods
{
  
    public static class GroupsSample
    {

        public class GroupsDeleteOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a group. 
        /// Documentation https://developers.google.com/youtubeanalytics/v1/reference/groups/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtubeanalytics service.</param>  
        /// <param name="id">The id parameter specifies the YouTube group ID for the group that is being deleted.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(YoutubeanalyticsService service, string id, GroupsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Building the initial request.
                var request = service.Groups.Delete(id);

                // Applying optional parameters to the request.                
                request = (GroupsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Groups.Delete failed.", ex);
            }
        }
        public class GroupsInsertOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a group. 
        /// Documentation https://developers.google.com/youtubeanalytics/v1/reference/groups/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtubeanalytics service.</param>  
        /// <param name="body">A valid Youtubeanalytics v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>GroupResponse</returns>
        public static Group Insert(YoutubeanalyticsService service, Group body, GroupsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Groups.Insert(body);

                // Applying optional parameters to the request.                
                request = (GroupsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Groups.Insert failed.", ex);
            }
        }
        public class GroupsListOptionalParms
        {
            /// The id parameter specifies a comma-separated list of the YouTube group ID(s) for the resource(s) that are being retrieved. In a group resource, the id property specifies the group's YouTube group ID.
            public string Id { get; set; }  
            /// Set this parameter's value to true to instruct the API to only return groups owned by the authenticated user.
            public bool? Mine { get; set; }  
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
            /// The pageToken parameter identifies a specific page in the result set that should be returned. In an API response, the nextPageToken property identifies the next page that can be retrieved.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a collection of groups that match the API request parameters. For example, you can retrieve all groups that the authenticated user owns, or you can retrieve one or more groups by their unique IDs. 
        /// Documentation https://developers.google.com/youtubeanalytics/v1/reference/groups/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtubeanalytics service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>GroupListResponseResponse</returns>
        public static GroupListResponse List(YoutubeanalyticsService service, GroupsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Groups.List();

                // Applying optional parameters to the request.                
                request = (GroupsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Groups.List failed.", ex);
            }
        }
        public class GroupsUpdateOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
        
        }
 
        /// <summary>
        /// Modifies a group. For example, you could change a group's title. 
        /// Documentation https://developers.google.com/youtubeanalytics/v1/reference/groups/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtubeanalytics service.</param>  
        /// <param name="body">A valid Youtubeanalytics v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>GroupResponse</returns>
        public static Group Update(YoutubeanalyticsService service, Group body, GroupsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Groups.Update(body);

                // Applying optional parameters to the request.                
                request = (GroupsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Groups.Update failed.", ex);
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