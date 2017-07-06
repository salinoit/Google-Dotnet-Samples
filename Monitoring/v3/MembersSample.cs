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
// Unoffical sample for the Monitoring v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your Stackdriver Monitoring data and configurations. Most projects must be associated with a Stackdriver account, with a few exceptions as noted on the individual method pages.
// API Documentation Link https://cloud.google.com/monitoring/api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Monitoring/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Monitoring.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Monitoring.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Monitoring.v3;
using Google.Apis.Monitoring.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Monitoringv3.Methods
{
  
    public static class MembersSample
    {

        public class MembersListOptionalParms
        {
            /// Required. The end of the time interval.
            public string Interval.endTime { get; set; }  
            /// An optional list filter describing the members to be returned. The filter may reference the type, labels, and metadata of monitored resources that comprise the group. For example, to return only resources representing Compute Engine VM instances, use this filter:resource.type = "gce_instance"
            public string Filter { get; set; }  
            /// If this field is not empty then it must contain the nextPageToken value returned by a previous call to this method. Using this field causes the method to return additional results from the previous method call.
            public string PageToken { get; set; }  
            /// Optional. The beginning of the time interval. The default value for the start time is the end time. The start time must not be later than the end time.
            public string Interval.startTime { get; set; }  
            /// A positive number that is the maximum number of results to return.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the monitored resources that are members of a group. 
        /// Documentation https://developers.google.com/monitoring/v3/reference/members/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Monitoring service.</param>  
        /// <param name="name">The group whose members are listed. The format is "projects/{project_id_or_number}/groups/{group_id}".</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListGroupMembersResponseResponse</returns>
        public static ListGroupMembersResponse List(MonitoringService service, string name, MembersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Members.List(name);

                // Applying optional parameters to the request.                
                request = (MembersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Members.List failed.", ex);
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