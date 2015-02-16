using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SiparisListeleme
{
    public class Siparis
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public String FirmaAdi { get; set; }
        public String SiparisText { get; set; }
        public String AciklamaText { get; set; }
        public int  AdetText { get; set; }
        public int SiparisDurumId { get; set; }
        public String SiparisDurumText { get; set; }


        public Siparis()
        {

        }
        public static SqlConnection cnn = new SqlConnection("Server=.; Database=SERCANDB; Trusted_Connection = true;");

        public Siparis(int Id) {
            String sql = "select * from Siparis where Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", Id);
         
            
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.Id = reader.GetInt32(0);
                    this.MusteriId = reader.GetInt32(1);
                    this.SiparisText = reader.GetString(2);
                    this.AciklamaText = reader.GetString(3);
                    this.AdetText = reader.GetInt32(4);
                    this.SiparisDurumId = reader.GetInt32(5);

                }
                cnn.Close();
            }
        // Insert
        public void Insert()
        {


            String sql = "insert into Siparis (MusteriId, SiparisText, AciklamaText, AdetText,SiparisDurumId) VALUES (@MusteriId,@SiparisText,@AciklamaText,@AdetText,1)";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@MusteriId", this.MusteriId);
            cmd.Parameters.AddWithValue("@SiparisText", this.SiparisText);
            cmd.Parameters.AddWithValue("@AciklamaText", this.AciklamaText);
            cmd.Parameters.AddWithValue("@AdetText", this.AdetText);
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public List<Siparis>GetSiparis()
        {
            List<Siparis> siparisler= new List<Siparis>();

            String sql = "select"
            + " s.Id,m.Firm,s.SiparisText,s.AdetText,s.MusteriId,s.SiparisDurumId,sd.SiparisDurumText"
            + " from Siparis s"
            + " INNER JOIN musteri m ON m.Id = s.MusteriId"
            + " INNER JOIN SiparisDurum sd on s.SiparisDurumId = sd.SiparisDurumId";
            SqlCommand cmd = new SqlCommand(sql, cnn);
         
                cnn.Open();
                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Siparis s = new Siparis();
                        s.Id = reader.GetInt32(0);
                        s.FirmaAdi = reader.GetString(1);
                        s.SiparisText = reader.GetString(2);
                        s.AdetText = reader.GetInt32(3);
                        s.MusteriId = reader.GetInt32(4);
                        s.SiparisDurumId = reader.GetInt32(5);
                        s.SiparisDurumText = reader.GetString(6);
                        siparisler.Add(s);
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            
           
            return siparisler;
        }

        public List<Siparis> GetSiparis(int MusteriId)
        {
            List<Siparis> siparisler = new List<Siparis>();

            String sql = "select"
            + " s.Id,m.Firm,s.SiparisText,s.AdetText,s.SiparisDurumId,sd.SiparisDurumText"
            + " from Siparis s"
            + " INNER JOIN Musteri m ON m.Id = s.MusteriId"
            + " INNER JOIN SiparisDurum sd on s.SiparisDurumId = sd.SiparisDurumId"
            + " WHERE s.MusteriId = @MusteriId";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@MusteriId", MusteriId);

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Siparis s = new Siparis();
                    s.Id = reader.GetInt32(0);
                    s.MusteriId = reader.GetInt32(1);
                    s.SiparisText = reader.GetString(2);
                    s.AdetText = reader.GetInt32(3);
                    s.SiparisDurumId = reader.GetInt32(4);
                    s.SiparisDurumText = reader.GetString(5);
                    siparisler.Add(s);
                }
            }
            catch (Exception ex)
            {
                String msg = ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }
            return siparisler;
        }

        public void Save() {
            String sql = "update Siparis set"
                + " MusteriId = @MusteriId,"
                + " SiparisText = @SiparisText,"
                + " AciklamaText = @AciklamaText,"
                + " AdetText = @AdetText,"
                + " SiparisDurumId = @SiparisDurumId"
                + " where Id = @Id";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@MusteriId", this.MusteriId);
            cmd.Parameters.AddWithValue("@SiparisText", this.SiparisText);
            cmd.Parameters.AddWithValue("@AciklamaText", this.AciklamaText);
            cmd.Parameters.AddWithValue("@AdetText", this.AdetText);
            cmd.Parameters.AddWithValue("@SiparisDurumId", this.SiparisDurumId);
            cmd.Parameters.AddWithValue("@Id", this.Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();


        }
          

        }

    

    }
