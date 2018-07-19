Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheetfeebackdetails
Public Function Insert(ByVal objonboardingsheetfeebackdetails As Models.onboardingsheetfeebackdetails ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetfeebackdetails  as new DAL.onboardingsheetfeebackdetails
Return DA_onboardingsheetfeebackdetails.Insert(objonboardingsheetfeebackdetails, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheetfeebackdetails As Models.onboardingsheetfeebackdetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetfeebackdetails  as new DAL.onboardingsheetfeebackdetails
Return DA_onboardingsheetfeebackdetails.Update(objonboardingsheetfeebackdetails, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheetfeebackdetails As Models.onboardingsheetfeebackdetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetfeebackdetails  as new DAL.onboardingsheetfeebackdetails
Return DA_onboardingsheetfeebackdetails.Delete(objonboardingsheetfeebackdetails, con, MyTrans)
End Function

End Class
End Namespace

