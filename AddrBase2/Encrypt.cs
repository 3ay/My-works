using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace AddrBase2
    {
    public class Encrypt
        {
        public static string CalculateMD5Hash( string input )
            {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte [] inputBytes = System.Text.Encoding.ASCII.GetBytes( input );
            byte [] hash = md5.ComputeHash( inputBytes );
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for ( int i = 0; i < hash.Length; i++ )
                {
                sb.Append( hash [i].ToString( "X2" ) );
                }
            return sb.ToString();
            }
        /*
         public static bool Flag = false;
         public static  Guid GetHashString (string s)
             {
             Guid p= new Guid();

             if (s!=null)
                 {
                 // перевод строки в байт-массив
             byte [] bytes = System.Text.Encoding.Unicode.GetBytes( s );
             // создаём объект для получения средств шифрованя
             MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
             // вычисление хеш-представления в байтах
             byte [] byteHash = CSP.ComputeHash( bytes );
             string hash = string.Empty;
             // формируем одну цельную строку из массива
             foreach ( byte b in byteHash )
                 hash += string.Format( "{0:x2}", b );
             return new Guid( hash );
                 }
             return p;
             }
             */
        }
    }