using System;
using System.Drawing;
using System.Windows.Forms;
using NaricesFriasUI.Controls;

namespace NaricesFriasUI.Forms
{
    public partial class LoginForm : Form
    {
        public string UsuarioSeleccionado { get; private set; } = "Encargada Refugio Gamaliel";
        public string RolSeleccionado { get; private set; } = "Encargado General";

        public LoginForm()
        {
            InitializeComponent();
            AplicarTema();
            cmbPerfilRapido.SelectedIndex = 0;
        }

        private void AplicarTema()
        {
            BackColor = ThemePalette.CanvasBg;
            pnlHeader.BackColor = ThemePalette.SlateHeader;
            logo.CircleColor = ThemePalette.Terracotta;
            cardLogin.BorderColor = ThemePalette.BorderGray;
            lblCardTitle.ForeColor = ThemePalette.SlateHeader;
            lblPerfil.ForeColor = ThemePalette.MutedText;
            lblUser.ForeColor = ThemePalette.SlateText;
            lblPass.ForeColor = ThemePalette.SlateText;
            btnIngresar.NormalColor = ThemePalette.Terracotta;
            btnIngresar.HoverColor = ThemePalette.TerracottaHover;
            lblFooterNote.ForeColor = ThemePalette.MutedText;
        }

        private void cmbPerfilRapido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPerfilRapido.SelectedItem != null)
            {
                string sel = cmbPerfilRapido.SelectedItem.ToString();
                txtUsuario.Text = sel.Split(' ')[0];
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string sel = cmbPerfilRapido.SelectedItem?.ToString() ?? "";
            if (sel.StartsWith("Alejandra", StringComparison.OrdinalIgnoreCase))
            {
                UsuarioSeleccionado = "Alejandra Knaudt";
                RolSeleccionado = "Coordinadora / Líder";
            }
            else if (sel.StartsWith("Andre", StringComparison.OrdinalIgnoreCase))
            {
                UsuarioSeleccionado = "Gonzalo André Galarza";
                RolSeleccionado = "Analista / Operaciones";
            }
            else if (sel.StartsWith("Nicole", StringComparison.OrdinalIgnoreCase))
            {
                UsuarioSeleccionado = "Nicole Chávez";
                RolSeleccionado = "Voluntaria / Adopciones";
            }
            else
            {
                UsuarioSeleccionado = "Encargada Refugio Gamaliel";
                RolSeleccionado = "Encargado General";
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblBadge_Click(object sender, EventArgs e)
        {

        }
    }
}
