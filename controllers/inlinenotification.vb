Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Inlinenotification
Public Function Insert(ByVal objinlinenotification As Models.inlinenotification ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotification  as new DAL.inlinenotification
Return DA_inlinenotification.Insert(objinlinenotification, con, MyTrans)
End Function

Public Function Update(ByVal objinlinenotification As Models.inlinenotification, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotification  as new DAL.inlinenotification
Return DA_inlinenotification.Update(objinlinenotification, con, MyTrans)
End Function

        Public Function Delete(ByVal objinlinenotification As Models.inlinenotification, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_inlinenotification As New DAL.inlinenotification
            Return DA_inlinenotification.Delete(objinlinenotification, con, MyTrans)
        End Function

        Public Function GetInlineNotifications(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, UserID As Integer) As Data.DataSet
            Dim DA_inlinenotification As New DAL.Inlinenotification
            Return DA_inlinenotification.GetInlineNotifications(con, MyTrans, UserID)
        End Function



    End Class
End Namespace

