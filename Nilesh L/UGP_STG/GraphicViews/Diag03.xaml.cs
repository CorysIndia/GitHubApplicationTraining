using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag03")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag03
    { 
        public Diag03() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
