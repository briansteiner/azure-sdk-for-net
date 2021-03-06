// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for a CloudJobScheduleOperations.Patch request.
    /// </summary>
    public partial class JobSchedulePatchParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobSchedulePatchParameter class.
        /// </summary>
        public JobSchedulePatchParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobSchedulePatchParameter class.
        /// </summary>
        /// <param name="schedule">The schedule according to which jobs will be created.</param>
        /// <param name="jobSpecification">The details of the jobs to be created on this schedule.</param>
        /// <param name="metadata">A list of name-value pairs associated with the job schedule as metadata.</param>
        public JobSchedulePatchParameter(Schedule schedule = default(Schedule), JobSpecification jobSpecification = default(JobSpecification), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Schedule = schedule;
            JobSpecification = jobSpecification;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets the schedule according to which jobs will be created.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the details of the jobs to be created on this
        /// schedule.
        /// </summary>
        [JsonProperty(PropertyName = "jobSpecification")]
        public JobSpecification JobSpecification { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job
        /// schedule as metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.JobSpecification != null)
            {
                this.JobSpecification.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element in this.Metadata)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
