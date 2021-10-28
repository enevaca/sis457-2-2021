using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using CadMinerva;
using System.Windows.Forms;
using System.Globalization;

namespace CpMinervaDesktop
{
    public class Utils
    {
        public static Usuario usuario;
        public static Empleado empleado;
		public static bool notPaste = true;

        public static string Encrypt(string text)
        {
            string Password = "SIS457-2-2020!";
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(text);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x0, 0x1, 0x2, 0x1C, 0x1D, 0x1E, 0x3, 0x4, 0x5, 0xF, 0x20, 0x21, 0xAD, 0xAF, 0xA4 });
            byte[] encryptedData = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16)); // 256 Bits
            return Convert.ToBase64String(encryptedData);
        }

        private static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(clearData, 0, clearData.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

		/// <summary>
		/// Validar sólo números en el evento KeyPress
		/// </summary>
		public static void onlyNumbers(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 22 && notPaste) e.Handled = true; //Deshabilitar Ctrl + V (Pegar)
			else
			{
				if (Char.IsDigit(e.KeyChar)) e.Handled = false;
				else if (Char.IsControl(e.KeyChar)) e.Handled = false;
				else e.Handled = true;
			}
		}

		/// <summary>
		/// Validar sólo números enteros o decimales en el evento KeyPress
		/// </summary>
		public static void onlyDecimals(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 22 && notPaste) e.Handled = true; //Deshabilitar Ctrl + V (Pegar)
			else
			{
				char separtor = Char.Parse(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
				char group = Char.Parse(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator);
				int points = ((Control)sender).Text.Split(separtor).Count();

				if (group.Equals(e.KeyChar)) e.KeyChar = separtor;

				if (Char.IsDigit(e.KeyChar)) e.Handled = false;
				else if (Char.IsControl(e.KeyChar)) e.Handled = false;
				else if (separtor.Equals(e.KeyChar) && points <= 1) e.Handled = false;
				else e.Handled = true;
				((Control)sender).Text = ((Control)sender).Text.Replace(group, separtor);
			}
		}

		/// <summary>
		/// Validar sólo letras en el evento KeyPress
		/// </summary>
		public static void onlyLetters(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar)) e.Handled = false;
			else if (Char.IsControl(e.KeyChar)) e.Handled = false;
			else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
			else e.Handled = true;
		}

		/// <summary>
		/// Validar ni números ni letras en el evento KeyPress
		/// </summary>
		public static void notNumbersLetters(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsLetterOrDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))) e.Handled = false;
			else if (Char.IsControl(e.KeyChar)) e.Handled = false;
			else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
			else if (Char.IsSymbol(e.KeyChar)) e.Handled = false;
			else if ((int)e.KeyChar <= 47) e.Handled = false;
			else e.Handled = true;
		}


		public static void notButtonRight(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				//if (isMsgTxtMouseDown) MessageBox.Show(msgTxtMouseDown);
			}
		}
	}
}
