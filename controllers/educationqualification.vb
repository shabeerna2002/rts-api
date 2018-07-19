Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Educationqualification
Public Function Insert(ByVal objeducationqualification As Models.educationqualification ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_educationqualification  as new DAL.educationqualification
Return DA_educationqualification.Insert(objeducationqualification, con, MyTrans)
End Function

Public Function Update(ByVal objeducationqualification As Models.educationqualification, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_educationqualification  as new DAL.educationqualification
Return DA_educationqualification.Update(objeducationqualification, con, MyTrans)
End Function

Public Function Delete(ByVal objeducationqualification As Models.educationqualification, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_educationqualification  as new DAL.educationqualification
Return DA_educationqualification.Delete(objeducationqualification, con, MyTrans)
End Function

End Class
End Namespace

