using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_06disp06")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _06DISP06
    { 
        public _06DISP06() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
