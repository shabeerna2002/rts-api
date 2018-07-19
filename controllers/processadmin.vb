Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Processadmin
Public Function Insert(ByVal objprocessadmin As Models.processadmin ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_processadmin  as new DAL.processadmin
Return DA_processadmin.Insert(objprocessadmin, con, MyTrans)
End Function

Public Function Update(ByVal objprocessadmin As Models.processadmin, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_processadmin  as new DAL.processadmin
Return DA_processadmin.Update(objprocessadmin, con, MyTrans)
End Function

Public Function Delete(ByVal objprocessadmin As Models.processadmin, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_processadmin  as new DAL.processadmin
Return DA_processadmin.Delete(objprocessadmin, con, MyTrans)
End Function

End Class
End Namespace

