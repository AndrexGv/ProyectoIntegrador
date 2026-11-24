using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NaricesFriasUI.Controls;

namespace NaricesFriasUI.Forms
{
    public partial class MainForm : Form
    {
        private readonly string _usuarioActivo;
        private readonly string _rolActivo;
        private readonly List<Button> _navButtons = new();

        public MainForm() : this("Encargada Refugio Gamaliel", "Encargado General")
        {
        }

        public MainForm(string usuarioActivo, string rolActivo)
        {
            _usuarioActivo = usuarioActivo;
            _rolActivo = rolActivo;

            InitializeComponent();

            _navButtons.AddRange(new[]
            {
                btnNavDashboard,
                btnNavAnimales,
                btnNavMedico,
                btnNavAdopciones,
                btnNavInventario
            });

            lblUserBadge.Text = $"👤 {_usuarioActivo}\n      {_rolActivo}";

            AplicarTema();
            InicializarCombosYTablas();
            MostrarVista(0);
        }

        private void AplicarTema()
        {
            BackColor = ThemePalette.CanvasBg;
            topBar.BackColor = ThemePalette.SlateHeader;
            miniLogo.CircleColor = ThemePalette.Terracotta;
            btnBackupVisual.NormalColor = ThemePalette.Terracotta;
            btnBackupVisual.HoverColor = ThemePalette.TerracottaHover;

            sideBar.BackColor = ThemePalette.NavyDark;
            lblMenuCaption.ForeColor = ThemePalette.MutedText;
            pnlOds.BackColor = ThemePalette.SlateHeader;
            pnlOds.BorderColor = Color.FromArgb(51, 65, 85);

            pnlContenido.BackColor = ThemePalette.CanvasBg;

            cardKpi1.AccentLeftColor = ThemePalette.SlateHeader;
            cardKpi2.AccentLeftColor = ThemePalette.Terracotta;
            cardKpi3.AccentLeftColor = ThemePalette.Emerald;
            cardKpi4.AccentLeftColor = ThemePalette.RoyalBlue;
            cardKpi5.AccentLeftColor = ThemePalette.PurpleAccent;
            cardKpi6.AccentLeftColor = ThemePalette.Crimson;

            btnAniFoto.NormalColor = ThemePalette.SlateHeader;
            btnAniFoto.HoverColor = ThemePalette.NavyDark;
            btnAniLimpiar.NormalColor = ThemePalette.MutedText;
            btnAniLimpiar.HoverColor = ThemePalette.SlateText;
            btnAniGuardar.NormalColor = ThemePalette.Terracotta;
            btnAniGuardar.HoverColor = ThemePalette.TerracottaHover;

            btnMedGuardar.NormalColor = ThemePalette.Emerald;
            btnMedGuardar.HoverColor = Color.FromArgb(21, 128, 61);

            boxAdoReqs.BackColor = ThemePalette.OrangeLight;
            boxAdoReqs.BorderColor = Color.FromArgb(253, 186, 116);
            lblAdoReqTit.ForeColor = ThemePalette.Terracotta;
            btnAdoAprobar.NormalColor = ThemePalette.Terracotta;
            btnAdoAprobar.HoverColor = ThemePalette.TerracottaHover;
            btnAdoWhatsapp.NormalColor = ThemePalette.SlateHeader;
            btnAdoWhatsapp.HoverColor = ThemePalette.NavyDark;

            btnInvRegistrar.NormalColor = ThemePalette.Terracotta;
            btnInvRegistrar.HoverColor = ThemePalette.TerracottaHover;
            cardInvStock.BackColor = ThemePalette.EmeraldLight;
            cardInvStock.BorderColor = Color.FromArgb(134, 239, 172);
        }

