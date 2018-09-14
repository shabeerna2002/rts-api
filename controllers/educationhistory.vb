Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Educationhistory
        Public Function Insert(ByVal objeducationhistory As Models.Educationhistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_educationhistory As New DAL.Educationhistory
            Return DA_educationhistory.Insert(objeducationhistory, con, MyTrans)
        End Function

        Public Function Update(ByVal objeducationhistory As Models.Educationhistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_educationhistory As New DAL.Educationhistory
            Return DA_educationhistory.Update(objeducationhistory, con, MyTrans)
        End Function

        Public Function Delete(ByVal objeducationhistory As Models.Educationhistory, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_educationhistory As New DAL.Educationhistory
            Return DA_educationhistory.Delete(objeducationhistory, con, MyTrans)
        End Function

    End Class
End Namespace

