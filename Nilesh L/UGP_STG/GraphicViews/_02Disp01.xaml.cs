using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_02disp01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _02Disp01
    { 
        public _02Disp01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
