using System.Net;
using System.Collections.Specialized;
using System.Text;
using System.Collections.Generic;

namespace loquela_csharp
{
  class loquela
  {
    /************************************************************************/
    /* This is the current url                                              */
    /************************************************************************/
    protected const string _Url = "http://api.loque.la/v1/";

    /************************************************************************/
    /* The user given api key                                               */
    /************************************************************************/
    protected readonly string _ApiKey;

    /************************************************************************/
    /* Create the class, pass the api key                                   */
    /************************************************************************/
    public loquela(string apiKey)
    {
      _ApiKey = apiKey;
    }

    /************************************************************************/
    /* Get the json response for the given text                             */
    /* Return the json response or throws an error                          */ 
    /************************************************************************/
    public string Detect(string unknownText)
    {
      var unknownTexts = new List<string>();
      unknownTexts.Add(unknownText);
      return Detect(unknownTexts);
    }

    public string Detect(List<string> unknownTexts)
    {
      string responseString = "";
      using (var wb = new WebClient())
      {
        var data = new NameValueCollection();
        var i = 0;
        foreach ( var unknownText in unknownTexts )
        {
          data.Add("q[" + (i++).ToString() + "]", unknownText);
        }
        data["key"] = _ApiKey;

        var response = wb.UploadValues(_Url, data);
        responseString = Encoding.Default.GetString(response);
      }
      return responseString;
    }

    /************************************************************************/
    /* Get the current usage for the user.                                  */
    /************************************************************************/
    public string Status()
    {
      string responseString = "";
      using (var wb = new WebClient())
      {
        var data = new NameValueCollection();
        data["get"] = "status";
        data["key"] = _ApiKey;

        var response = wb.UploadValues(_Url, data);
        responseString = Encoding.Default.GetString(response);
      }
      return responseString;
    }
  }
}
