using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag12")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class Diag12
    { 
        public Diag12() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
