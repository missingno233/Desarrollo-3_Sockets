using Microsoft.Data.Sql;
using System.ComponentModel.DataAnnotations.Schema;


namespace sockets
{
    public partial class VentanaPrincipal : Form
    {
        private string nombreUsuario;
        private string rolUsuario;

        public VentanaPrincipal(string nombre, string rol)
        {
            InitializeComponent();

            this.nombreUsuario = nombre;
            this.rolUsuario = rol;

            ConfigurarInterfaz();
            CargarSalas();
        }

        private void ConfigurarInterfaz()
        {
            // Mostrar info del usuario
            lblUsuario.Text = $"Usuario: {nombreUsuario}";
            lblRolUsuario.Text = $"Rol: {rolUsuario}";

            // Si es estudiante, ocultar botón de crear sala
            if (rolUsuario != "Profesor")
            {
                btnCrear.Visible = false;
            }

            // Configurar área de mensajes
            rtbMensajes.ReadOnly = true;
            rtbMensajes.ScrollBars = RichTextBoxScrollBars.Vertical;
        }

        private void CargarSalas()
        {
            // Aquí cargarías las salas desde la BD
            // Implementar método para obtener salas del usuario
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMensaje.Text))
            {
                MessageBox.Show("Escribe un mensaje primero", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí enviarías el mensaje al servidor
            EnviarMensaje(txtMensaje.Text);
            txtMensaje.Clear();
            txtMensaje.Focus();
        }

        private void EnviarMensaje(string mensaje)
        {
            // Lógica para enviar mensaje por socket
            // Y guardar en BD

            // Mostrar mensaje localmente
            AgregarMensajeAChat($"Tú: {mensaje}");
        }

        private void AgregarMensajeAChat(string mensaje)
        {
            rtbMensajes.AppendText($"{DateTime.Now:HH:mm} - {mensaje}\n");
            rtbMensajes.ScrollToCaret(); // Auto-scroll al final
        }

        private void txtMensaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enviar con Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnviar_Click(sender, e);
                e.Handled = true; // Evitar el "beep"
            }
        }




        private void btnArchivo_Click(object sender, EventArgs e)
        {

        }


        private void TSBCrear_Click(object sender, EventArgs e)
        {

        }

        private void TSBCerrarSesión_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
