using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_01disp02")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01Disp02
    { 
        public _01Disp02() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
