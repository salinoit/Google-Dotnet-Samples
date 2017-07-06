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
// Unoffical sample for the Plusdomains v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Builds on top of the Google+ platform for Google Apps Domains.
// API Documentation Link https://developers.google.com/+/domains/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Plusdomains/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Plusdomains.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Plusdomains.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Plusdomains.v1;
using Google.Apis.Plusdomains.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Plusdomainsv1.Methods
{
  
    public static class ActivitiesSample
    {


        /// <summary>
        /// Get an activity. 
        /// Documentation https://developers.google.com/plusdomains/v1/reference/activities/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Plusdomains service.</param>  
        /// <param name="activityId">The ID of the activity to get.</param>
        /// <returns>ActivityResponse</returns>
        public static Activity Get(PlusdomainsService service, string activityId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (activityId == null)
                    throw new ArgumentNullException(activityId);

                // Make the request.
                return service.Activities.Get(activityId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Activities.Get failed.", ex);
            }
        }
        public class ActivitiesInsertOptionalParms
        {
            /// If "true", extract the potential media attachments for a URL. The response will include all possible attachments for a URL, including video, photos, and articles based on the content of the page.
            public bool? Preview { get; set; }  
        
        }
 
        /// <summary>
        /// Create a new activity for the authenticated user. 
        /// Documentation https://developers.google.com/plusdomains/v1/reference/activities/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Plusdomains service.</param>  
        /// <param name="userId">The ID of the user to create the activity on behalf of. Its value should be "me", to indicate the authenticated user.</param>
        /// <param name="body">A valid Plusdomains v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ActivityResponse</returns>
        public static Activity Insert(PlusdomainsService service, string userId, Activity body, ActivitiesInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Building the initial request.
                var request = service.Activities.Insert(body, userId);

                // Applying optional parameters to the request.                
                request = (ActivitiesResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Activities.Insert failed.", ex);
            }
        }
        public class ActivitiesListOptionalParms
        {
            /// The maximum number of activities to include in the response, which is used for paging. For any response, the actual number returned might be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The continuation token, which is used to page through large result sets. To get the next page of results, set this parameter to the value of "nextPageToken" from the previous response.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List all of the activities in the specified collection for a particular user. 
        /// Documentation https://developers.google.com/plusdomains/v1/reference/activities/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Plusdomains service.</param>  
        /// <param name="userId">The ID of the user to get activities for. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="collection">The collection of activities to list.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ActivityFeedResponse</returns>
        public static ActivityFeed List(PlusdomainsService service, string userId, string collection, ActivitiesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (collection == null)
                    throw new ArgumentNullException(collection);

                // Building the initial request.
                var request = service.Activities.List(userId, collection);

                // Applying optional parameters to the request.                
                request = (ActivitiesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Activities.List failed.", ex);
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