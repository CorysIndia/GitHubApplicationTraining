using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("igv_k0001")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class IGV_K0001
    { 
        public IGV_K0001() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
