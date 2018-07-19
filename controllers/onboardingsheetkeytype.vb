Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheetkeytype
Public Function Insert(ByVal objonboardingsheetkeytype As Models.onboardingsheetkeytype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeytype  as new DAL.onboardingsheetkeytype
Return DA_onboardingsheetkeytype.Insert(objonboardingsheetkeytype, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheetkeytype As Models.onboardingsheetkeytype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeytype  as new DAL.onboardingsheetkeytype
Return DA_onboardingsheetkeytype.Update(objonboardingsheetkeytype, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheetkeytype As Models.onboardingsheetkeytype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeytype  as new DAL.onboardingsheetkeytype
Return DA_onboardingsheetkeytype.Delete(objonboardingsheetkeytype, con, MyTrans)
End Function

End Class
End Namespace

