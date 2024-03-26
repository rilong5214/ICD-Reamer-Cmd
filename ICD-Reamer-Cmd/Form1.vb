Option Explicit On
Option Strict Off

Imports System.Runtime.InteropServices


Public Class FrmPlcHole
    Inherits System.Windows.Forms.Form

    'リターンキーをTABキーと同じ動きをさせる
    <System.Security.Permissions.UIPermission(
    System.Security.Permissions.SecurityAction.Demand,
    Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)>
    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        'Returnキーが押されているか調べる
        'AltかCtrlキーが押されている時は、本来の動作をさせる
        If ((keyData And Keys.KeyCode) = Keys.Return) AndAlso
        ((keyData And (Keys.Alt Or Keys.Control)) = Keys.None) Then
            'Tabキーを押した時と同じ動作をさせる
            'Shiftキーが押されている時は、逆順にする
            Me.ProcessTabKey((keyData And Keys.Shift) <> Keys.Shift)

        ElseIf ((keyData And Keys.KeyCode) = Keys.Return) AndAlso ((keyData And Keys.KeyCode) = Keys.Right) Then
            Button1.PerformClick()

            '本来の処理はさせない
            Return True
        End If

        'return the key to the base class if not used.
        Return MyBase.ProcessDialogKey(keyData)
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ICADObj As Object
        Dim sMacro As String
        Dim Ita1 As Double
        Dim ita2 As Double
        Dim GentenY As Double
        Dim Dp As Double

        Dp = DpBox.Text
        GentenY = 37.81112 + Dp
        Debug.Print("GentenY " + GentenY.ToString)


        If Not Double.TryParse(ItaBox.Text, Ita1) Then
            MsgBox("Please enter a valid number!!")
            Exit Sub
        End If

        If Ita1 = 0 Then
            Ita1 = 436207616
            ita2 = 1
        ElseIf Ita1 = 1 Then
            Ita1 = 503316480
            ita2 = 2
        Else
            MsgBox("Please enter 0 or 1!!")
        End If

        Dim Yobi As String
        Yobi = YobiBox.Text

        Dim GentenX As Double
        GentenX = 173.800969 + 0.5 * (Yobi - 1)


        Dim Pene As Double
        If Not Double.TryParse(PeneBox.Text, Pene) Then
            MsgBox("Please enter a valid number!!")
            Exit Sub
        End If

        If Pene = 1 Then
            sMacro = ";BLOAD                                                                          " + ControlChars.NewLine
            sMacro &= ";JLOD                                                                           " + ControlChars.NewLine
            sMacro &= ";JELM                                                                           " + ControlChars.NewLine
            sMacro &= "@IOFF                                                                           " + ControlChars.NewLine
            sMacro &= "@IOFF                                                                           " + ControlChars.NewLine
            sMacro &= ";LAY                                                                            " + ControlChars.NewLine
            sMacro &= ";LOD                                                                            " + ControlChars.NewLine
            sMacro &= ".ZUMEN /リーマ穴(THRU)@3D                  /                               " + ControlChars.NewLine
            sMacro &= ".DIR1 /C:\ICADSX\JISPARTS\USER\_旧式\3D\01_ねじ穴(英)\06_リーマ穴(THRU)/   " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".DIR2 /                                                         /        " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".DIR3 /                                                                /        " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".DIR4 /                                                                /        " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".HAICHI /リーマ穴φ" + Yobi.ToString + "H7通シ                       /                              " + ControlChars.NewLine
            sMacro &= ".ATR1 /33554432/                                                                " + ControlChars.NewLine
            sMacro &= ".ATR2 /3       /                                                                " + ControlChars.NewLine
            sMacro &= ".GENTENX /" + GentenX.ToString + " /                                                         " + ControlChars.NewLine
            sMacro &= ".GENTENY /47.81112     /                                                         " + ControlChars.NewLine
            sMacro &= ".COMMENT /リーマ穴_" + Yobi.ToString + "                                      /                     " + ControlChars.NewLine
            sMacro &= ".ATR3 /" + Ita1.ToString + "  /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= "..HOLATR /1/                                                                    " + ControlChars.NewLine
            sMacro &= "..HOLTEG /1/                                                                    " + ControlChars.NewLine
            sMacro &= "..HOLNUM /2/                                                                    " + ControlChars.NewLine
            sMacro &= "..NPARM1 /16777216/                                                             " + ControlChars.NewLine
            sMacro &= "..PRTVER /" + ita2.ToString + "/                                                                    " + ControlChars.NewLine
            sMacro &= ".YOBI /" + Yobi.ToString + "                       /                                                " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= ".PARAM /l                                               /                       " + ControlChars.NewLine
            sMacro &= ".ATAI /" + DpBox.Text + "       /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= ".PARAM /d                                               /                       " + ControlChars.NewLine
            sMacro &= ".ATAI /" + Yobi.ToString + "          /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= ".PARAM /                                                /                       " + ControlChars.NewLine
            sMacro &= ".ATAI /0           /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            If Ita1 = 436207616 Then
                GoTo Jump1
            End If
            sMacro &= "..BHMODE /1/                                                                    " + ControlChars.NewLine
            sMacro &= "..BHNAME /l/                                                                    " + ControlChars.NewLine
            sMacro &= "..FRMMOD /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..FRMBAS / /                                                                    " + ControlChars.NewLine
            sMacro &= "..FRMPAR / /                                                                    " + ControlChars.NewLine
            sMacro &= "..VARPNM //                                                                     " + ControlChars.NewLine
            sMacro &= "..CVARPR /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ZAGRAD /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HOLTYP /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..BTMADJ /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..BLTMOD /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HOLMAN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..EXLENG /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..HOLMLE /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..BLTHED /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..SIKVAL /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..EXCVAL /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..PREVAL /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..KNPMAX /9/                                                                    " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..ADJPOS /0.000000/                                                             " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..HANTEN /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
            sMacro &= "..ACTKPT /0/                                                                    " + ControlChars.NewLine
