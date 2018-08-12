using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace festas
{
    class Arquivo
    {
        public static void Cadastrar(string caminho, string novoRegistro)
        {
            if (File.Exists(caminho))
            {
                string[] linhas = File.ReadAllLines(caminho);
                string[] ultimoRegistro = linhas[linhas.Length - 1].Split('|');
                int ultimoCodigoInserido = int.Parse(ultimoRegistro[0]);
                string novoCodigo = (ultimoCodigoInserido + 1).ToString();
                novoRegistro = novoCodigo + "|" + novoRegistro;


                List<string> novaLista = linhas.ToList();
                novaLista.Add(novoRegistro);
                File.WriteAllLines(caminho, novaLista);
            }
            else
            {
                StreamWriter Arquivo = new StreamWriter(caminho);
                Arquivo.Write("1|" + novoRegistro);
                Arquivo.Close();
            }
        }
    }
}
