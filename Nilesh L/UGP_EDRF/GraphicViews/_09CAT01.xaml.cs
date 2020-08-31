using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_09cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _09CAT01
    { 
        public _09CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
