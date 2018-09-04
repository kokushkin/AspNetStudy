using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_3SimmetricSecurity
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string KeyFileName;
        private string AlgorithmName = "DES";

        protected void Page_Load(object sender, EventArgs e)
        {
            SymmetricEncryptionUtility.AlgorithmName = AlgorithmName;
            KeyFileName = Server.MapPath("~/") + "\\symmetric_key.config";
        }

        protected void GenerateKeyCommand_Click(object sender, EventArgs e)
        {
            try
            {
                SymmetricEncryptionUtility.ProtectKey = EncryptKeyCheck.Checked;
                SymmetricEncryptionUtility.GenerateKey(KeyFileName);

                Response.Write("Ключ успешно сгенерирован!");
            }
            catch
            {
                Response.Write("Возникла ошибка при генерации ключа!");
            }
        }

        protected void EncryptCommand_Click(object sender, EventArgs e)
        {
            // Проверить наличие ключа
            if (!File.Exists(KeyFileName))
            {
                Response.Write("Отсутствует ключ шифрования!");
            }

            try
            {
                byte[] data = SymmetricEncryptionUtility.EncryptData(ClearDataText.Text, KeyFileName);
                EncryptedDataText.Text = Convert.ToBase64String(data);
            }
            catch
            {
                Response.Write("Ошибка при шифровании данных!");
            }
        }

        protected void DecryptCommand_Click(object sender, EventArgs e)
        {
            // Проверить наличие ключа
            if (!File.Exists(KeyFileName))
            {
                Response.Write("Отсутствует ключ шифрования!");
            }

            try
            {
                byte[] data = Convert.FromBase64String(EncryptedDataText.Text);
                ClearDataText.Text = SymmetricEncryptionUtility.DecryptData(data, KeyFileName);
            }
            catch
            {
                Response.Write("Ошибка при дешифровании данных!");
            }
        }

        protected void ClearCommand_Click(object sender, EventArgs e)
        {
            ClearDataText.Text = "";
            EncryptedDataText.Text = "";
        }
    }
}