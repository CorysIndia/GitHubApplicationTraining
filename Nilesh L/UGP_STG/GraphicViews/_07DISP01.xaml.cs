using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_07disp01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _07DISP01
    { 
        public _07DISP01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
