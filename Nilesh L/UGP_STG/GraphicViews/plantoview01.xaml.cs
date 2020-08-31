using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("plantoview01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class plantoview01
    { 
        public plantoview01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
