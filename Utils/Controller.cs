using DesafioProjetoHospedagem.Models;

namespace Utils {
  public static class Controller {
    public static Suite AdicionarSuite() {
      string tipo;
      int capacidade;
      decimal valorDiaria; 

      Console.Write("Forneça o tipo da suíte > ");
      tipo = Console.ReadLine();
      
      Console.Write("Forneça a capacidade da suíte > ");
      capacidade = Convert.ToInt32(Console.ReadLine());

      Console.Write("Forneça o valor da diária > ");
      valorDiaria = Convert.ToDecimal(Console.ReadLine());

      return new Suite() {
        Capacidade = capacidade,
        TipoSuite = tipo,
        ValorDiaria = valorDiaria
      };
    }

    public static Pessoa AdicionarPessoa() {
      return null;
    }

    public static Reserva CriarReserva() {
      return null;
    }
  }
}