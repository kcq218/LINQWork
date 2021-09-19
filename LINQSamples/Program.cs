using System;

namespace LINQSamples
{
  class Program
  {
    static void Main(string[] args)
    {
      // Instantiate the ViewModel
      SamplesViewModel vm = new SamplesViewModel
      {
        // Use Query or Method Syntax?
        UseQuerySyntax = true
      };

      // Call a sample method
      vm.ForEach();

      // Display Product Collection
      foreach (var item in vm.Products) {
        Console.Write(item.ToString());
      }

      // Display Result Text
      Console.WriteLine(vm.ResultText);
    }
  }
}
