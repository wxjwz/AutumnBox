﻿using AutumnBox.GUI.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutumnBox.GUI.View.Windows
{
    /// <summary>
    /// ChoiceWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ChoiceWindow : Window, INotifyPropertyChanged
    {
        public string Message
        {
            get => _message; set
            {
                _message = App.Current.Resources[value]?.ToString() ?? value;
                RaisePropertyChanged();
            }
        }
        private string _message;

        public string BtnLeft
        {
            get => _btnLeft; set
            {
                _btnLeft = App.Current.Resources[value]?.ToString() ?? value;
                RaisePropertyChanged();
            }
        }
        private string _btnLeft;

        public string BtnRight
        {
            get => _btnRight; set
            {
                _btnRight = App.Current.Resources[value]?.ToString() ?? value;
                RaisePropertyChanged();
            }
        }
        private string _btnRight;

        public string BtnCancel
        {
            get => _btnCancel; set
            {
                _btnCancel = App.Current.Resources[value]?.ToString() ?? value;
                RaisePropertyChanged();
            }
        }
        private string _btnCancel;

        public ChoiceWindow()
        {
            InitializeComponent();
            BtnCancel = "ChoiceWindowBtnCancel";
            BtnLeft = "ChoiceWindowBtnNo";
            BtnRight = "ChoiceWindowBtnYes";
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName]string caller = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = null;
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
