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
    [ExportSynoptic("srg_control_overview_m39_k_0007c")] 
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SRG_CONTROL_OVERVIEW_M39_K_0007C
    {
        public SRG_CONTROL_OVERVIEW_M39_K_0007C()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += SRG_CONTROL_OVERVIEW_M39_K_0007C_Loaded;
            this.InitializeComponent();
        }

        private void SRG_CONTROL_OVERVIEW_M39_K_0007C_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SurgeReferencePlot7C1.ShowAxis = false;
            ControlReferencePlot7C1.ShowAxis = false;
            HoverPoint7C1.ShowAxis = false;
            OperatingPoint7C1.ShowAxis = false;
            SurgeLinePlot7C1.ShowAxis = false;
            ControlLinePlot7C1.ShowAxis = false;


            SurgeReferencePlot7C2.ShowAxis = false;
            ControlReferencePlot7C2.ShowAxis = false;
            HoverPoint7C2.ShowAxis = false;
            OperatingPoint7C2.ShowAxis = false;
            SurgeLinePlot7C2.ShowAxis = false;
            ControlLinePlot7C2.ShowAxis = false;


        }
    }
} 
