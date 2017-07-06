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
// Unoffical sample for the Storage v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Stores and retrieves potentially large, immutable data objects.
// API Documentation Link https://developers.google.com/storage/docs/json_api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Storage/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Storage.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Storage.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Storage.v1;
using Google.Apis.Storage.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Storagev1.Methods
{
  
    public static class BucketAccessControlsSample
    {

        public class BucketAccessControlsDeleteOptionalParms
        {
            /// The project to be billed for this request, for Requester Pays buckets.
            public string UserProject { get; set; }  
        
        }
 
        /// <summary>
        /// Permanently deletes the ACL entry for the specified entity on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/bucketAccessControls/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(StorageService service, string bucket, string entity, BucketAccessControlsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.BucketAccessControls.Delete(bucket, entity);

                // Applying optional parameters to the request.                
                request = (BucketAccessControlsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BucketAccessControls.Delete failed.", ex);
            }
        }
        public class BucketAccessControlsGetOptionalParms
        {
            /// The project to be billed for this request, for Requester Pays buckets.
            public string UserProject { get; set; }  
        
        }
 
        /// <summary>
        /// Returns the ACL entry for the specified entity on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/bucketAccessControls/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>BucketAccessControlResponse</returns>
        public static BucketAccessControl Get(StorageService service, string bucket, string entity, BucketAccessControlsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.BucketAccessControls.Get(bucket, entity);

                // Applying optional parameters to the request.                
                request = (BucketAccessControlsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BucketAccessControls.Get failed.", ex);
            }
        }
        public class BucketAccessControlsInsertOptionalParms
        {
            /// The project to be billed for this request, for Requester Pays buckets.
            public string UserProject { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a new ACL entry on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/bucketAccessControls/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="body">A valid Storage v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>BucketAccessControlResponse</returns>
        public static BucketAccessControl Insert(StorageService service, string bucket, BucketAccessControl body, BucketAccessControlsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.BucketAccessControls.Insert(body, bucket);

                // Applying optional parameters to the request.                
                request = (BucketAccessControlsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BucketAccessControls.Insert failed.", ex);
            }
        }
        public class BucketAccessControlsListOptionalParms
        {
            /// The project to be billed for this request, for Requester Pays buckets.
            public string UserProject { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves ACL entries on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/bucketAccessControls/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>BucketAccessControlsResponse</returns>
        public static BucketAccessControls List(StorageService service, string bucket, BucketAccessControlsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.BucketAccessControls.List(bucket);

                // Applying optional parameters to the request.                
                request = (BucketAccessControlsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BucketAccessControls.List failed.", ex);
            }
        }
        public class BucketAccessControlsPatchOptionalParms
        {
            /// The project to be billed for this request, for Requester Pays buckets.
            public string UserProject { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an ACL entry on the specified bucket. This method supports patch semantics. 
        /// Documentation https://developers.google.com/storage/v1/reference/bucketAccessControls/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="body">A valid Storage v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>BucketAccessControlResponse</returns>
        public static BucketAccessControl Patch(StorageService service, string bucket, string entity, BucketAccessControl body, BucketAccessControlsPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.BucketAccessControls.Patch(body, bucket, entity);

                // Applying optional parameters to the request.                
                request = (BucketAccessControlsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BucketAccessControls.Patch failed.", ex);
            }
        }
        public class BucketAccessControlsUpdateOptionalParms
        {
            /// The project to be billed for this request, for Requester Pays buckets.
            public string UserProject { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an ACL entry on the specified bucket. 
        /// Documentation https://developers.google.com/storage/v1/reference/bucketAccessControls/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of a bucket.</param>
        /// <param name="entity">The entity holding the permission. Can be user-userId, user-emailAddress, group-groupId, group-emailAddress, allUsers, or allAuthenticatedUsers.</param>
        /// <param name="body">A valid Storage v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>BucketAccessControlResponse</returns>
        public static BucketAccessControl Update(StorageService service, string bucket, string entity, BucketAccessControl body, BucketAccessControlsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (entity == null)
                    throw new ArgumentNullException(entity);

                // Building the initial request.
                var request = service.BucketAccessControls.Update(body, bucket, entity);

                // Applying optional parameters to the request.                
                request = (BucketAccessControlsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BucketAccessControls.Update failed.", ex);
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