        private void InicializarCombosYTablas()
        {
            cmbAniEsp.SelectedIndex = 0;
            cmbAniTam.SelectedIndex = 0;
            cmbAniUbi.SelectedIndex = 0;
            cmbAniEst.SelectedIndex = 0;
            cmbAniFiltro.SelectedIndex = 0;
            cmbMedAnimal.SelectedIndex = 0;
            cmbMedEvento.SelectedIndex = 0;
            cmbAdoAnimal.SelectedIndex = 0;
            cmbInvTipo.SelectedIndex = 0;
            cmbInvCategoria.SelectedIndex = 0;

            dgvDashAlertas.Rows.Add("NF-003", "Rocky", "Perro", "Clínica Veterinaria", "En Tratamiento", "URGENTE (1 día)", "Fractura de fémur derecho. Campaña QR activa para cirugía.");
            dgvDashAlertas.Rows.Add("NF-002", "Luna", "Gato", "Hogar Temporal", "En Rehabilitación", "URGENTE (2 días)", "En hogar temporal ganando peso previo a esterilización.");
            dgvDashAlertas.Rows.Add("NF-001", "Choco", "Perro", "Canil Refugio", "Disponible", "En 12 días", "Recuperado de desnutrición leve. Vacunas completas.");
            dgvDashAlertas.Rows.Add("NF-005", "Toby", "Perro", "Canil Refugio", "Disponible", "En 20 días", "Desparasitado y con vacuna séxtuple al día.");
            dgvDashAlertas.Rows[0].Cells[5].Style.ForeColor = ThemePalette.Crimson;
            dgvDashAlertas.Rows[0].Cells[5].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvDashAlertas.Rows[1].Cells[5].Style.ForeColor = ThemePalette.Terracotta;
            dgvDashAlertas.Rows[1].Cells[5].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvAnimales.Rows.Add("NF-001", "Choco", "Perro", "16.5 kg", "Canil Refugio", "Disponible");
            dgvAnimales.Rows.Add("NF-002", "Luna", "Gato", "3.4 kg", "Hogar Temporal", "En Rehabilitación");
            dgvAnimales.Rows.Add("NF-003", "Rocky", "Perro", "24.0 kg", "Clínica Veterinaria", "En Tratamiento");
            dgvAnimales.Rows.Add("NF-004", "Canela", "Perro", "9.2 kg", "Domicilio Adoptante", "Adoptado");
            dgvAnimales.Rows.Add("NF-005", "Toby", "Perro", "14.0 kg", "Canil Refugio", "Disponible");

            dgvMedico.Rows.Add("15/11/2026", "NF-003", "Rocky", "Cirugía", "Hospital Veterinario del Valle", "650 Bs");
            dgvMedico.Rows.Add("10/11/2026", "NF-002", "Luna", "Desparasitación", "Veterinaria Huellitas", "80 Bs");
            dgvMedico.Rows.Add("27/10/2026", "NF-001", "Choco", "Vacunación", "Veterinaria San Roque Cbba", "140 Bs");

            dgvAdopciones.Rows.Add("31/10/2026", "Canela", "María Fernanda Rojas", "72233445", "Aprobada", "Seguimiento 15d: Fotos en patio cerrado recibidas.");
            dgvAdopciones.Rows[0].Cells[4].Style.ForeColor = ThemePalette.Emerald;
            dgvAdopciones.Rows[0].Cells[4].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvInventario.Rows.Add("18/11/2026", "Consumo / Egreso", "Alimento Balanceado (kg)", "32.0", "Ración semanal caniles Refugio Gamaliel");
            dgvInventario.Rows.Add("17/11/2026", "Consumo / Egreso", "Recaudación QR (Bs)", "450.0", "Pago a cuenta cirugía veterinaria caso Rocky");
            dgvInventario.Rows.Add("16/11/2026", "Ingreso Donación", "Recaudación QR (Bs)", "820.0", "Campaña QR redes sociales caso rescate Rocky");
            dgvInventario.Rows.Add("13/11/2026", "Ingreso Donación", "Alimento Balanceado (kg)", "80.0", "Donación de croquetas adulto (Feria solidaria)");
        }

        private void MostrarVista(int index)
        {
            for (int i = 0; i < _navButtons.Count; i++)
            {
                _navButtons[i].BackColor = (i == index) ? ThemePalette.Terracotta : ThemePalette.SlateHeader;
            }

            switch (index)
            {
                case 0: pnlVistaDashboard.BringToFront(); break;
                case 1: pnlVistaAnimales.BringToFront(); break;
                case 2: pnlVistaMedico.BringToFront(); break;
                case 3: pnlVistaAdopciones.BringToFront(); break;
                case 4: pnlVistaInventario.BringToFront(); break;
            }
        }

        private void btnBackupVisual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vista previa de diálogo de exportación de respaldo (.json).", "Diseño Visual UI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNavDashboard_Click(object sender, EventArgs e) => MostrarVista(0);
        private void btnNavAnimales_Click(object sender, EventArgs e) => MostrarVista(1);
        private void btnNavMedico_Click(object sender, EventArgs e) => MostrarVista(2);
        private void btnNavAdopciones_Click(object sender, EventArgs e) => MostrarVista(3);
        private void btnNavInventario_Click(object sender, EventArgs e) => MostrarVista(4);

        private void lblSubtituloApp_Click(object sender, EventArgs e)
        {

        }
    }
}
