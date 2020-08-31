using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_03disp01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _03DISP01
    { 
        public _03DISP01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
