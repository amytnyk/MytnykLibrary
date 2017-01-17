public class Lcm
{
  public int value;
  public Lcm(int a, int b)
  {
    Gcd gcd = new Gcd(a, b);
    this.value = a /gcd.value * b;
  }
}