Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobrequestederf
Public Function Insert(ByVal objjobrequestederf As Models.jobrequestederf ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobrequestederf  as new DAL.jobrequestederf
Return DA_jobrequestederf.Insert(objjobrequestederf, con, MyTrans)
End Function

Public Function Update(ByVal objjobrequestederf As Models.jobrequestederf, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobrequestederf  as new DAL.jobrequestederf
Return DA_jobrequestederf.Update(objjobrequestederf, con, MyTrans)
End Function

Public Function Delete(ByVal objjobrequestederf As Models.jobrequestederf, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobrequestederf  as new DAL.jobrequestederf
Return DA_jobrequestederf.Delete(objjobrequestederf, con, MyTrans)
End Function

End Class
End Namespace

