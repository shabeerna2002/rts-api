Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Transitionactivity
Public Function Insert(ByVal objtransitionactivity As Models.transitionactivity ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transitionactivity  as new DAL.transitionactivity
Return DA_transitionactivity.Insert(objtransitionactivity, con, MyTrans)
End Function

Public Function Update(ByVal objtransitionactivity As Models.transitionactivity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transitionactivity  as new DAL.transitionactivity
Return DA_transitionactivity.Update(objtransitionactivity, con, MyTrans)
End Function

Public Function Delete(ByVal objtransitionactivity As Models.transitionactivity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_transitionactivity  as new DAL.transitionactivity
Return DA_transitionactivity.Delete(objtransitionactivity, con, MyTrans)
End Function

End Class
End Namespace

