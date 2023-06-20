﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Common.Util
{
    public static class CPF
    {
        public static bool Validar(string cpf)
        {
            if (cpf == null)
                return false;

            cpf = cpf.Replace(".", String.Empty).Replace("-", String.Empty).Trim();

            if (cpf.Length != 11)
                return false;

            switch (cpf)
            {
                case "00000000000":
                case "11111111111":
                case "22222222222":
                case "33333333333":
                case "44444444444":
                case "55555555555":
                case "66666666666":
                case "77777777777":
                case "88888888888":
                case "99999999999":
                    return false;
            }

            int soma = 0;
            for (int i = 0, j = 10, d; i < 9; i++, j--)
            {
                if (!Int32.TryParse(cpf[i].ToString(), out d))
                    return false;
                soma += d * j;
            }

            int resto = soma % 11;

            string digito = (resto < 2 ? 0 : 11 - resto).ToString();
            string prefixo = cpf.Substring(0, 9) + digito;

            soma = 0;
            for (int i = 0, j = 11; i < 10; i++, j--)
                soma += Int32.Parse(prefixo[i].ToString()) * j;

            resto = soma % 11;
            digito += (resto < 2 ? 0 : 11 - resto).ToString();

            return cpf.EndsWith(digito);
        }

        public static string Formatar(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return string.Empty;

            cpf = cpf.Trim();

            if (cpf.Length != 11)
                return string.Empty;

            return string.Format("{0}.{1}.{2}-{3}", cpf.Substring(0, 3), cpf.Substring(3, 3), cpf.Substring(6, 3), cpf.Substring(9));
        }

    }

    public static class ImageUtility
    {
        public static SaveImageResult SaveImage(string path, int maxSize, string allowedExtensions, HttpPostedFileBase image, HttpServerUtilityBase server)
        {
            var result = new SaveImageResult { Success = false };

            if (image == null || image.ContentLength == 0)
            {
                result.Errors.Add("There was problem with sending image.");
                return result;
            }

            // Check image size
            if (image.ContentLength > maxSize)
                result.Errors.Add("Image is too big.");

            // Check image extension
            var extension = Path.GetExtension(image.FileName).Substring(1).ToLower();
            if (!allowedExtensions.Contains(extension))
                result.Errors.Add(string.Format("'{0}' format is not allowed.", extension));

            // If there are no errors save image
            if (!result.Errors.Any())
            {
                // Generate unique name for safety reasons
                var newName = Guid.NewGuid().ToString("N") + "." + extension;
                var serverPath = server.MapPath("~" + path + newName);
                image.SaveAs(serverPath);

                result.FileName = path + newName;
                result.Success = true;
            }

            return result;
        }
    }
    
    public class SaveImageResult
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public string FileName { get; set; }

        public SaveImageResult()
        {
            Errors = new List<string>();
        }
    }
    
}
