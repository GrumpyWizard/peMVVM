using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using peMVVM.GUI.ViewModels;

namespace peMVVM.GUI
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);
      peMVVM.GUI.MainWindow window = new peMVVM.GUI.MainWindow();
      peViewModel peVM = new peViewModel();
      window.DataContext = peVM;
      window.Show();
    }
  }
}
