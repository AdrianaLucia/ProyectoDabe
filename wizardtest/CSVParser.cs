using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wizardtest
{
    public class CSVParser
    {
        public static string[][] ParsearArchivo(string path)
        {
            string[] listaFilas = System.IO.File.ReadAllLines(path);
            string[][] resultado = new string[listaFilas.Length][];

            for (int i = 0; i < listaFilas.Length; ++i)
            {
                resultado[i] = ParseCsvRow(listaFilas[i]);
            }

            return resultado;
        }

        private static string[] ParseCsvRow(string r)
        {

            string[] c;
            string t;
            List<string> resp = new List<string>();
            bool cont = false;
            string cs = "";

            c = r.Split(new char[] { ',' }, StringSplitOptions.None);

            foreach (string y in c)
            {
                string x = y;


                if (cont)
                {
                    // End of field
                    if (x.EndsWith("\""))
                    {
                        cs += "," + x.Substring(0, x.Length - 1);
                        resp.Add(cs);
                        cs = "";
                        cont = false;
                        continue;

                    }
                    else
                    {
                        // Field still not ended
                        cs += "," + x;
                        continue;
                    }
                }

                // Fully encapsulated with no comma within
                if (x.StartsWith("\"") && x.EndsWith("\""))
                {
                    if ((x.EndsWith("\"\"") && !x.EndsWith("\"\"\"")) && x != "\"\"")
                    {
                        cont = true;
                        cs = x;
                        continue;
                    }

                    resp.Add(x.Substring(1, x.Length - 2));
                    continue;
                }

                // Start of encapsulation but comma has split it into at least next field
                if (x.StartsWith("\"") && !x.EndsWith("\""))
                {
                    cont = true;
                    cs += x.Substring(1);
                    continue;
                }

                // Non encapsulated complete field
                resp.Add(x);

            }

            return resp.ToArray();

        }
    }
}
