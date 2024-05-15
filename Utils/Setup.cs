namespace Utils {
  public static class Setup {
    public static void Execute() {
      CreateIfNotExists(Configs.ReservasArquivo);
      CreateIfNotExists(Configs.SuitesArquivo);
      CreateIfNotExists(Configs.PessoasArquivo);
    }

    private static void CreateIfNotExists(string path) {
      if(!File.Exists(path)) {
        File.Create(path);
      }
    }
  }

}