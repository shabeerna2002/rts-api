Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Caste
Public Function Insert(ByVal objcaste As Models.caste ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_caste  as new DAL.caste
Return DA_caste.Insert(objcaste, con, MyTrans)
End Function

Public Function Update(ByVal objcaste As Models.caste, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_caste  as new DAL.caste
Return DA_caste.Update(objcaste, con, MyTrans)
End Function

Public Function Delete(ByVal objcaste As Models.caste, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_caste  as new DAL.caste
Return DA_caste.Delete(objcaste, con, MyTrans)
End Function

End Class
End Namespace

