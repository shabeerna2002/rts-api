Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Requesthistory
        Public Function Insert(ByVal objrequesthistory As Models.Requesthistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_requesthistory As New DAL.Requesthistory
            Return DA_requesthistory.Insert(objrequesthistory, con, MyTrans)
        End Function

        Public Function Update(ByVal objrequesthistory As Models.Requesthistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_requesthistory As New DAL.Requesthistory
            Return DA_requesthistory.Update(objrequesthistory, con, MyTrans)
        End Function

        Public Function Delete(ByVal objrequesthistory As Models.Requesthistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_requesthistory As New DAL.Requesthistory
            Return DA_requesthistory.Delete(objrequesthistory, con, MyTrans)
        End Function

    End Class
End Namespace
