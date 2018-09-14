Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Accesslogsgroup
        Public Function Insert(ByVal objaccesslogsgroup As Models.Accesslogsgroup, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_accesslogsgroup As New DAL.Accesslogsgroup
            Return DA_accesslogsgroup.Insert(objaccesslogsgroup, con, MyTrans)
        End Function

        Public Function Update(ByVal objaccesslogsgroup As Models.Accesslogsgroup, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_accesslogsgroup As New DAL.Accesslogsgroup
            Return DA_accesslogsgroup.Update(objaccesslogsgroup, con, MyTrans)
        End Function

        Public Function Delete(ByVal objaccesslogsgroup As Models.Accesslogsgroup, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_accesslogsgroup As New DAL.Accesslogsgroup
            Return DA_accesslogsgroup.Delete(objaccesslogsgroup, con, MyTrans)
        End Function

    End Class
End Namespace

