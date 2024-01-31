namespace Exercise013
{
    public class Statistics
    {
        public int count { get; set; }
    public int sum { get; set; }

    public Statistics()
    {
      this.count = 0;
      this.sum  = 0;
    }


    public void AddNumber(int number)
    {
      // write code here
      this.count++;
      this.sum = sum + number;
    }
  }
}