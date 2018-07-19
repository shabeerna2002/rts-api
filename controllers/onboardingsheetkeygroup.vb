Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheetkeygroup
Public Function Insert(ByVal objonboardingsheetkeygroup As Models.onboardingsheetkeygroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeygroup  as new DAL.onboardingsheetkeygroup
Return DA_onboardingsheetkeygroup.Insert(objonboardingsheetkeygroup, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheetkeygroup As Models.onboardingsheetkeygroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeygroup  as new DAL.onboardingsheetkeygroup
Return DA_onboardingsheetkeygroup.Update(objonboardingsheetkeygroup, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheetkeygroup As Models.onboardingsheetkeygroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeygroup  as new DAL.onboardingsheetkeygroup
Return DA_onboardingsheetkeygroup.Delete(objonboardingsheetkeygroup, con, MyTrans)
End Function

End Class
End Namespace

