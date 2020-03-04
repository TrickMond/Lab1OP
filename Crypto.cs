namespace _1_lab
{
    /// <summary>
    /// Класс для шифрования/дешифромания с помощтю XOR
    /// </summary>
    public static class Crypto
    {
        /// <summary>
        /// Кодирование/Декодирование файлов
        /// </summary>
        /// <param name="Path">Путь</param>
        /// <param name="pKey">Пароль для шифрации</param>
        /// <param name="method">"e" - шифрация, "d" - дешифрация</param>
        public static void Encode(string Path, string pKey, string method) {
            byte[] txt = System.IO.File.ReadAllBytes(Path);
            byte[] key = System.Text.Encoding.ASCII.GetBytes(pKey);
            byte[] res = new byte[txt.Length];

            for (int i = 0; i < txt.Length; i++) {
                res[i] = (byte) (txt[i] ^ key[i % key.Length]);
            }
            switch(method)
            {
                case "e":
                System.IO.File.WriteAllBytes(Path.Replace(".encode"," ")+".encode",res);
                break;
                case "d":
                    System.IO.File.WriteAllBytes(Path.Replace(".encode"," "),res);
                break;
            }
        }
    }
}