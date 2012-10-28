using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace helloBlend
{
    public partial class MainPage : PhoneApplicationPage
    {
        private int i;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            i = 0; 
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
			this.HideText.Begin();
        }

        private void HideText_Completed(object sender, EventArgs e)
        {
            __.Text = MessageTextBox.Text;
            MessageTextBox.Text = String.Empty;
            i++;
            if (i==1)
            {
                this.ShowText1.Begin();
            } else if (i==2) {
                this.ShowText2.Begin();
            } else {
                this.ShowText3.Begin();
                i = 0;
            }
        }
    }
}