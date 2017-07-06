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
  
    public static class InappproductsSample
    {


        /// <summary>
        /// NA 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/inappproducts/batch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="body">A valid Androidpublisher v2 body.</param>
        /// <returns>InappproductsBatchResponseResponse</returns>
        public static InappproductsBatchResponse Batch(AndroidpublisherService service, InappproductsBatchRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Inappproducts.Batch(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Inappproducts.Batch failed.", ex);
            }
        }

        /// <summary>
        /// Delete an in-app product for an app. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/inappproducts/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app with the in-app product; for example, "com.spiffygame".</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        public static void Delete(AndroidpublisherService service, string packageName, string sku)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (sku == null)
                    throw new ArgumentNullException(sku);

                // Make the request.
                 service.Inappproducts.Delete(packageName, sku).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Inappproducts.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Returns information about the in-app product specified. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/inappproducts/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">NA</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        /// <returns>InAppProductResponse</returns>
        public static InAppProduct Get(AndroidpublisherService service, string packageName, string sku)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (sku == null)
                    throw new ArgumentNullException(sku);

                // Make the request.
                return service.Inappproducts.Get(packageName, sku).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Inappproducts.Get failed.", ex);
            }
        }
        public class InappproductsInsertOptionalParms
        {
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this in-app product will be auto converted to the target currency based on the default price. Defaults to false.
            public bool? AutoConvertMissingPrices { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a new in-app product for an app. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/inappproducts/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app; for example, "com.spiffygame".</param>
        /// <param name="body">A valid Androidpublisher v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>InAppProductResponse</returns>
        public static InAppProduct Insert(AndroidpublisherService service, string packageName, InAppProduct body, InappproductsInsertOptionalParms optional = null)
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

                // Building the initial request.
                var request = service.Inappproducts.Insert(body, packageName);

                // Applying optional parameters to the request.                
                request = (InappproductsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Inappproducts.Insert failed.", ex);
            }
        }
        public class InappproductsListOptionalParms
        {
            /// NA
            public int? MaxResults { get; set; }  
            /// NA
            public int? StartIndex { get; set; }  
            /// NA
            public string Token { get; set; }  
        
        }
 
        /// <summary>
        /// List all the in-app products for an Android app, both subscriptions and managed in-app products.. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/inappproducts/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app with in-app products; for example, "com.spiffygame".</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>InappproductsListResponseResponse</returns>
        public static InappproductsListResponse List(AndroidpublisherService service, string packageName, InappproductsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);

                // Building the initial request.
                var request = service.Inappproducts.List(packageName);

                // Applying optional parameters to the request.                
                request = (InappproductsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Inappproducts.List failed.", ex);
            }
        }
        public class InappproductsPatchOptionalParms
        {
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this in-app product will be auto converted to the target currency based on the default price. Defaults to false.
            public bool? AutoConvertMissingPrices { get; set; }  
        
        }
 
        /// <summary>
        /// Updates the details of an in-app product. This method supports patch semantics. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/inappproducts/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app with the in-app product; for example, "com.spiffygame".</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        /// <param name="body">A valid Androidpublisher v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>InAppProductResponse</returns>
        public static InAppProduct Patch(AndroidpublisherService service, string packageName, string sku, InAppProduct body, InappproductsPatchOptionalParms optional = null)
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
                if (sku == null)
                    throw new ArgumentNullException(sku);

                // Building the initial request.
                var request = service.Inappproducts.Patch(body, packageName, sku);

                // Applying optional parameters to the request.                
                request = (InappproductsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Inappproducts.Patch failed.", ex);
            }
        }
        public class InappproductsUpdateOptionalParms
        {
            /// If true the prices for all regions targeted by the parent app that don't have a price specified for this in-app product will be auto converted to the target currency based on the default price. Defaults to false.
            public bool? AutoConvertMissingPrices { get; set; }  
        
        }
 
        /// <summary>
        /// Updates the details of an in-app product. 
        /// Documentation https://developers.google.com/androidpublisher/v2/reference/inappproducts/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">Unique identifier for the Android app with the in-app product; for example, "com.spiffygame".</param>
        /// <param name="sku">Unique identifier for the in-app product.</param>
        /// <param name="body">A valid Androidpublisher v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>InAppProductResponse</returns>
        public static InAppProduct Update(AndroidpublisherService service, string packageName, string sku, InAppProduct body, InappproductsUpdateOptionalParms optional = null)
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
                if (sku == null)
                    throw new ArgumentNullException(sku);

                // Building the initial request.
                var request = service.Inappproducts.Update(body, packageName, sku);

                // Applying optional parameters to the request.                
                request = (InappproductsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Inappproducts.Update failed.", ex);
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