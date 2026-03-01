using MVC;
namespace business
{
    public class BLCal
    {
        public int BLAdd(int a,int b)
        {
            DALCal cal = new DALCal();
            int sum = cal.dalAdd(a, b);
            return sum -1;

        }
    }
}
