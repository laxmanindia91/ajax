using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CS : System.Web.UI.Page
{
    [System.Web.Services.WebMethod]
    public static string SendParameters(string name)
    {
        return string.Format("Name: {0}", name);
    }
}