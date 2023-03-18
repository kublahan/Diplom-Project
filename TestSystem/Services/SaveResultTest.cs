using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.Models;

namespace TestSystem.Services
{
    internal class SaveResultTest
    {
        //private readonly DialogService _dialogService;
        //private readonly CustomFileService _customFileService;
        //private readonly PageNavigationService _navigationService;
        //private readonly Repository _repository;

        //private Test currentTest;
        //public Test CurrentTest
        //{
        //    get => currentTest;
        //    set
        //    {
        //        currentTest = value;
        //    }
        //}


        //public SaveResultTest(DialogService dialogService, CustomFileService customFileService, PageNavigationService navigationService, Repository repository)
        //{
        //    _dialogService = dialogService;
        //    _customFileService = customFileService;
        //    _navigationService = navigationService;
        //    _repository = repository;
        //}


        //public void SaveResultToFile(Results Results)
        //{
        //    if (_dialogService.SaveFileDialog(out string filepath))
        //    {
        //        try
        //        {
        //            _customFileService.WriteResultToFile(filepath, Results);
        //            _dialogService.ShowMessage("Тест сохранен успешно!");
        //        }
        //        catch (Exception e)
        //        {
        //            _dialogService.ShowMessage(e.Message);
        //        }
        //    }
        //    else
        //    {
        //        _dialogService.ShowMessage("Неверный путь к файлу");
        //    }
        //}

        private readonly TestState _testState;


    }
}
