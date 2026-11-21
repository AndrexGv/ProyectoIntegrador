using System;
using System.Windows.Forms;
using NaricesFriasUI.Forms;

namespace NaricesFriasUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(loginForm.UsuarioSeleccionado, loginForm.RolSeleccionado));
            }
        }
    }
}
