Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Country
Public Function Insert(ByVal objcountry As Models.country ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_country  as new DAL.country
Return DA_country.Insert(objcountry, con, MyTrans)
End Function

Public Function Update(ByVal objcountry As Models.country, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_country  as new DAL.country
Return DA_country.Update(objcountry, con, MyTrans)
End Function

Public Function Delete(ByVal objcountry As Models.country, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_country  as new DAL.country
Return DA_country.Delete(objcountry, con, MyTrans)
End Function

End Class
End Namespace

