using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace KONKURS2.Pages.YRITUSED
{
    public class createModel : PageModel
    {
        public YrituseInfo YrituseInfo = new YrituseInfo();
        public String errorMessage = "";
        public String onSuccess = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            YrituseInfo.nimi = Request.Form["nimi"];
            YrituseInfo.aeg = Request.Form["aeg"];
            YrituseInfo.koht = Request.Form["koht"];
            YrituseInfo.kirj = Request.Form["kirj"];

            if (YrituseInfo.nimi.Length == 0 || YrituseInfo.aeg.Length == 0 || YrituseInfo.koht.Length == 0 || YrituseInfo.kirj.Length == 0)
            {
                errorMessage = "All of the fields are required!";
                return;
            }

            //HERE WE NEED TO SAVE THE DATA TO THE DATABASE
            try
            {
                String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=konkurs;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO yritused " +
                                "(nimi, aeg, koht, kirj) VALUES " +
                                 "(@nimi, @aeg, @koht, @kirj);";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nimi", YrituseInfo.nimi);
                        command.Parameters.AddWithValue("@aeg", YrituseInfo.aeg);
                        command.Parameters.AddWithValue("@koht", YrituseInfo.koht);
                        command.Parameters.AddWithValue("@kirj", YrituseInfo.kirj);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }
            //SUCCESS MESSAGE (DOES NOT WORK CURRENTLY, INVESTIGATING
            YrituseInfo.nimi = ""; YrituseInfo.aeg = ""; YrituseInfo.koht = ""; YrituseInfo.kirj = "";
            onSuccess = "New Üritus added";

            Response.Redirect("/YRITUSED/Index");
        }
    }
}
