public class Gcd
{
  public int value;
  public Gcd(int a, int b)
  {
    while (b != 0)
    {
      int r = a % b;
      a = b;
      b = r;
    }
    this.value = a;
  }
}