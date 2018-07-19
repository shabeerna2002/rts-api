Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheetkeygroupmaster
Public Function Insert(ByVal objonboardingsheetkeygroupmaster As Models.onboardingsheetkeygroupmaster ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeygroupmaster  as new DAL.onboardingsheetkeygroupmaster
Return DA_onboardingsheetkeygroupmaster.Insert(objonboardingsheetkeygroupmaster, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheetkeygroupmaster As Models.onboardingsheetkeygroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeygroupmaster  as new DAL.onboardingsheetkeygroupmaster
Return DA_onboardingsheetkeygroupmaster.Update(objonboardingsheetkeygroupmaster, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheetkeygroupmaster As Models.onboardingsheetkeygroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheetkeygroupmaster  as new DAL.onboardingsheetkeygroupmaster
Return DA_onboardingsheetkeygroupmaster.Delete(objonboardingsheetkeygroupmaster, con, MyTrans)
End Function

End Class
End Namespace

