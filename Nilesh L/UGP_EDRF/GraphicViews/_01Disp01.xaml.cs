using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_01disp01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01Disp01
    { 
        public _01Disp01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
