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
  
    public static class PermissionsSample
    {


        /// <summary>
        /// Creates a user's Account & Container Permissions. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/permissions/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="body">A valid Tagmanager v1 body.</param>
        /// <returns>UserAccessResponse</returns>
        public static UserAccess Create(TagmanagerService service, string accountId, UserAccess body)
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

                // Make the request.
                return service.Permissions.Create(body, accountId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Create failed.", ex);
            }
        }

        /// <summary>
        /// Removes a user from the account, revoking access to it and all of its containers. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/permissions/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="permissionId">The GTM User ID.</param>
        public static void Delete(TagmanagerService service, string accountId, string permissionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (permissionId == null)
                    throw new ArgumentNullException(permissionId);

                // Make the request.
                 service.Permissions.Delete(accountId, permissionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets a user's Account & Container Permissions. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/permissions/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="permissionId">The GTM User ID.</param>
        /// <returns>UserAccessResponse</returns>
        public static UserAccess Get(TagmanagerService service, string accountId, string permissionId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (permissionId == null)
                    throw new ArgumentNullException(permissionId);

                // Make the request.
                return service.Permissions.Get(accountId, permissionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Get failed.", ex);
            }
        }

        /// <summary>
        /// List all users that have access to the account along with Account and Container Permissions granted to each of them. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/permissions/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID. @required tagmanager.accounts.permissions.list</param>
        /// <returns>ListAccountUsersResponseResponse</returns>
        public static ListAccountUsersResponse List(TagmanagerService service, string accountId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);

                // Make the request.
                return service.Permissions.List(accountId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates a user's Account & Container Permissions. 
        /// Documentation https://developers.google.com/tagmanager/v1/reference/permissions/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Tagmanager service.</param>  
        /// <param name="accountId">The GTM Account ID.</param>
        /// <param name="permissionId">The GTM User ID.</param>
        /// <param name="body">A valid Tagmanager v1 body.</param>
        /// <returns>UserAccessResponse</returns>
        public static UserAccess Update(TagmanagerService service, string accountId, string permissionId, UserAccess body)
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
                if (permissionId == null)
                    throw new ArgumentNullException(permissionId);

                // Make the request.
                return service.Permissions.Update(body, accountId, permissionId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Update failed.", ex);
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