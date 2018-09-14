Imports MySql.Data.MySqlClient
Partial Class syncallusers
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim tService As New ae.gov.shurooq.takamul.tawasul

            GridView1.DataSource = tService.GetAllUsers("ADF767DGH")
            GridView1.DataBind()

        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySql.Data.MySqlClient.MySqlConnection
        Dim dt As New Data.DataTable
        Dim tService As New ae.gov.shurooq.takamul.tawasul
        dt = tService.GetAllUsers("ADF767DGH").Tables(0)
        Dim CommandText As String = ""
        For Each dr In dt.Rows
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
            cmd.Parameters.Add("?p_UserSource", MySqlDbType.VarChar)
            cmd.Parameters.Add("?p_UserTypeid", MySqlDbType.Int64)
            cmd.Parameters.Add("?p_User_Name", MySqlDbType.VarChar)
            cmd.Parameters.Add("?p_User_Group", MySqlDbType.VarChar)
            cmd.Parameters.Add("?p_User_Dept", MySqlDbType.VarChar)
            cmd.Parameters.Add("?p_User_Person_Name", MySqlDbType.VarChar)
            cmd.Parameters.Add("?p_User_Designation", MySqlDbType.VarChar)
            cmd.Parameters.Add("?p_Email", MySqlDbType.VarChar)

            cmd.Parameters.Item("?p_UserSource").Value = "ACTIVEDIRECTORY"
            cmd.Parameters.Item("?p_UserTypeid").Value = "1"
            cmd.Parameters.Item("?p_User_Name").Value = dr("AD_User_Name").ToString
            cmd.Parameters.Item("?p_User_Group").Value = dr("AD_Company").ToString
            cmd.Parameters.Item("?p_User_Dept").Value = dr("AD_Department").ToString
            cmd.Parameters.Item("?p_User_Person_Name").Value = dr("AD_DisplayName").ToString
            cmd.Parameters.Item("?p_User_Designation").Value = dr("AD_Title").ToString
            cmd.Parameters.Item("?p_Email").Value = dr("EmailAddress").ToString

            If dr("AD_Company").ToString.Length > 2 Then
                CommandText = "Select count(*) from user where Email=?p_Email"
                cmd.CommandText = CommandText
                If DatabaseCommands.ExecuteScalar(Data.CommandType.Text, cmd, False) = 0 Then
                    CommandText = "insert into user (UserSource,UserTypeid, User_Name,User_Group,User_Dept,User_Person_Name,User_Designation,Email) values (?p_UserSource,?p_UserTypeid, ?p_User_Name,?p_User_Group,?p_User_Dept,?p_User_Person_Name,?p_User_Designation,?p_Email)"
                Else
                    CommandText = "update user set UserSource=?p_UserSource,UserTypeid=?p_UserTypeid,User_Group=?p_User_Group,User_Dept=?p_User_Dept,User_Person_Name=?p_User_Person_Name,User_Designation=?p_User_Designation where Email=?p_Email"
                End If

                cmd.CommandText = CommandText
                DatabaseCommands.ExecuteNonQuery(Data.CommandType.Text, cmd, False)
            End If


        Next


    End Sub
End Class
