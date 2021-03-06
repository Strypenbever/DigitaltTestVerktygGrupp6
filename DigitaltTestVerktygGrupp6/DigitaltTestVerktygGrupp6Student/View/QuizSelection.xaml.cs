﻿using DigitaltTestVerktygGrupp6Student.Model;
using DigitaltTestVerktygGrupp6Student.ViewModel;
using System;
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

namespace DigitaltTestVerktygGrupp6Student.View
{
    /// <summary>
    /// Interaction logic for Quiz.xaml
    /// </summary>
    public partial class QuizSelection : Page
    {
        private QuizViewmodel viewModel;
        public QuizSelection()
        {
            InitializeComponent();
            viewModel = QuizViewmodel.Instance;
            DataContext = viewModel;
            InitializeComponent();

            FontSize = 16;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ContentFrame.Navigate(new Quiz());          
        }

        private void QuizList_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as ListView).SelectedIndex = 0;
        }

        private void btnShowFinishedTests_Click(object sender, RoutedEventArgs e)
        {
            viewModel.NavigateTo(new FinishedQuizes());
            viewModel.GetFinishedQuizes(viewModel.ActiveStudent);
        }
    }
}
