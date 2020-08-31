using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("vms_cat")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class VMS_CAT
    { 
        public VMS_CAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
