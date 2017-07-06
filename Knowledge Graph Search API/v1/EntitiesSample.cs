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
// Unoffical sample for the Kgsearch v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Searches the Google Knowledge Graph for entities.
// API Documentation Link https://developers.google.com/knowledge-graph/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Kgsearch/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Kgsearch.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Kgsearch.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Kgsearch.v1;
using Google.Apis.Kgsearch.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Kgsearchv1.Methods
{
  
    public static class EntitiesSample
    {

        public class EntitiesSearchOptionalParms
        {
            /// Enables indenting of json results.
            public bool? Indent { get; set; }  
            /// The list of language codes (defined in ISO 693) to run the query with,e.g. 'en'.
            public string Languages { get; set; }  
            /// The list of entity id to be used for search instead of query string.To specify multiple ids in the HTTP request, repeat the parameter in theURL as in ...?ids=A&ids=B
            public string Ids { get; set; }  
            /// Limits the number of entities to be returned.
            public int? Limit { get; set; }  
            /// Enables prefix match against names and aliases of entities
            public bool? Prefix { get; set; }  
            /// The literal query string for search.
            public string Query { get; set; }  
            /// Restricts returned entities with these types, e.g. Person(as defined in http://schema.org/Person). If multiple types are specified,returned entities will contain one or more of these types.
            public string Types { get; set; }  
        
        }
 
        /// <summary>
        /// Searches Knowledge Graph for entities that match the constraints.A list of matched entities will be returned in response, which will be inJSON-LD format and compatible with http://schema.org 
        /// Documentation https://developers.google.com/kgsearch/v1/reference/entities/search
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Kgsearch service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>SearchResponseResponse</returns>
        public static SearchResponse Search(KgsearchService service, EntitiesSearchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Entities.Search();

                // Applying optional parameters to the request.                
                request = (EntitiesResource.SearchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Entities.Search failed.", ex);
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