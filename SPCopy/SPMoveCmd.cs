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
using System.Text;
using Microsoft.SharePoint.PowerShell;
using System.Management.Automation;

namespace MANSoftDev.SharePoint.PowerShell
{
    [Cmdlet(VerbsCommon.Move, "SPWeb")]
    public class SPMoveCmd : SPCopyBase
    {
        public SPMoveCmd()
        {
            base.IsCopy = false;
        }
    }
}

