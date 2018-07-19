Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Activitylogdocument
Public Function Insert(ByVal objactivitylogdocument As Models.activitylogdocument ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogdocument  as new DAL.activitylogdocument
Return DA_activitylogdocument.Insert(objactivitylogdocument, con, MyTrans)
End Function

Public Function Update(ByVal objactivitylogdocument As Models.activitylogdocument, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogdocument  as new DAL.activitylogdocument
Return DA_activitylogdocument.Update(objactivitylogdocument, con, MyTrans)
End Function

Public Function Delete(ByVal objactivitylogdocument As Models.activitylogdocument, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogdocument  as new DAL.activitylogdocument
Return DA_activitylogdocument.Delete(objactivitylogdocument, con, MyTrans)
End Function

End Class
End Namespace

