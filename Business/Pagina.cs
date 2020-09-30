using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pagina
    {
        public int Id {get; set;}
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Date { get; set; }

        public List<Pagina> Lista()
        {

            var lista = new List<Pagina>();
            var PaginaBb = new Database.Pagina();
           
            foreach(DataRow row in PaginaBb.Lista().Rows)
            {
                var pagina = new Pagina();
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo =row["conteudo"].ToString();
                pagina.Date = Convert.ToDateTime(row["data"]);

                lista.Add(pagina);
               
            }
            return lista;
        }

        public static Pagina BuscaPorID(int id)
        {
            var pagina = new Pagina();
            var PaginaBb = new Database.Pagina();

            foreach (DataRow row in PaginaBb.BuscaPorID(id).Rows)
            {
                
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Date = Convert.ToDateTime(row["data"]);

            }
            return pagina;   
        }

        public void Save()
        {
            new Database.Pagina().Salvar(this.Id, this.Nome, this.Conteudo, this.Date);
        }

        public static void Excluir(int id)
        {
            new Database.Pagina().Excluir(id);
        }
    }
}
