using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMB.Adapter.Repository.Entites
{
    public class UserBookRegistryEntity
    {
        public string Id { get; set; }
        public string Livro_id { get; set; }
        public string Ranking { get; set; }
        public string Tipo { get; set; }
        public string Favorito { get; set; }
        public string Desejado { get; set; }
        public string Troco { get; set; }
        public string Tenho { get; set; }
        public string Emprestei { get; set; }
        public string Paginas { get; set; }
        public string Dt_resenha { get; set; }
        public string Paginas_lidas { get; set; }
        public string Dt_leitura { get; set; }
        public string Meta { get; set; }
        public string Spoiler { get; set; }
        public string Media { get; set; }

        public BookEntity Edicao { get; set; }
    }
}