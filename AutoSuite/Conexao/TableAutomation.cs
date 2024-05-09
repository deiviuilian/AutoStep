using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSuite.Conexao
{
    public class TableAutomation
    {
        public bool Add(Commands automacao, string nomeAutomacao)
        {
            var conn = new Conexao();

            string query = @"INSERT INTO public.listastep
            (NomeAutomacao, Step, Type, Value, criadoem, criadopor)
            VALUES(@NomeAutomacao, @Step, @Type, @Value, CURRENT_TIMESTAMP, 'Deividi');";

            string typeString = automacao.Type.ToString();
            string valorString = automacao.Value.ToString();
            string valor;

            if (typeString == "Click")
            {
                valor = ExtractNumbers(valorString);
            }
            else
            {
                valor = valorString;
            }           

            var result = conn.Connection.Execute(sql: query, param: new { NomeAutomacao = nomeAutomacao, automacao.Step, Type = typeString, Value = valor});
            conn.Dispose();
            return result == 1;
        }

        
        public static string ExtractNumbers(string input)
        {
            string numbers = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c) || c == ',')
                {
                    numbers += c;
                }
            }
            return numbers;
        }
        

        public List<Commands> Get(string nomeAutomacao)
        {
            var conn = new Conexao();
            string query = @"SELECT Step, Type, Value FROM public.listastep WHERE NomeAutomacao = @NomeAutomacao;";
           
            var automacao = conn.Connection.Query<Commands>(sql: query, param: new {NomeAutomacao = nomeAutomacao});
            conn.Dispose();
            return automacao.ToList();
        }

        public List<string> GetDistinctNames()
        {
            var conn = new Conexao();
            string query = @"SELECT DISTINCT NomeAutomacao FROM public.listastep;";
            var nomes = conn.Connection.Query<string>(sql: query);
            conn.Dispose();
            return nomes.ToList();
        }

        public void Delete(string nomeAutomacao)
        {
            var conn = new Conexao();
            string query = @"DELETE FROM public.listastep WHERE NomeAutomacao = @NomeAutomacao;";

            conn.Connection.Execute(sql: query, param: new { NomeAutomacao = nomeAutomacao });
            conn.Dispose();
        }


    }
}
