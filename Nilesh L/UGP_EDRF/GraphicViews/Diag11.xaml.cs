using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag11")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag11
    { 
        public Diag11() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
