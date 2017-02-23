// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateCombined
{
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateARecordSet;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateAaaaRecordSet;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateMXRecordSet;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateNSRecordSet;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdatePtrRecordSet;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateSoaRecord;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateSrvRecordSet;
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateTxtRecordSet;

    /// <summary>
    /// The entirety of a record sets update as a part of parent DNS zone update.
    /// </summary>
    public interface IUpdateCombined  :
        IUpdateARecordSet,
        IUpdateAaaaRecordSet,
        IUpdatePtrRecordSet,
        IUpdateMXRecordSet,
        IUpdateNSRecordSet,
        IUpdateSrvRecordSet,
        IUpdateTxtRecordSet,
        IUpdateSoaRecord,
        IUpdate
    {
    }
}