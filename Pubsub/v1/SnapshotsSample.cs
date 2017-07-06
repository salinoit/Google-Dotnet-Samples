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
// Unoffical sample for the Pubsub v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Provides reliable, many-to-many, asynchronous messaging between applications.
// API Documentation Link https://cloud.google.com/pubsub/docs
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Pubsub/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Pubsub.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Pubsub.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Pubsub.v1;
using Google.Apis.Pubsub.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Pubsubv1.Methods
{
  
    public static class SnapshotsSample
    {


        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces anyexisting policy. 
        /// Documentation https://developers.google.com/pubsub/v1/reference/snapshots/setIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Pubsub service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy is being specified.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Pubsub v1 body.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy SetIamPolicy(PubsubService service, string resource, SetIamPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Snapshots.SetIamPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Snapshots.SetIamPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.If the resource does not exist, this will return an empty set ofpermissions, not a NOT_FOUND error.Note: This operation is designed to be used for building permission-awareUIs and command-line tools, not for authorization checking. This operationmay "fail open" without warning. 
        /// Documentation https://developers.google.com/pubsub/v1/reference/snapshots/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Pubsub service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Pubsub v1 body.</param>
        /// <returns>TestIamPermissionsResponseResponse</returns>
        public static TestIamPermissionsResponse TestIamPermissions(PubsubService service, string resource, TestIamPermissionsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Snapshots.TestIamPermissions(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Snapshots.TestIamPermissions failed.", ex);
            }
        }

        /// <summary>
        /// Gets the access control policy for a resource.Returns an empty policy if the resource exists and does not have a policyset. 
        /// Documentation https://developers.google.com/pubsub/v1/reference/snapshots/getIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Pubsub service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy is being requested.See the operation documentation for the appropriate value for this field.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy GetIamPolicy(PubsubService service, string resource)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Snapshots.GetIamPolicy(resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Snapshots.GetIamPolicy failed.", ex);
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