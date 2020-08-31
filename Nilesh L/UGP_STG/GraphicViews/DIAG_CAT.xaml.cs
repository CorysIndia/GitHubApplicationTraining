using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag_cat")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DIAG_CAT
    { 
        public DIAG_CAT() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
