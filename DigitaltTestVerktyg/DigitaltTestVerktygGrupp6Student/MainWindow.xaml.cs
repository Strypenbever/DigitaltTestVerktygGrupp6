﻿using System;
using System.Collections.Generic;
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
using DigitaltTestVerktygGrupp6Student.Model;
using DigitaltTestVerktygGrupp6Student.View;
using DigitaltTestVerktygGrupp6Student.ViewModel;
using DigitaltTestVerktygGrupp6Student.Database;

namespace DigitaltTestVerktygGrupp6Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuizViewmodel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = QuizViewmodel.Instance;
            viewModel.ContentFrame = LoginFrame;
            viewModel.NavigateTo(new Loggin());
        }
    }
}
