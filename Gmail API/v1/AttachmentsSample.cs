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
// Unoffical sample for the Gmail v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Access Gmail mailboxes including sending user email.
// API Documentation Link https://developers.google.com/gmail/api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Gmail/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Gmail.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Gmail.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Gmailv1.Methods
{
  
    public static class AttachmentsSample
    {


        /// <summary>
        /// Gets the specified message attachment. 
        /// Documentation https://developers.google.com/gmail/v1/reference/attachments/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Gmail service.</param>  
        /// <param name="userId">The user's email address. The special value me can be used to indicate the authenticated user.</param>
        /// <param name="messageId">The ID of the message containing the attachment.</param>
        /// <param name="id">The ID of the attachment.</param>
        /// <returns>MessagePartBodyResponse</returns>
        public static MessagePartBody Get(GmailService service, string userId, string messageId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (messageId == null)
                    throw new ArgumentNullException(messageId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Attachments.Get(userId, messageId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Attachments.Get failed.", ex);
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