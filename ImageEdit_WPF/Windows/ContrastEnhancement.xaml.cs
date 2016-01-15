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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows;

namespace ImageEdit_WPF.Windows {
    /// <summary>
    /// Interaction logic for ContrastEnhancement.xaml
    /// </summary>
    public partial class ContrastEnhancement : Window {
        private ImageEditData m_data = null;

        /// <summary>
        /// Contrast Enhancement <c>constructor</c>.
        /// Here we initialiaze the images and also we set the focus at the textBox being used.
        /// </summary>
        public ContrastEnhancement(ImageEditData data) {
            m_data = data;

            InitializeComponent();
            textboxBrightness.Focus();
        }

        /// <summary>
        /// Implementation of the Contrast Enhancement algorithm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ok_Click(object sender, RoutedEventArgs e) {
            int brightness = 0;
            double contrast = 0;
            double r = 0;
            double g = 0;
            double b = 0;

            try {
                contrast = double.Parse(textboxContrast.Text, new CultureInfo("el-GR"));
                brightness = int.Parse(textboxBrightness.Text);
                //if (brightness > 255 || brightness < 0)
                //{
                //    String message = "Wrong range" + Environment.NewLine + Environment.NewLine + "Give a number between 0 and 255";
                //    MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //    return;
                //}
            } catch (ArgumentNullException ex) {
                MessageBox.Show(ex.Message, "ArgumentNullException", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
                return;
            } catch (FormatException ex) {
                MessageBox.Show(ex.Message, "FormatException", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
                return;
            } catch (OverflowException ex) {
                MessageBox.Show(ex.Message, "OverflowException", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
                return;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
                return;
            }

            // Lock the bitmap's bits.  
            BitmapData bmpData = m_data.M_bitmap.LockBits(new Rectangle(0, 0, m_data.M_bitmap.Width, m_data.M_bitmap.Height), ImageLockMode.ReadWrite, m_data.M_bitmap.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap. 
            int bytes = Math.Abs(bmpData.Stride)*m_data.M_bitmap.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            Marshal.Copy(ptr, rgbValues, 0, bytes);

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < m_data.M_bitmap.Width; i++) {
                for (int j = 0; j < m_data.M_bitmap.Height; j++) {
                    int index = (j*bmpData.Stride) + (i*3);

                    r = (rgbValues[index + 2] + brightness)*contrast;
                    g = (rgbValues[index + 1] + brightness)*contrast;
                    b = (rgbValues[index] + brightness)*contrast;

                    if (r > 255.0) {
                        r = 255.0;
                    } else if (r < 0.0) {
                        r = 0.0;
                    }

                    if (g > 255.0) {
                        g = 255.0;
                    } else if (g < 0.0) {
                        g = 0.0;
                    }

                    if (b > 255.0) {
                        b = 255.0;
                    } else if (b < 0.0) {
                        b = 0.0;
                    }

                    rgbValues[index + 2] = (byte)r;
                    rgbValues[index + 1] = (byte)g;
                    rgbValues[index] = (byte)b;
                }
            }

            watch.Stop();
            TimeSpan elapsedTime = watch.Elapsed;

            // Copy the RGB values back to the bitmap
            Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            m_data.M_bitmap.UnlockBits(bmpData);

            m_data.M_bitmapBind = m_data.M_bitmap.BitmapToBitmapSource();

            string messageOperation = "Done!\r\n\r\nElapsed time (HH:MM:SS.MS): " + elapsedTime;
            MessageBoxResult result = MessageBox.Show(messageOperation, "Elapsed time", MessageBoxButton.OK, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK) {
                m_data.M_noChange = false;
                m_data.M_action = ActionType.ContrastEnhancement;
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
}