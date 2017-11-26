using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMIInterface1
{
    public class ClassStoppages
    {
        public static long OrderCode;
        public static int PartID;
        public static string PartCode;
        public static string PartName;
        public static int StoppagesID;
        public static DateTime dateTimeStoppages;
        

    }
    public class ClassWaste
    {
        public static long OrderCode;
        public static int PartID;
        public static string PartCode;
        public static string PartName;
        public static int PartWasteId;
        public static string PartWasteCode;
        public static string PartWasteName;
        public static int LesionID;
        public static string LesionName;
        public static float Weight;
        public static string Formula;

    }
    public class ClassProduct
    {

        public static long OrderCode;
        public static int PartID;
        public static string PartCode;
        public static string PartName;
        public static string Formula;
        public static float Weight;
        public static float NumberOfBatch;
        public static float WeightContainer;
        public static long OrderCodeDestination;
        public static int ProductionLineIDOrderDestination;
        

    }
    public class ClassOperator
    {
        public static long OperatorID;
        public static string OperatorName;
        public static string Password;

    }
    public class ClassDatabase
    {
       public static  SqlConnection ConnectionServer = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
        public static SqlCommand Command;
    }
    public class ClassSetting
    {
        public static bool ShowContainer;
        public static bool ShowOrderDestination;
        public static string IP;
        public static int ProductionLineID;
        public static string ComPort;

    }
    public class ClassHome
    {
        public static long OrderCode;
        public static long PartID;

    }
    public class ClassReturned
    {
        public static long OrderCode;
        public static float Weight;
        public static float Amount1;
        public static long PartID;
    }
    public class ClassGetMaterial
    {
        public static long OrderCode;
        public static float Weight;
        public static float Amount;
        public static float Amount1;
        public static long PartID;
        public static long DestinationOrderCode;
        public static long DestinationProductionLineID;
        public static string IP;

    }

}
