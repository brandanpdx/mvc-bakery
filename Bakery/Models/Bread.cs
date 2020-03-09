namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQuantity { get; set; }
    public int BreadTotal { get; set; }
    public int GroupedLoaves { get; set; }
    public int IndividualLoaves { get; set; }

    public void BreadCalc(int qty)
    {
      BreadQuantity = qty;
      BreadPrice = qty * 5;

      if (BreadQuantity >= 3)
      {
      GroupedLoaves = (qty / 3);
      IndividualLoaves = (qty % 3);
      BreadPrice = (GroupedLoaves * 10) + (IndividualLoaves * 5); 
      }
    }
  }
}

