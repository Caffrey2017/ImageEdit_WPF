﻿/*
Basic image processing software
<https://github.com/nlabiris/ImageEdit_WPF>

Copyright (C) 2015  Nikos Labiris

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using ImageEdit_WPF.HelperClasses;
using System;
using System.Drawing;
using System.Windows;

namespace ImageEdit_WPF.Windows {
    /// <summary>
    /// Interaction logic for NoiseReductionMean.xaml
    /// </summary>
    public partial class NoiseReductionMean : Window {
        private ImageData m_data = null;

        /// <summary>
        /// Size of the kernel.
        /// </summary>
        private int m_sizeMask = 0;

        /// <summary>
        /// Noise Reduction (Mean filter) <c>constructor</c>.
        /// Here we initialiaze the images and also we set the default kernel.
        /// </summary>
        public NoiseReductionMean(ImageData data) {
            m_data = data;

            InitializeComponent();
            three.IsChecked = true;
        }

        /// <summary>
        /// If 3x3 radioBox is checked, set kernel's size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void three_Checked(object sender, RoutedEventArgs e) {
            m_sizeMask = 3;
        }

        /// <summary>
        /// If 5x5 radioBox is checked, set kernel's size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void five_Checked(object sender, RoutedEventArgs e) {
            m_sizeMask = 5;
        }

        /// <summary>
        /// If 7x7 radioBox is checked, set kernel's size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seven_Checked(object sender, RoutedEventArgs e) {
            m_sizeMask = 7;
        }

        /// <summary>
        /// Implementation of the Noise Reduction (Mean filter) algorithm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ok_Click(object sender, RoutedEventArgs e) {
            // Apply algorithm and return execution time
            TimeSpan elapsedTime = Algorithms.NoiseReduction_Mean(m_data, m_sizeMask);

            // Set main image
            m_data.M_bitmapBind = m_data.M_bitmap.BitmapToBitmapSource();

            string messageOperation = "Done!\r\n\r\nElapsed time (HH:MM:SS.MS): " + elapsedTime;
            MessageBox.Show(messageOperation, "Elapsed time", MessageBoxButton.OK, MessageBoxImage.Information);

            m_data.M_noChange = false;
            m_data.M_action = ActionType.ImageConvolution;
            m_data.M_bmpUndoRedo = m_data.M_bitmap.Clone() as Bitmap;
            m_data.M_undoStack.Push(m_data.M_bmpUndoRedo);
            m_data.M_redoStack.Clear();
            foreach (Window mainWindow in Application.Current.Windows) {
                if (mainWindow.GetType() == typeof (MainWindow)) {
                    ((MainWindow)mainWindow).undo.IsEnabled = true;
                    ((MainWindow)mainWindow).redo.IsEnabled = false;
                }
            }
            Close();
        }
    }
}