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
// Unoffical sample for the Drive v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Drive/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Drive.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Drive.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Drivev2.Methods
{
  
    public static class ChildrenSample
    {


        /// <summary>
        /// Removes a child from a folder. 
        /// Documentation https://developers.google.com/drive/v2/reference/children/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="folderId">The ID of the folder.</param>
        /// <param name="childId">The ID of the child.</param>
        public static void Delete(DriveService service, string folderId, string childId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (folderId == null)
                    throw new ArgumentNullException(folderId);
                if (childId == null)
                    throw new ArgumentNullException(childId);

                // Make the request.
                 service.Children.Delete(folderId, childId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Children.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets a specific child reference. 
        /// Documentation https://developers.google.com/drive/v2/reference/children/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="folderId">The ID of the folder.</param>
        /// <param name="childId">The ID of the child.</param>
        /// <returns>ChildReferenceResponse</returns>
        public static ChildReference Get(DriveService service, string folderId, string childId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (folderId == null)
                    throw new ArgumentNullException(folderId);
                if (childId == null)
                    throw new ArgumentNullException(childId);

                // Make the request.
                return service.Children.Get(folderId, childId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Children.Get failed.", ex);
            }
        }
        public class ChildrenInsertOptionalParms
        {
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Inserts a file into a folder. 
        /// Documentation https://developers.google.com/drive/v2/reference/children/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="folderId">The ID of the folder.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChildReferenceResponse</returns>
        public static ChildReference Insert(DriveService service, string folderId, ChildReference body, ChildrenInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (folderId == null)
                    throw new ArgumentNullException(folderId);

                // Building the initial request.
                var request = service.Children.Insert(body, folderId);

                // Applying optional parameters to the request.                
                request = (ChildrenResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Children.Insert failed.", ex);
            }
        }
        public class ChildrenListOptionalParms
        {
            /// Maximum number of children to return.
            public int? MaxResults { get; set; }  
            /// A comma-separated list of sort keys. Valid keys are 'createdDate', 'folder', 'lastViewedByMeDate', 'modifiedByMeDate', 'modifiedDate', 'quotaBytesUsed', 'recency', 'sharedWithMeDate', 'starred', and 'title'. Each key sorts ascending by default, but may be reversed with the 'desc' modifier. Example usage: ?orderBy=folder,modifiedDate desc,title. Please note that there is a current limitation for users with approximately one million files in which the requested sort order is ignored.
            public string OrderBy { get; set; }  
            /// Page token for children.
            public string PageToken { get; set; }  
            /// Query string for searching children.
            public string Q { get; set; }  
        
        }
 
        /// <summary>
        /// Lists a folder's children. 
        /// Documentation https://developers.google.com/drive/v2/reference/children/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="folderId">The ID of the folder.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChildListResponse</returns>
        public static ChildList List(DriveService service, string folderId, ChildrenListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (folderId == null)
                    throw new ArgumentNullException(folderId);

                // Building the initial request.
                var request = service.Children.List(folderId);

                // Applying optional parameters to the request.                
                request = (ChildrenResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Children.List failed.", ex);
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