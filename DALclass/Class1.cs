using System.Reflection.Metadata.Ecma335;

namespace DALclass
{
    public class DALList

    {
        public List<string> GetNames()
        {
            List<string> students = new List<string>() { "shikha", "AAkarsh", "Anuskha", "Sparsh", "Shivam" };
            return students;
        }

    }
}
