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
    [SPCmdlet(RequireLocalFarmExist = true, RequireUserFarmAdmin = false)]
    public class SPCopyBase : SPCmdlet
    {
        protected override void InternalValidate()
        {
            if(string.IsNullOrEmpty(Source))
                throw new ArgumentException("Source must be specified");

            if(string.IsNullOrEmpty(Destination))
                throw new ArgumentException("Destination must be specified");
        }

        protected override void InternalProcessRecord()
        {
            SPWeb copy = new SPWeb();
            copy.SourceURL = Source;
            copy.DestinationURL = Destination;

            if(IsCopy)
                copy.Copy();
            else
                copy.Move();
        }

        #region Properties

        [Parameter(Position = 0, Mandatory = true)]
        public string Source { get; set; }

        [Parameter(Position = 1, Mandatory = true)]
        public string Destination { get; set; }

        protected bool IsCopy { get; set; }

        #endregion
    }
}
