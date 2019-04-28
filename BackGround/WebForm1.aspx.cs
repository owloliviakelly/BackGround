using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NLog;


namespace BackGround
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void doIt(object sender, EventArgs e)
        {
            Body.Attributes["bgcolor"] = "Red";
            logger.Trace("Нажата кнопка красный");
        }
        protected void doIt2(object sender, EventArgs e)
        {
            Body.Attributes["bgcolor"] = "yellow";
            logger.Trace("Нажата кнопка Желтый");
        }
        protected void doIt3(object sender, EventArgs e)
        {
            Body.Attributes["bgcolor"] = "green";
            logger.Trace("Нажата кнопка зеленый");
        }
        protected void doIt4(object sender, EventArgs e)
        {
            Body.Attributes["bgcolor"] = "blue";
            logger.Trace("Нажата кнопка синий");
        }
      
    }
}