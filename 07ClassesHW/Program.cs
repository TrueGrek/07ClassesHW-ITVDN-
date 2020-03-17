using System;

namespace _07ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook note = new Notebook("M3", "Tesla", 150000);
            note.Show();
        }
    }
    struct Notebook
    {
        private string model;
        private string productManager;
        private int cost;

        public Notebook(string model, string productManager, int cost)
        {
            this.model = model;
            this.productManager = productManager;
            this.cost = cost;
        }

        public void Show()
        {
            Console.WriteLine("Model: {0}\nProduct: {1}\nCost: {2}", model, productManager, cost);
        }
    }
}
