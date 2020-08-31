using System; 
using System.Collections.Generic; 
using System.Windows.Controls; 
using System.ComponentModel.Composition; 
namespace UGP_EDRF 
{ 
    [ExportSynoptic("cooling")] 
    [PartCreationPolicy(CreationPolicy.NonShared)] 
    public partial class COOLING
    { 
        public COOLING() 
        { 
            this.InitializeComponent(); 
        } 
    } 
} 
