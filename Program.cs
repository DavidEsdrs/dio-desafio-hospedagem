using System.Text;
using DesafioProjetoHospedagem.Models;
using Newtonsoft.Json;
using Utils;

Setup.Execute();

List<Suite> suites = [];
List<Pessoa> pessoas = [];
List<Reserva> reservas = [];

JsonConvert.DeserializeObject<List<Suite>>(File.ReadAllText(Configs.SuitesArquivo));
JsonConvert.DeserializeObject<List<Suite>>(File.ReadAllText(Configs.SuitesArquivo));
JsonConvert.DeserializeObject<List<Suite>>(File.ReadAllText(Configs.SuitesArquivo));

Console.OutputEncoding = Encoding.UTF8;

int opcao;

do {
  Console.Write("Escolha sua opção > ");
  opcao = Convert.ToInt32(Console.ReadLine());

  string content;

  switch (opcao) {
    case 1:
      Console.WriteLine("Criando suíte");
      Suite s = Controller.AdicionarSuite();
      suites.Add(s);
      content = JsonConvert.SerializeObject(suites, Formatting.Indented);
      File.WriteAllText(Configs.SuitesArquivo, content);
      break;
    case 2:
      Console.WriteLine("Adicionando pessoa");
      Pessoa p = Controller.AdicionarPessoa();
      pessoas.Add(p);
      content = JsonConvert.SerializeObject(pessoas, Formatting.Indented);
      File.WriteAllText(Configs.PessoasArquivo, content);
      break;
    case 3:
      Console.WriteLine("Criar reserva");
      Reserva r = Controller.CriarReserva();
      reservas.Add(r);
      content = JsonConvert.SerializeObject(pessoas, Formatting.Indented);
      File.WriteAllText(Configs.ReservasArquivo, content);
      break;
    case 4:
      Console.WriteLine("Ver suítes");
      foreach(var suite in suites) {
        Console.WriteLine(suite);
      }
      break;
    case 5:
      Console.WriteLine("Ver pessoas");
      foreach(var pessoa in pessoas) {
        Console.WriteLine(pessoa);
      }
      break;
    case 6:
      Console.WriteLine("Ver reservas");
      foreach(var reserva in reservas) {
        Console.WriteLine(reserva);
      }
      break;
    default:
      break;
  }
} while(opcao != 0);