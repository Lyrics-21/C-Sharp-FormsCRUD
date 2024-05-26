namespace Forms
{
    public partial class FormLogin : Form
    {
        private string path;
        private List<Datos> listaAux;

        public FormLogin()
        {
            InitializeComponent();
            listaAux = new List<Datos>();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            path = @".\MOCK_DATA.json";
            string pathLogin = Path.Combine(Directory.GetCurrentDirectory(), path);

            if (File.Exists(pathLogin))
            {
                using (StreamReader sr = new StreamReader(pathLogin))
                {
                    string json_str = sr.ReadToEnd();
                    listaAux = System.Text.Json.JsonSerializer.Deserialize<List<Datos>>(json_str);
                }
            }
        }

        public void cambiarLabel(bool estado1, bool estado2, bool estado3, bool estado4)
        {
            this.label3.Visible = estado1;
            this.label4.Visible = estado2;
            this.label5.Visible = estado3;
            this.label6.Visible = estado4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Datos dato in this.listaAux)
            {
                if (this.textBox1.Text == dato.correo && this.textBox2.Text == dato.clave || true)
                {
                    this.DialogResult = DialogResult.OK;
                    ObtenerDato.DatoNombre = dato.nombre;
                    break;
                }
                else if (this.textBox1.Text.Length <= 0 || this.textBox2.Text.Length <= 0)
                {
                    this.cambiarLabel(false, false, true, true);
                }
                else
                {
                    this.cambiarLabel(true, true, false, false);
                }
            }
        }
        public class Datos
        {
            public string apellido { get; set; }
            public string nombre { get; set; }
            public int legajo { get; set; }
            public string correo { get; set; }
            public string clave { get; set; }
            public string perfil { get; set; }
        }

        public static class ObtenerDato
        {
            public static string DatoNombre { get; set; }
        }

    }
}
