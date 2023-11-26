#region Summary
/******************************************************************************
// AUTHOR                   : Mark Nischalke 
// CREATE DATE              : 4/26/2010 
//
// Copyright © MANSoftDev 2010 all rights reserved
// ===========================================================================
// Copyright notice must remain
//
******************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SharePoint.PowerShell;
using System.Management.Automation;

namespace MANSoftDev.SharePoint.PowerShell
{
    [Cmdlet(VerbsCommon.Copy, "SPWeb")]
    public class SPCopyCmd : SPCopyBase
    {
        public SPCopyCmd()
        {
            base.IsCopy = true;
        }
    }
}
