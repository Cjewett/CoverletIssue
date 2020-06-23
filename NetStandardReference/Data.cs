using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace NetStandardReference
{
    public class Data
    {
        public void Test()
        {
            string pattern = @"\b(\w+)\s\1\b";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches("blahblah");

            SqlDbType test = SqlDbType.VarChar;
            DbDataReader dbDataReader;
        }
    }
}