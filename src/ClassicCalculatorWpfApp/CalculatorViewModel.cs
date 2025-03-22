using ClassicCalculator;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;

namespace ClassicCalculatorWpfApp
{
    public partial class CalculatorViewModel(
        ICalculator calculator, ILogger<CalculatorViewModel> logger) : ObservableObject
    {
        public string DisplayValue => _calculator.DisplayValue;


        private readonly ICalculator _calculator = calculator;

        [RelayCommand]
        private void PressButton(CalculatorButton button)
        {
            logger.LogInformation("Button pressed: {Button}", button);
            _calculator.PressButton(button);
            OnPropertyChanged(nameof(DisplayValue));
        }
    }
}
