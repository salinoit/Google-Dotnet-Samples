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
// Unoffical sample for the Cloudoslogin v1alpha API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: A Google Cloud API for managing OS login configuration for Directory API users.
// API Documentation Link https://developers.google.com/apis-explorer/#p/oslogin/v1alpha/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudoslogin/v1alpha/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudoslogin.v1alpha/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudoslogin.v1alpha
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudoslogin.v1alpha;
using Google.Apis.Cloudoslogin.v1alpha.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudosloginv1alpha.Methods
{
  
    public static class SshPublicKeysSample
    {


        /// <summary>
        /// Deletes an SSH public key. 
        /// Documentation https://developers.google.com/cloudoslogin/v1alpha/reference/sshPublicKeys/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudoslogin service.</param>  
        /// <param name="name">The fingerprint of the public key to update. Public keys are identified bytheir SHA-256 fingerprint. The fingerprint of the public key is in format`users/{user}/sshPublicKeys/{fingerprint}`.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(CloudosloginService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.SshPublicKeys.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SshPublicKeys.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves an SSH public key. 
        /// Documentation https://developers.google.com/cloudoslogin/v1alpha/reference/sshPublicKeys/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudoslogin service.</param>  
        /// <param name="name">The fingerprint of the public key to retrieve. Public keys are identifiedby their SHA-256 fingerprint. The fingerprint of the public key is informat `users/{user}/sshPublicKeys/{fingerprint}`.</param>
        /// <returns>SshPublicKeyResponse</returns>
        public static SshPublicKey Get(CloudosloginService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.SshPublicKeys.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SshPublicKeys.Get failed.", ex);
            }
        }
        public class SshPublicKeysPatchOptionalParms
        {
            /// Mask to control which fields get updated. Updates all if not present.
            public string UpdateMask { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an SSH public key and returns the profile information. This methodsupports patch semantics. 
        /// Documentation https://developers.google.com/cloudoslogin/v1alpha/reference/sshPublicKeys/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudoslogin service.</param>  
        /// <param name="name">The fingerprint of the public key to update. Public keys are identified bytheir SHA-256 fingerprint. The fingerprint of the public key is in format`users/{user}/sshPublicKeys/{fingerprint}`.</param>
        /// <param name="body">A valid Cloudoslogin v1alpha body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>SshPublicKeyResponse</returns>
        public static SshPublicKey Patch(CloudosloginService service, string name, SshPublicKey body, SshPublicKeysPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.SshPublicKeys.Patch(body, name);

                // Applying optional parameters to the request.                
                request = (SshPublicKeysResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SshPublicKeys.Patch failed.", ex);
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