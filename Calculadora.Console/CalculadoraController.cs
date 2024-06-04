namespace Calculadora.Console
{
    public class CalculadoraController
    {
        private List<string> historicoList;

        public CalculadoraController()
        {
            historicoList = new List<string>();
        }

        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;
            historicoList.Insert(0, "Res: " + res);
            return res;
        }

        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            historicoList.Insert(0, "Res: " + res);
            return res;
        }

        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            historicoList.Insert(0, "Res: " + res);
            return res;
        }

        public int Divisao(int n1, int n2)
        {
            int res = n1 / n2;
            historicoList.Insert(0, "Res: " + res);
            return res;
        }

        public List<string> historico()
        {
            historicoList.RemoveRange(3, historicoList.Count - 3);
            return historicoList;
        }
    }
}
