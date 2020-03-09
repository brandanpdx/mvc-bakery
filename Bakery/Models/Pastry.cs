namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryQuantity { get; set; }
    public int GroupedPastry { get; set; }
    public int IndividualPastry { get; set;}

    public void PastryCalc(int qty)
    {
      PastryQuantity = qty;
      PastryPrice = qty * 2;

      if (PastryQuantity >= 3)
      {
      GroupedPastry = (qty / 3);
      IndividualPastry = (qty % 3);
      PastryPrice = (GroupedPastry * 5) + (IndividualPastry * 2); 
      }
    }
  }
}