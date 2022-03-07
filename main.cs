using System;
using System.Threading;
using System.Threading.Tasks;

class Program {
  public static async Task Main (string[] args) {
    Console.WriteLine (await greet());
  }

  private static async Task<string> greet() {
    await Task.Delay(TimeSpan.FromSeconds(2));

    return "Hello world";
  }
}