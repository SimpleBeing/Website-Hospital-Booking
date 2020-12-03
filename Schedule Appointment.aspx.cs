using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ScheduleAppointment: Page
{
    SqlConnection sConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename=|DataDirectory|\dbAppointments.mdf;");
    protected void Page_Load(object sender, EventArgs e)
    {
        ConsultationStartTimes();
    }
    public void ConsultationStartTimes()
    {
        int x;
        string[] arrConStartTimes = {/*1*/"9:00",/*2*/ "9:30",/*3*/ "10:00",/*4*/ "10:30",/*5*/ "11:00",
                /*6*/ "11:30",/*7*/ "12:00",/*8*/ "12:30",/*9*/ "13:00",/*10*/ "13:30",/*11*/ "14:00",
                /*12*/ "14:30",/*13*/ "15:00",/*14*/ "15:30",/*15*/ "16:00",/*16*/ "16:30" };
        if (CalDate.SelectedDate.DayOfWeek == DayOfWeek.Saturday || CalDate.SelectedDate.DayOfWeek == DayOfWeek.Sunday)
        {
            ddlAppTime.Items.Clear();
            for (x = 0; x < 6; ++x)
            {
                ddlAppTime.Items.Add(arrConStartTimes[x]);
            }
            for (x = 6; x < 16; ++x)
            {
                ddlAppTime.Items.Add("Unavailable");
            }

        }
        else
            if (CalDate.SelectedDate.DayOfWeek == DayOfWeek.Wednesday)
        {
            ddlAppTime.Items.Clear();
            for (x = 0; x < 6; ++x)
            {
                ddlAppTime.Items.Add(arrConStartTimes[x]);
            }
            for (x = 6; x < 8; ++x)
            {
                ddlAppTime.Items.Add("Unavailable");
            }
            for (x = 8; x < 16; ++x)
            {
                ddlAppTime.Items.Add(arrConStartTimes[x]);
            }
        }
        else
            if (CalDate.SelectedDate.DayOfWeek == DayOfWeek.Friday)
        {
            ddlAppTime.Items.Clear();
            for (x = 0; x < 14; ++x)
            {
                ddlAppTime.Items.Add(arrConStartTimes[x]);
            }
            for (x = 14; x < 16; ++x)
            {
                ddlAppTime.Items.Add("Unavailable");
            }
        }
        else
        {
            ddlAppTime.Items.Clear();
            for (x = 0; x < 16; ++x)
            {
                ddlAppTime.Items.Add(arrConStartTimes[x]);
            }
        }
    }
    protected void Display_Click(object sender, EventArgs e)
    {
        try
        {
            lblError.Text = "";
            sConn.Open();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            SqlCommand sCmd = new SqlCommand("Select * From Appointments", sConn);
            SqlCommandBuilder cBuilder = new SqlCommandBuilder(dAdapter);
            dAdapter.SelectCommand = sCmd;
            sCmd.ExecuteNonQuery();
            DataSet dSet = new DataSet();
            dAdapter.Fill(dSet, "Appointments");
            gvBookings.DataSourceID = "";
            gvBookings.DataSource = dSet;
            gvBookings.DataMember = "Appointments";
            gvBookings.DataBind();
            sConn.Close();
        }
        catch (Exception exe)
        {
            lblError.Text = exe.Message;
        }
    }

    protected void BtnBook_Click(object sender, EventArgs e)
    {
        if (ddlAppTime.Text.Equals("Unavaliable") == false)
        {
            string nameAndSname = txtName.Text + " " + txtSurname.Text;
            sConn.Open();
            SqlCommand sCmd = new SqlCommand("INSERT INTO Appointments VALUES ('" + nameAndSname +
                "','" + CalDate.SelectedDate.Date.ToString().Substring(0, 10) + "','" + ddlAppTime.Text + "')", sConn);
            sCmd.ExecuteNonQuery();
            sConn.Close();
            lblError.Text = "Booking Successful";
        }
        else
        {
            lblError.Text = "Please pick a time where the doctor is available";
        }
    }

    protected void CalDate_SelectionChanged(object sender, EventArgs e)
    {
        ConsultationStartTimes();
    }
}