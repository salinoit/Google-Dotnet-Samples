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
//     Build date: 07/06/2017 15:31:12
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Directory directory_v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Admin SDK Directory API lets you view and manage enterprise resources such as users and groups, administrative notifications, security features, and more.
// API Documentation Link https://developers.google.com/admin-sdk/directory/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Directory/directory_v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Directory.directory_v1/ 
// Install Command: PM>  Install-Package Google.Apis.Directory.directory_v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Directory.directory_v1;
using Google.Apis.Directory.directory_v1.Data;
using System;

namespace GoogleSamplecSharpSample.Directorydirectory_v1.Methods
{
  
    public static class ChromeosdevicesSample
    {


        /// <summary>
        /// Take action on Chrome OS Device 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/chromeosdevices/action
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="resourceId">Immutable ID of Chrome OS Device</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        public static void Action(DirectoryService service, string customerId, string resourceId, ChromeOsDeviceAction body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (resourceId == null)
                    throw new ArgumentNullException(resourceId);

                // Make the request.
                 service.Chromeosdevices.Action(body, customerId, resourceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Chromeosdevices.Action failed.", ex);
            }
        }
        public class ChromeosdevicesGetOptionalParms
        {
            /// Restrict information returned to a set of selected fields.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieve Chrome OS Device 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/chromeosdevices/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="deviceId">Immutable ID of Chrome OS Device</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChromeOsDeviceResponse</returns>
        public static ChromeOsDevice Get(DirectoryService service, string customerId, string deviceId, ChromeosdevicesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (deviceId == null)
                    throw new ArgumentNullException(deviceId);

                // Building the initial request.
                var request = service.Chromeosdevices.Get(customerId, deviceId);

                // Applying optional parameters to the request.                
                request = (ChromeosdevicesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Chromeosdevices.Get failed.", ex);
            }
        }
        public class ChromeosdevicesListOptionalParms
        {
            /// Maximum number of results to return. Default is 100
            public int? MaxResults { get; set; }  
            /// Column to use for sorting results
            public string OrderBy { get; set; }  
            /// Full path of the organization unit or its Id
            public string OrgUnitPath { get; set; }  
            /// Token to specify next page in the list
            public string PageToken { get; set; }  
            /// Restrict information returned to a set of selected fields.
            public string Projection { get; set; }  
            /// Search string in the format given at http://support.google.com/chromeos/a/bin/answer.py?hl=en&answer=1698333
            public string Query { get; set; }  
            /// Whether to return results in ascending or descending order. Only of use when orderBy is also used
            public string SortOrder { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieve all Chrome OS Devices of a customer (paginated) 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/chromeosdevices/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChromeOsDevicesResponse</returns>
        public static ChromeOsDevices List(DirectoryService service, string customerId, ChromeosdevicesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);

                // Building the initial request.
                var request = service.Chromeosdevices.List(customerId);

                // Applying optional parameters to the request.                
                request = (ChromeosdevicesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Chromeosdevices.List failed.", ex);
            }
        }
        public class ChromeosdevicesPatchOptionalParms
        {
            /// Restrict information returned to a set of selected fields.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Update Chrome OS Device. This method supports patch semantics. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/chromeosdevices/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="deviceId">Immutable ID of Chrome OS Device</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChromeOsDeviceResponse</returns>
        public static ChromeOsDevice Patch(DirectoryService service, string customerId, string deviceId, ChromeOsDevice body, ChromeosdevicesPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (deviceId == null)
                    throw new ArgumentNullException(deviceId);

                // Building the initial request.
                var request = service.Chromeosdevices.Patch(body, customerId, deviceId);

                // Applying optional parameters to the request.                
                request = (ChromeosdevicesResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Chromeosdevices.Patch failed.", ex);
            }
        }
        public class ChromeosdevicesUpdateOptionalParms
        {
            /// Restrict information returned to a set of selected fields.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Update Chrome OS Device 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/chromeosdevices/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="deviceId">Immutable ID of Chrome OS Device</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChromeOsDeviceResponse</returns>
        public static ChromeOsDevice Update(DirectoryService service, string customerId, string deviceId, ChromeOsDevice body, ChromeosdevicesUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);
                if (deviceId == null)
                    throw new ArgumentNullException(deviceId);

                // Building the initial request.
                var request = service.Chromeosdevices.Update(body, customerId, deviceId);

                // Applying optional parameters to the request.                
                request = (ChromeosdevicesResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Chromeosdevices.Update failed.", ex);
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