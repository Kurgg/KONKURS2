using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace KONKURS2.Pages.YRITUSED
{
    public class IndexModel : PageModel
    {
        public List<YrituseInfo> listYritused = new List<YrituseInfo>();    
        public void OnGet()
        {
            try
            {
                String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=konkurs;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); 
                    String sql = "SELECT * FROM yritused";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                YrituseInfo yrituseinfo = new YrituseInfo();
                                yrituseinfo.id = "" + reader.GetInt32(0);
                                yrituseinfo.nimi = reader.GetString(1);
                                yrituseinfo.aeg = reader.GetDateTime(2).ToString();
                                yrituseinfo.koht = reader.GetString(3);
                                yrituseinfo.kirj = reader.GetString(4);

                                listYritused.Add(yrituseinfo);


                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }
    }

    public class YrituseInfo
    {
        public string id;
        public string nimi;
        public string aeg;
        public string koht;
        public string kirj;
    }
}
