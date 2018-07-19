Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Actiontype
Public Function Insert(ByVal objactiontype As Models.actiontype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_actiontype  as new DAL.actiontype
Return DA_actiontype.Insert(objactiontype, con, MyTrans)
End Function

Public Function Update(ByVal objactiontype As Models.actiontype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_actiontype  as new DAL.actiontype
Return DA_actiontype.Update(objactiontype, con, MyTrans)
End Function

Public Function Delete(ByVal objactiontype As Models.actiontype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_actiontype  as new DAL.actiontype
Return DA_actiontype.Delete(objactiontype, con, MyTrans)
End Function

End Class
End Namespace

