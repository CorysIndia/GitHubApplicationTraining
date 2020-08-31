using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_01cat01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01CAT01
    { 
        public _01CAT01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
