﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SessionModel.Library
{
    public static class UserHelper
    {
        public static string CalculateMD5Hash(string input)

        {
            if (input != null)
            {
                MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
            return null;
            
        }
    }
}
