namespace ML
{
    public class Fact()
    {
        public int value;
        public Fact(int N)
        {
            if(N < 0)
                return 0;
            if (N == 0)
                return 1;
            else
                return N * Fact(N - 1);
        }
    }
    
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
    
    public class Lcm
    {
      public int value;
      public Lcm(int a, int b)
      {
        Gcd gcd = new Gcd(a, b);
        this.value = a /gcd.value * b;
      }
    }
}
