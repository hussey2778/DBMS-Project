using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Data;

namespace ConferenceMgmt
{
    public static class Common
    {
        public static void BindList(ListBox lst, DataTable dt, string dataTextField, string dataValueField)
        {
            lst.Items.Clear();
            //lst.Items.Add(new ListItem("None", "0"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Items.Add(new ListItem(dt.Rows[i][dataTextField].ToString(), dt.Rows[i][dataValueField].ToString()));
            }
            lst.DataValueField = dataValueField;
            lst.DataTextField = dataValueField;
            lst.DataBind();
        }
        public static void FillDropDown(DropDownList ddl, DataTable dt, string dataTextField, string dataValueField)
        {
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem("--Select--", "0"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddl.Items.Add(new ListItem(dt.Rows[i][dataTextField].ToString(), dt.Rows[i][dataValueField].ToString()));
            }
            ddl.DataValueField = dataValueField;
            ddl.DataTextField = dataValueField;
            ddl.DataBind();
        }

    }
}