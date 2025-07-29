﻿using Wpf.Ui.Abstractions.Controls;
using WPFUI.ViewModels.Pages;

namespace WPFUI.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
