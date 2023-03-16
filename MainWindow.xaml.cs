﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace dyrmyshi.leo._4h.Threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _counter = 0;
        const int NGIRI= 100;
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(Incrementa);
            t.Start();
        }

        void Incrementa()
        {
            for(int x = 0; x < NGIRI; x++)
            {
                _counter++;
                Dispatcher.Invoke(
                    () =>
                    {
                        txtCounter1.Text = _counter.ToString();
                    }
                );

                Thread.Sleep(500);
            }
        }
    }
}
