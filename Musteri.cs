using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SiparisListeleme
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public String Firm { get; set; }
        public long TelNo { get; set; }
        public string Email { get; set; }

        public static SqlConnection cnn = new SqlConnection("Server=.; Database=SERCANDB; Trusted_Connection = true;");

            public void Insert() { 
            String sql = "insert into musteri ("
            +" Name,SurName,Firm,TelNo,Email"
            +" )VALUES ("
            + " @Name,@SurName,@Firm,@TelNo,@Email"
            +" )";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", this.Id);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@SurName", this.SurName);
            cmd.Parameters.AddWithValue("@Firm", this.Firm);
            cmd.Parameters.AddWithValue("@TelNo", this.TelNo);
            cmd.Parameters.AddWithValue("@Email", this.Email);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        
            public List<Musteri> GetAll()
            {
                List<Musteri> musteriler = new List<Musteri>();

                String sql = "Select * from Musteri";
                    
                SqlCommand cmd = new SqlCommand(sql, cnn);
              

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Musteri c = new Musteri();
                    c.Id = int.Parse(reader["Id"].ToString());
                    c.Name = reader["Name"].ToString();
                    c.SurName = reader["SurName"].ToString();
                    c.Firm = reader["Firm"].ToString();
                    c.TelNo = long.Parse(reader["TelNo"].ToString());
                    c.Email = reader["Email"].ToString();
                    musteriler.Add(c);
                }
                cnn.Close();


                return musteriler;

            }

            public List<Musteri> GetOne(int musteriId)
            {
                List<Musteri> musteriler = new List<Musteri>();

                String sql = "Select * from Musteri m"
                   + " inner join Siparis s on m.BrandId = s.Id"
                    + " where m.Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Id", musteriId);
                
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Musteri c = new Musteri();
                    c.Id = int.Parse(reader["Id"].ToString());
                    c.Name = reader["Name"].ToString();
                    c.SurName = reader["SurName"].ToString();
                    c.Firm = reader["Firm"].ToString();
                    c.TelNo = long.Parse(reader["TelNo"].ToString());
                    c.Email = reader["Email"].ToString();
                    musteriler.Add(c);
                }
                cnn.Close();


                return musteriler;

            }
        public Musteri()
        {


        }

        public Musteri(int musteriId)
        {
            String sql = "Select * from Musteri m"
                   + " inner join Siparis s on m.BrandId = s.Id"
                    + " where m.Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", musteriId);
          
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Musteri c = new Musteri();
                c.Id = int.Parse(reader["Id"].ToString());
                c.Name = reader["Name"].ToString();
                c.SurName = reader["SurName"].ToString();
                c.Firm = reader["Firm"].ToString();
                c.TelNo = long.Parse(reader["TelNo"].ToString());
                c.Email = reader["Email"].ToString();
            }
            cnn.Close();
        }
        public void Delete()
        {
            String sql = "Delete from Musteri where Id = @Id";

            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Id", this.Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void Save()
        {
            String sql = "update Musteri set"
                + " Name = @Name,"
                + " SurName = @Surname,"
                + " Firm = @Firm,"
                + " TelNo = @TelNo,"
                + " Email = @Email,"
                + " where"
                + " Id = @Id";

            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@Name", this.Name);
            cmd.Parameters.AddWithValue("@SurName", this.SurName);
            cmd.Parameters.AddWithValue("@Firm", this.Firm);
            cmd.Parameters.AddWithValue("@TelNo", this.TelNo);
            cmd.Parameters.AddWithValue("@Email", this.Email);
            cmd.Parameters.AddWithValue("@Id", this.Id);

            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}