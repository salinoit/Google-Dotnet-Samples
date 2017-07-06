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
//     Build date: 07/06/2017 15:31:20
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Dns v2beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Configures and serves authoritative DNS records.
// API Documentation Link https://developers.google.com/cloud-dns
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dns/v2beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dns.v2beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Dns.v2beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Dns.v2beta1;
using Google.Apis.Dns.v2beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Dnsv2beta1.Methods
{
  
    public static class ChangesSample
    {

        public class ChangesCreateOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Atomically update the ResourceRecordSet collection. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/changes/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <param name="body">A valid Dns v2beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChangeResponse</returns>
        public static Change Create(DnsService service, string project, string managedZone, Change body, ChangesCreateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);

                // Building the initial request.
                var request = service.Changes.Create(body, project, managedZone);

                // Applying optional parameters to the request.                
                request = (ChangesResource.CreateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Changes.Create failed.", ex);
            }
        }
        public class ChangesGetOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Fetch the representation of an existing Change. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/changes/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <param name="changeId">The identifier of the requested change, from a previous ResourceRecordSetsChangeResponse.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChangeResponse</returns>
        public static Change Get(DnsService service, string project, string managedZone, string changeId, ChangesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);
                if (changeId == null)
                    throw new ArgumentNullException(changeId);

                // Building the initial request.
                var request = service.Changes.Get(project, managedZone, changeId);

                // Applying optional parameters to the request.                
                request = (ChangesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Changes.Get failed.", ex);
            }
        }
        public class ChangesListOptionalParms
        {
            /// Optional. Maximum number of results to be returned. If unspecified, the server will decide how many results to return.
            public int? MaxResults { get; set; }  
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a previous list request.
            public string PageToken { get; set; }  
            /// Sorting criterion. The only supported value is change sequence.
            public string SortBy { get; set; }  
            /// Sorting order direction: 'ascending' or 'descending'.
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Enumerate Changes to a ResourceRecordSet collection. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/changes/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChangesListResponseResponse</returns>
        public static ChangesListResponse List(DnsService service, string project, string managedZone, ChangesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);

                // Building the initial request.
                var request = service.Changes.List(project, managedZone);

                // Applying optional parameters to the request.                
                request = (ChangesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Changes.List failed.", ex);
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