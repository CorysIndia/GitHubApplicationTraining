using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("igv_k0003a")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class IGV_K0003A
    { 
        public IGV_K0003A() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
