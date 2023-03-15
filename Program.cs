using v27;

Kalkulator kal = new Kalkulator();
kal.judul("Luas Persegi Panjang ");
Console.Write("masukkan p : ");
int p = Convert.ToInt16(Console.ReadLine());
Console.Write("masukkan l : ");
int l = Convert.ToInt16(Console.ReadL1ine());
Console.Write($"luas persegi panjang dengan p :{p} dan l : {l} adalah : ");
Console.WriteLine(kal.kali(p,l));