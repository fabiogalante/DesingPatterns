using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartbuzzCoffe
{
    public class Expresso : BebidaBase
    {

        public Expresso(string descricao) : base(descricao)
        {
            Descricao = descricao;
        }


        public override string ObterDescricao()
        {
            return $"Descrição da bebida -  {Descricao}"; 
        }

        public override decimal Valor()
        {
            return 5.50m;
        }
    }
}
