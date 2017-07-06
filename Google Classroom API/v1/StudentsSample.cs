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
// Unoffical sample for the Classroom v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages classes, rosters, and invitations in Google Classroom.
// API Documentation Link https://developers.google.com/classroom/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Classroom/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Classroom.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Classroom.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Classroom.v1;
using Google.Apis.Classroom.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Classroomv1.Methods
{
  
    public static class StudentsSample
    {


        /// <summary>
        /// Deletes a student of a course.This method returns the following error codes:* `PERMISSION_DENIED` if the requesting user is not permitted to deletestudents of this course or for access errors.* `NOT_FOUND` if no student of this course has the requested ID or if thecourse does not exist. 
        /// Documentation https://developers.google.com/classroom/v1/reference/students/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Classroom service.</param>  
        /// <param name="courseId">Identifier of the course.This identifier can be either the Classroom-assigned identifier or analias.</param>
        /// <param name="userId">Identifier of the student to delete. The identifier can be one of thefollowing:* the numeric identifier for the user* the email address of the user* the string literal `"me"`, indicating the requesting user</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(ClassroomService service, string courseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (courseId == null)
                    throw new ArgumentNullException(courseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Students.Delete(courseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Students.Delete failed.", ex);
            }
        }
        public class StudentsListOptionalParms
        {
            /// nextPageTokenvalue returned from a previouslist call, indicating thatthe subsequent page of results should be returned.The list request must beotherwise identical to the one that resulted in this token.
            public string PageToken { get; set; }  
            /// Maximum number of items to return. Zero means no maximum.The server may return fewer than the specified number of results.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of students of this course that the requesteris permitted to view.This method returns the following error codes:* `NOT_FOUND` if the course does not exist.* `PERMISSION_DENIED` for access errors. 
        /// Documentation https://developers.google.com/classroom/v1/reference/students/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Classroom service.</param>  
        /// <param name="courseId">Identifier of the course.This identifier can be either the Classroom-assigned identifier or analias.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListStudentsResponseResponse</returns>
        public static ListStudentsResponse List(ClassroomService service, string courseId, StudentsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (courseId == null)
                    throw new ArgumentNullException(courseId);

                // Building the initial request.
                var request = service.Students.List(courseId);

                // Applying optional parameters to the request.                
                request = (StudentsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Students.List failed.", ex);
            }
        }

        /// <summary>
        /// Returns a student of a course.This method returns the following error codes:* `PERMISSION_DENIED` if the requesting user is not permitted to viewstudents of this course or for access errors.* `NOT_FOUND` if no student of this course has the requested ID or if thecourse does not exist. 
        /// Documentation https://developers.google.com/classroom/v1/reference/students/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Classroom service.</param>  
        /// <param name="courseId">Identifier of the course.This identifier can be either the Classroom-assigned identifier or analias.</param>
        /// <param name="userId">Identifier of the student to return. The identifier can be one of thefollowing:* the numeric identifier for the user* the email address of the user* the string literal `"me"`, indicating the requesting user</param>
        /// <returns>StudentResponse</returns>
        public static Student Get(ClassroomService service, string courseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (courseId == null)
                    throw new ArgumentNullException(courseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Students.Get(courseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Students.Get failed.", ex);
            }
        }
        public class StudentsCreateOptionalParms
        {
            /// Enrollment code of the course to create the student in.This code is required if userIdcorresponds to the requesting user; it may be omitted if the requestinguser has administrative permissions to create students for any user.
            public string EnrollmentCode { get; set; }  
        
        }
 
        /// <summary>
        /// Adds a user as a student of a course.This method returns the following error codes:* `PERMISSION_DENIED` if the requesting user is not permitted to createstudents in this course or for access errors.* `NOT_FOUND` if the requested course ID does not exist.* `FAILED_PRECONDITION` if the requested user's account is disabled,for the following request errors:    * CourseMemberLimitReached    * CourseNotModifiable    * UserGroupsMembershipLimitReached* `ALREADY_EXISTS` if the user is already a student or teacher in thecourse. 
        /// Documentation https://developers.google.com/classroom/v1/reference/students/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Classroom service.</param>  
        /// <param name="courseId">Identifier of the course to create the student in.This identifier can be either the Classroom-assigned identifier or analias.</param>
        /// <param name="body">A valid Classroom v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>StudentResponse</returns>
        public static Student Create(ClassroomService service, string courseId, Student body, StudentsCreateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (courseId == null)
                    throw new ArgumentNullException(courseId);

                // Building the initial request.
                var request = service.Students.Create(body, courseId);

                // Applying optional parameters to the request.                
                request = (StudentsResource.CreateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Students.Create failed.", ex);
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