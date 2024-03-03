using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;

namespace WarehouseManagement
{
    public partial class SQLQueryForm : BaseForm
    {
        private DataSet data = new DataSet();
        public SQLQueryForm()
        {
            InitializeComponent();
        }
        private void QueryTable()
        {
            SqlDatabase db = (SqlDatabase)DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {

                    string sql = "SELECT  o.object_id AS id,o.name,u.name AS owner,o.type,CAST(p.[value] AS varchar(8000)) AS cmt "
   + "FROM sys.all_objects o INNER JOIN sys.schemas u ON u.schema_id = o.schema_id "
       + "LEFT OUTER JOIN sys.extended_properties p ON p.major_id = o.object_id AND p.minor_id = 0 AND p.name = 'MS_Description' "
   + "WHERE o.type in ('U')  ORDER BY o.name, u.name";

                    SqlCommand dbCommand = (SqlCommand)db.GetSqlStringCommand(sql);
                    data = db.ExecuteDataSet(dbCommand);
                    int cont = data.Tables[0].Rows.Count;
                    for (int i = 0; i < cont; i++)
                    {
                        // string a = _data.Tables[0].Rows[i][1].ToString();
                        cbbTable.Items.Add(data.Tables[0].Rows[i][1].ToString());

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex);
                }
            }
        }
        private string GetQueryString()
        {
            Control query = tabQuery.SelectedTab.Controls[0];
            TextBox txtbox = query as TextBox;
            string[] lines = txtbox.Lines;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].StartsWith("--"))
                {
                    sb.AppendLine(lines[i]);
                }
            }

            return sb.ToString();
        }
        private void Query()
        {
            Cursor = Cursors.WaitCursor;

            //Clear content.
            txtMessage.Clear();
            data.Clear();

            bool ret = false;
            SqlDatabase db = (SqlDatabase)DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {

                    string sql = GetQueryString();

                    SqlCommand dbCommand = (SqlCommand)db.GetSqlStringCommand(sql);

                    if (sql.Trim().ToUpper().StartsWith("SELECT"))
                    {
                        data = db.ExecuteDataSet(dbCommand);
                        grdResult.DataSource = data;
                        grdResult.DataMember = "Table";

                        txtMessage.Text = grdResult.RowCount + " record(s).";
                        //lblRecord.Text = grdResult.RowCount + " record(s).";
                    }
                    else if (sql.Trim().ToUpper().StartsWith("INSERT") ||
                        sql.Trim().ToUpper().StartsWith("UPDATE") ||
                        sql.Trim().ToUpper().StartsWith("DELETE"))
                    {
                        txtMessage.Text = db.ExecuteNonQuery(dbCommand) + " record(s).";
                    }
                    else
                    {
                        var result = db.ExecuteNonQuery(dbCommand);
                        data = db.ExecuteDataSet(dbCommand);
                        grdResult.DataSource = data;
                        grdResult.DataMember = "Table";
                        if (result >= -1)
                        {
                            txtMessage.Text = "Cập nhật cơ sở dữ liệu thành công";
                        }
                    }

                    //Active Tab Grid after have result.
                    uiTabPage3.Selected = true;

                    transaction.Commit();
                    ret = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    txtMessage.Text = ex.Message + "\r\n\n" + ex.StackTrace;
                    uiTabPage2.Selected = true;
                }
                finally
                {
                    connection.Close();

                    Cursor = Cursors.Default;
                }
            }
        }
        private void SQLQueryForm_Load(object sender, EventArgs e)
        {
            QueryTable();
            tabQuery.SelectedTab.Controls.Add(new TextBox() { Dock = DockStyle.Fill, Multiline = true, ScrollBars = ScrollBars.Vertical });
        }

        private void btnTabDelete_Click(object sender, EventArgs e)
        {
            tabQuery.TabPages.Remove(tabQuery.SelectedTab);
        }

        private void btnTabNew_Click(object sender, EventArgs e)
        {
            string title = "SQL QUERY " + (tabQuery.TabPages.Count + 1).ToString();
            Janus.Windows.UI.Tab.UITabPage myTabPage = new Janus.Windows.UI.Tab.UITabPage(title);
            TextBox txtQuery = new TextBox();
            myTabPage.Controls.Add(txtQuery);
            txtQuery.Dock = DockStyle.Fill;
            txtQuery.Multiline = true;
            tabQuery.TabPages.Add(myTabPage);
        }

        private void tabQuery_KeyUp(object sender, KeyEventArgs e)
        {
            string str = tabQuery.SelectedTab.Controls[0].Text;
            if (e.KeyData == Keys.F5)
            {
                Query();
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                Control query = tabQuery.SelectedTab.Controls[0];
                TextBox txtbox = query as TextBox;
                txtbox.SelectAll();

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Control query = tabQuery.SelectedTab.Controls[0];
            query.Text = query.Text + "\r\n" + "SELECT * from " + cbbTable.Text + " WHERE id = ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Control query = tabQuery.SelectedTab.Controls[0];
            query.Text = query.Text + "\r\n" + "UPDATE " + cbbTable.Text + " SET  WHERE id = ";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Control query = tabQuery.SelectedTab.Controls[0];
            query.Text = query.Text + "\r\n" + "INSERT INTO " + cbbTable.Text + " (,,,) VALUES (,,,)";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Control query = tabQuery.SelectedTab.Controls[0];
            query.Text = query.Text + "\r\n" + "DELETE " + cbbTable.Text + "  WHERE id = ";
        }
    }
}
