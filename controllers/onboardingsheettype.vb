Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Onboardingsheettype
Public Function Insert(ByVal objonboardingsheettype As Models.onboardingsheettype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheettype  as new DAL.onboardingsheettype
Return DA_onboardingsheettype.Insert(objonboardingsheettype, con, MyTrans)
End Function

Public Function Update(ByVal objonboardingsheettype As Models.onboardingsheettype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheettype  as new DAL.onboardingsheettype
Return DA_onboardingsheettype.Update(objonboardingsheettype, con, MyTrans)
End Function

Public Function Delete(ByVal objonboardingsheettype As Models.onboardingsheettype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_onboardingsheettype  as new DAL.onboardingsheettype
Return DA_onboardingsheettype.Delete(objonboardingsheettype, con, MyTrans)
End Function

End Class
End Namespace

