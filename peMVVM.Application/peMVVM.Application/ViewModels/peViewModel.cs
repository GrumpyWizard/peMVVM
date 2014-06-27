using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace peMVVM.GUI.ViewModels
{
  class peViewModel
  {

    #region RelayCommands
    private RelayCommand _goCommand;
    public RelayCommand GoCommand { get { return _goCommand ?? (_goCommand = new RelayCommand(() => { Go(); }, () => IsValidData()));  } }

    public void Go()
    {
      // {@} nyi
    }

    public bool IsValidData()
    {
      // {@} nyi
      return true;
    }
    #endregion
  }
}
