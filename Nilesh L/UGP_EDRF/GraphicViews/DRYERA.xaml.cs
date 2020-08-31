using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("dryera")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class DRYERA
    { 
        public DRYERA() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
