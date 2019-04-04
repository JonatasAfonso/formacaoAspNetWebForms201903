using System.Text;

namespace CadeMeuMedico.Models
{
    public static class Criptografia
    {
        public static string CalculateMD5Hash(string senha)
        {
            var resultado = "";

            try
            {
                // step 1, calculate MD5 hash from input
                var md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes(senha);
                byte[] hash = md5.ComputeHash(inputBytes);

                // step 2, convert byte array to hex string
                var sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
            catch (System.Exception)
            {

            }


            return resultado;
        }
    }
}