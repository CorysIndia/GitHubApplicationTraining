using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("ove_cat")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class OVE_CAT
    { 
        public OVE_CAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
