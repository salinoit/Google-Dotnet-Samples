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
//     Build date: 07/06/2017 15:31:20
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Gamesmanagement v1management API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Management API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Gamesmanagement/v1management/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Gamesmanagement.v1management/ 
// Install Command: PM>  Install-Package Google.Apis.Gamesmanagement.v1management
//
//------------------------------------------------------------------------------  
using Google.Apis.Gamesmanagement.v1management;
using Google.Apis.Gamesmanagement.v1management.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesmanagementv1management.Methods
{
  
    public static class TurnBasedMatchesSample
    {


        /// <summary>
        /// Reset all turn-based match data for a user. This method is only accessible to whitelisted tester accounts for your application. 
        /// Documentation https://developers.google.com/gamesmanagement/v1management/reference/turnBasedMatches/reset
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesmanagement service.</param>  
        public static void Reset(GamesmanagementService service)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Make the request.
                 service.TurnBasedMatches.Reset().Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.Reset failed.", ex);
            }
        }

        /// <summary>
        /// Deletes turn-based matches where the only match participants are from whitelisted tester accounts for your application. This method is only available to user accounts for your developer console. 
        /// Documentation https://developers.google.com/gamesmanagement/v1management/reference/turnBasedMatches/resetForAllPlayers
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gamesmanagement service.</param>  
        public static void ResetForAllPlayers(GamesmanagementService service)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Make the request.
                 service.TurnBasedMatches.ResetForAllPlayers().Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request TurnBasedMatches.ResetForAllPlayers failed.", ex);
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