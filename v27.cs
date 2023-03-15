namespace v27
{
    interface IHitung{
        void judul(string j);
        int kali(int a, int b);
        int tambah(int a, int b);
    }

    class Kalkulator:IHitung
    {
        public void judul(string j){
           Console.WriteLine(j);
        }

        public int kali(int a, int b){
            return a * b;
        }
        public int tambah(int a, int b){
            return a + b;
        }
    }
}