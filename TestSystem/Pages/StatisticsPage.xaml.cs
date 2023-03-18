using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using TestSystem.Models;
using System.Linq;

namespace TestSystem.Pages
{
    /// <summary>
    /// Interaction logic for StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        
        public StatisticsPage()
        {
            InitializeComponent();
        }

        private void I2CSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string fileText = TextBlockResult.Text + "% - " + DateTime.Now;

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
            }

        }
    }
}
