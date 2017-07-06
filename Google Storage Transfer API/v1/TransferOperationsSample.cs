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
// Unoffical sample for the Storagetransfer v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Transfers data from external data sources to a Google Cloud Storage bucket or between Google Cloud Storage buckets.
// API Documentation Link https://cloud.google.com/storage/transfer
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Storagetransfer/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Storagetransfer.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Storagetransfer.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Storagetransfer.v1;
using Google.Apis.Storagetransfer.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Storagetransferv1.Methods
{
  
    public static class TransferOperationsSample
    {


        /// <summary>
        /// Pauses a transfer operation. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/pause
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storagetransfer service.</param>  
        /// <param name="name">The name of the transfer operation.Required.</param>
        /// <param name="body">A valid Storagetransfer v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Pause(StoragetransferService service, string name, PauseTransferOperationRequest body)
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

                // Make the request.
                return service.TransferOperations.Pause(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Pause failed.", ex);
            }
        }

        /// <summary>
        /// This method is not supported and the server returns `UNIMPLEMENTED`. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storagetransfer service.</param>  
        /// <param name="name">The name of the operation resource to be deleted.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(StoragetransferService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.TransferOperations.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Delete failed.", ex);
            }
        }
        public class TransferOperationsListOptionalParms
        {
            /// The list page token.
            public string PageToken { get; set; }  
            /// The list page size. The max allowed value is 256.
            public int? PageSize { get; set; }  
            /// A list of query parameters specified as JSON text in the form of {\"project_id\" : \"my_project_id\", \"job_names\" : [\"jobid1\", \"jobid2\",...], \"operation_names\" : [\"opid1\", \"opid2\",...], \"transfer_statuses\":[\"status1\", \"status2\",...]}. Since `job_names`, `operation_names`, and `transfer_statuses` support multiple values, they must be specified with array notation. `job_names`, `operation_names`, and `transfer_statuses` are optional.
            public string Filter { get; set; }  
        
        }
 
        /// <summary>
        /// Lists operations that match the specified filter in the request. If theserver doesn't support this method, it returns `UNIMPLEMENTED`.NOTE: the `name` binding allows API services to override the bindingto use different resource name schemes, such as `users/*/operations`. Tooverride the binding, API services can add a binding such as`"/v1/{name=users/*}/operations"` to their service configuration.For backwards compatibility, the default name includes the operationscollection id, however overriding users must ensure the name bindingis the parent resource, without the operations collection id. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storagetransfer service.</param>  
        /// <param name="name">The value `transferOperations`.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListOperationsResponseResponse</returns>
        public static ListOperationsResponse List(StoragetransferService service, string name, TransferOperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.TransferOperations.List(name);

                // Applying optional parameters to the request.                
                request = (TransferOperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.List failed.", ex);
            }
        }

        /// <summary>
        /// Resumes a transfer operation that is paused. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/resume
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storagetransfer service.</param>  
        /// <param name="name">The name of the transfer operation.Required.</param>
        /// <param name="body">A valid Storagetransfer v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Resume(StoragetransferService service, string name, ResumeTransferOperationRequest body)
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

                // Make the request.
                return service.TransferOperations.Resume(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Resume failed.", ex);
            }
        }

        /// <summary>
        /// Cancels a transfer. Use the get method to check whether the cancellation succeeded or whether the operation completed despite cancellation. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storagetransfer service.</param>  
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Cancel(StoragetransferService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.TransferOperations.Cancel(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Cancel failed.", ex);
            }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use thismethod to poll the operation result at intervals as recommended by the APIservice. 
        /// Documentation https://developers.google.com/storagetransfer/v1/reference/transferOperations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storagetransfer service.</param>  
        /// <param name="name">The name of the operation resource.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(StoragetransferService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.TransferOperations.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TransferOperations.Get failed.", ex);
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