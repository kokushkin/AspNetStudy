using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace _5_3SimmetricSecurity
{
    public static class SymmetricEncryptionUtility
    {
        private static bool _ProtectKey;
        private static string _AlgorithmName;
        public static string AlgorithmName
        {
            get { return _AlgorithmName; }
            set { _AlgorithmName = value; }
        }
        public static bool ProtectKey
        {
            get { return _ProtectKey; }
            set { _ProtectKey = value; }
        }

        public static void GenerateKey(string targetFile)
        {
            // Создать алгоритм
            SymmetricAlgorithm Algorithm = SymmetricAlgorithm.Create(AlgorithmName);
            Algorithm.GenerateKey();

            // Получить ключ
            byte[] Key = Algorithm.Key;

            if (ProtectKey)
            {
                // Использовать DPAPI для шифрования ключа
                Key = ProtectedData.Protect(
                    Key, null, DataProtectionScope.LocalMachine);
            }

            // Сохранить ключ в файле key.config
            using (FileStream fs = new FileStream(targetFile, FileMode.Create))
            {
                fs.Write(Key, 0, Key.Length);
            }
        }

        public static void ReadKey(SymmetricAlgorithm algorithm, string keyFile)
        {
            byte[] Key;

            using (FileStream fs = new FileStream(keyFile, FileMode.Open))
            {
                Key = new byte[fs.Length];
                fs.Read(Key, 0, (int)fs.Length);
            }

            if (ProtectKey)
                algorithm.Key = ProtectedData.Unprotect(Key, null, DataProtectionScope.LocalMachine);
            else
                algorithm.Key = Key;
        }

        public static byte[] EncryptData(string data, string keyFile)
        {
            // Преобразовать строку data в байтовый массив
            byte[] ClearData = Encoding.UTF8.GetBytes(data);

            // Создать алгоритм шифрования
            SymmetricAlgorithm Algorithm = SymmetricAlgorithm.Create(AlgorithmName);
            ReadKey(Algorithm, keyFile);

            // Зашифровать информацию
            MemoryStream Target = new MemoryStream();

            // Сгенерировать случайный вектор инициализации (IV)
            // для использования с алгоритмом
            Algorithm.GenerateIV();
            Target.Write(Algorithm.IV, 0, Algorithm.IV.Length);

            // Зашифровать реальные данные
            CryptoStream cs = new CryptoStream(Target, Algorithm.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(ClearData, 0, ClearData.Length);
            cs.FlushFinalBlock();

            // Вернуть зашифрованный поток данных в виде байтового массива
            return Target.ToArray();
        }

        public static string DecryptData(byte[] data, string keyFile)
        {
            // Создать алгоритм
            SymmetricAlgorithm Algorithm = SymmetricAlgorithm.Create(AlgorithmName);
            ReadKey(Algorithm, keyFile);

            // Расшифровать информацию
            MemoryStream Target = new MemoryStream();

            // Прочитать вектор инициализации (IV)
            // и инициализировать им алгоритм
            int ReadPos = 0;
            byte[] IV = new byte[Algorithm.IV.Length];
            Array.Copy(data, IV, IV.Length);
            Algorithm.IV = IV;
            ReadPos += Algorithm.IV.Length;

            CryptoStream cs = new CryptoStream(Target, Algorithm.CreateDecryptor(),
                CryptoStreamMode.Write);
            cs.Write(data, ReadPos, data.Length - ReadPos);
            cs.FlushFinalBlock();

            // Получить байты из потока в памяти и преобразовать их в текст
            return Encoding.UTF8.GetString(Target.ToArray());
        }
    }
}