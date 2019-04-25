
using System;  
using System.Data;  
using System.Configuration;  
using System.Web;  
using System.Web.Security;  
using System.Web.UI;  
using System.Web.UI.WebControls;  
using System.Web.UI.WebControls.WebParts;  
using System.Web.UI.HtmlControls;  
using System.Data.SqlClient;  
using Telerik.WebControls;  
using System.Configuration;  
 
public partial class _Default : System.Web.UI.Page   
{  
    //Declare a global DataTable dtTable    
    public static DataTable dtTable;  
    //Get the connectionstring from the webconfig and declare a global SqlConnection "SqlConnection"    
    public static string connectionString = ConfigurationManager.AppSettings["ConnectionString"];  
    public SqlConnection SqlConnection = new SqlConnection(connectionString);  
    //Declare a global SqlDataAdapter SqlDataAdapter    
    public SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();  
    //Declare a global SqlCommand SqlCommand    
    public SqlCommand SqlCommand = new SqlCommand();    
 
    protected void RadGrid1_NeedDataSource(object source, Telerik.WebControls.GridNeedDataSourceEventArgs e)  
    {  
        //Populate the Radgrid    
        dtTable = new DataTable();  
        //Open the SqlConnection    
        SqlConnection.Open();  
        try  
        {  
            //Select Query to populate the RadGrid with data from table Employees.    
            string selectQuery = "SELECT * FROM Employees";  
            SqlDataAdapter.SelectCommand = new SqlCommand(selectQuery, SqlConnection);  
            SqlDataAdapter.Fill(dtTable);  
            RadGrid1.DataSource = dtTable;  
        }  
        finally  
        {  
            //Close the SqlConnection    
            SqlConnection.Close();  
        }    
 
    }  
    protected void RadGrid1_DeleteCommand(object source, Telerik.WebControls.GridCommandEventArgs e)  
    {  
        //Get the GridDataItem of the RadGrid    
        GridDataItem item = (GridDataItem)e.Item;  
        //Get the primary key value using the DataKeyValue.    
        string EmployeeID = item.OwnerTableView.DataKeyValues[item.ItemIndex]["EmployeeID"].ToString();  
        try  
        {  
            //Open the SqlConnection    
            SqlConnection.Open();  
            string deleteQuery = "DELETE from Employees where EmployeeID='" + EmployeeID + "'";  
            SqlCommand.CommandText = deleteQuery;  
            SqlCommand.Connection = SqlConnection;  
            SqlCommand.ExecuteNonQuery();  
            //Close the SqlConnection    
            SqlConnection.Close();  
 
        }  
        catch (Exception ex)  
        {  
            RadGrid1.Controls.Add(new LiteralControl("Unable to delete Employee. Reason: " + ex.Message));  
            e.Canceled = true;  
        }    
 
    }  
    protected void RadGrid1_UpdateCommand(object source, Telerik.WebControls.GridCommandEventArgs e)  
    {  
        //Get the GridEditableItem of the RadGrid    
        GridEditableItem eeditedItem = e.Item as GridEditableItem;  
        //Get the primary key value using the DataKeyValue.    
        string EmployeeID = editedItem.OwnerTableView.DataKeyValues[editedItem.ItemIndex]["EmployeeID"].ToString();  
        //Access the textbox from the edit form template and store the values in string variables.    
        string LastName = (editedItem["LastName"].Controls[0] as TextBox).Text;  
        string FirstName = (editedItem["FirstName"].Controls[0] as TextBox).Text;  
        string Title = (editedItem["Title"].Controls[0] as TextBox).Text;  
        string Address = (editedItem["Address"].Controls[0] as TextBox).Text;  
        string City = (editedItem["City"].Controls[0] as TextBox).Text;  
 
        try  
        {  
            //Open the SqlConnection    
            SqlConnection.Open();  
            //Update Query to update the Datatable     
            string updateQuery = "UPDATE Employees set LastName='" + LastName + "',FirstName='" + FirstName + "',Title='" + Title + "',Address='" + Address + "',City='" + City + "' where EmployeeID='" + EmployeeID + "'";  
            SqlCommand.CommandText = updateQuery;  
            SqlCommand.Connection = SqlConnection;  
            SqlCommand.ExecuteNonQuery();  
            //Close the SqlConnection    
            SqlConnection.Close();  
 
 
        }  
        catch (Exception ex)  
        {  
            RadGrid1.Controls.Add(new LiteralControl("Unable to update Employee. Reason: " + ex.Message));  
            e.Canceled = true;  
        }    
 
    }  
    protected void RadGrid1_InsertCommand(object source, Telerik.WebControls.GridCommandEventArgs e)  
    {  
        //Get the GridEditFormInsertItem of the RadGrid    
        GridEditFormInsertItem insertedItem = (GridEditFormInsertItem)e.Item;  
 
        //string EmployeeID = (insertedItem["EmployeeID"].Controls[0] as TextBox).Text;  
 
        string LastName = (insertedItem["LastName"].Controls[0] as TextBox).Text;  
        string FirstName = (insertedItem["FirstName"].Controls[0] as TextBox).Text;  
        string Title = (insertedItem["Title"].Controls[0] as TextBox).Text;  
        string Address = (insertedItem["Address"].Controls[0] as TextBox).Text;  
        string City = (insertedItem["City"].Controls[0] as TextBox).Text;  
         
        try  
        {  
            //Open the SqlConnection    
            SqlConnection.Open();  
            //Update Query to insert into  the database     
            string insertQuery = "INSERT into  Employees(LastName,FirstName,Title,Address,City) values('" + LastName + "','" + FirstName + "','" + Title + "','" + Address + "','" + City + "')";  
            SqlCommand.CommandText = insertQuery;  
            SqlCommand.Connection = SqlConnection;  
            SqlCommand.ExecuteNonQuery();  
            //Close the SqlConnection    
            SqlConnection.Close();  
 
 
        }  
        catch (Exception ex)  
        {  
            RadGrid1.Controls.Add(new LiteralControl("Unable to insert Employee. Reason: " + ex.Message));  
            e.Canceled = true;  
        }    
 