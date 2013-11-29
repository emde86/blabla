using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Net.Mail;
using System.Security.Cryptography;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper;
using System.IO;
using System.Net.Mime;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml;
//using System.Net.Http;
using System.Net;
using System.Xml.Serialization;
//using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using rndTestConsole.Attribute;
//using Newtonsoft.Json;
//using rndTestConsole.Model;
using OfficeOpenXml;
using DevOne.Security.Cryptography.BCrypt;
using System.Data.SqlServerCe;

namespace rndTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("********************");

                int p1 = 0;
                int? p2 = 2;
                int? p3 = null;

                Console.WriteLine(CorrectDefaultValue(p1, 0));
                Console.WriteLine(CorrectDefaultValue(p2, 2));
                Console.WriteLine(CorrectDefaultValue(p3));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }

            Console.WriteLine("Press enter to end.");
            Console.ReadLine();
        }

        private static object CorrectDefaultValue<T>(T value)
        {
            return CorrectDefaultValue<T>(value, null);
        }

        private static object CorrectDefaultValue<T>(T value, object nullValue)
        {
            object defaultValueStr = "NULL";

            if (value == null)
            {
                return defaultValueStr;
            }
            else if (value.Equals((T)nullValue))
            {
                return defaultValueStr;
            }

            return value;
        }
    }
}
