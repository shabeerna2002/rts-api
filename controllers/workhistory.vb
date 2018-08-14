Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Workhistory
        Public Function Insert(ByVal objworkhistory As Models.Workhistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_workhistory As New DAL.Workhistory
            Return DA_workhistory.Insert(objworkhistory, con, MyTrans)
        End Function



        Public Function Update(ByVal objworkhistory As Models.Workhistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_workhistory As New DAL.Workhistory
            Return DA_workhistory.Update(objworkhistory, con, MyTrans)
        End Function

        Public Function Delete(ByVal objworkhistory As Models.Workhistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_workhistory As New DAL.Workhistory
            Return DA_workhistory.Delete(objworkhistory, con, MyTrans)
        End Function

    End Class
End Namespace
