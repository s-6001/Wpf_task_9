﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.IO;
using Microsoft.Win32;


namespace Wpf_task_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = (sender as ComboBox).SelectedItem.ToString();
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int fontSize = Convert.ToInt32((sender as ComboBox).SelectedItem.ToString());
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight != FontWeights.Bold)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textBox.FontWeight = FontWeights.Normal;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle != FontStyles.Italic)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations != TextDecorations.Underline)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textBox.TextDecorations = null;
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }
    }
}