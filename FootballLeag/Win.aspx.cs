using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FootballLeag
{
    public partial class Win : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            GridView1.DataSource = data.FootBallLeagues;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            win();
        }
        private void win()
        {
            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            GridView1.DataSource = from win_status in dataClasses1DataContext.FootBallLeagues
                                   where win_status.MatchStatus == "win"
                                   select win_status;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Draw();
        }
        private void Draw()
        {
            DataClasses1DataContext dataClasses1DataContext1 = new DataClasses1DataContext();
            GridView1.DataSource = from draw_status in dataClasses1DataContext1.FootBallLeagues
                                   where draw_status.MatchStatus == "Draw"
                                   select draw_status;
            GridView1.DataBind();
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            japan();
        }
        private void japan()
        {
            DataClasses1DataContext dataClasses1DataContext = new DataClasses1DataContext();
            GridView1.DataSource = from japan_Data in dataClasses1DataContext.FootBallLeagues
                                   where japan_Data.TeamName1 == "japan" || japan_Data.TeamName2 == "japan"
                                   select japan_Data;
            GridView1.DataBind();
        }
    }
}