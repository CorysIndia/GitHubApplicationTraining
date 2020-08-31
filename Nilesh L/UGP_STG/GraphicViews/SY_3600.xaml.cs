using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("sy_3600")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class SY_3600
    { 
        public SY_3600() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
