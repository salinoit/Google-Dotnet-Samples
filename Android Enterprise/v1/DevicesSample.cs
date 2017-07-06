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
//     Build date: 07/06/2017 15:31:13
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Androidenterprise v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages the deployment of apps to Android for Work users.
// API Documentation Link https://developers.google.com/android/work/play/emm-api
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Androidenterprise/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Androidenterprise.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Androidenterprise.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Androidenterprise.v1;
using Google.Apis.Androidenterprise.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Androidenterprisev1.Methods
{
  
    public static class DevicesSample
    {


        /// <summary>
        /// Retrieves the details of a device. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/devices/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        /// <returns>DeviceResponse</returns>
        public static Device Get(AndroidenterpriseService service, string enterpriseId, string userId, string deviceId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (deviceId == null)
                    throw new ArgumentNullException(deviceId);

                // Make the request.
                return service.Devices.Get(enterpriseId, userId, deviceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Devices.Get failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves whether a device's access to Google services is enabled or disabled. The device state takes effect only if enforcing EMM policies on Android devices is enabled in the Google Admin Console. Otherwise, the device state is ignored and all devices are allowed access to Google services. This is only supported for Google-managed users. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/devices/getState
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        /// <returns>DeviceStateResponse</returns>
        public static DeviceState GetState(AndroidenterpriseService service, string enterpriseId, string userId, string deviceId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (deviceId == null)
                    throw new ArgumentNullException(deviceId);

                // Make the request.
                return service.Devices.GetState(enterpriseId, userId, deviceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Devices.GetState failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the IDs of all of a user's devices. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/devices/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>DevicesListResponseResponse</returns>
        public static DevicesListResponse List(AndroidenterpriseService service, string enterpriseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Devices.List(enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Devices.List failed.", ex);
            }
        }

        /// <summary>
        /// Sets whether a device's access to Google services is enabled or disabled. The device state takes effect only if enforcing EMM policies on Android devices is enabled in the Google Admin Console. Otherwise, the device state is ignored and all devices are allowed access to Google services. This is only supported for Google-managed users. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/devices/setState
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="deviceId">The ID of the device.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>DeviceStateResponse</returns>
        public static DeviceState SetState(AndroidenterpriseService service, string enterpriseId, string userId, string deviceId, DeviceState body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (deviceId == null)
                    throw new ArgumentNullException(deviceId);

                // Make the request.
                return service.Devices.SetState(body, enterpriseId, userId, deviceId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Devices.SetState failed.", ex);
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