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
using System.Runtime.InteropServices;
using System.Windows;

namespace ImageEdit_WPF.Windows {
    /// <summary>
    /// Interaction logic for NoiseReductionMedian.xaml
    /// </summary>
    public partial class NoiseReductionMedian : Window {
        private ImageEditData m_data = null;

        /// <summary>
        /// Size of the kernel.
        /// </summary>
        private int _sizeMask = 0;

        /// <summary>
        /// Noise Reduction (Median filter) <c>constuctor</c>.
        /// Here we initialiaze the images and also we set the default kernel.
        /// </summary>
        public NoiseReductionMedian(ImageEditData data) {
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
            _sizeMask = 3;
        }

        /// <summary>
        /// If 5x5 radioBox is checked, set kernel's size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void five_Checked(object sender, RoutedEventArgs e) {
            _sizeMask = 5;
        }

        /// <summary>
        /// If 7x7 radioBox is checked, set kernel's size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seven_Checked(object sender, RoutedEventArgs e) {
            _sizeMask = 7;
        }

        /// <summary>
        /// Implementation of the Noise Reduction (Median filter) algorithm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ok_Click(object sender, RoutedEventArgs e) {
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int z = 0;
            int aR = 0;
            int aG = 0;
            int aB = 0;
            int[] arR = new int[121];
            int[] arG = new int[121];
            int[] arB = new int[121];

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

            if (_sizeMask == 3) {
                for (i = _sizeMask/2; i < m_data.M_bitmap.Width - _sizeMask/2; i++) {
                    for (j = _sizeMask/2; j < m_data.M_bitmap.Height - _sizeMask/2; j++) {
                        int index;
                        z = 0;

                        for (k = 0; k < _sizeMask; k++) {
                            for (l = 0; l < _sizeMask; l++) {
                                index = ((j + l - 1)*bmpData.Stride) + ((i + k - 1)*3);
                                arR[z] = rgbValues[index + 2];
                                arG[z] = rgbValues[index + 1];
                                arB[z] = rgbValues[index];
                                z++;
                            }
                        }

                        for (k = 1; k <= _sizeMask*_sizeMask - 1; k++) {
                            aR = arR[k];
                            aG = arG[k];
                            aB = arB[k];
                            l = k - 1;

                            while (l >= 0 && arR[l] > aR) {
                                arR[l + 1] = arR[l];
                                l--;
                            }
                            while (l >= 0 && arG[l] > aG) {
                                arG[l + 1] = arG[l];
                                l--;
                            }
                            while (l >= 0 && arB[l] > aB) {
                                arB[l + 1] = arB[l];
                                l--;
                            }

                            arR[l + 1] = aR;
                            arG[l + 1] = aG;
                            arB[l + 1] = aB;
                        }

                        index = (j*bmpData.Stride) + (i*3);

                        rgbValues[index + 2] = (byte)arR[_sizeMask*_sizeMask/2];
                        rgbValues[index + 1] = (byte)arG[_sizeMask*_sizeMask/2];
                        rgbValues[index] = (byte)arB[_sizeMask*_sizeMask/2];
                    }
                }
            } else if (_sizeMask == 5) {
                for (i = _sizeMask/2; i < m_data.M_bitmap.Width - _sizeMask/2; i++) {
                    for (j = _sizeMask/2; j < m_data.M_bitmap.Height - _sizeMask/2; j++) {
                        int index;
                        z = 0;

                        for (k = 0; k < _sizeMask; k++) {
                            for (l = 0; l < _sizeMask; l++) {
                                index = ((j + l - 1)*bmpData.Stride) + ((i + k - 1)*3);
                                arR[z] = rgbValues[index + 2];
                                arG[z] = rgbValues[index + 1];
                                arB[z] = rgbValues[index];
                                z++;
                            }
                        }

                        for (k = 1; k <= _sizeMask*_sizeMask - 1; k++) {
                            aR = arR[k];
                            aG = arG[k];
                            aB = arB[k];
                            l = k - 1;

                            while (l >= 0 && arR[l] > aR) {
                                arR[l + 1] = arR[l];
                                l--;
                            }
                            while (l >= 0 && arG[l] > aG) {
                                arG[l + 1] = arG[l];
                                l--;
                            }
                            while (l >= 0 && arB[l] > aB) {
                                arB[l + 1] = arB[l];
                                l--;
                            }

                            arR[l + 1] = aR;
                            arG[l + 1] = aG;
                            arB[l + 1] = aB;
                        }

                        index = (j*bmpData.Stride) + (i*3);

                        rgbValues[index + 2] = (byte)arR[_sizeMask*_sizeMask/2];
                        rgbValues[index + 1] = (byte)arG[_sizeMask*_sizeMask/2];
                        rgbValues[index] = (byte)arB[_sizeMask*_sizeMask/2];
                    }
                }
            } else if (_sizeMask == 7) {
                for (i = _sizeMask/2; i < m_data.M_bitmap.Width - _sizeMask/2; i++) {
                    for (j = _sizeMask/2; j < m_data.M_bitmap.Height - _sizeMask/2; j++) {
                        int index;
                        z = 0;

                        for (k = 0; k < _sizeMask; k++) {
                            for (l = 0; l < _sizeMask; l++) {
                                index = ((j + l - 1)*bmpData.Stride) + ((i + k - 1)*3);
                                arR[z] = rgbValues[index + 2];
                                arG[z] = rgbValues[index + 1];
                                arB[z] = rgbValues[index];
                                z++;
                            }
                        }

                        for (k = 1; k <= _sizeMask*_sizeMask - 1; k++) {
                            aR = arR[k];
                            aG = arG[k];
                            aB = arB[k];
                            l = k - 1;

                            while (l >= 0 && arR[l] > aR) {
                                arR[l + 1] = arR[l];
                                l--;
                            }
                            while (l >= 0 && arG[l] > aG) {
                                arG[l + 1] = arG[l];
                                l--;
                            }
                            while (l >= 0 && arB[l] > aB) {
                                arB[l + 1] = arB[l];
                                l--;
                            }

                            arR[l + 1] = aR;
                            arG[l + 1] = aG;
                            arB[l + 1] = aB;
                        }

                        index = (j*bmpData.Stride) + (i*3);

                        rgbValues[index + 2] = (byte)arR[_sizeMask*_sizeMask/2];
                        rgbValues[index + 1] = (byte)arG[_sizeMask*_sizeMask/2];
                        rgbValues[index] = (byte)arB[_sizeMask*_sizeMask/2];
                    }
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
}