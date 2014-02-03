using System;
using System.Collections.Generic;

namespace loquela_csharp
{
  class Program
  {
    static void Main()
    {
      //  create the loquela class.
      var l = new Loquela("YOUR-API-KEY");

      // single request.
      var r = l.Detect("Welcome to this language project.");
      Console.WriteLine(r);

      // multiple query
      var unknownTexts = new List<string>
      {
        "If we have no peace, it is because we have forgotten that we belong to each other.",
        "Be faithful in small things because it is in them that your strength lies."
      };

      var rs = l.Detect( unknownTexts );
      Console.WriteLine(rs);

      // status query
      var s = l.Status();
      Console.WriteLine(s);
    }
  }
}
