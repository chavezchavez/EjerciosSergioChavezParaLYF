using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using DeviceLibrary;
using DeviceLibrary.Models;
using System.Data.SQLite;



namespace EjercicioSergioChavez
{
    
    public partial class Form1 : Form
    {
        
        string nombreUsuario, deuda;
        decimal valorBilleteOMoneda, feria;
        string insertarRegistro;
        string  urlPOST = "https://api.xenterglobal.com:2053/transaction?token=a083a14bc095757200c243d5f0cd4593";
       

        DeviceLibrary.DeviceLibrary objetoDeviceLibrary = new DeviceLibrary.DeviceLibrary();
        

        DeviceLibrary.Models.Enums.DocumentType tipoMoneda = DeviceLibrary.Models.Enums.DocumentType.Coin;
        DeviceLibrary.Models.Enums.DocumentType tipoBillete = DeviceLibrary.Models.Enums.DocumentType.Bill;
       // DeviceLibrary.Models.Document objetoDeviceLibraryDocument = new DeviceLibrary.Models.Document(moneda5, tipoMoneda, contador5);
       
        DeviceLibrary.Models.Enums.DeviceStatus objetoConnected = DeviceLibrary.Models.Enums.DeviceStatus.Connected;
        DeviceLibrary.Models.Enums.DeviceStatus objetoDisconnected = DeviceLibrary.Models.Enums.DeviceStatus.Disconnected;
        DeviceLibrary.Models.Enums.DeviceStatus objetoEnabled = DeviceLibrary.Models.Enums.DeviceStatus.Enabled;
        DeviceLibrary.Models.Enums.DeviceStatus objetoDisabled = DeviceLibrary.Models.Enums.DeviceStatus.Disabled;
        DeviceLibrary.Models.Enums.DeviceStatus objetoDispensing = DeviceLibrary.Models.Enums.DeviceStatus.Dispensing;
        
        

            
        public Form1()
        {
            InitializeComponent();
            objetoDeviceLibrary.Open();

        }

       

        //METODOS=======METODOS===========METODOS============METODOS==========METODOS=========
        //METODOS=======METODOS===========METODOS============METODOS==========METODOS=========
        public static string GetPost(string urlPost, string cuenta, decimal pago)
        {
            Persona objetoPersona = new Persona() { account= cuenta, paid= pago };
            string result = "";
            WebRequest objetoRequest = WebRequest.Create(urlPost);
            objetoRequest.Method = "post";
            objetoRequest.ContentType = "application/json;charset=UTF-8";
            using (var objetoStreamWriter= new StreamWriter(objetoRequest.GetRequestStream()))
            {
                //string json = "{\"account\":\"5692569574\",\"paid\": \"1\" }";
                string json = JsonConvert.SerializeObject(objetoPersona);
                objetoStreamWriter.Write(json);
                objetoStreamWriter.Flush();
                objetoStreamWriter.Close();
            }

            WebResponse objetoResponse = objetoRequest.GetResponse();
            using (var objetoStreamReader = new StreamReader(objetoResponse.GetResponseStream()))
            {
                result = objetoStreamReader.ReadToEnd().Trim();
            }

            MessageBox.Show("Respuesta del POST: " + result);
            return result;

        }
        public string agregarABaseDeDatos(string usuario,string numeroCuenta,decimal deuda,decimal pago)
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source=ejemplo01.sqlite;Version=3;New=True;Compress=True;");

            conexion.Open();
            //string CrearTabla = "create table registro (Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            //    "Customer varchar(40), " +
            //    "Account varchar(10), " +
            //    "Debt NUMERIC DECIMAL(10,2), " +
            //    "Paid NUMERIC DECIMAL(10,2), " +
            //    "Date DateTime default current_timestamp );";

            //SQLiteCommand cmd = new SQLiteCommand(CrearTabla, conexion);
            //cmd.ExecuteNonQuery();

            insertarRegistro = "insert into registro (Customer,Account,Debt,Paid) values( " +
                "'" + usuario + "'," +
                "'" + numeroCuenta + "'," +
                "" + deuda + "," +
                "" + pago + ")"; ;
            SQLiteCommand cmd = new SQLiteCommand(insertarRegistro, conexion);
            int seGuardo = cmd.ExecuteNonQuery();
            conexion.Close();
            return seGuardo.ToString();
        }
        
        public List<string> MostrarBaseDeDatos()
        {

            List<string> resultado = new List<string>();
            SQLiteConnection conexion = new SQLiteConnection("Data Source=ejemplo01.sqlite;Version=3;New=False;Compress=True;");

            conexion.Open();

            string query = "select * from registro";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);


