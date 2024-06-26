﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Aura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddMusic_OnClick(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new()
            {
                IsFolderPicker = true
            };
            if (openFileDialog.ShowDialog() != CommonFileDialogResult.Ok) return;
            var files = openFileDialog.FileNames;
            foreach (var file in files)
            {
                tracks.SelectedItems.Add(file);
            }
        }
    }
}