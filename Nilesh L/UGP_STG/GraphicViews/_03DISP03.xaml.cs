using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_03disp03")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _03DISP03
    { 
        public _03DISP03() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
