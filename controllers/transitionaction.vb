Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Transitionaction
Public Function Insert(ByVal objtransitionaction As Models.transitionaction ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transitionaction  as new DAL.transitionaction
Return DA_transitionaction.Insert(objtransitionaction, con, MyTrans)
End Function

Public Function Update(ByVal objtransitionaction As Models.transitionaction, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transitionaction  as new DAL.transitionaction
Return DA_transitionaction.Update(objtransitionaction, con, MyTrans)
End Function

Public Function Delete(ByVal objtransitionaction As Models.transitionaction, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transitionaction  as new DAL.transitionaction
Return DA_transitionaction.Delete(objtransitionaction, con, MyTrans)
End Function

End Class
End Namespace

