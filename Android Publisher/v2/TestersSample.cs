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
// Unoffical sample for the Androidpublisher v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets Android application developers access their Google Play accounts.
// API Documentation Link https://developers.google.com/android-publisher
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Androidpublisher/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Androidpublisher.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Androidpublisher.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Androidpublisher.v2;
using Google.Apis.Androidpublisher.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Androidpublisherv2.Methods
{
  
    public static class TestersSample
    {


        /// <summary>
        /// NA 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/testers/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <param name="track">NA</param>
        /// <returns>TestersResponse</returns>
        public static Testers Get(AndroidpublisherService service, string packageName, string editId, string track)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);
                if (track == null)
                    throw new ArgumentNullException(track);

                // Make the request.
                return service.Testers.Get(packageName, editId, track).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Testers.Get failed.", ex);
            }
        }

        /// <summary>
        /// NA 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/testers/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <param name="track">NA</param>
        /// <param name="body">A valid Androidpublisher v2 body.</param>
        /// <returns>TestersResponse</returns>
        public static Testers Patch(AndroidpublisherService service, string packageName, string editId, string track, Testers body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);
                if (track == null)
                    throw new ArgumentNullException(track);

                // Make the request.
                return service.Testers.Patch(body, packageName, editId, track).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Testers.Patch failed.", ex);
            }
        }

        /// <summary>
        /// NA 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/testers/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app that is being updated; for example, "com.spiffygame".</param>
        /// <param name="editId">Unique identifier for this edit.</param>
        /// <param name="track">NA</param>
        /// <param name="body">A valid Androidpublisher v2 body.</param>
        /// <returns>TestersResponse</returns>
        public static Testers Update(AndroidpublisherService service, string packageName, string editId, string track, Testers body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (editId == null)
                    throw new ArgumentNullException(editId);
                if (track == null)
                    throw new ArgumentNullException(track);

                // Make the request.
                return service.Testers.Update(body, packageName, editId, track).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Testers.Update failed.", ex);
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