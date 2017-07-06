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
//     Build date: 07/06/2017 15:31:21
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Monitoring v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages your Stackdriver Monitoring data and configurations. Most projects must be associated with a Stackdriver account, with a few exceptions as noted on the individual method pages.
// API Documentation Link https://cloud.google.com/monitoring/api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Monitoring/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Monitoring.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Monitoring.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Monitoring.v3;
using Google.Apis.Monitoring.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Monitoringv3.Methods
{
  
    public static class TimeSeriesSample
    {

        public class TimeSeriesListOptionalParms
        {
            /// The set of fields to preserve when crossSeriesReducer is specified. The groupByFields determine how the time series are partitioned into subsets prior to applying the aggregation function. Each subset contains time series that have the same value for each of the grouping fields. Each individual time series is a member of exactly one subset. The crossSeriesReducer is applied to each subset of time series. It is not possible to reduce across different resource types, so this field implicitly contains resource.type. Fields not specified in groupByFields are aggregated away. If groupByFields is not specified and all the time series have the same resource type, then the time series are aggregated into a single output time series. If crossSeriesReducer is not defined, this field is ignored.
            public string Aggregation.groupByFields { get; set; }  
            /// Required. The end of the time interval.
            public string Interval.endTime { get; set; }  
            /// The alignment period for per-time series alignment. If present, alignmentPeriod must be at least 60 seconds. After per-time series alignment, each time series will contain data points only on the period boundaries. If perSeriesAligner is not specified or equals ALIGN_NONE, then this field is ignored. If perSeriesAligner is specified and does not equal ALIGN_NONE, then this field must be defined; otherwise an error is returned.
            public string Aggregation.alignmentPeriod { get; set; }  
            /// A positive number that is the maximum number of results to return. When view field sets to FULL, it limits the number of Points server will return; if view field is HEADERS, it limits the number of TimeSeries server will return.
            public int? PageSize { get; set; }  
            /// Specifies the order in which the points of the time series should be returned. By default, results are not ordered. Currently, this field must be left blank.
            public string OrderBy { get; set; }  
            /// The approach to be used to combine time series. Not all reducer functions may be applied to all time series, depending on the metric type and the value type of the original time series. Reduction may change the metric type of value type of the time series.Time series data must be aligned in order to perform cross-time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned.
            public string Aggregation.crossSeriesReducer { get; set; }  
            /// A monitoring filter that specifies which time series should be returned. The filter must specify a single metric type, and can additionally specify metric labels and other information. For example:metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND    metric.label.instance_name = "my-instance-name"
            public string Filter { get; set; }  
            /// The approach to be used to align individual time series. Not all alignment functions may be applied to all time series, depending on the metric type and value type of the original time series. Alignment may change the metric type or the value type of the time series.Time series data must be aligned in order to perform cross-time series reduction. If crossSeriesReducer is specified, then perSeriesAligner must be specified and not equal ALIGN_NONE and alignmentPeriod must be specified; otherwise, an error is returned.
            public string Aggregation.perSeriesAligner { get; set; }  
            /// If this field is not empty then it must contain the nextPageToken value returned by a previous call to this method. Using this field causes the method to return additional results from the previous method call.
            public string PageToken { get; set; }  
            /// Optional. The beginning of the time interval. The default value for the start time is the end time. The start time must not be later than the end time.
            public string Interval.startTime { get; set; }  
            /// Specifies which information is returned about the time series.
            public string View { get; set; }  
        
        }
 
        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account. 
        /// Documentation https://developers.google.com/monitoring/v3/reference/timeSeries/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Monitoring service.</param>  
        /// <param name="name">The project on which to execute the request. The format is "projects/{project_id_or_number}".</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListTimeSeriesResponseResponse</returns>
        public static ListTimeSeriesResponse List(MonitoringService service, string name, TimeSeriesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.TimeSeries.List(name);

                // Applying optional parameters to the request.                
                request = (TimeSeriesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TimeSeries.List failed.", ex);
            }
        }

        /// <summary>
        /// Creates or adds data to one or more time series. The response is empty if all time series in the request were written. If any time series could not be written, a corresponding failure message is included in the error response. 
        /// Documentation https://developers.google.com/monitoring/v3/reference/timeSeries/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Monitoring service.</param>  
        /// <param name="name">The project on which to execute the request. The format is "projects/{project_id_or_number}".</param>
        /// <param name="body">A valid Monitoring v3 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Create(MonitoringService service, string name, CreateTimeSeriesRequest body)
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
                return service.TimeSeries.Create(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TimeSeries.Create failed.", ex);
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