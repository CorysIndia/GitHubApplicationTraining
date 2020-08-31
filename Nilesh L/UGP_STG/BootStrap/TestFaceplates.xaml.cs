using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.ComponentModel.Composition;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using RSI.IndissLike.Controls.Controls;

namespace UGP_STG.BootStrap
{
    [ExportSynoptic("TestFaceplates")]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class TestFaceplates
    {

        private ObservableCollection<String> faceplatesNames;
        public ObservableCollection<String> FaceplatesNames
        {
            get
            {
                if (faceplatesNames == null)
                    faceplatesNames = new ObservableCollection<String>();
                return faceplatesNames;
            }
        }

        public TestFaceplates()
        {
            this.InitializeComponent();
            //var types =
            //    from type in Assembly.GetExecutingAssembly().GetTypes()
            //    where type is RSIFacePlate
            //    select type;

            var faceplateTypes =
                from type in Assembly.GetExecutingAssembly().GetTypes()
                where (type.BaseType.Name == "RSIFacePlate")
                select type;

            foreach (var facePlateType in faceplateTypes)
            {
                FaceplatesNames.Add(facePlateType.Name);
            }

            //FaceplatesNames.Add("FIC_0003");
        }
    }
}
