using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("sw_vlv_k0001")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SW_VLV_K0001
    { 
        public SW_VLV_K0001() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
