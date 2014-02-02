using System;
using System.Collections.Generic;

namespace loquela_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      //  create the loquela class.
      var l = new loquela("YOUR-API-KEY");

      // single request.
      var r = l.Detect("Welcome to this language project.");
      Console.WriteLine(r);

      // multiple query
      var unknownTexts = new List<string>();
      unknownTexts.Add("If we have no peace, it is because we have forgotten that we belong to each other." );
      unknownTexts.Add("Be faithful in small things because it is in them that your strength lies.");

      var rs = l.Detect( unknownTexts );
      Console.WriteLine(rs);

      // status query
      var s = l.Status();
      Console.WriteLine(s);
    }
  }
}
