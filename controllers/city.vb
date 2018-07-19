Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class City
Public Function Insert(ByVal objcity As Models.city ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_city  as new DAL.city
Return DA_city.Insert(objcity, con, MyTrans)
End Function

Public Function Update(ByVal objcity As Models.city, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_city  as new DAL.city
Return DA_city.Update(objcity, con, MyTrans)
End Function

Public Function Delete(ByVal objcity As Models.city, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_city  as new DAL.city
Return DA_city.Delete(objcity, con, MyTrans)
End Function

End Class
End Namespace

