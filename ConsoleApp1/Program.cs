using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Insert
            //Console.Write("Digite o nome do aluno");
            //string nome = Console.ReadLine();

            //Console.Write("Digite o nome do email");
            //string email = Console.ReadLine();

            //Console.Write("Digite o nome do celular");
            //string celular = Console.ReadLine();

            //Console.Write("Digite o curso");
            //string curso = Console.ReadLine();

            //Console.Write("Digite o nome do RM");
            //string rm = Console.ReadLine();

            //Aluno aluno = new Aluno("Alunos", rm)
            //{
            //    Celular = celular,
            //    Nome = nome,
            //    Email = email,
            //    Curso = curso
            //};

            //CloudStorageAccount account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=fiap11net2;AccountKey=yXW/qtVwDvzSPX3hwiZ7pdhe1RYg5TsT8GBmsWXG8eXmEuplRnLrLEsPTE6BaNfgVYoOq7uFELouYFuI9wpzKQ==;EndpointSuffix=core.windows.net");

            //CloudTableClient table = account.CreateCloudTableClient();
            //CloudTable tbAlunos = table.GetTableReference("AlunosFIAP");
            //tbAlunos.CreateIfNotExists();

            //TableOperation operation = TableOperation.Insert(aluno);
            //tbAlunos.Execute(operation);

            //Console.WriteLine("fim");
            //Console.Read();
            //#endregion

            #region Select
            //CloudStorageAccount account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=fiap11net2;AccountKey=yXW/qtVwDvzSPX3hwiZ7pdhe1RYg5TsT8GBmsWXG8eXmEuplRnLrLEsPTE6BaNfgVYoOq7uFELouYFuI9wpzKQ==;EndpointSuffix=core.windows.net");

            //CloudTableClient table = account.CreateCloudTableClient();
            //CloudTable tbAlunos = table.GetTableReference("AlunosFIAP");
            //tbAlunos.CreateIfNotExists();

            //TableQuery<Aluno> query = new TableQuery<Aluno>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "alunos"));

            //List<Aluno> result = tbAlunos.ExecuteQuery(query).ToList();

            /////TableOperation.Retrieve<Aluno>("alunos", "RM31948");
            ////TableResult result = tbAlunos.Execute(retrieve);

            ////List<Aluno> aluno = result.Result as List<Aluno>;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Nome: {item.Nome}");
            //    Console.WriteLine($"Celular: {item.Celular}");
            //    Console.WriteLine($"Email: {item.Email}");
            //}


            //Console.WriteLine("fim");
            //Console.Read();
            #endregion

            #region Delete
            CloudStorageAccount account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=fiap11net2;AccountKey=yXW/qtVwDvzSPX3hwiZ7pdhe1RYg5TsT8GBmsWXG8eXmEuplRnLrLEsPTE6BaNfgVYoOq7uFELouYFuI9wpzKQ==;EndpointSuffix=core.windows.net");

            CloudTableClient table = account.CreateCloudTableClient();
            CloudTable tbAlunos = table.GetTableReference("AlunosFIAP");
            tbAlunos.CreateIfNotExists();

            var operation = TableOperation.Retrieve<Aluno>("alunos", "teste");
            TableResult result = tbAlunos.Execute(operation);

            Aluno alunoExcluir = result.Result as Aluno;

            TableOperation delete = TableOperation.Delete(alunoExcluir);

            tbAlunos.Execute(delete);

            #endregion

        }
    }
}
