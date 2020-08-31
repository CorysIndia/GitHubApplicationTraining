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
    [ExportSynoptic("srg_control_overview_m39_k_0007b")] 
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SRG_CONTROL_OVERVIEW_M39_K_0007B
    {
        public SRG_CONTROL_OVERVIEW_M39_K_0007B()
        {
            if (Designer.IsInDesignModeStatic == false)
            {
                ServiceLocator.Instance.RegisterType<ID3Factory, OxyPlotFactory>();
                this.OnceLoaded(fe => ServiceLocator.Instance.UnregisterType<ID3Factory>());
            }
            this.Loaded += SRG_CONTROL_OVERVIEW_M39_K_0007B_Loaded;
            this.InitializeComponent();
        }

        private void SRG_CONTROL_OVERVIEW_M39_K_0007B_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            SurgeReferencePlot7B1.ShowAxis = false;
            ControlReferencePlot7B1.ShowAxis = false;
            HoverPoint7B1.ShowAxis = false;
            OperatingPoint7B1.ShowAxis = false;
            SurgeLinePlot7B1.ShowAxis = false;
            ControlLinePlot7B1.ShowAxis = false;


            SurgeReferencePlot7B2.ShowAxis = false;
            ControlReferencePlot7B2.ShowAxis = false;
            HoverPoint7B2.ShowAxis = false;
            OperatingPoint7B2.ShowAxis = false;
            SurgeLinePlot7B2.ShowAxis = false;
            ControlLinePlot7B2.ShowAxis = false;


        }
    }
} 
