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
// Unoffical sample for the Proximitybeacon v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Registers, manages, indexes, and searches beacons.
// API Documentation Link https://developers.google.com/beacons/proximity/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Proximitybeacon/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Proximitybeacon.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Proximitybeacon.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Proximitybeacon.v1beta1;
using Google.Apis.Proximitybeacon.v1beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Proximitybeaconv1beta1.Methods
{
  
    public static class DiagnosticsSample
    {

        public class DiagnosticsListOptionalParms
        {
            /// Requests only diagnostic records for the given project id. If not set,then the project making the request will be used for looking updiagnostic records. Optional.
            public string ProjectId { get; set; }  
            /// Requests results that occur after the `page_token`, obtained from theresponse to a previous request. Optional.
            public string PageToken { get; set; }  
            /// Requests only beacons that have the given alert. For example, to findbeacons that have low batteries use `alert_filter=LOW_BATTERY`.
            public string AlertFilter { get; set; }  
            /// Specifies the maximum number of results to return. Defaults to10. Maximum 1000. Optional.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// List the diagnostics for a single beacon. You can also list diagnostics forall the beacons owned by your Google Developers Console project by usingthe beacon name `beacons/-`.Authenticate using an [OAuth access token](https://developers.google.com/identity/protocols/OAuth2)from a signed-in user with **viewer**, **Is owner** or **Can edit**permissions in the Google Developers Console project. 
        /// Documentation https://developers.google.com/proximitybeacon/v1beta1/reference/diagnostics/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Proximitybeacon service.</param>  
        /// <param name="beaconName">Beacon that the diagnostics are for.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListDiagnosticsResponseResponse</returns>
        public static ListDiagnosticsResponse List(ProximitybeaconService service, string beaconName, DiagnosticsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (beaconName == null)
                    throw new ArgumentNullException(beaconName);

                // Building the initial request.
                var request = service.Diagnostics.List(beaconName);

                // Applying optional parameters to the request.                
                request = (DiagnosticsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Diagnostics.List failed.", ex);
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