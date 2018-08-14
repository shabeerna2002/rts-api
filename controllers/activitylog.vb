Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Activitylog
        Public Function Insert(ByVal objactivitylog As Models.Activitylog, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_activitylog As New DAL.Activitylog
            Return DA_activitylog.Insert(objactivitylog, con, MyTrans)
        End Function

        Public Function Update(ByVal objactivitylog As Models.Activitylog, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_activitylog As New DAL.Activitylog
            Return DA_activitylog.Update(objactivitylog, con, MyTrans)
        End Function

        Public Function Delete(ByVal objactivitylog As Models.Activitylog, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_activitylog As New DAL.Activitylog
            Return DA_activitylog.Delete(objactivitylog, con, MyTrans)
        End Function



    End Class
End Namespace
