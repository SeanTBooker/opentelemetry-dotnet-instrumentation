using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Samples.AspNet472.LoaderOptimizationRegKey
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Global.InitializeTrace("Samples.AspNet472.LoaderOptimizationRegKey.About.Page_Load");
        }
    }
}
