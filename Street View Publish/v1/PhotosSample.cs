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
//     Build date: 07/06/2017 15:31:23
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Streetviewpublish v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Street View Publish API allows your application to publish 360 photos to Google Maps, along with image metadata that specifies the position, orientation, and connectivity of each photo. With this API, any app can offer an interface for positioning, connecting, and uploading user-generated Street View images.
// API Documentation Link https://developers.google.com/streetview/publish/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Streetviewpublish/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Streetviewpublish.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Streetviewpublish.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Streetviewpublish.v1;
using Google.Apis.Streetviewpublish.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Streetviewpublishv1.Methods
{
  
    public static class PhotosSample
    {

        public class PhotosBatchGetOptionalParms
        {
            /// Specifies if a download URL for the photo bytes should be returned in thePhoto response.
            public string View { get; set; }  
            /// Required. IDs of the Photos. For HTTPGET requests, the URL query parameter should be`photoIds=<id1>&photoIds=<id2>&...`.
            public string PhotoIds { get; set; }  
        
        }
 
        /// <summary>
        /// Gets the metadata of the specifiedPhoto batch.Note that ifBatchGetPhotosfails, either critical fields are missing or there was an authenticationerror. Even ifBatchGetPhotossucceeds, there may have been failures for single photos in the batch.These failures will be specified in eachPhotoResponse.statusinBatchGetPhotosResponse.results.SeeGetPhotofor specific failures that can occur per photo. 
        /// Documentation https://developers.google.com/streetviewpublish/v1/reference/photos/batchGet
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Streetviewpublish service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>BatchGetPhotosResponseResponse</returns>
        public static BatchGetPhotosResponse BatchGet(StreetviewpublishService service, PhotosBatchGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Photos.BatchGet();

                // Applying optional parameters to the request.                
                request = (PhotosResource.BatchGetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Photos.BatchGet failed.", ex);
            }
        }
        public class PhotosListOptionalParms
        {
            /// The filter expression. For example: `placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw`.
            public string Filter { get; set; }  
            /// ThenextPageTokenvalue returned from a previousListPhotosrequest, if any.
            public string PageToken { get; set; }  
            /// The maximum number of photos to return.`pageSize` must be non-negative. If `pageSize` is zero or is not provided,the default page size of 100 will be used.The number of photos returned in the response may be less than `pageSize`if the number of photos that belong to the user is less than `pageSize`.
            public int? PageSize { get; set; }  
            /// Specifies if a download URL for the photos bytes should be returned in thePhotos response.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all the Photos that belong to the user. 
        /// Documentation https://developers.google.com/streetviewpublish/v1/reference/photos/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Streetviewpublish service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListPhotosResponseResponse</returns>
        public static ListPhotosResponse List(StreetviewpublishService service, PhotosListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Photos.List();

                // Applying optional parameters to the request.                
                request = (PhotosResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Photos.List failed.", ex);
            }
        }

        /// <summary>
        /// Deletes a list of Photos and their metadata.Note that ifBatchDeletePhotosfails, either critical fields are missing or there was an authenticationerror. Even ifBatchDeletePhotossucceeds, there may have been failures for single photos in the batch.These failures will be specified in eachPhotoResponse.statusinBatchDeletePhotosResponse.results.SeeDeletePhotofor specific failures that can occur per photo. 
        /// Documentation https://developers.google.com/streetviewpublish/v1/reference/photos/batchDelete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Streetviewpublish service.</param>  
        /// <param name="body">A valid Streetviewpublish v1 body.</param>
        /// <returns>BatchDeletePhotosResponseResponse</returns>
        public static BatchDeletePhotosResponse BatchDelete(StreetviewpublishService service, BatchDeletePhotosRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Photos.BatchDelete(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Photos.BatchDelete failed.", ex);
            }
        }

        /// <summary>
        /// Updates the metadata of Photos, suchas pose, place association, connections, etc. Changing the pixels of photosis not supported.Note that ifBatchUpdatePhotosfails, either critical fields are missing or there was an authenticationerror. Even ifBatchUpdatePhotossucceeds, there may have been failures for single photos in the batch.These failures will be specified in eachPhotoResponse.statusinBatchUpdatePhotosResponse.results.SeeUpdatePhotofor specific failures that can occur per photo. 
        /// Documentation https://developers.google.com/streetviewpublish/v1/reference/photos/batchUpdate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Streetviewpublish service.</param>  
        /// <param name="body">A valid Streetviewpublish v1 body.</param>
        /// <returns>BatchUpdatePhotosResponseResponse</returns>
        public static BatchUpdatePhotosResponse BatchUpdate(StreetviewpublishService service, <Nasty Null Bug Log Issue Please> body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Photos.BatchUpdate(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Photos.BatchUpdate failed.", ex);
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