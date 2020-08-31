using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("PLANTOVIEW01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class PLANTOVIEW01
    { 
        public PLANTOVIEW01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
