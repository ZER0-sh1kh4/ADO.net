using DALclass;
namespace BusnisessList
{
    public class BusinessClass
    {
        public List<string> reverse()
        {
            DALList dal = new DALList();
            List<string> names = dal.GetNames();

            List<string> reversedList = new List<string>();

            foreach (string name in names)
            {
                char[] arr = name.ToCharArray();
                Array.Reverse(arr);
                reversedList.Add(new string(arr));
            }

            return reversedList;


        }
    }
}
