public class Kalkulator
{
    public int Tambah(int a, int b) => a + b;

    public int Kurang(int a, int b) => a - b;

    public int Kali(int a, int b) => a * b;

    public double Bagi(int a, int b)
{
    return b == 0 ? 0 : (double)a / b;
}


}
