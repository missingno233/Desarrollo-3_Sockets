namespace sockets
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            lvSalas = new ListView();
            toolStrip1 = new ToolStrip();
            TSBCerrarSesión = new ToolStripButton();
            rtbMensajes = new RichTextBox();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            btnArchivo = new Button();
            label1 = new Label();
            lblSalaActual = new Label();
            btnCrear = new Button();
            label2 = new Label();
            lblUsuario = new Label();
            lblRolUsuario = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvSalas
            // 
            lvSalas.Location = new Point(0, 63);
            lvSalas.Name = "lvSalas";
            lvSalas.Size = new Size(153, 385);
            lvSalas.TabIndex = 0;
            lvSalas.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSBCerrarSesión });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // TSBCerrarSesión
            // 
            TSBCerrarSesión.Alignment = ToolStripItemAlignment.Right;
            TSBCerrarSesión.Image = (Image)resources.GetObject("TSBCerrarSesión.Image");
            TSBCerrarSesión.ImageTransparentColor = Color.Magenta;
            TSBCerrarSesión.Name = "TSBCerrarSesión";
            TSBCerrarSesión.Size = new Size(116, 24);
            TSBCerrarSesión.Text = "Cerrar Sesión";
            TSBCerrarSesión.Click += TSBCerrarSesión_Click;
            // 
            // rtbMensajes
            // 
            rtbMensajes.Location = new Point(162, 63);
            rtbMensajes.Name = "rtbMensajes";
            rtbMensajes.ReadOnly = true;
            rtbMensajes.Size = new Size(629, 326);
            rtbMensajes.TabIndex = 2;
            rtbMensajes.Text = "";
            // 
            // txtMensaje
            // 
            txtMensaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMensaje.Location = new Point(165, 405);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(469, 29);
            txtMensaje.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(736, 394);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(55, 45);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnArchivo
            // 
            btnArchivo.Location = new Point(670, 394);
            btnArchivo.Name = "btnArchivo";
            btnArchivo.Size = new Size(60, 45);
            btnArchivo.TabIndex = 5;
            btnArchivo.Text = "Archivo";
            btnArchivo.UseVisualStyleBackColor = true;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 6;
            label1.Text = "Sala:";
            // 
            // lblSalaActual
            // 
            lblSalaActual.AutoSize = true;
            lblSalaActual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalaActual.Location = new Point(213, 30);
            lblSalaActual.Name = "lblSalaActual";
            lblSalaActual.Size = new Size(0, 21);
            lblSalaActual.TabIndex = 7;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(38, 405);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear chat";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 29);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 9;
            label2.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(61, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 21);
            lblUsuario.TabIndex = 10;
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRolUsuario.Location = new Point(706, 30);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(0, 21);
            lblRolUsuario.TabIndex = 11;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRolUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(label2);
            Controls.Add(btnCrear);
            Controls.Add(lblSalaActual);
            Controls.Add(label1);
            Controls.Add(btnArchivo);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(rtbMensajes);
            Controls.Add(toolStrip1);
            Controls.Add(lvSalas);
            Name = "VentanaPrincipal";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvSalas;
        private ToolStrip toolStrip1;
        private ToolStripButton TSBCerrarSesión;
        private RichTextBox rtbMensajes;
        private TextBox txtMensaje;
        private Button btnEnviar;
        private Button btnArchivo;
        private Label label1;
        private Label lblSalaActual;
        private Button btnCrear;
        private Label label2;
        private Label lblUsuario;
        private Label lblRolUsuario;
    }
}
