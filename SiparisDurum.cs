using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SiparisListeleme
{
    public class SiparisDurum
    {
        public int SiparisDurumId { get; set; }
        public String SiparisDurumText { get; set; }

        public static SqlConnection cnn = new SqlConnection("Server=.; Database=SERCANDB; Trusted_Connection = true;");

        public static List<SiparisDurum> getAllSiparisDurum()
        {
            List<SiparisDurum> siparisDurumList = new List<SiparisDurum>();

            String sql = "select * from SiparisDurum";

            SqlCommand cmd = new SqlCommand(sql, cnn);
           
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                SiparisDurum sd = new SiparisDurum();
                sd.SiparisDurumId = int.Parse(reader["SiparisDurumId"].ToString());
                sd.SiparisDurumText = reader["SiparisDurumText"].ToString();
                siparisDurumList.Add(sd);
            }
            reader.Close();
            cnn.Close();
            return siparisDurumList;
        }
    }
}