            SQLiteDataReader lector = cmd.ExecuteReader();
            
            while (lector.Read())
            {
                resultado.Add("ID:["+Convert.ToString(lector[0]) + "] Customer:[" 
                + Convert.ToString(lector[1]) + "] Account:[" 
                + Convert.ToString(lector[2]) + "] Debt:[" 
                + Convert.ToString(lector[3]) + "] Paid:[" 
                + Convert.ToString(lector[4]) + "] Date:[" 
                + Convert.ToString(lector[5])+"]");

                //MessageBox.Show("ID: ["+ id +"]\n Customer: [" + customer + "]\n Account: [" + account + "]\n Debt: [" + debt + "]\n Paid: [" + paid + "]\n Date: [" + datetimee + "]");
            }
            //lector.Close();
            return resultado;
            conexion.Close();

        }
        private void LimpiarTextBoxNumeroCuenta()
        {

            if (txtAccountNumeroCuenta.Text == "Número de cuenta...")
            {
                txtAccountNumeroCuenta.Text = "";
            }
        }

        public void TotalTransaccion(decimal CantidadRestante, decimal CantidadIngresada)
        {
            lbPaymentDepositado.Text = (Convert.ToDecimal(lbPaymentDepositado.Text) + CantidadIngresada).ToString();
            decimal total = CantidadRestante - CantidadIngresada;
            if (total < 0)
            {
               
                GetPost(urlPOST, lbBalanceNumeroCuenta.Text, Convert.ToDecimal(lbPaymentDepositado.Text));
                string resultadoDeGuardado = agregarABaseDeDatos(nombreUsuario, txtAccountNumeroCuenta.Text, Convert.ToDecimal(deuda), Convert.ToDecimal(lbPaymentDepositado.Text));
                feria = Math.Abs(Convert.ToDecimal(lbPaymentRestante.Text) - CantidadIngresada);
                objetoDisabled.ToString();
                MessageBox.Show("Feria: " + feria, objetoDispensing.ToString());
                lbPaymentRestante.Text = "0";
            }
            else if (total == 0)
            {
                lbPaymentRestante.Text = "0";
                GetPost(urlPOST, lbBalanceNumeroCuenta.Text, Convert.ToDecimal(lbPaymentDepositado.Text));
                string resultadoDeGuardado = agregarABaseDeDatos(nombreUsuario, txtAccountNumeroCuenta.Text, Convert.ToDecimal(deuda), Convert.ToDecimal(lbPaymentDepositado.Text));
            }
            else
            {
                lbPaymentRestante.Text = total.ToString();
            }

        }
        public object metodoModelDocument(decimal dineroTotal, DeviceLibrary.Models.Enums.DocumentType tipoPago, int contador)
        {
            Document objetoDeviceLibraryDocument = new Document(dineroTotal, tipoPago, contador);

            return objetoDeviceLibraryDocument;
        }
        //METODOS=======METODOS===========METODOS============METODOS==========METODOS=========
        //METODOS=======METODOS===========METODOS============METODOS==========METODOS=========
        private void tabWelcome_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAccountView;
            objetoConnected.ToString();
            txtAccountNumeroCuenta.Text = "Número de cuenta...";
            txtAccountNumeroCuenta.Focus();
        }

        //BOTONES=======BOTONES===========BOTONES============BOTONES==========BOTONES=========
        //BOTONES=======BOTONES===========BOTONES============BOTONES==========BOTONES=========
        private void btnPaymentAbonar_Click(object sender, EventArgs e)
        {
           
            GetPost(urlPOST, lbBalanceNumeroCuenta.Text, Convert.ToDecimal(lbPaymentDepositado.Text));
            string resultadoDeGuardado = agregarABaseDeDatos(nombreUsuario, txtAccountNumeroCuenta.Text, Convert.ToDecimal(deuda), Convert.ToDecimal(lbPaymentDepositado.Text));
            foreach (string dato in MostrarBaseDeDatos())
            MessageBox.Show("Base de datos" + dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAccountBuscarNumeroCuenta_Click(object sender, EventArgs e)
        {
            if (txtAccountNumeroCuenta.Text.Length > 0)
            {
                txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text.Remove(txtAccountNumeroCuenta.Text.Length - 1);
            }

        }

        private void btnAccountContinuar_Click(object sender, EventArgs e)
        {
            string numeroDeCuenta = txtAccountNumeroCuenta.Text;

            var url = "https://api.xenterglobal.com:2053/account_balance?token=a083a14bc095757200c243d5f0cd4593&account=" + numeroDeCuenta;

            WebClient wc = new WebClient();

            var datos = wc.DownloadString(url);

            var result = JsonConvert.DeserializeObject<Resultado>(datos);


            nombreUsuario = result.user;
            deuda = result.debt;

            if (nombreUsuario == null & deuda == null)
            {
                MessageBox.Show("No existen datos de usuario.");
                txtAccountNumeroCuenta.Text = "";
                txtAccountNumeroCuenta.Focus();

            }
            else
            {

                lbBalanceNumeroCuenta.Text = txtAccountNumeroCuenta.Text;
                lbBalanceUsuario.Text = nombreUsuario;
                lbBalanceDeuda.Text = deuda;
                tabControl1.SelectedTab = tabBalanceView;
            }

        }
        private void btnBalanceVolver_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAccountView;
        }

        private void btnAccountCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabWelcome;
        }

        private void btnBalancePagar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lbBalanceDeuda.Text) > 0)
            {
                MessageBox.Show("Ingrese dinero.", "Status: " + objetoEnabled.ToString());
                lbPaymentDeuda.Text = deuda;
                lbPaymentDepositado.Text = "0";
                lbPaymentRestante.Text = deuda;
                tabControl1.SelectedTab = tabPaymentView;
            }
            else
            {
                MessageBox.Show("Status: " + objetoDisabled.ToString() + ". No tiene deuda, no puede pagar.");
                tabControl1.SelectedTab = tabWelcome;

            }


        }

        private void btnPayment500_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 500;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoBillete, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }

        private void btnPayment200_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 200;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoBillete, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }

        private void btnPayment100_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 100;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoBillete, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }

        private void btnPayment50_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 50;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoBillete, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }

        private void btnPayment20_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 20;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoBillete, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }

        private void btnPayment10_Click(object sender, EventArgs e)
        { 
            valorBilleteOMoneda = 10;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), Convert.ToDecimal(valorBilleteOMoneda));

            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoMoneda, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
      
        }
        private void btnPayment5_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 5;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoMoneda, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }

        private void btnPayment2_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 2;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoMoneda, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }

        private void btnPayment1_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 1;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoMoneda, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }
        private void btnPayment50Centavos_Click(object sender, EventArgs e)
        {
            valorBilleteOMoneda = 0.50M;
            TotalTransaccion(Convert.ToDecimal(lbPaymentRestante.Text), valorBilleteOMoneda);
            Document objetoDeviceLibraryDocument = new Document(valorBilleteOMoneda, tipoMoneda, 1);
            objetoDeviceLibrary.SimulateInsertion(objetoDeviceLibraryDocument);
        }
        private void btnAccount1_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "2";
        }

        

        private void btn3_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "9";
        }

        private void btnPaymentCancelar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lbPaymentDepositado.Text) > 0)
            {
                MessageBox.Show("No puede cancelar la operación. Abone cantidad depositada para salir.");
            }
            else
            {
                tabControl1.SelectedTab = tabWelcome;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
            txtAccountNumeroCuenta.Text = txtAccountNumeroCuenta.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMostrarBaseDatos_Click(object sender, EventArgs e)
        {
            //foreach (string dato in MostrarBaseDeDatos())
                //    MessageBox.Show(dato);
            SQLiteConnection conexion= new SQLiteConnection("Data Source=ejemplo01.sqlite;Version=3;New=False;Compress=True;");
            conexion.Open();
            string query = "select * from registro";
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource=dt;



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection conexion = new SQLiteConnection("Data Source=ejemplo01.sqlite;Version=3;New=True;Compress=True;");

            conexion.Open();
            string borrar = "delete from registro";
            SQLiteCommand cmd = new SQLiteCommand(borrar, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //BOTONES=======BOTONES===========BOTONES============BOTONES==========BOTONES=========
        //BOTONES=======BOTONES===========BOTONES============BOTONES==========BOTONES=========





        //TEXTBOXS=======TEXTBOXS===========TEXTBOXS============TEXTBOXS==========TEXTBOXS=========
        //TEXTBOXS=======BOTONES===========TEXTBOXS============TEXTBOXS==========TEXTBOXS=========



        private void txtAccountNumeroCuenta_TextChanged(object sender, EventArgs e)
        {
            LimpiarTextBoxNumeroCuenta();
        }
        private void txtAccountNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //TEXTBOXS=======TEXTBOXS===========TEXTBOXS============TEXTBOXS==========TEXTBOXS=========
        //TEXTBOXS=======BOTONES===========TEXTBOXS============TEXTBOXS==========TEXTBOXS=========






    }
}
