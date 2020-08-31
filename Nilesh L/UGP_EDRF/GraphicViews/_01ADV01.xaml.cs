using System; 
using System.Windows; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("_01adv01")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class _01ADV01
    { 
        public _01ADV01() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
