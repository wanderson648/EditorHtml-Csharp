using System;

namespace EditorHtml 
{
  public static class Menu 
  {
    public static void Show()
    {
      Console.Clear();
      // definindo a cor do menu
      Console.BackgroundColor = ConsoleColor.DarkGray;
      Console.ForegroundColor = ConsoleColor.White;

      DrawScreen();
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);
    }

    // Método para desenhar tela
    public static void DrawScreen()
    {
        
      DrawColumns();
      // desenhando as linhas
      for(int lines = 0; lines <= 10; lines++)
      {
        Console.Write("|");
        for(int i = 0; i<= 30; i++)
          Console.Write(" ");
        Console.Write("|");
        Console.Write("\n");
      }
      DrawColumns();
    }

    // Método para desenhar colunas
    public static void DrawColumns() 
    {
      // desenhando a tela
        Console.Write("+");
        // desenhando as colunas
        for(int col = 0; col <= 30; col++) 
            Console.Write("=");

        Console.Write("+");
        Console.Write("\n");
    }

    // Método para opções
    public static void WriteOptions()
    { 
      // escrever em uma posição específica da tela
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("-------------");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção:");

    }

    // manipulando o menu
    public static void HandleMenuOption(short option)
    {
      switch(option)
      {
        case 1: Editor.Show() ; break;
        case 2: Console.WriteLine("Abrir"); break;
        case 0: 
        {
          Console.Clear();
          Environment.Exit(0);
          break;
        }
        default: Show(); break;
      }
    }




  }
}