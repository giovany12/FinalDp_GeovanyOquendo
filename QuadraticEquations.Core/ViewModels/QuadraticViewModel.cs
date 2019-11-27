using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System.Threading.Tasks;

namespace QuadraticEquations.Core.ViewModels
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        private int _a;
        private int _b;
        private int _c;
        private decimal _x1;
        private decimal _x2;

        public QuadraticViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public int A
        {
            get => _a;
            set
            {
                _a = value;
                RaisePropertyChanged(() => A);
                Recalculate();
            }
        }

        public int B
        {
            get => _b;
            set
            {
                _b = value;
                RaisePropertyChanged(() => B);
                Recalculate();
            }
        }

        public int C
        {
            get => _c;
            set
            {
                _c = value;
                RaisePropertyChanged(() => C);
                Recalculate();
            }
        }

        public decimal X1
        {
            get => _x1;
            set
            {
                _x1 = value;
                RaisePropertyChanged(() => X1);
            }
        }

        public decimal X2
        {
            get => _x2;
            set
            {
                _x2 = value;
                RaisePropertyChanged(() => X2);
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            A = 1;
            B = 2;
            C = 3;
            Recalculate();
        }

        private void Recalculate()
        {
            X1 = _calculationService.QuadraticPos(A, B, C);
            X2 = _calculationService.QuadraticNeg(A, B, C);
        }
    }
}
