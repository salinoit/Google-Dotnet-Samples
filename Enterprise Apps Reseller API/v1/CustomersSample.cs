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
// Unoffical sample for the Reseller v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and manages your customers and their subscriptions.
// API Documentation Link https://developers.google.com/google-apps/reseller/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Reseller/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Reseller.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Reseller.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Reseller.v1;
using Google.Apis.Reseller.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Resellerv1.Methods
{
  
    public static class CustomersSample
    {


        /// <summary>
        /// Get a customer account. 
        /// Documentation https://developers.google.com/reseller/v1/reference/customers/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Reseller service.</param>  
        /// <param name="customerId">Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we do not recommend using a customerId as a key for persistent data. If the domain name for a customerId is changed, the Google system automatically updates.</param>
        /// <returns>CustomerResponse</returns>
        public static Customer Get(ResellerService service, string customerId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customerId == null)
                    throw new ArgumentNullException(customerId);

                // Make the request.
                return service.Customers.Get(customerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Customers.Get failed.", ex);
            }
        }
        public class CustomersInsertOptionalParms
        {
            /// The customerAuthToken query string is required when creating a resold account that transfers a direct customer's subscription or transfers another reseller customer's subscription to your reseller management. This is a hexadecimal authentication token needed to complete the subscription transfer. For more information, see the administrator help center.
            public string CustomerAuthToken { get; set; }  
        
        }
 
        /// <summary>
        /// Order a new customer's account. 
        /// Documentation https://developers.google.com/reseller/v1/reference/customers/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Reseller service.</param>  
        /// <param name="body">A valid Reseller v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CustomerResponse</returns>
        public static Customer Insert(ResellerService service, Customer body, CustomersInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Customers.Insert(body);

                // Applying optional parameters to the request.                
                request = (CustomersResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Customers.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Update a customer account's settings. This method supports patch semantics. 
        /// Documentation https://developers.google.com/reseller/v1/reference/customers/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Reseller service.</param>  
        /// <param name="customerId">Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we do not recommend using a customerId as a key for persistent data. If the domain name for a customerId is changed, the Google system automatically updates.</param>
        /// <param name="body">A valid Reseller v1 body.</param>
        /// <returns>CustomerResponse</returns>
        public static Customer Patch(ResellerService service, string customerId, Customer body)
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

                // Make the request.
                return service.Customers.Patch(body, customerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Customers.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Update a customer account's settings. 
        /// Documentation https://developers.google.com/reseller/v1/reference/customers/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Reseller service.</param>  
        /// <param name="customerId">Either the customer's primary domain name or the customer's unique identifier. If using the domain name, we do not recommend using a customerId as a key for persistent data. If the domain name for a customerId is changed, the Google system automatically updates.</param>
        /// <param name="body">A valid Reseller v1 body.</param>
        /// <returns>CustomerResponse</returns>
        public static Customer Update(ResellerService service, string customerId, Customer body)
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

                // Make the request.
                return service.Customers.Update(body, customerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Customers.Update failed.", ex);
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