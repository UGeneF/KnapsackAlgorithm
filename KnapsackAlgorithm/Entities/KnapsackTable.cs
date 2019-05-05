namespace KnapsackAlgorithm.Entities
{
    public class KnapsackTable
    {
        private double[] _prevLine;
        private double[] _currentLine;

        public KnapsackTable(int knapsackWeight)
        {
            _prevLine = new double[knapsackWeight + 1];
            _currentLine = new double[knapsackWeight + 1];
        }

        public double GetPrevCost(int weight)
        {
            return _prevLine[weight];
        }

        public void SetCurrentCost(int weight, double value)
        {
            _currentLine[weight] = value;
        }

        public void NewLine()
        {
            CopyCurrentLineToPrev();
            ResetCurrentLine();
        }

        public double GetResult()
        {
            return GetPrevCost(_prevLine.Length - 1);
        }

        private void ResetCurrentLine()
        {
            for (var i = 0; i < _currentLine.Length; i++)
            {
                _currentLine[i] = 0;
            }
        }

        private void CopyCurrentLineToPrev()
        {
            for (var i = 0; i < _prevLine.Length; i++)
            {
                _prevLine[i] = _currentLine[i];
            }
        }
    }
}