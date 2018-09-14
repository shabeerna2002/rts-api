Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
    Public Class Dashboard

        Public Function GetDashboard(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ChartDisplayCount As Integer) As DataSet

            Try


                Dim ds As New DataSet("dashboard")
                Dim dtPortlets As New DataTable("portlets")
                Dim dtChart As New DataTable("chart")
                Dim dtRecentCandidates As New DataTable("recentcandidates")


                dtPortlets = GetDashboardCounterPortlets(con, MyTrans).Tables(0)
                dtChart = GetApplicationSummaryDashboardChart(con, MyTrans, ChartDisplayCount).Tables(0)
                dtRecentCandidates = GetDashboardRecentCandidates(con, MyTrans).Tables(0)

                'Chart Ticks
                Dim ChartTicks As String = ""
                If Not dtChart Is Nothing Then
                    If dtChart.Rows.Count > 0 Then
                        For i = 0 To dtChart.Rows.Count - 1
                            ChartTicks += "[" & i & ",""" & dtChart.Rows(i)("ApplicationDate") & """],"
                        Next
                        If ChartTicks.IndexOf(",") > 0 Then
                            ChartTicks = ChartTicks.Remove(ChartTicks.LastIndexOf(","), 1)
                        End If
                    End If
                End If
                ChartTicks = "[" & ChartTicks & "]"
                '**************************


                'Chart Ticks
                Dim ChartData As String = ""
                If Not dtChart Is Nothing Then
                    If dtChart.Rows.Count > 0 Then
                        For i = 0 To dtChart.Rows.Count - 1
                            ChartData += "[" & i & "," & dtChart.Rows(i)("Candidates") & "],"
                        Next
                        If ChartData.IndexOf(",") > 0 Then

                            ChartData = ChartData.Remove(ChartData.LastIndexOf(","), 1)
                        End If
                    End If
                End If
                ChartData = "[" & ChartData & "]"

                dtPortlets.Columns.Add("ChartTicks", GetType(String))
                dtPortlets.Columns.Add("ChartData", GetType(String))
                If Not dtPortlets Is Nothing Then
                    If dtPortlets.Rows.Count > 0 Then
                        dtPortlets.Rows(0)("ChartTicks") = ChartTicks
                        dtPortlets.Rows(0)("ChartData") = ChartData

                    End If
                End If


                Dim tmpDT1 As New DataTable
                tmpDT1 = dtPortlets.Copy
                tmpDT1.TableName = "portlets"

                Dim tmpDT2 As New DataTable
                tmpDT2 = dtChart.Copy
                tmpDT2.TableName = "chart"





                Dim tmpDT3 As New DataTable
                tmpDT3 = dtRecentCandidates.Copy
                tmpDT3.TableName = "recentcandidates"

                ds.Tables.Add(tmpDT1)
                ds.Tables.Add(tmpDT2)
                ds.Tables.Add(tmpDT3)

                tmpDT1.Dispose()
                tmpDT2.Dispose()
                tmpDT3.Dispose()
                dtPortlets.Dispose()
                dtChart.Dispose()
                dtRecentCandidates.Dispose()

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function



        Public Function GetDashboardRecentCandidates(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As DataSet

            Try
                Dim cmd As New MySqlCommand

                Dim commandtext As String = "GetDashboardRecentCandidates"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)


                If Not ds.Tables(0) Is Nothing Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        ds.Tables(0).Columns.Add("PostedAgo", GetType(String))
                        ds.Tables(0).Columns.Add("pic", GetType(String))
                        For Each dr In ds.Tables(0).Rows
                            If dr("FullName").ToString.Length > 20 Then
                                dr("FullName") = dr("FullName").ToString.Substring(0, 18) & "..."
                            End If
                            If dr("Gender").ToString.ToLower = "male" Then
                                dr("pic") = "profile-image-2.png"
                            Else
                                dr("pic") = "profile-image-1.png"
                            End If
                            dr("PostedAgo") = TimeAgo((dr("PostedOn")))
                        Next
                    End If
                End If

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetApplicationSummaryDashboardChart(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, DisplayCount As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_DisplayCount", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_DisplayCount").Value = DisplayCount


                Dim commandtext As String = "GetDashboardApplicationSummaryChart"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetDashboardCounterPortlets(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As DataSet

            Try
                Dim cmd As New MySqlCommand

                Dim commandtext As String = "GetDashboardCounterPortlets"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function TimeAgo(dt As DateTime) As String
            Dim span As TimeSpan = DateTime.UtcNow - dt
            If span.Days > 365 Then
                Dim years As Integer = (span.Days / 365)
                If span.Days Mod 365 <> 0 Then
                    years += 1
                End If
                Return [String].Format("about {0} {1} ago", years, If(years = 1, "year", "years"))
            End If
            If span.Days > 30 Then
                Dim months As Integer = (span.Days / 30)
                If span.Days Mod 31 <> 0 Then
                    months += 1
                End If
                Return [String].Format("about {0} {1} ago", months, If(months = 1, "month", "months"))
            End If
            If span.Days > 0 Then
                Return [String].Format("about {0} {1} ago", span.Days, If(span.Days = 1, "day", "days"))
            End If
            If span.Hours > 0 Then
                Return [String].Format("about {0} {1} ago", span.Hours, If(span.Hours = 1, "hour", "hours"))
            End If
            If span.Minutes > 0 Then
                Return [String].Format("about {0} {1} ago", span.Minutes, If(span.Minutes = 1, "minute", "minutes"))
            End If
            If span.Seconds > 5 Then
                Return [String].Format("about {0} seconds ago", span.Seconds)
            End If
            If span.Seconds <= 5 Then
                Return "just now"
            End If
            Return String.Empty
        End Function
    End Class
End Namespace

