Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheet
Public Function Insert(ByVal objonboardingsheet As Models.onboardingsheet ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheet  as new DAL.onboardingsheet
Return DA_onboardingsheet.Insert(objonboardingsheet, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheet As Models.onboardingsheet, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheet  as new DAL.onboardingsheet
Return DA_onboardingsheet.Update(objonboardingsheet, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheet As Models.onboardingsheet, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheet  as new DAL.onboardingsheet
Return DA_onboardingsheet.Delete(objonboardingsheet, con, MyTrans)
End Function

End Class
End Namespace

