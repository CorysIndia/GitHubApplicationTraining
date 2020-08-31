using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using RSI.IndissPlus.Solution.Controls;

namespace UGP_EDRF.BootStrap.Framework.Alarms
{

    public static class PropertyGridExtension
    {
        public static readonly DependencyProperty ObserveVisibleItemsProperty = DependencyProperty.RegisterAttached(
            "ObserveVisibleItems", typeof(bool), typeof(PropertyGridExtension),
            new PropertyMetadata(false, OnObserveVisibleItemsChanged));

        public static readonly DependencyProperty VisibleItemsProperty = DependencyProperty.RegisterAttached(
            "VisibleItems", typeof(List<object>), typeof(PropertyGridExtension),
            new PropertyMetadata(null));

        private static readonly DependencyProperty SenderDataGridProperty = DependencyProperty.RegisterAttached(
            "SenderDataGrid", typeof(PropertyDataGrid), typeof(PropertyGridExtension), new PropertyMetadata(default(PropertyDataGrid)));

        private static void OnObserveVisibleItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PropertyDataGrid dataGrid = d as PropertyDataGrid;
            if (dataGrid == null)
                return;
            dataGrid.Loaded += DataGridLoaded;
        }

        private static void DataGridLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            PropertyDataGrid dataGrid = (PropertyDataGrid)sender;
            dataGrid.Loaded -= DataGridLoaded;
            ScrollViewer scrollViewer = FindChildren<ScrollViewer>(dataGrid).FirstOrDefault();
            if (scrollViewer != null)
            {
                SetSenderDataGrid(scrollViewer, dataGrid);
                scrollViewer.ScrollChanged += ScrollViewerOnScrollChanged;
                //ScrollViewerOnScrollChanged(scrollViewer, null);
                RefreshVisibleItems(scrollViewer);
            }

            dataGrid.SizeChanged += DataGridSizeChanged;


            dataGrid.Unloaded += DataGridUnloaded;
        }



        private static void DataGridUnloaded(object sender, RoutedEventArgs e)
        {
            PropertyDataGrid dataGrid = (PropertyDataGrid)sender;
            ScrollViewer scrollViewer = FindChildren<ScrollViewer>(dataGrid).FirstOrDefault();
            if (scrollViewer != null)
            {
                scrollViewer.ScrollChanged -= ScrollViewerOnScrollChanged;
            }
            dataGrid.SizeChanged -= DataGridSizeChanged;
            dataGrid.Unloaded -= DataGridUnloaded;
        }

        public static void SetObserveVisibleItems(DependencyObject element, bool value)
        {
            element.SetValue(ObserveVisibleItemsProperty, value);
        }

        public static bool GetObserveVisibleItems(DependencyObject element)
        {
            return (bool)element.GetValue(ObserveVisibleItemsProperty);
        }

        private static void SetSenderDataGrid(DependencyObject element, PropertyDataGrid value)
        {
            element.SetValue(SenderDataGridProperty, value);
        }

        private static PropertyDataGrid GetSenderDataGrid(DependencyObject element)
        {
            return (PropertyDataGrid)element.GetValue(SenderDataGridProperty);
        }

        private static void DataGridSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var dataGrid = sender as PropertyDataGrid;
            ScrollViewer scrollViewer = FindChildren<ScrollViewer>(dataGrid).FirstOrDefault();
            if (scrollViewer != null)
            {
                RefreshVisibleItems(scrollViewer);
            }
        }

        private static void ScrollViewerOnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            Console.WriteLine("ScrollViewerOnScrollChanged");
            ScrollViewer scrollViewer = sender as ScrollViewer;
            if (scrollViewer == null)
                return;

            RefreshVisibleItems(scrollViewer);
        }

        private static void RefreshVisibleItems(ScrollViewer scrollViewer)
        {
            ScrollBar verticalScrollBar =
                FindChildren<ScrollBar>(scrollViewer).FirstOrDefault(s => s.Orientation == Orientation.Vertical);
            if (verticalScrollBar != null)
            {
                PropertyDataGrid dataGrid = GetSenderDataGrid(scrollViewer);

                int totalCount = dataGrid.Items.Count;
                int firstVisible = (int)verticalScrollBar.Value;
                int lastVisible = (int)(firstVisible + totalCount - verticalScrollBar.Maximum);

                //List<Person> visiblePersons = new List<Person>();
                List<object> visibleItems = new List<object>();
                for (int i = firstVisible; i <= lastVisible; i++)
                {
                    if (i < dataGrid.Items.Count)
                        visibleItems.Add(dataGrid.Items[i]);
                }
                SetVisibleItems(dataGrid, visibleItems);
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public static void SetVisibleItems(DependencyObject element, List<object> value)
        {
            element.SetValue(VisibleItemsProperty, value);
        }

        public static List<object> GetVisibleItems(DependencyObject element)
        {
            return (List<object>)element.GetValue(VisibleItemsProperty);
        }

        private static IList<T> FindChildren<T>(DependencyObject element) where T : FrameworkElement
        {
            List<T> retval = new List<T>();
            for (int counter = 0; counter < VisualTreeHelper.GetChildrenCount(element); counter++)
            {
                FrameworkElement toadd = VisualTreeHelper.GetChild(element, counter) as FrameworkElement;
                if (toadd != null)
                {
                    T correctlyTyped = toadd as T;
                    if (correctlyTyped != null)
                    {
                        retval.Add(correctlyTyped);
                    }
                    else
                    {
                        retval.AddRange(FindChildren<T>(toadd));
                    }
                }
            }
            return retval;
        }
    }
}