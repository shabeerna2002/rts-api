Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Modaltype
        Public Function Insert(ByVal objmodaltype As Models.Modaltype, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_modaltype As New DAL.Modaltype
            Return DA_modaltype.Insert(objmodaltype, con, MyTrans)
        End Function

        Public Function Update(ByVal objmodaltype As Models.Modaltype, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_modaltype As New DAL.Modaltype
            Return DA_modaltype.Update(objmodaltype, con, MyTrans)
        End Function

        Public Function Delete(ByVal objmodaltype As Models.Modaltype, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_modaltype As New DAL.Modaltype
            Return DA_modaltype.Delete(objmodaltype, con, MyTrans)
        End Function

    End Class
End Namespace

