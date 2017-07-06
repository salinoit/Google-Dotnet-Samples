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
//     Build date: 07/06/2017 15:31:14
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Books v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Searches for books and manages your Google Books library.
// API Documentation Link https://developers.google.com/books/docs/v1/getting_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Books/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Books.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Books.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Booksv1.Methods
{
  
    public static class AnnotationsSample
    {

        public class AnnotationsDeleteOptionalParms
        {
            /// String to identify the originator of this request.
            public string Source { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes an annotation. 
        /// Documentation https://developers.google.com/books/v1/reference/annotations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="annotationId">The ID for the annotation to delete.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(BooksService service, string annotationId, AnnotationsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (annotationId == null)
                    throw new ArgumentNullException(annotationId);

                // Building the initial request.
                var request = service.Annotations.Delete(annotationId);

                // Applying optional parameters to the request.                
                request = (AnnotationsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Delete failed.", ex);
            }
        }
        public class AnnotationsInsertOptionalParms
        {
            /// The ID for the annotation to insert.
            public string AnnotationId { get; set; }  
            /// ISO-3166-1 code to override the IP-based location.
            public string Country { get; set; }  
            /// Requests that only the summary of the specified layer be provided in the response.
            public bool? ShowOnlySummaryInResponse { get; set; }  
            /// String to identify the originator of this request.
            public string Source { get; set; }  
        
        }
 
        /// <summary>
        /// Inserts a new annotation. 
        /// Documentation https://developers.google.com/books/v1/reference/annotations/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="body">A valid Books v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AnnotationResponse</returns>
        public static Annotation Insert(BooksService service, Annotation body, AnnotationsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Annotations.Insert(body);

                // Applying optional parameters to the request.                
                request = (AnnotationsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Insert failed.", ex);
            }
        }
        public class AnnotationsListOptionalParms
        {
            /// The content version for the requested volume.
            public string ContentVersion { get; set; }  
            /// The layer ID to limit annotation by.
            public string LayerId { get; set; }  
            /// The layer ID(s) to limit annotation by.
            public string LayerIds { get; set; }  
            /// Maximum number of results to return
            public int? MaxResults { get; set; }  
            /// The value of the nextToken from the previous page.
            public string PageToken { get; set; }  
            /// Set to true to return deleted annotations. updatedMin must be in the request to use this. Defaults to false.
            public bool? ShowDeleted { get; set; }  
            /// String to identify the originator of this request.
            public string Source { get; set; }  
            /// RFC 3339 timestamp to restrict to items updated prior to this timestamp (exclusive).
            public string UpdatedMax { get; set; }  
            /// RFC 3339 timestamp to restrict to items updated since this timestamp (inclusive).
            public string UpdatedMin { get; set; }  
            /// The volume to restrict annotations to.
            public string VolumeId { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of annotations, possibly filtered. 
        /// Documentation https://developers.google.com/books/v1/reference/annotations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AnnotationsResponse</returns>
        public static Annotations List(BooksService service, AnnotationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Annotations.List();

                // Applying optional parameters to the request.                
                request = (AnnotationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.List failed.", ex);
            }
        }

        /// <summary>
        /// Gets the summary of specified layers. 
        /// Documentation https://developers.google.com/books/v1/reference/annotations/summary
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="layerIds">Array of layer IDs to get the summary for.</param>
        /// <param name="volumeId">Volume id to get the summary for.</param>
        /// <returns>AnnotationsSummaryResponse</returns>
        public static AnnotationsSummary Summary(BooksService service, string layerIds, string volumeId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (layerIds == null)
                    throw new ArgumentNullException(layerIds);
                if (volumeId == null)
                    throw new ArgumentNullException(volumeId);

                // Make the request.
                return service.Annotations.Summary(layerIds, volumeId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Summary failed.", ex);
            }
        }
        public class AnnotationsUpdateOptionalParms
        {
            /// String to identify the originator of this request.
            public string Source { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an existing annotation. 
        /// Documentation https://developers.google.com/books/v1/reference/annotations/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Books service.</param>  
        /// <param name="annotationId">The ID for the annotation to update.</param>
        /// <param name="body">A valid Books v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AnnotationResponse</returns>
        public static Annotation Update(BooksService service, string annotationId, Annotation body, AnnotationsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (annotationId == null)
                    throw new ArgumentNullException(annotationId);

                // Building the initial request.
                var request = service.Annotations.Update(body, annotationId);

                // Applying optional parameters to the request.                
                request = (AnnotationsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Annotations.Update failed.", ex);
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