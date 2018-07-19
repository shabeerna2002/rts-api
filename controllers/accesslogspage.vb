Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Accesslogspage
Public Function Insert(ByVal objaccesslogspage As Models.accesslogspage ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogspage  as new DAL.accesslogspage
Return DA_accesslogspage.Insert(objaccesslogspage, con, MyTrans)
End Function

Public Function Update(ByVal objaccesslogspage As Models.accesslogspage, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogspage  as new DAL.accesslogspage
Return DA_accesslogspage.Update(objaccesslogspage, con, MyTrans)
End Function

Public Function Delete(ByVal objaccesslogspage As Models.accesslogspage, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogspage  as new DAL.accesslogspage
Return DA_accesslogspage.Delete(objaccesslogspage, con, MyTrans)
End Function

End Class
End Namespace

