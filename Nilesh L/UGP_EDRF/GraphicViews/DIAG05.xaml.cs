using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag05")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DIAG05
    { 
        public DIAG05() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
