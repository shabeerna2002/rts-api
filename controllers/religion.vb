Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Religion
        Public Function Insert(ByVal objreligion As Models.Religion, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_religion As New DAL.Religion
            Return DA_religion.Insert(objreligion, con, MyTrans)
        End Function

        Public Function Update(ByVal objreligion As Models.Religion, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_religion As New DAL.Religion
            Return DA_religion.Update(objreligion, con, MyTrans)
        End Function

        Public Function Delete(ByVal objreligion As Models.Religion, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_religion As New DAL.Religion
            Return DA_religion.Delete(objreligion, con, MyTrans)
        End Function

        Public Function GetAllReligion(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As Data.DataSet
            Dim DA_usermaster As New DAL.Religion
            Return DA_usermaster.GetGetAllReligion(con, MyTrans)
        End Function

    End Class
End Namespace

