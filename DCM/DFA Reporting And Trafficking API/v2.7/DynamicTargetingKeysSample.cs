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
  
    public static class DynamicTargetingKeysSample
    {


        /// <summary>
        /// Deletes an existing dynamic targeting key. 
        /// Documentation https://developers.google.com/dfareporting/v2.7/reference/dynamicTargetingKeys/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="objectId">ID of the object of this dynamic targeting key. This is a required field.</param>
        /// <param name="name">Name of this dynamic targeting key. This is a required field. Must be less than 256 characters long and cannot contain commas. All characters are converted to lowercase.</param>
        /// <param name="objectType">Type of the object of this dynamic targeting key. This is a required field.</param>
        public static void Delete(DfareportingService service, string profileId, string objectId, string name, string objectType)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);
                if (objectId == null)
                    throw new ArgumentNullException(objectId);
                if (name == null)
                    throw new ArgumentNullException(name);
                if (objectType == null)
                    throw new ArgumentNullException(objectType);

                // Make the request.
                 service.DynamicTargetingKeys.Delete(profileId, objectId, name, objectType).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DynamicTargetingKeys.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a new dynamic targeting key. Keys must be created at the advertiser level before being assigned to the advertiser's ads, creatives, or placements. There is a maximum of 1000 keys per advertiser, out of which a maximum of 20 keys can be assigned per ad, creative, or placement. 
        /// Documentation https://developers.google.com/dfareporting/v2.7/reference/dynamicTargetingKeys/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="body">A valid Dfareporting v2.7 body.</param>
        /// <returns>DynamicTargetingKeyResponse</returns>
        public static DynamicTargetingKey Insert(DfareportingService service, string profileId, DynamicTargetingKey body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Make the request.
                return service.DynamicTargetingKeys.Insert(body, profileId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DynamicTargetingKeys.Insert failed.", ex);
            }
        }
        public class DynamicTargetingKeysListOptionalParms
        {
            /// Select only dynamic targeting keys whose object has this advertiser ID.
            public string AdvertiserId { get; set; }  
            /// Select only dynamic targeting keys exactly matching these names.
            public string Names { get; set; }  
            /// Select only dynamic targeting keys with this object ID.
            public string ObjectId { get; set; }  
            /// Select only dynamic targeting keys with this object type.
            public string ObjectType { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of dynamic targeting keys. 
        /// Documentation https://developers.google.com/dfareporting/v2.7/reference/dynamicTargetingKeys/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dfareporting service.</param>  
        /// <param name="profileId">User profile ID associated with this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DynamicTargetingKeysListResponseResponse</returns>
        public static DynamicTargetingKeysListResponse List(DfareportingService service, string profileId, DynamicTargetingKeysListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (profileId == null)
                    throw new ArgumentNullException(profileId);

                // Building the initial request.
                var request = service.DynamicTargetingKeys.List(profileId);

                // Applying optional parameters to the request.                
                request = (DynamicTargetingKeysResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DynamicTargetingKeys.List failed.", ex);
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