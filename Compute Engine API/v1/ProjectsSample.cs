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
//     Build date: 07/06/2017 15:31:17
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Compute v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and runs virtual machines on Google Cloud Platform.
// API Documentation Link https://developers.google.com/compute/docs/reference/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Compute/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Compute.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Compute.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Compute.v1;
using Google.Apis.Compute.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Computev1.Methods
{
  
    public static class ProjectsSample
    {


        /// <summary>
        /// Disable this project as an XPN host project. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/disableXpnHost
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <returns>OperationResponse</returns>
        public static Operation DisableXpnHost(ComputeService service, string project)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.DisableXpnHost(project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.DisableXpnHost failed.", ex);
            }
        }

        /// <summary>
        /// Disable an XPN resource associated with this host project. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/disableXpnResource
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation DisableXpnResource(ComputeService service, string project, ProjectsDisableXpnResourceRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.DisableXpnResource(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.DisableXpnResource failed.", ex);
            }
        }

        /// <summary>
        /// Enable this project as an XPN host project. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/enableXpnHost
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <returns>OperationResponse</returns>
        public static Operation EnableXpnHost(ComputeService service, string project)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.EnableXpnHost(project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.EnableXpnHost failed.", ex);
            }
        }

        /// <summary>
        /// Enable XPN resource (a.k.a service project or service folder in the future) for a host project, so that subnetworks in the host project can be used by instances in the service project or folder. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/enableXpnResource
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation EnableXpnResource(ComputeService service, string project, ProjectsEnableXpnResourceRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.EnableXpnResource(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.EnableXpnResource failed.", ex);
            }
        }

        /// <summary>
        /// Returns the specified Project resource. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <returns>ProjectResponse</returns>
        public static Project Get(ComputeService service, string project)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.Get(project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Get failed.", ex);
            }
        }

        /// <summary>
        /// Get the XPN host project that this project links to. May be empty if no link exists. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/getXpnHost
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <returns>ProjectResponse</returns>
        public static Project GetXpnHost(ComputeService service, string project)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.GetXpnHost(project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.GetXpnHost failed.", ex);
            }
        }
        public class ProjectsGetXpnResourcesOptionalParms
        {
            /// NA
            public string Filter { get; set; }  
            /// NA
            public int? MaxResults { get; set; }  
            /// NA
            public string Order_by { get; set; }  
            /// NA
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Get XPN resources associated with this host project. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/getXpnResources
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ProjectsGetXpnResourcesResponse</returns>
        public static ProjectsGetXpnResources GetXpnResources(ComputeService service, string project, ProjectsGetXpnResourcesOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Projects.GetXpnResources(project);

                // Applying optional parameters to the request.                
                request = (ProjectsResource.GetXpnResourcesRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.GetXpnResources failed.", ex);
            }
        }
        public class ProjectsListXpnHostsOptionalParms
        {
            /// NA
            public string Filter { get; set; }  
            /// NA
            public int? MaxResults { get; set; }  
            /// NA
            public string Order_by { get; set; }  
            /// NA
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// List all XPN host projects visible to the user in an organization. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/listXpnHosts
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>XpnHostListResponse</returns>
        public static XpnHostList ListXpnHosts(ComputeService service, string project, ProjectsListXpnHostsRequest body, ProjectsListXpnHostsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.Projects.ListXpnHosts(body, project);

                // Applying optional parameters to the request.                
                request = (ProjectsResource.ListXpnHostsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.ListXpnHosts failed.", ex);
            }
        }

        /// <summary>
        /// Moves a persistent disk from one zone to another. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/moveDisk
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation MoveDisk(ComputeService service, string project, DiskMoveRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.MoveDisk(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.MoveDisk failed.", ex);
            }
        }

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/moveInstance
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation MoveInstance(ComputeService service, string project, InstanceMoveRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.MoveInstance(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.MoveInstance failed.", ex);
            }
        }

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/setCommonInstanceMetadata
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetCommonInstanceMetadata(ComputeService service, string project, Metadata body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.SetCommonInstanceMetadata(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.SetCommonInstanceMetadata failed.", ex);
            }
        }

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled. 
        /// Documentation https://developers.google.com/compute/v1/reference/projects/setUsageExportBucket
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="body">A valid Compute v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetUsageExportBucket(ComputeService service, string project, UsageExportLocation body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.Projects.SetUsageExportBucket(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.SetUsageExportBucket failed.", ex);
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