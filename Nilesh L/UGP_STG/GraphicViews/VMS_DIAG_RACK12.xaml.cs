using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("vms_diag_rack12")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class VMS_DIAG_RACK12
    { 
        public VMS_DIAG_RACK12() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
