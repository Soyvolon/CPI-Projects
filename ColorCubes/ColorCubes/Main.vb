Imports System.Reflection

Public Class Main
#Region "Global Vars"
    Dim strColors(0) As String
    Dim intColors As Integer = 0
    Public intFavCount As Integer = -1
    'Declare array
    Public strFavss() As String = {}
#End Region
#Region "Main"
    Dim myColor As Color
    Private Sub btnPaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaint.Click
        'For loop
        For count = 1 To 100
            'Declare myCheck as the object CheckBox
            Dim myCheck As CheckBox
            'Combine CheckBox and the For loop count to create the name of the check box (CheckBox1, CheckBox2, etc.)
            myCheck = grpSelector.Controls("CheckBox" & count.ToString)
            'Declare myPic as the object PictureBox
            Dim myPic As PictureBox
            'Combine PictureBox and the For loop count to create the name of the picture box (PictureBox1, PictureBox2, etc.)
            myPic = Panel1.Controls("PictureBox" & count.ToString)
            'Test for if the check box is checked or not
            'The check box number is depedent on the vlaue of the For loop counter, if count = 1 then the check box will be CheckBox1
            If myCheck.Checked Then
                'Tests for the overide checkbox
                If chkOverride.Checked Then
                    'Color.FromName() pulls the name of a color from the item in the '()'
                    myColor = Color.FromName(cboColor.Text)
                    myPic.BackColor = myColor
                Else
                    'Tests for if the background color is the default white
                    If myPic.BackColor = Color.White Then
                        myColor = Color.FromName(cboColor.Text)
                        myPic.BackColor = myColor
                    End If
                End If
            End If
        Next
    End Sub
#End Region
#Region "Settings: Color Override"
    Private Sub btnOverride_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverride.Click
        MessageBox.Show("Color Override: This options will cause all cheked boxes to be colored the selected color, insted of only the white squares getting colored", "Color Overide - Info")
    End Sub
#End Region
#Region "Reset All"
    Private Sub btnRAQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRAQ.Click
        MessageBox.Show("Resets the application to the way it was on launch.", "Reset All - Info")
    End Sub

    Private Sub btnRA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRA.Click
        For count = 1 To 100
            Dim myPic As PictureBox
            myPic = Panel1.Controls("PictureBox" & count.ToString)
            Dim myCheck As CheckBox
            myCheck = grpSelector.Controls("CheckBox" & count.ToString)
            'Sets all picture boxes to the color white (default)
            myPic.BackColor = Color.White
            'Sets all checkboxes to unchecked
            If myCheck.Checked Then
                myCheck.CheckState = False
            End If
        Next
    End Sub
#End Region
#Region "Reset Color Selection"

    Private Sub btnRCSQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCSQ.Click
        MessageBox.Show("Resets all check boxes to the default 'Uncheked' mode.", "Reset Color Selection - Info")
    End Sub

    Private Sub btnRCS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCS.Click
        For count = 1 To 100
            Dim myCheck As CheckBox
            myCheck = grpSelector.Controls("CheckBox" & count.ToString)
            If myCheck.Checked Then
                myCheck.CheckState = False
            End If
        Next
    End Sub
#End Region
#Region "Reset Color"
    Private Sub btnRCQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCQ.Click
        MessageBox.Show("Resets the colors but not the selected checks.", "Reset Color - Info")
    End Sub

    Private Sub btnRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRC.Click
        For count = 1 To 100
            Dim myPic As PictureBox
            myPic = Panel1.Controls("PictureBox" & count.ToString)
            myPic.BackColor = Color.White
        Next
    End Sub
#End Region
#Region "Save"
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
        'Panel1.DrawToBitmap(bmp, Panel1.ClientRectangle)
        'bmp.Save("ColorCube.png")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()

        ' If the file name is not an empty string open it for saving.
        If saveFileDialog1.FileName <> "" Then
            ' Saves the Image via a FileStream created by the OpenFile method.
            Dim fs As System.IO.FileStream = CType _
               (saveFileDialog1.OpenFile(), System.IO.FileStream)
            ' Saves the Image in the appropriate ImageFormat based upon the
            ' file type selected in the dialog box.
            ' NOTE that the FilterIndex property is one-based.
            Dim bmp As New Bitmap(Panel1.Width, Panel1.Height)
            Panel1.DrawToBitmap(bmp, Panel1.ClientRectangle)
            bmp.Save("ColorCube.png")
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    bmp.Save(fs, _
                       System.Drawing.Imaging.ImageFormat.Jpeg)

                Case 2
                    bmp.Save(fs, _
                       System.Drawing.Imaging.ImageFormat.Bmp)

                Case 3
                    bmp.Save(fs, _
                       System.Drawing.Imaging.ImageFormat.Gif)
            End Select

            fs.Close()
        End If
    End Sub
    Private Sub btnSaveQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveQ.Click
        MessageBox.Show("Save your picture as an image", "Save - Info")
    End Sub
#End Region
#Region "App Info"
    Private Sub btnAppInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("This appliaction was developed by Andrew Bounds" & vbCrLf & "This is version 2.0 - Released 11/2/2016", "Application Info")
    End Sub
    Private Sub PictureBox101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox101.Click
        Process.Start("https://creativecommons.org/licenses/by-sa/4.0/")
    End Sub
#End Region
#Region "On Load"
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'binding combobox with color vaues
        'assign combobox drawmode
        cboColor.DrawMode = DrawMode.OwnerDrawFixed
        cboColor.ItemHeight = 20
        Dim colType As Type = GetType(System.Drawing.Color)
        For Each prop As PropertyInfo In colType.GetProperties()
            If prop.PropertyType Is GetType(System.Drawing.Color) Then
                cboColor.Items.Add(prop.Name)
            End If
        Next
    End Sub
    Private Sub cboColor_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cboColor.DrawItem
        'Drawing the itemsinto the combobox.
        'Every time it fires when an item is drawn to the combobox.
        'exit if there is no item
        If e.Index = -1 Then
            Exit Sub
        End If
        'declare a colorbrush
        Dim colBrush As Brush = New SolidBrush(Color.FromName(DirectCast(cboColor.Items(e.Index), String)))
        'Drawing rectangles for the color values
        e.Graphics.DrawRectangle(New Pen(Brushes.Black), e.Bounds.Left + 2, e.Bounds.Top + 2, 30, e.Bounds.Height - 5)
        e.Graphics.FillRectangle(colBrush, e.Bounds.Left + 3, e.Bounds.Top + 3, 29, e.Bounds.Height - 6)
        'Draw the name of the color
        e.Graphics.DrawString(DirectCast(cboColor.Items(e.Index), String), cboColor.Font, Brushes.Black, 35, e.Bounds.Top + 2)
    End Sub
#End Region
#Region "Favorites"
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFav.Click
        intFavCount += 1
        'Add stuff to the array
        ReDim Preserve strFavss(intFavCount)
        strFavss(intFavCount) = cboColor.Text
    End Sub
    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewFav.Click
        Favorites.Show()
    End Sub
#End Region
End Class