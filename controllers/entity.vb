Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Entity
Public Function Insert(ByVal objentity As Models.entity ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_entity  as new DAL.entity
Return DA_entity.Insert(objentity, con, MyTrans)
End Function

Public Function Update(ByVal objentity As Models.entity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_entity  as new DAL.entity
Return DA_entity.Update(objentity, con, MyTrans)
End Function

Public Function Delete(ByVal objentity As Models.entity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_entity  as new DAL.entity
Return DA_entity.Delete(objentity, con, MyTrans)
End Function

End Class
End Namespace

