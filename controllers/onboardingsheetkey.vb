Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheetkey
Public Function Insert(ByVal objonboardingsheetkey As Models.onboardingsheetkey ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkey  as new DAL.onboardingsheetkey
Return DA_onboardingsheetkey.Insert(objonboardingsheetkey, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheetkey As Models.onboardingsheetkey, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkey  as new DAL.onboardingsheetkey
Return DA_onboardingsheetkey.Update(objonboardingsheetkey, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheetkey As Models.onboardingsheetkey, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkey  as new DAL.onboardingsheetkey
Return DA_onboardingsheetkey.Delete(objonboardingsheetkey, con, MyTrans)
End Function

End Class
End Namespace

