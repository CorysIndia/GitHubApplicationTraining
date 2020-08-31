using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag07")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DIAG07
    { 
        public DIAG07() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
