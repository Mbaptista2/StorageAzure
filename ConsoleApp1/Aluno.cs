using Microsoft.WindowsAzure.Storage.Table;


namespace ConsoleApp1
{
    public class Aluno: TableEntity
    {
        public Aluno()
        {

        }
        public Aluno(string partitionKey, string rowKey): base(partitionKey, rowKey)
        {

        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Curso { get; set; }
    }
}
