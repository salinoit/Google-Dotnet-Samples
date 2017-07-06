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
//     Build date: 07/06/2017 15:31:14
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Calendar v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manipulates events and other calendar data.
// API Documentation Link https://developers.google.com/google-apps/calendar/firstapp
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Calendar/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Calendar.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Calendar.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Calendarv3.Methods
{
  
    public static class CalendarsSample
    {


        /// <summary>
        /// Clears a primary calendar. This operation deletes all events associated with the primary calendar of an account. 
        /// Documentation https://developers.google.com/calendar/v3/reference/calendars/clear
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        public static void Clear(CalendarService service, string calendarId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Make the request.
                 service.Calendars.Clear(calendarId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Clear failed.", ex);
            }
        }

        /// <summary>
        /// Deletes a secondary calendar. Use calendars.clear for clearing all events on primary calendars. 
        /// Documentation https://developers.google.com/calendar/v3/reference/calendars/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        public static void Delete(CalendarService service, string calendarId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Make the request.
                 service.Calendars.Delete(calendarId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Returns metadata for a calendar. 
        /// Documentation https://developers.google.com/calendar/v3/reference/calendars/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <returns>CalendarResponse</returns>
        public static Calendar Get(CalendarService service, string calendarId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Make the request.
                return service.Calendars.Get(calendarId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates a secondary calendar. 
        /// Documentation https://developers.google.com/calendar/v3/reference/calendars/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="body">A valid Calendar v3 body.</param>
        /// <returns>CalendarResponse</returns>
        public static Calendar Insert(CalendarService service, Calendar body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Calendars.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Updates metadata for a calendar. This method supports patch semantics. 
        /// Documentation https://developers.google.com/calendar/v3/reference/calendars/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="body">A valid Calendar v3 body.</param>
        /// <returns>CalendarResponse</returns>
        public static Calendar Patch(CalendarService service, string calendarId, Calendar body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Make the request.
                return service.Calendars.Patch(body, calendarId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates metadata for a calendar. 
        /// Documentation https://developers.google.com/calendar/v3/reference/calendars/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Calendar service.</param>  
        /// <param name="calendarId">Calendar identifier. To retrieve calendar IDs call the calendarList.list method. If you want to access the primary calendar of the currently logged in user, use the "primary" keyword.</param>
        /// <param name="body">A valid Calendar v3 body.</param>
        /// <returns>CalendarResponse</returns>
        public static Calendar Update(CalendarService service, string calendarId, Calendar body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (calendarId == null)
                    throw new ArgumentNullException(calendarId);

                // Make the request.
                return service.Calendars.Update(body, calendarId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Calendars.Update failed.", ex);
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