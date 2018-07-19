Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Employeerequestprefferedlanguage
Public Function Insert(ByVal objemployeerequestprefferedlanguage As Models.employeerequestprefferedlanguage ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequestprefferedlanguage  as new DAL.employeerequestprefferedlanguage
Return DA_employeerequestprefferedlanguage.Insert(objemployeerequestprefferedlanguage, con, MyTrans)
End Function

Public Function Update(ByVal objemployeerequestprefferedlanguage As Models.employeerequestprefferedlanguage, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequestprefferedlanguage  as new DAL.employeerequestprefferedlanguage
Return DA_employeerequestprefferedlanguage.Update(objemployeerequestprefferedlanguage, con, MyTrans)
End Function

Public Function Delete(ByVal objemployeerequestprefferedlanguage As Models.employeerequestprefferedlanguage, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequestprefferedlanguage  as new DAL.employeerequestprefferedlanguage
Return DA_employeerequestprefferedlanguage.Delete(objemployeerequestprefferedlanguage, con, MyTrans)
End Function

End Class
End Namespace

