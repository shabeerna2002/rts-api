Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheettemplate
Public Function Insert(ByVal objonboardingsheettemplate As Models.onboardingsheettemplate ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheettemplate  as new DAL.onboardingsheettemplate
Return DA_onboardingsheettemplate.Insert(objonboardingsheettemplate, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheettemplate As Models.onboardingsheettemplate, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheettemplate  as new DAL.onboardingsheettemplate
Return DA_onboardingsheettemplate.Update(objonboardingsheettemplate, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheettemplate As Models.onboardingsheettemplate, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheettemplate  as new DAL.onboardingsheettemplate
Return DA_onboardingsheettemplate.Delete(objonboardingsheettemplate, con, MyTrans)
End Function

End Class
End Namespace

