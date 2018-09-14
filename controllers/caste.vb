Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Caste
        Public Function Insert(ByVal objcaste As Models.Caste, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_caste As New DAL.Caste
            Return DA_caste.Insert(objcaste, con, MyTrans)
        End Function

        Public Function Update(ByVal objcaste As Models.Caste, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_caste As New DAL.Caste
            Return DA_caste.Update(objcaste, con, MyTrans)
        End Function

        Public Function Delete(ByVal objcaste As Models.Caste, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_caste As New DAL.Caste
            Return DA_caste.Delete(objcaste, con, MyTrans)
        End Function

    End Class
End Namespace

