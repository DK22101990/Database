using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace component.helper
{
    public static class FileHelper
    {
        public const string BulkuploadFilePath = "uploads/";
        public static bool CheckFileExists(string filePath)
        {
            return File.Exists(filePath);
        }
        public static bool CheckDirectoryExists(string filePath)
        {
            return Directory.Exists(filePath);
        }
        public static void RemoveFile(string filePath)
        {
            File.Delete(filePath);
        }
        public static void CreateDirectory(string filePath)
        {
            Directory.CreateDirectory(filePath);
        }
        public static string GetFinalFilePath(string filepath, string fileName)
        {
            if (!CheckDirectoryExists(filepath))
                CreateDirectory(filepath);

            string finalpath = Path.Combine(filepath, fileName);
            if (File.Exists(finalpath))
            {
                File.Delete(finalpath);
            }
            return finalpath;
        }
        public static bool ContainColumn(string columnName, DataTable table)
        {
            bool result = false;
            DataColumnCollection columns = table.Columns;
            for (int i = 0; i < columns.Count; i++)
            {
                if (columns[i].ColumnName.ToLower() == columnName.ToLower())
                {
                    result = true;
                }
            }
            return result;
        }
        public static double FileSizeInMb(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                FileInfo fi = new FileInfo(FilePath);
                return ((double)fi.Length / (double)1024) / (double)1024;
            }
            return 0;
        }

        public static bool CheckImageFormat(string filePath)
        {
            List<string> includedExtension = new List<string> { ".jpg", ".png", ".jpeg" };
            string extension = System.IO.Path.GetExtension(filePath);
            if (includedExtension.Contains(extension.ToString().ToLower()))
                return true;
            return false;
        }
        public static double FileSizeInMb(byte[] fileDataByteArray)
        {
            if (fileDataByteArray != null)
                return ((double)fileDataByteArray.Length / (double)1024) / (double)1024;
            return 0;
        }

        public static string ConvertFileToBase64(string filePath)
        {
            if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
            {
                Byte[] bytes = File.ReadAllBytes(filePath);
                return Convert.ToBase64String(bytes).ToString();
            }

            return string.Empty;
        }
    }
}
