// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Security.AccessControl.CommonObjectSecurity.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Security.AccessControl
{
  abstract public partial class CommonObjectSecurity : ObjectSecurity
  {
    #region Methods and constructors
    protected void AddAccessRule(AccessRule rule)
    {
    }

    protected void AddAuditRule(AuditRule rule)
    {
    }

    protected CommonObjectSecurity(bool isContainer) : base (default(CommonSecurityDescriptor))
    {
    }

    public AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, Type targetType)
    {
      Contract.Ensures(Contract.Result<System.Security.AccessControl.AuthorizationRuleCollection>() != null);

      return default(AuthorizationRuleCollection);
    }

    public AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, Type targetType)
    {
      Contract.Ensures(Contract.Result<System.Security.AccessControl.AuthorizationRuleCollection>() != null);

      return default(AuthorizationRuleCollection);
    }

    protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified)
    {
      modified = default(bool);

      return default(bool);
    }

    protected override bool ModifyAudit(AccessControlModification modification, AuditRule rule, out bool modified)
    {
      modified = default(bool);

      return default(bool);
    }

    protected bool RemoveAccessRule(AccessRule rule)
    {
      return default(bool);
    }

    protected void RemoveAccessRuleAll(AccessRule rule)
    {
    }

    protected void RemoveAccessRuleSpecific(AccessRule rule)
    {
    }

    protected bool RemoveAuditRule(AuditRule rule)
    {
      return default(bool);
    }

    protected void RemoveAuditRuleAll(AuditRule rule)
    {
    }

    protected void RemoveAuditRuleSpecific(AuditRule rule)
    {
    }

    protected void ResetAccessRule(AccessRule rule)
    {
    }

    protected void SetAccessRule(AccessRule rule)
    {
    }

    protected void SetAuditRule(AuditRule rule)
    {
    }
    #endregion
  }
}
