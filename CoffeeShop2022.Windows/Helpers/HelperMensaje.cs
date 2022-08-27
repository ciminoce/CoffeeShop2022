using System;
using System.Windows.Forms;

namespace CoffeeShop2022.Windows.Helpers
{
    public static class HelperMensaje
    {
        public static void Mensaje(TipoMensaje tipo, string mensaje, string titulo)
        {
            switch (tipo)
            {
                case TipoMensaje.OK:
                    MessageBox.Show($"{mensaje}", $"{titulo}",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case TipoMensaje.Error:
                    MessageBox.Show($"{mensaje}", $"{titulo}",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case TipoMensaje.Warning:
                    MessageBox.Show($"{mensaje}", $"{titulo}",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
            }

        }

        public static DialogResult Mensaje(string mensaje, string titulo)
        {
            return MessageBox.Show($"{mensaje}", $"{titulo}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }
    }
}
