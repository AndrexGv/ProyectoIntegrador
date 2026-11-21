namespace NaricesFriasUI.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBadge;
        private NaricesFriasUI.Controls.PawLogoControl logo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private NaricesFriasUI.Controls.RoundedPanel cardLogin;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbPerfilRapido;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private NaricesFriasUI.Controls.ModernButton btnIngresar;
        private System.Windows.Forms.Label lblFooterNote;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblBadge = new Label();
            logo = new NaricesFriasUI.Controls.PawLogoControl();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            cardLogin = new NaricesFriasUI.Controls.RoundedPanel();
            lblCardTitle = new Label();
            lblPerfil = new Label();
            cmbPerfilRapido = new ComboBox();
            lblUser = new Label();
            txtUsuario = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            btnIngresar = new NaricesFriasUI.Controls.ModernButton();
            lblFooterNote = new Label();
            pnlHeader.SuspendLayout();
            cardLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Chocolate;
            pnlHeader.Controls.Add(lblBadge);
            pnlHeader.Controls.Add(logo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(454, 521);
            pnlHeader.TabIndex = 0;
            // 
            // lblBadge
            // 
            lblBadge.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblBadge.ForeColor = Color.White;
            lblBadge.Location = new Point(0, 16);
            lblBadge.Name = "lblBadge";
            lblBadge.Size = new Size(454, 22);
            lblBadge.TabIndex = 0;
            lblBadge.Text = "PROYECTO INTEGRADOR • UNIFRANZ";
            lblBadge.TextAlign = ContentAlignment.MiddleCenter;
            lblBadge.Click += lblBadge_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Snow;
            logo.CircleColor = Color.FromArgb(234, 88, 12);
            logo.Location = new Point(201, 44);
            logo.Name = "logo";
            logo.Size = new Size(52, 52);
            logo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(454, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "NARICES FRIAS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(203, 213, 225);
            lblSubtitulo.Location = new Point(0, 132);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(454, 22);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Sistema Integral de Gestión";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardLogin
            // 
            cardLogin.AccentLeftColor = Color.Transparent;
            cardLogin.BackColor = Color.PeachPuff;
            cardLogin.BorderColor = Color.FromArgb(203, 213, 225);
            cardLogin.BorderRadius = 14;
            cardLogin.Controls.Add(lblCardTitle);
            cardLogin.Controls.Add(lblPerfil);
            cardLogin.Controls.Add(cmbPerfilRapido);
            cardLogin.Controls.Add(lblUser);
            cardLogin.Controls.Add(txtUsuario);
            cardLogin.Controls.Add(lblPass);
            cardLogin.Controls.Add(txtPassword);
            cardLogin.Controls.Add(btnIngresar);
            cardLogin.Controls.Add(lblFooterNote);
            cardLogin.Location = new Point(34, 185);
            cardLogin.Name = "cardLogin";
            cardLogin.Size = new Size(386, 315);
            cardLogin.TabIndex = 1;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblCardTitle.Location = new Point(24, 20);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(130, 21);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Inicio de Sesión";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPerfil.Location = new Point(24, 54);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(208, 15);
            lblPerfil.TabIndex = 1;
            lblPerfil.Text = "Vista rápida e inicio de sesión rápido:";
            // 
            // cmbPerfilRapido
            // 
            cmbPerfilRapido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerfilRapido.Font = new Font("Segoe UI", 9F);
            cmbPerfilRapido.FormattingEnabled = true;
            cmbPerfilRapido.Items.AddRange(new object[] { "Admin — Encargada Refugio Gamaliel", "Alejandra", "Andre - Dueño del sistema", "Nicole" });
            cmbPerfilRapido.Location = new Point(24, 74);
            cmbPerfilRapido.Name = "cmbPerfilRapido";
            cmbPerfilRapido.Size = new Size(338, 23);
            cmbPerfilRapido.TabIndex = 2;
            cmbPerfilRapido.SelectedIndexChanged += cmbPerfilRapido_SelectedIndexChanged;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUser.Location = new Point(24, 112);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(52, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(24, 134);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(338, 24);
            txtUsuario.TabIndex = 4;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPass.Location = new Point(24, 170);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(72, 15);
            lblPass.TabIndex = 5;
            lblPass.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(24, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(338, 24);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BorderRadius = 8;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.HoverColor = Color.FromArgb(194, 65, 12);
            btnIngresar.Location = new Point(24, 238);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.NormalColor = Color.FromArgb(234, 88, 12);
            btnIngresar.Size = new Size(338, 42);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "INGRESAR  →";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblFooterNote
            // 
            lblFooterNote.Font = new Font("Segoe UI", 8F);
            lblFooterNote.Location = new Point(24, 286);
            lblFooterNote.Name = "lblFooterNote";
            lblFooterNote.Size = new Size(338, 18);
            lblFooterNote.TabIndex = 8;
            lblFooterNote.Text = "PROTOTIPO";
            lblFooterNote.TextAlign = ContentAlignment.MiddleCenter;
            lblFooterNote.Click += lblFooterNote_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnIngresar;
            ClientSize = new Size(454, 521);
            Controls.Add(cardLogin);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Narices Frias — Diseño Visual";
            Load += LoginForm_Load;
            pnlHeader.ResumeLayout(false);
            cardLogin.ResumeLayout(false);
            cardLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}
