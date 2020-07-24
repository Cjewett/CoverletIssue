using NetStandardReference;
using System.Data;
using System.Data.SqlClient;

namespace CoverletIssue
{
    public static class CoverletTesting
    {
        public static bool Reproduce(SqlDbType sqlDbType = SqlDbType.VarChar) 
        {
            if (sqlDbType == SqlDbType.VarChar)
            {
                return true;
            }

            return false;
        }

        public static bool ReproduceTwo(SqlBulkCopyOptions sqlBulkCopyOptions = SqlBulkCopyOptions.Default)
        {
            if (sqlBulkCopyOptions == SqlBulkCopyOptions.Default)
            {
                return true;
            }

            return false;
        }

        public static void Test()
        {
            Data test = new Data();
            test.Test();
        }
    }
}