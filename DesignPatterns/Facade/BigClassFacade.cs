namespace Facade
{
    public class BigClassFacade
    {
        private int _number;

        public int GetValueA()
            => _number;

        public string GetValueB()
            => "Ball of Mud";

        public void SetValueI(int number)
            => _number = number;

        public void IncrementI() => _number++;

        public void DecrememntWith(int secondNumber)
            => _number -= secondNumber;

        public int AddToI(int number)
        {
            _number += number;

            return _number;
        }

        public void UnrelatedMethod()
           => Console.WriteLine("Unrelated Method");

        public void AddSecontNumber(int secondNumber)
           => _number += secondNumber;
    }
}
