namespace StartbuzzCoffe
{
    public abstract class BebidaBase
    {
        protected string Descricao;

        public BebidaBase(string descricao)
        {
            Descricao = descricao;
        }

        public abstract string ObterDescricao();

        public abstract decimal Valor();
    }
}
