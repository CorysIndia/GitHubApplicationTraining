using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag01
    { 
        public Diag01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
