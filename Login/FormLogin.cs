using System.Text;

namespace Forms
{
    public partial class FormLogin : Form
    {
        private string path;
        private List<Datos> listaAux;

        public FormLogin()
        {
            InitializeComponent();
            this.listaAux = new List<Datos>();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Deserealizo el archivo
            path = @".\MOCK_DATA.json";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string json_str = sr.ReadToEnd();
                    this.listaAux = System.Text.Json.JsonSerializer.Deserialize<List<Datos>>(json_str);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Recorro la lista con los datos del MockData
            foreach (Datos dato in this.listaAux)
            {
                //Si la contraseña coinside con el correo del mockdata entra al if
                if (this.textBox1.Text == dato.correo && this.textBox2.Text == dato.clave)
                {
                    this.DialogResult = DialogResult.OK;

                    //Guardo el nompre y el perfil del usuario logueado
                    ObtenerDatos.DatoNombre = dato.nombre;
                    ObtenerDatos.DatoPerfil = dato.perfil;

                    //Guardo todos los datos concatenados en DatosLogin
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"Usuario logueado:\n");
                    sb.Append($"Tipo: {dato.perfil}\n");
                    sb.Append($"Nombre: {dato.nombre} {dato.apellido}\n");
                    sb.Append($"Correo: {dato.correo}\n");
                    sb.Append($"Legajo: {dato.legajo}\n");
                    ObtenerDatos.DatosLogin = sb.ToString();

                }
                //si no ingrese el usuario me muestra un label
                else if (this.textBox1.Text.Length <= 0 || this.textBox2.Text.Length <= 0)
                {
                    this.cambiarLabel(false, false, true, true);
                }
                //si la contraseña o mail no coinciden muestra un label
                else
                {
                    this.cambiarLabel(true, true, false, false);
                }
            }
        }

        //Genero este metodo para mostrar u ocultar los label con los booleanos
        public void cambiarLabel(bool estado1, bool estado2, bool estado3, bool estado4)
        {
            this.label3.Visible = estado1;
            this.label4.Visible = estado2;
            this.label5.Visible = estado3;
            this.label6.Visible = estado4;
        }

        //Esta clase con propiedades la genero para deserealizar y guardar los datos del archivo
        public class Datos
        {
            public string apellido { get; set; }
            public string nombre { get; set; }
            public int legajo { get; set; }
            public string correo { get; set; }
            public string clave { get; set; }
            public string perfil { get; set; }
        }

        //Genero una clase con propiedades para guardar los datos del usuario ya logueado
        public static class ObtenerDatos
        {
            public static string DatoNombre { get; set; }
            public static string DatoPerfil { get; set; }
            public static string DatosLogin { get; set; }
        }

    }
}