Jump1:
            sMacro &= "..PRTEND /1/   " + ControlChars.NewLine

        ElseIf Pene = 0 Then
            sMacro = ";BLOAD                                                                          " + ControlChars.NewLine
            sMacro &= ";JLOD                                                                           " + ControlChars.NewLine
            sMacro &= ";JELM                                                                           " + ControlChars.NewLine
            sMacro &= "@IOFF                                                                           " + ControlChars.NewLine
            sMacro &= "@IOFF                                                                           " + ControlChars.NewLine
            sMacro &= ";LAY                                                                            " + ControlChars.NewLine
            sMacro &= ";LOD                                                                            " + ControlChars.NewLine
            sMacro &= ".ZUMEN /リーマ穴@3D                             /                               " + ControlChars.NewLine
            sMacro &= ".DIR1 /C:\ICADSX\JISPARTS\USER\_旧式\3D\01_ねじ穴(英)\06_リーマ穴      /        " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".DIR2 /                                                                /        " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".DIR3 /                                                                /        " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".DIR4 /                                                                /        " + ControlChars.NewLine
            sMacro &= "                                                                                " + ControlChars.NewLine
            sMacro &= ".HAICHI /φ" + Yobi.ToString + "H7深サ" + DpBox.Text + "                            /                              " + ControlChars.NewLine
            sMacro &= ".ATR1 /33554432/                                                                " + ControlChars.NewLine
            sMacro &= ".ATR2 /3       /                                                                " + ControlChars.NewLine
            sMacro &= ".GENTENX /176.300969  /                                                         " + ControlChars.NewLine
            sMacro &= ".GENTENY /" + GentenY.ToString + "   /                                                         " + ControlChars.NewLine
            sMacro &= ".COMMENT /リーマ穴_" + Yobi.ToString + "                                      /                     " + ControlChars.NewLine
            sMacro &= ".ATR3 /436207616   /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= "..HOLATR /1/                                                                    " + ControlChars.NewLine
            sMacro &= "..HOLTEG /1/                                                                    " + ControlChars.NewLine
            sMacro &= "..HOLNUM /1/                                                                    " + ControlChars.NewLine
            sMacro &= "..NPARM1 /16777216/                                                             " + ControlChars.NewLine
            sMacro &= "..PRTVER /1/                                                                    " + ControlChars.NewLine
            sMacro &= ".YOBI /" + Yobi.ToString + "                      /                                                " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= ".PARAM /l                                               /                       " + ControlChars.NewLine
            sMacro &= ".ATAI /" + DpBox.Text + "          /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= ".PARAM /d                                               /                       " + ControlChars.NewLine
            sMacro &= ".ATAI /" + Yobi.ToString + "           /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= ".PARAM /                                                /                       " + ControlChars.NewLine
            sMacro &= ".ATAI /0           /                                                            " + ControlChars.NewLine
            sMacro &= ":                                                                               " + ControlChars.NewLine
            sMacro &= "..PRTEND /1/                   " + ControlChars.NewLine
        End If



        Try
            ICADObj = CreateObject("ICAD.Application")
            ICADObj.Activate()

            ICADObj.RunCommand(sMacro, ICADOLEA.COMMANDMODE.MODE_MACRO)
        Finally
            If Not ICADObj Is Nothing Then
                While System.Runtime.InteropServices.Marshal.ReleaseComObject(ICADObj) > 0
                End While
            End If

        End Try


        Debug.Print(sMacro)

        While Marshal.ReleaseComObject(ICADObj) > 0
        End While

    End Sub



End Class
