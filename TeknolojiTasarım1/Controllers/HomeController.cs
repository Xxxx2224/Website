using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Data.SqlClient;
using System.Diagnostics;
using TeknolojiTasarım1.Models;
using Microsoft.SqlServer;
using System.ComponentModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Drawing.Drawing2D;

namespace TeknolojiTasarım1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Elektronik()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'elektronik';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Kitap()
        {
			SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
			SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Kitap';", con);
			List<xxx> model1 = new List<xxx>();
			con.Open();
			SqlDataReader veri = cmd.ExecuteReader();
			while (veri.Read())
			{
				model1.Add(new xxx
				{
					id = (string)veri["id"],
					baslık = (string)veri["baslık"],
					fiyat = (string)veri["fiyat"],
					kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
			}
			con.Close();
			return View(model1);
		}
        public IActionResult EvAletleri()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Ev Aletleri';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Otomotiv()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Otomotiv';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Mobilya()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Mobilya';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Oyuncak()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Oyuncak';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Spor()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Spor';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Sağlık()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Sağlık';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Oyun()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Oyun';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
        public IActionResult Giyim()
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_3 WHERE kategori = 'Giyim';", con);
            List<xxx> model1 = new List<xxx>();
            con.Open();
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model1.Add(new xxx
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model1);
        }
 
        public IActionResult ilan()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Login1(string username = "", string password = "")
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_2 WHERE kullanıcı = @username AND sifre = @sifre", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@sifre", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                con.Close();
                return RedirectToAction("index");
            }
            else
            {
                con.Close();
                
                return RedirectToAction("Login", new {ErrorMessage = "Kullanıcı adı veya şifre hatalı." });
                
            }
            
        }
        


        public IActionResult index(string ara = "")
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select * FROM Table_3 WHERE id LIKE @anahtar;", con);
            cmd.Parameters.AddWithValue("@anahtar", '%' + ara + '%');
            List<xxx1> model12 = new List<xxx1>();
            
            SqlDataReader veri = cmd.ExecuteReader();
            while (veri.Read())
            {
                model12.Add(new xxx1
                {
                    id = (string)veri["id"],
                    baslık = (string)veri["baslık"],
                    fiyat = (string)veri["fiyat"],
                    kategori = (string)veri["kategori"],
                    resim = (string)veri["resim"],


                });
            }
            con.Close();
            return View(model12);
            
            
        }
        [HttpPost]
        public IActionResult Verial(string baslik,string kategori,string isim,int fiyat,string resim1)
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_3 (kategori, id, baslık, fiyat, resim) VALUES (@kategor, @id, @basl, @fiya ,@resi)", con);
            cmd.Parameters.AddWithValue("@basl", baslik);
            cmd.Parameters.AddWithValue("@id", isim);
            cmd.Parameters.AddWithValue("@kategor", kategori);
            cmd.Parameters.AddWithValue("@fiya", fiyat);
            cmd.Parameters.AddWithValue("@resi", resim1);
            int xX=cmd.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("kitap");
        }
        public IActionResult kaydol(string username1, string password1)
        {
            SqlConnection con = new SqlConnection("Data Source=EMEC;Initial Catalog=Tasarım;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_2 ( kullanıcı, sifre) VALUES (@kullan, @sif)", con);
            cmd.Parameters.AddWithValue("@kullan", username1);
            cmd.Parameters.AddWithValue("@sif", password1);
            int xX = cmd.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
