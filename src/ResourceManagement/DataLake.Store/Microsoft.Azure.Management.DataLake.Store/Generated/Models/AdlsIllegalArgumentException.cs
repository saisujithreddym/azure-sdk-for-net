// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Azure;
    using Management;
    using DataLake;
    using Store;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A WebHDFS exception thrown indicating that one more arguments is
    /// incorrect. Thrown when a 400 error response code is returned (bad
    /// request).
    /// </summary>
    [Newtonsoft.Json.JsonObject("IllegalArgumentException")]
    public partial class AdlsIllegalArgumentException : AdlsRemoteException
    {
        /// <summary>
        /// Initializes a new instance of the AdlsIllegalArgumentException
        /// class.
        /// </summary>
        public AdlsIllegalArgumentException() { }

        /// <summary>
        /// Initializes a new instance of the AdlsIllegalArgumentException
        /// class.
        /// </summary>
        /// <param name="javaClassName">the full class package name for the
        /// exception thrown, such as
        /// 'java.lang.IllegalArgumentException'.</param>
        /// <param name="message">the message associated with the exception
        /// that was thrown, such as 'Invalid value for webhdfs parameter
        /// "permission":...'.</param>
        public AdlsIllegalArgumentException(string javaClassName = default(string), string message = default(string))
            : base(javaClassName, message)
        {
        }

    }
}

