﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomDepPropApp
{
    /// <summary>
    /// Interaction logic for ShowNumberControl.xaml
    /// </summary>
    public partial class ShowNumberControl : UserControl  // Must Extend DepedenceyObject
    {        
        public ShowNumberControl()
        {
            InitializeComponent();
        }


        #region The CurrentNumber dependency property.
        
        public int CurrentNumber
        {
            get { return (int)GetValue(CurrentNumberProperty); }
            set 
            { 
                SetValue(CurrentNumberProperty, value); 
                MessageBox.Show("In SET"); 
            }
        }

        // Note the second param of UIPropertyMetadata.
        public static readonly DependencyProperty CurrentNumberProperty =
            DependencyProperty.Register("CurrentNumber", typeof(int), typeof(ShowNumberControl),
            new UIPropertyMetadata(100, new PropertyChangedCallback(CurrentNumberChanged)), 
            new ValidateValueCallback(ValidateCurrentNumber));

        public static bool ValidateCurrentNumber(object value)
        {
            // Just a simple business rule.  Value must be between 0 and 500.
            if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 500)
                return true;
            else
                return false;
            
        }

        private static void CurrentNumberChanged(DependencyObject depObj, 
            DependencyPropertyChangedEventArgs args)
        {
            // Cast the DependencyObject into ShowNumberControl
            ShowNumberControl c = (ShowNumberControl)depObj;

            // Get the Label control in the ShowNumberControl.
            Label theLabel = c.numberDisplay;

            // Set the label with the new value.
            theLabel.Content = args.NewValue.ToString();
        }
        
        #endregion
        
        
         // A Normal, every day .NET property
        // private int currNumber = 0;
        //public int CurrentNumber
        //{
        //    get { return currNumber; }
        //    set 
        //    { 
        //        currNumber = value;
        //        numberDisplay.Content = CurrentNumber.ToString();
        //    }
        //}
    }
}
