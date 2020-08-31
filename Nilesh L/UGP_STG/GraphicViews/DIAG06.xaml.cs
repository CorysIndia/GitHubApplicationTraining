using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("diag06")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DIAG06
    { 
        public DIAG06() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
