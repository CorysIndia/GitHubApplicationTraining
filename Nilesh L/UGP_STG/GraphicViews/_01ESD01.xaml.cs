using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_01esd01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01ESD01
    { 
        public _01ESD01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
