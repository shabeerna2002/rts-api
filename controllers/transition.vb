Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Transition
Public Function Insert(ByVal objtransition As Models.transition ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transition  as new DAL.transition
Return DA_transition.Insert(objtransition, con, MyTrans)
End Function

Public Function Update(ByVal objtransition As Models.transition, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transition  as new DAL.transition
Return DA_transition.Update(objtransition, con, MyTrans)
End Function

Public Function Delete(ByVal objtransition As Models.transition, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transition  as new DAL.transition
Return DA_transition.Delete(objtransition, con, MyTrans)
End Function

End Class
End Namespace

