Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class User
        Public Function Insert(ByVal objuser As Models.User, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_user As New DAL.User
            Return DA_user.Insert(objuser, con, MyTrans)
        End Function

        Public Function Update(ByVal objuser As Models.User, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_user As New DAL.User
            Return DA_user.Update(objuser, con, MyTrans)
        End Function

        Public Function Delete(ByVal objuser As Models.User, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_user As New DAL.User
            Return DA_user.Delete(objuser, con, MyTrans)
        End Function
        Public Function CheckLoginUserInfo(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, UserName As String, Password As String, UserTypeID As Integer) As Data.DataSet
            Dim DA_user As New DAL.User
            Return DA_user.CheckLoginUserInfo(con, MyTrans, UserName, Password, UserTypeID)
        End Function


    End Class
End Namespace

