Imports MySql.Data.MySqlClient
Imports RTS.JobStation
Namespace JobStation.Controller
    Public Class Dashboard
        Public Function GetDashboard(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, DisplayCount As Integer) As Data.DataSet
            Dim da As New RTS.JobStation.DAL.Dashboard
            Return da.GetDashboard(con, MyTrans, DisplayCount)
        End Function

        Public Function GetApplicationSummaryDashboardChart(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, DisplayCount As Integer) As Data.DataSet
            Dim da As New RTS.JobStation.DAL.Dashboard
            Return da.GetApplicationSummaryDashboardChart(con, MyTrans, DisplayCount)
        End Function

        Public Function GetDashboardCounterPortlets(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As Data.DataSet
            Dim da As New RTS.JobStation.DAL.Dashboard
            Return da.GetDashboardCounterPortlets(con, MyTrans)
        End Function
    End Class
End Namespace

