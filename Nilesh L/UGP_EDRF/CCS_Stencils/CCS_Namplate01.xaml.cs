// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CCS_Namplate01.xaml.cs" company="RSI">
//   
// </copyright>
// <summary>
//   Interaction logic for CCS_Namplate01.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Windows;
using RSI.Emulation.Controls.Control;
using System.Windows.Controls;
using System.ComponentModel;
using RSI.IndissLike.Controls;
using RSI.FoxboroEVO.Core.Helpers;

namespace UGP_EDRF.CCS_Stencils
{
    /// <summary>
    /// Interaction logic for CCS_Namplate01.xaml
    /// </summary>
    public partial class CCS_Namplate01
    {
        public CCS_Namplate01()
        {
            this.InitializeComponent();


        }


        /// <summary>
        /// NameplateDescription Property
        /// </summary>
        public static readonly DependencyProperty NameplateDescriptionProperty =
            DependencyProperty.Register("$NameplateDescription", typeof(string), typeof(CCS_Namplate01));

        /// <summary>
        /// Gets or sets the NameplateDescription.  
        /// </summary>
		[Category("RSI")]
        [Description(@"Nameplate")]
        public string NameplateDescription
        {
            get { return (string)this.GetValue(NameplateDescriptionProperty); }
            set { this.SetValue(NameplateDescriptionProperty, value); }
        }





        //public override bool HasIndissLikeParameters => true;

        //public override IEnumerable<Param> IndissLikeParameters
        //{
        //    get
        //    {
        //        foreach (var p in base.IndissLikeParameters)
        //        {
        //            yield return p;
        //        }


        //        if (!string.IsNullOrWhiteSpace(this.NameplateDescription)) yield return new Param("$NameplateDescription", this.NameplateDescription);

        //    }
        //}

    }
}