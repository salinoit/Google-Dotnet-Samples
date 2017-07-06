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
// Unoffical sample for the Toolresults v1beta3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Reads and publishes results from Firebase Test Lab.
// API Documentation Link https://firebase.google.com/docs/test-lab/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Toolresults/v1beta3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Toolresults.v1beta3/ 
// Install Command: PM>  Install-Package Google.Apis.Toolresults.v1beta3
//
//------------------------------------------------------------------------------  
using Google.Apis.Toolresults.v1beta3;
using Google.Apis.Toolresults.v1beta3.Data;
using System;

namespace GoogleSamplecSharpSample.Toolresultsv1beta3.Methods
{
  
    public static class PerfMetricsSummarySample
    {


        /// <summary>
        /// Creates a PerfMetricsSummary resource.May return any of the following error code(s): - ALREADY_EXISTS - A PerfMetricSummary already exists for the given Step - NOT_FOUND - The containing Step does not exist 
        /// Documentation https://developers.google.com/toolresults/v1beta3/reference/perfMetricsSummary/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Toolresults service.</param>  
        /// <param name="projectId">The cloud project</param>
        /// <param name="historyId">A tool results history ID.</param>
        /// <param name="executionId">A tool results execution ID.</param>
        /// <param name="stepId">A tool results step ID.</param>
        /// <param name="body">A valid Toolresults v1beta3 body.</param>
        /// <returns>PerfMetricsSummaryResponse</returns>
        public static PerfMetricsSummary Create(ToolresultsService service, string projectId, string historyId, string executionId, string stepId, PerfMetricsSummary body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (historyId == null)
                    throw new ArgumentNullException(historyId);
                if (executionId == null)
                    throw new ArgumentNullException(executionId);
                if (stepId == null)
                    throw new ArgumentNullException(stepId);

                // Make the request.
                return service.PerfMetricsSummary.Create(body, projectId, historyId, executionId, stepId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PerfMetricsSummary.Create failed.", ex);
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