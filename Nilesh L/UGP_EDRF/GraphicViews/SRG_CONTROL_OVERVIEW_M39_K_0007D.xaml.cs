using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
using RSI.Common.Locator;
using RSI.IndissLike.Controls.Helpers;
using RSI.IndissPlus.Plots.Components;
using RSI.Common.WPFTools.Extensions;
using RSI.IndissPlus.Plots.OxyPlotTools;
using PlotComponent.Interfaces;
namespace UGP_EDRF 
{ 
    [ExportSynoptic("srg_control_overview_m39_k_0007d")] 
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SRG_CONTROL_OVERVIEW_M39_K_0007D
    {
        public SRG_CONTROL_OVERVIEW_M39_K_0007D()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += SRG_CONTROL_OVERVIEW_M39_K_0007D_Loaded;
            this.InitializeComponent();
        }

        private void SRG_CONTROL_OVERVIEW_M39_K_0007D_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SurgeReferencePlot7D1.ShowAxis = false;
            ControlReferencePlot7D1.ShowAxis = false;
            HoverPoint7D1.ShowAxis = false;
            OperatingPoint7D1.ShowAxis = false;
            SurgeLinePlot7D1.ShowAxis = false;
            ControlLinePlot7D1.ShowAxis = false;

            SurgeReferencePlot7D2.ShowAxis = false;
            ControlReferencePlot7D2.ShowAxis = false;
            HoverPoint7D2.ShowAxis = false;
            OperatingPoint7D2.ShowAxis = false;
            SurgeLinePlot7D2.ShowAxis = false;
            ControlLinePlot7D2.ShowAxis = false;





        }
    }
} 
