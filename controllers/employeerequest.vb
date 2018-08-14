﻿Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Employeerequest
Public Function Insert(ByVal objemployeerequest As Models.employeerequest ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequest  as new DAL.employeerequest
Return DA_employeerequest.Insert(objemployeerequest, con, MyTrans)
End Function

Public Function Update(ByVal objemployeerequest As Models.employeerequest, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequest  as new DAL.employeerequest
Return DA_employeerequest.Update(objemployeerequest, con, MyTrans)
End Function

        Public Function Delete(ByVal objemployeerequest As Models.employeerequest, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_employeerequest As New DAL.employeerequest
            Return DA_employeerequest.Delete(objemployeerequest, con, MyTrans)
        End Function

        Public Function GetEmployeeRequestID(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer) As Integer
            Dim DA_employeerequest As New DAL.Employeerequest
            Return DA_employeerequest.GetEmployeeRequestID(con, MyTrans, VacancyID)
        End Function


    End Class
End Namespace

