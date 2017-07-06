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
//     Build date: 07/06/2017 15:31:15
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Cloudfunctions v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for managing lightweight user-provided functions executed in response to events.
// API Documentation Link https://cloud.google.com/functions
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudfunctions/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudfunctions.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudfunctions.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudfunctions.v1beta2;
using Google.Apis.Cloudfunctions.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudfunctionsv1beta2.Methods
{
  
    public static class OperationsSample
    {


        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use thismethod to poll the operation result at intervals as recommended by the APIservice. 
        /// Documentation https://developers.google.com/cloudfunctions/v1beta2/reference/operations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudfunctions service.</param>  
        /// <param name="name">The name of the operation resource.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(CloudfunctionsService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Operations.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Get failed.", ex);
            }
        }
        public class OperationsListOptionalParms
        {
            /// The standard list filter.
            public string Filter { get; set; }  
            /// The standard list page token.
            public string PageToken { get; set; }  
            /// The name of the operation's parent resource.
            public string Name { get; set; }  
            /// The standard list page size.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Lists operations that match the specified filter in the request. If theserver doesn't support this method, it returns `UNIMPLEMENTED`.NOTE: the `name` binding allows API services to override the bindingto use different resource name schemes, such as `users/*/operations`. Tooverride the binding, API services can add a binding such as`"/v1/{name=users/*}/operations"` to their service configuration.For backwards compatibility, the default name includes the operationscollection id, however overriding users must ensure the name bindingis the parent resource, without the operations collection id. 
        /// Documentation https://developers.google.com/cloudfunctions/v1beta2/reference/operations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudfunctions service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListOperationsResponseResponse</returns>
        public static ListOperationsResponse List(CloudfunctionsService service, OperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Operations.List();

                // Applying optional parameters to the request.                
                request = (OperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.List failed.", ex);
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