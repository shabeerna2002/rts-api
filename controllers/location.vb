Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Location
Public Function Insert(ByVal objlocation As Models.location ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_location  as new DAL.location
Return DA_location.Insert(objlocation, con, MyTrans)
End Function

Public Function Update(ByVal objlocation As Models.location, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_location  as new DAL.location
Return DA_location.Update(objlocation, con, MyTrans)
End Function

Public Function Delete(ByVal objlocation As Models.location, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_location  as new DAL.location
Return DA_location.Delete(objlocation, con, MyTrans)
End Function

End Class
End Namespace

