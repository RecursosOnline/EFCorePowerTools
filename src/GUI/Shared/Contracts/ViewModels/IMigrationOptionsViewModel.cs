﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Community.VisualStudio.Toolkit;
using EFCorePowerTools.Contracts.EventArgs;

namespace EFCorePowerTools.Contracts.ViewModels
{
    public interface IMigrationOptionsViewModel : IViewModel
    {
        event EventHandler<CloseRequestedEventArgs> CloseRequested;

        string Title { get; }

        string ApplyButtonContent { get; }

        SortedDictionary<string, string> StatusList { get; }

        string SelectedStatusKey { get; set; }

        string StatusMessage { get; set; }

        string MigrationName { get; set; }

        ICommand LoadedCommand { get; }
        ICommand ApplyCommand { get; }
        ICommand CancelCommand { get; }

        double BackgroundOpacity { get; }
        Visibility MigrationNameVisibility { get; }

        void UseProjectForMigration(Project project);
        void UseOutputPath(string outputPath);
    }
}
