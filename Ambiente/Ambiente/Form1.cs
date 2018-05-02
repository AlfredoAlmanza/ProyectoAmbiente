using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Ambiente
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        Conexiones conexion = new Conexiones();
        SqlConnection conectar;
        int salir;
        public Form1()
        {
            conectar = conexion.Conectar();
            //Thread hilo = new Thread(new ThreadStart(Iniciar));
            //hilo.Start();
            InitializeComponent();
            //bool finalizado = hilo.Join(5000);
            //if (!finalizado)
            //    hilo.Abort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600,MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange100,MaterialSkin.TextShade.WHITE);
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            string query;
            if (TXT_Password.Text.Trim() == "" || TXT_User.Text.Trim() == "")
            {
                salir = 0;
                LBL_Error.Text = "INTRODUZCA TODOS SUS DATOS";
                PNL_Incorrecto.Visible = true;
                this.Enabled = false;
                timer1.Start();
            }
            else
            {
                conectar.Open();
                query = "SELECT * FROM Usuario WHERE usuario = '" + TXT_User.Text.Trim() + "' AND contrasenia = '" + TXT_Password.Text.Trim() + "'";
                SqlCommand comando = new SqlCommand(query, conectar);
                SqlDataReader reader = comando.ExecuteReader();
                if(reader.Read())
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    salir = 0;
                    LBL_Error.Text = "USER/PASSWORD INCORRECTO";
                    PNL_Incorrecto.Visible = true;
                    this.Enabled = false;
                    timer1.Start();
                }
                conectar.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(salir==5)
            {
                timer1.Stop();
                PNL_Incorrecto.Visible = false;
                this.Enabled = true;
            }
            salir++;
        }

        void Iniciar()
        {
            SplashScreen.SplashForm form = new SplashScreen.SplashForm();
            form.BackColor = Color.Gray;
            form.ShowIcon = false;
            form.AppName = "AMBIENTE";
            form.ShowInTaskbar = false;
            Application.Run(form);
        }
    }
}
    