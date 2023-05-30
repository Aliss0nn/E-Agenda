namespace E_Agenda_winApp.ModuloTarefa
{
    [Serializable]
    public class Itens
    {
        public string descricao;
        public string concluida;

        public Itens(string descricao, string concluida)
        {
            this.descricao = descricao;
            this.concluida = concluida;
        }
    }
}
