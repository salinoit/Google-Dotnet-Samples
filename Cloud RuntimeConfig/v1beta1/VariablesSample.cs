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
// Unoffical sample for the Cloudruntimeconfig v1beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Runtime Configurator allows you to dynamically configure and expose variables through Google Cloud Platform. In addition, you can also set Watchers and Waiters that will watch for changes to your data and return based on certain conditions.
// API Documentation Link https://cloud.google.com/deployment-manager/runtime-configurator/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudruntimeconfig/v1beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudruntimeconfig.v1beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudruntimeconfig.v1beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudruntimeconfig.v1beta1;
using Google.Apis.Cloudruntimeconfig.v1beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudruntimeconfigv1beta1.Methods
{
  
    public static class VariablesSample
    {


        /// <summary>
        /// Returns permissions that a caller has on the specified resource.If the resource does not exist, this will return an empty set ofpermissions, not a NOT_FOUND error.Note: This operation is designed to be used for building permission-awareUIs and command-line tools, not for authorization checking. This operationmay "fail open" without warning. 
        /// Documentation https://developers.google.com/cloudruntimeconfig/v1beta1/reference/variables/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudruntimeconfig service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Cloudruntimeconfig v1beta1 body.</param>
        /// <returns>TestIamPermissionsResponseResponse</returns>
        public static TestIamPermissionsResponse TestIamPermissions(CloudruntimeconfigService service, string resource, TestIamPermissionsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Variables.TestIamPermissions(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variables.TestIamPermissions failed.", ex);
            }
        }
        public class VariablesDeleteOptionalParms
        {
            /// Set to `true` to recursively delete multiple variables with the sameprefix.
            public bool? Recursive { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a variable or multiple variables.If you specify a variable name, then that variable is deleted. If youspecify a prefix and `recursive` is true, then all variables with thatprefix are deleted. You must set a `recursive` to true if you deletevariables by prefix. 
        /// Documentation https://developers.google.com/cloudruntimeconfig/v1beta1/reference/variables/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudruntimeconfig service.</param>  
        /// <param name="name">The name of the variable to delete, in the format:`projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIABLE_NAME]`</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(CloudruntimeconfigService service, string name, VariablesDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Variables.Delete(name);

                // Applying optional parameters to the request.                
                request = (VariablesResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variables.Delete failed.", ex);
            }
        }
        public class VariablesListOptionalParms
        {
            /// Filters variables by matching the specified filter. For example:`projects/example-project/config/[CONFIG_NAME]/variables/example-variable`.
            public string Filter { get; set; }  
            /// Specifies a page token to use. Set `pageToken` to a `nextPageToken`returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
            /// The flag indicates whether the user wants to return values of variables.If true, then only those variables that user has IAM GetVariable permissionwill be returned along with their values.
            public bool? ReturnValues { get; set; }  
            /// Specifies the number of results to return per page. If there are fewerelements than the specified number, returns all elements.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Lists variables within given a configuration, matching any provided filters.This only lists variable names, not the values, unless `return_values` istrue, in which case only variables that user has IAM permission to GetVariablewill be returned. 
        /// Documentation https://developers.google.com/cloudruntimeconfig/v1beta1/reference/variables/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudruntimeconfig service.</param>  
        /// <param name="parent">The path to the RuntimeConfig resource for which you want to list variables.The configuration must exist beforehand; the path must by in the format:`projects/[PROJECT_ID]/configs/[CONFIG_NAME]`</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListVariablesResponseResponse</returns>
        public static ListVariablesResponse List(CloudruntimeconfigService service, string parent, VariablesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (parent == null)
                    throw new ArgumentNullException(parent);

                // Building the initial request.
                var request = service.Variables.List(parent);

                // Applying optional parameters to the request.                
                request = (VariablesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variables.List failed.", ex);
            }
        }
        public class VariablesCreateOptionalParms
        {
            /// An optional but recommended unique `request_id`. If the serverreceives two `create()` requests  with the same`request_id`, then the second request will be ignored and thefirst resource created and stored in the backend is returned.Empty `request_id` fields are ignored.It is responsibility of the client to ensure uniqueness of the`request_id` strings.`request_id` strings are limited to 64 characters.
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a variable within the given configuration. You cannot createa variable with a name that is a prefix of an existing variable name, or aname that has an existing variable name as a prefix.To learn more about creating a variable, read the[Setting and Getting Data](/deployment-manager/runtime-configurator/set-and-get-variables)documentation. 
        /// Documentation https://developers.google.com/cloudruntimeconfig/v1beta1/reference/variables/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudruntimeconfig service.</param>  
        /// <param name="parent">The path to the RutimeConfig resource that this variable should belong to.The configuration must exist beforehand; the path must by in the format:`projects/[PROJECT_ID]/configs/[CONFIG_NAME]`</param>
        /// <param name="body">A valid Cloudruntimeconfig v1beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>VariableResponse</returns>
        public static Variable Create(CloudruntimeconfigService service, string parent, Variable body, VariablesCreateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (parent == null)
                    throw new ArgumentNullException(parent);

                // Building the initial request.
                var request = service.Variables.Create(body, parent);

                // Applying optional parameters to the request.                
                request = (VariablesResource.CreateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variables.Create failed.", ex);
            }
        }

        /// <summary>
        /// Gets information about a single variable. 
        /// Documentation https://developers.google.com/cloudruntimeconfig/v1beta1/reference/variables/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudruntimeconfig service.</param>  
        /// <param name="name">The name of the variable to return, in the format:`projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIBLE_NAME]`</param>
        /// <returns>VariableResponse</returns>
        public static Variable Get(CloudruntimeconfigService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Variables.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variables.Get failed.", ex);
            }
        }

        /// <summary>
        /// Watches a specific variable and waits for a change in the variable's value.When there is a change, this method returns the new value or times out.If a variable is deleted while being watched, the `variableState` state isset to `DELETED` and the method returns the last known variable `value`.If you set the deadline for watching to a larger value than internal timeout(60 seconds), the current variable value is returned and the `variableState`will be `VARIABLE_STATE_UNSPECIFIED`.To learn more about creating a watcher, read the[Watching a Variable for Changes](/deployment-manager/runtime-configurator/watching-a-variable)documentation. 
        /// Documentation https://developers.google.com/cloudruntimeconfig/v1beta1/reference/variables/watch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudruntimeconfig service.</param>  
        /// <param name="name">The name of the variable to watch, in the format:`projects/[PROJECT_ID]/configs/[CONFIG_NAME]`</param>
        /// <param name="body">A valid Cloudruntimeconfig v1beta1 body.</param>
        /// <returns>VariableResponse</returns>
        public static Variable Watch(CloudruntimeconfigService service, string name, WatchVariableRequest body)
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
                return service.Variables.Watch(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variables.Watch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing variable with a new value. 
        /// Documentation https://developers.google.com/cloudruntimeconfig/v1beta1/reference/variables/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudruntimeconfig service.</param>  
        /// <param name="name">The name of the variable to update, in the format:`projects/[PROJECT_ID]/configs/[CONFIG_NAME]/variables/[VARIABLE_NAME]`</param>
        /// <param name="body">A valid Cloudruntimeconfig v1beta1 body.</param>
        /// <returns>VariableResponse</returns>
        public static Variable Update(CloudruntimeconfigService service, string name, Variable body)
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
                return service.Variables.Update(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Variables.Update failed.", ex);
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