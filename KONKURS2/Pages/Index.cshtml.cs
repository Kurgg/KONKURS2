using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace KONKURS2.Pages
{
    public class IndexModel : PageModel
    {
        public List<YrituseInfo> listYritused = new List<YrituseInfo>();

        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=konkurs;Integrated Security=True"; //CONNECTION TO SQL DATABASE

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM yritused"; //SELECTS EVERYTHING

                    using (SqlCommand command = new SqlCommand(sql, connection))

                    {
                        using (SqlDataReader reader = command.ExecuteReader())

                        {
                            while (reader.Read())
                            {
                                YrituseInfo yrituseinfo = new YrituseInfo(); //GETS THE INFORMATION FROM THE TABLE AND IMPLEMENTS IT INTO "listYritused" FOR HTML USE
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
    public class IndexModel2 : PageModel // ???, Can't find fix on how to implement double model into cshtml
    {
        public List<toimunud_yritused> toiYritused = new List<toimunud_yritused>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=konkurs;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM toimunud_yritused";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                toimunud_yritused toim_yritused = new toimunud_yritused();
                                toim_yritused.id = "" + reader.GetInt32(0);
                                toim_yritused.nimi = reader.GetString(1);
                                toim_yritused.aeg = reader.GetDateTime(2).ToString();
                                toim_yritused.koht = reader.GetString(3);
                                toim_yritused.kirj = reader.GetString(4);

                                toiYritused.Add(toim_yritused);
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

    public class toimunud_yritused //PLACEHOLDER
    {
        public string id;
        public string nimi;
        public string aeg;
        public string koht;
        public string kirj;
    }
}

