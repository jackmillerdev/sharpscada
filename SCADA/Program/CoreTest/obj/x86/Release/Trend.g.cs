﻿#pragma checksum "..\..\..\Trend.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1B342724173D1F60676E7E203DB0077B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CoreTest;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.Charts;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes;
using Microsoft.Research.DynamicDataDisplay.Charts.Axes.Numeric;
using Microsoft.Research.DynamicDataDisplay.Charts.Isolines;
using Microsoft.Research.DynamicDataDisplay.Charts.Markers;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using Microsoft.Research.DynamicDataDisplay.Charts.Shapes;
using Microsoft.Research.DynamicDataDisplay.Common.Palettes;
using Microsoft.Research.DynamicDataDisplay.Converters;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.MarkupExtensions;
using Microsoft.Research.DynamicDataDisplay.Navigation;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.ViewportRestrictions;
using Microsoft.Windows.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CoreTest {
    
    
    /// <summary>
    /// Trend
    /// </summary>
    public partial class Trend : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.DateTimePicker dtstart;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.DateTimePicker dtend;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PCheckBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popusBottom;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.CheckListBox chklist;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comodel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkshow;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.ColorPicker colorpicker;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.ChartPlotter chartPlotter1;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.HorizontalDateTimeAxis hTimeSpanAxis;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.Navigation.CursorCoordinateGraph cursor;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Trend.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Research.DynamicDataDisplay.Charts.Navigation.AxisCursorGraph axiscuror;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CoreTest;component/trend.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Trend.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\Trend.xaml"
            ((CoreTest.Trend)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.toolBar1 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 3:
            this.dtstart = ((Microsoft.Windows.Controls.DateTimePicker)(target));
            return;
            case 4:
            this.dtend = ((Microsoft.Windows.Controls.DateTimePicker)(target));
            return;
            case 5:
            this.PCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.popusBottom = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 7:
            this.chklist = ((Microsoft.Windows.Controls.CheckListBox)(target));
            return;
            case 8:
            this.comodel = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\..\Trend.xaml"
            this.comodel.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comodel_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.chkshow = ((System.Windows.Controls.CheckBox)(target));
            
            #line 45 "..\..\..\Trend.xaml"
            this.chkshow.Click += new System.Windows.RoutedEventHandler(this.chkshow_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.colorpicker = ((Microsoft.Windows.Controls.ColorPicker)(target));
            
            #line 46 "..\..\..\Trend.xaml"
            this.colorpicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Windows.Media.Color>(this.ColorPicker_SelectedColorChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.chartPlotter1 = ((Microsoft.Research.DynamicDataDisplay.ChartPlotter)(target));
            return;
            case 12:
            this.hTimeSpanAxis = ((Microsoft.Research.DynamicDataDisplay.Charts.HorizontalDateTimeAxis)(target));
            return;
            case 13:
            this.cursor = ((Microsoft.Research.DynamicDataDisplay.Charts.Navigation.CursorCoordinateGraph)(target));
            return;
            case 14:
            this.axiscuror = ((Microsoft.Research.DynamicDataDisplay.Charts.Navigation.AxisCursorGraph)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

