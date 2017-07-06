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
// Unoffical sample for the Tagmanager v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses Tag Manager accounts and containers.
// API Documentation Link https://developers.google.com/tag-manager/api/v1/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Tagmanager/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Tagmanager.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Tagmanager.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Tagmanager.v1;
using Google.Apis.Tagmanager.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Tagmanagerv1.Methods
{
  
    public static class VersionsSample
    {


        /// <summary>
        /// Creates a Container Version. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="body">A valid Tagmanager v1 body.</param>
        /// <returns>CreateContainerVersionResponseResponse</returns>
        public static CreateContainerVersionResponse Create(TagmanagerService service, string accountId, string containerId, CreateContainerVersionRequestVersionOptions body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);

                // Make the request.
                return service.Versions.Create(body, accountId, containerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.Create failed.", ex);
            }
        }

        /// <summary>
        /// Deletes a Container Version. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="containerVersionId">The GTM Container Version ID.</param>
        public static void Delete(TagmanagerService service, string accountId, string containerId, string containerVersionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);
                if (containerVersionId == null)
                    throw new ArgumentNullException(containerVersionId);

                // Make the request.
                 service.Versions.Delete(accountId, containerId, containerVersionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets a Container Version. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="containerVersionId">The GTM Container Version ID. Specify published to retrieve the currently published version.</param>
        /// <returns>ContainerVersionResponse</returns>
        public static ContainerVersion Get(TagmanagerService service, string accountId, string containerId, string containerVersionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);
                if (containerVersionId == null)
                    throw new ArgumentNullException(containerVersionId);

                // Make the request.
                return service.Versions.Get(accountId, containerId, containerVersionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.Get failed.", ex);
            }
        }
        public class VersionsListOptionalParms
        {
            /// Retrieve headers only when true.
            public bool? Headers { get; set; }  
            /// Also retrieve deleted (archived) versions when true.
            public bool? IncludeDeleted { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all Container Versions of a GTM Container. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListContainerVersionsResponseResponse</returns>
        public static ListContainerVersionsResponse List(TagmanagerService service, string accountId, string containerId, VersionsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);

                // Building the initial request.
                var request = service.Versions.List(accountId, containerId);

                // Applying optional parameters to the request.                
                request = (VersionsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.List failed.", ex);
            }
        }
        public class VersionsPublishOptionalParms
        {
            /// When provided, this fingerprint must match the fingerprint of the container version in storage.
            public string Fingerprint { get; set; }  
        
        }
 
        /// <summary>
        /// Publishes a Container Version. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/publish
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="containerVersionId">The GTM Container Version ID.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PublishContainerVersionResponseResponse</returns>
        public static PublishContainerVersionResponse Publish(TagmanagerService service, string accountId, string containerId, string containerVersionId, VersionsPublishOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);
                if (containerVersionId == null)
                    throw new ArgumentNullException(containerVersionId);

                // Building the initial request.
                var request = service.Versions.Publish(accountId, containerId, containerVersionId);

                // Applying optional parameters to the request.                
                request = (VersionsResource.PublishRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.Publish failed.", ex);
            }
        }

        /// <summary>
        /// Restores a Container Version. This will overwrite the container's current configuration (including its variables, triggers and tags). The operation will not have any effect on the version that is being served (i.e. the published version). 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/restore
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="containerVersionId">The GTM Container Version ID.</param>
        /// <returns>ContainerVersionResponse</returns>
        public static ContainerVersion Restore(TagmanagerService service, string accountId, string containerId, string containerVersionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);
                if (containerVersionId == null)
                    throw new ArgumentNullException(containerVersionId);

                // Make the request.
                return service.Versions.Restore(accountId, containerId, containerVersionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.Restore failed.", ex);
            }
        }

        /// <summary>
        /// Undeletes a Container Version. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/undelete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="containerVersionId">The GTM Container Version ID.</param>
        /// <returns>ContainerVersionResponse</returns>
        public static ContainerVersion Undelete(TagmanagerService service, string accountId, string containerId, string containerVersionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);
                if (containerVersionId == null)
                    throw new ArgumentNullException(containerVersionId);

                // Make the request.
                return service.Versions.Undelete(accountId, containerId, containerVersionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.Undelete failed.", ex);
            }
        }
        public class VersionsUpdateOptionalParms
        {
            /// When provided, this fingerprint must match the fingerprint of the container version in storage.
            public string Fingerprint { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a Container Version. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/versions/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="containerId">The GTM Container ID.</param>
        /// <param name="containerVersionId">The GTM Container Version ID.</param>
        /// <param name="body">A valid Tagmanager v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ContainerVersionResponse</returns>
        public static ContainerVersion Update(TagmanagerService service, string accountId, string containerId, string containerVersionId, ContainerVersion body, VersionsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (containerId == null)
                    throw new ArgumentNullException(containerId);
                if (containerVersionId == null)
                    throw new ArgumentNullException(containerVersionId);

                // Building the initial request.
                var request = service.Versions.Update(body, accountId, containerId, containerVersionId);

                // Applying optional parameters to the request.                
                request = (VersionsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Versions.Update failed.", ex);
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