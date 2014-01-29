// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.WebSitesExtensions;
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure.WebSitesExtensions
{
    /// <summary>
    /// Operations for managing the jobs.
    /// </summary>
    public static partial class WebJobOperationsExtensions
    {
        /// <summary>
        /// Delete a continuous job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='recursive'>
        /// Removing the specified directory and all its files and
        /// subdirectories. The value must be set to true.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse DeleteContinuous(this IWebJobOperations operations, string jobName, bool recursive)
        {
            try
            {
                return operations.DeleteContinuousAsync(jobName, recursive).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Delete a continuous job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='recursive'>
        /// Removing the specified directory and all its files and
        /// subdirectories. The value must be set to true.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteContinuousAsync(this IWebJobOperations operations, string jobName, bool recursive)
        {
            return operations.DeleteContinuousAsync(jobName, recursive, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete a triggered job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='recursive'>
        /// Removing the specified directory and all its files and
        /// subdirectories. The value must be set to true.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse DeleteTriggered(this IWebJobOperations operations, string jobName, bool recursive)
        {
            try
            {
                return operations.DeleteTriggeredAsync(jobName, recursive).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Delete a triggered job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='recursive'>
        /// Removing the specified directory and all its files and
        /// subdirectories. The value must be set to true.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteTriggeredAsync(this IWebJobOperations operations, string jobName, bool recursive)
        {
            return operations.DeleteTriggeredAsync(jobName, recursive, CancellationToken.None);
        }
        
        /// <summary>
        /// TBD.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// The get Web Job Operation Response.
        /// </returns>
        public static WebJobGetResponse Get(this IWebJobOperations operations, string jobName)
        {
            try
            {
                return operations.GetAsync(jobName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// TBD.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// The get Web Job Operation Response.
        /// </returns>
        public static Task<WebJobGetResponse> GetAsync(this IWebJobOperations operations, string jobName)
        {
            return operations.GetAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// The get Web Job Operation Response.
        /// </returns>
        public static WebJobGetResponse GetContinuous(this IWebJobOperations operations, string jobName)
        {
            try
            {
                return operations.GetContinuousAsync(jobName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// The get Web Job Operation Response.
        /// </returns>
        public static Task<WebJobGetResponse> GetContinuousAsync(this IWebJobOperations operations, string jobName)
        {
            return operations.GetContinuousAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a web job run.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='jobRunId'>
        /// The job run identifier.
        /// </param>
        /// <returns>
        /// The Get Web Job Run operation response.
        /// </returns>
        public static WebJobGetRunResponse GetRun(this IWebJobOperations operations, string jobName, string jobRunId)
        {
            try
            {
                return operations.GetRunAsync(jobName, jobRunId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get a web job run.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='jobRunId'>
        /// The job run identifier.
        /// </param>
        /// <returns>
        /// The Get Web Job Run operation response.
        /// </returns>
        public static Task<WebJobGetRunResponse> GetRunAsync(this IWebJobOperations operations, string jobName, string jobRunId)
        {
            return operations.GetRunAsync(jobName, jobRunId, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// The get Web Job Operation Response.
        /// </returns>
        public static WebJobGetResponse GetTriggered(this IWebJobOperations operations, string jobName)
        {
            try
            {
                return operations.GetTriggeredAsync(jobName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Get a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// The get Web Job Operation Response.
        /// </returns>
        public static Task<WebJobGetResponse> GetTriggeredAsync(this IWebJobOperations operations, string jobName)
        {
            return operations.GetTriggeredAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// List the web jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The list of jobs operation response.
        /// </returns>
        public static WebJobListResponse List(this IWebJobOperations operations, WebJobListParameters parameters)
        {
            try
            {
                return operations.ListAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// List the web jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The list of jobs operation response.
        /// </returns>
        public static Task<WebJobListResponse> ListAsync(this IWebJobOperations operations, WebJobListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// List the continuous web jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The list of jobs operation response.
        /// </returns>
        public static WebJobListResponse ListContinuous(this IWebJobOperations operations, WebJobListParameters parameters)
        {
            try
            {
                return operations.ListContinuousAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// List the continuous web jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The list of jobs operation response.
        /// </returns>
        public static Task<WebJobListResponse> ListContinuousAsync(this IWebJobOperations operations, WebJobListParameters parameters)
        {
            return operations.ListContinuousAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// List the web job runs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The Web Job run list operation response.
        /// </returns>
        public static WebJobRunListResponse ListRuns(this IWebJobOperations operations, string jobName, WebJobRunListParameters parameters)
        {
            try
            {
                return operations.ListRunsAsync(jobName, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// List the web job runs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The Web Job run list operation response.
        /// </returns>
        public static Task<WebJobRunListResponse> ListRunsAsync(this IWebJobOperations operations, string jobName, WebJobRunListParameters parameters)
        {
            return operations.ListRunsAsync(jobName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// List the triggered web jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The list of jobs operation response.
        /// </returns>
        public static WebJobListResponse ListTriggered(this IWebJobOperations operations, WebJobListParameters parameters)
        {
            try
            {
                return operations.ListTriggeredAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// List the triggered web jobs.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters.
        /// </param>
        /// <returns>
        /// The list of jobs operation response.
        /// </returns>
        public static Task<WebJobListResponse> ListTriggeredAsync(this IWebJobOperations operations, WebJobListParameters parameters)
        {
            return operations.ListTriggeredAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Run a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse RunTriggered(this IWebJobOperations operations, string jobName)
        {
            try
            {
                return operations.RunTriggeredAsync(jobName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Run a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> RunTriggeredAsync(this IWebJobOperations operations, string jobName)
        {
            return operations.RunTriggeredAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// If a continuous job is set as singleton it'll run only on a single
        /// instance opposed to running on all instances.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='isSingleton'>
        /// Boolean value indicating if the job is singleton or not.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse SetSingleton(this IWebJobOperations operations, string jobName, bool isSingleton)
        {
            try
            {
                return operations.SetSingletonAsync(jobName, isSingleton).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// If a continuous job is set as singleton it'll run only on a single
        /// instance opposed to running on all instances.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='isSingleton'>
        /// Boolean value indicating if the job is singleton or not.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> SetSingletonAsync(this IWebJobOperations operations, string jobName, bool isSingleton)
        {
            return operations.SetSingletonAsync(jobName, isSingleton, CancellationToken.None);
        }
        
        /// <summary>
        /// Start a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse StartContinous(this IWebJobOperations operations, string jobName)
        {
            try
            {
                return operations.StartContinousAsync(jobName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Start a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> StartContinousAsync(this IWebJobOperations operations, string jobName)
        {
            return operations.StartContinousAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Stop a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse StopContinous(this IWebJobOperations operations, string jobName)
        {
            try
            {
                return operations.StopContinousAsync(jobName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Stop a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> StopContinousAsync(this IWebJobOperations operations, string jobName)
        {
            return operations.StopContinousAsync(jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Upload a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='jobContent'>
        /// The job content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse UploadContinuous(this IWebJobOperations operations, string jobName, Stream jobContent)
        {
            try
            {
                return operations.UploadContinuousAsync(jobName, jobContent).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Upload a continuous web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='jobContent'>
        /// The job content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UploadContinuousAsync(this IWebJobOperations operations, string jobName, Stream jobContent)
        {
            return operations.UploadContinuousAsync(jobName, jobContent, CancellationToken.None);
        }
        
        /// <summary>
        /// Upload a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='jobContent'>
        /// The job content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse UploadTriggered(this IWebJobOperations operations, string jobName, Stream jobContent)
        {
            try
            {
                return operations.UploadTriggeredAsync(jobName, jobContent).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Upload a triggered web job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IWebJobOperations.
        /// </param>
        /// <param name='jobName'>
        /// The job name.
        /// </param>
        /// <param name='jobContent'>
        /// The job content.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UploadTriggeredAsync(this IWebJobOperations operations, string jobName, Stream jobContent)
        {
            return operations.UploadTriggeredAsync(jobName, jobContent, CancellationToken.None);
        }
    }
}
