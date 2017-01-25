Public Class Main
#Region "Vars"
    'Resources
    Public totalMoney As Double
    Public totalOre As Double
    Public totalSteel As Double
    'Earn Per Second
    Public TaxCollectors As Integer
    Public TaxCollectorsC As Integer
    Public Donations As Integer
    Public DonationsC As Integer
    'Workers
    Public cWorker As Integer
    Public cWorkerC As Integer
    'Construction
    Public cOreM As Integer
    Public cOreMC As Integer
#End Region
#Region "Setup"
    Private Sub BCityHall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCityHall.Click
        totalMoney += 1
        Money.Text = totalMoney.ToString("$0.00")
    End Sub

    Private Sub ResetTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetTimer.Tick
        'Button on/off
        'Upgrades
        If totalMoney >= TaxCollectorsC Then
            BTaxC.Enabled = True
        Else
            BTaxC.Enabled = False
        End If

        If totalMoney >= DonationsC Then
            BDo.Enabled = True
        Else
            BDo.Enabled = False
        End If


        'Workers
        If totalMoney >= cWorkerC Then
            BWork.Enabled = True
        Else
            BWork.Enabled = False
        End If


        'Construction
        If totalMoney >= cOreMC And cWorker > 0 Then
            BCOre.Enabled = True
        Else
            BCOre.Enabled = False
        End If
    End Sub

    Private Sub SecondCount_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondCount.Tick
        'Money per second
        totalMoney += TaxCollectors * 1
        totalMoney += Donations * 5

        Money.Text = totalMoney.ToString("$0.00")
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SecondCount.Start()
        ResetTimer.Start()
        'Upgrades
        TaxCollectorsC = 10 : BTaxC.Text = "Tax Collector ($1/sec): " & TaxCollectorsC.ToString("$0")
        DonationsC = 50 : BDo.Text = "Donations ($5/sec): " & DonationsC.ToString("$0")
        'Workers
        cWorkerC = 4000 : BWork.Text = "Construction Worker: " & cWorkerC.ToString("$0") & vbCrLf & "(Unlocks Construction)"
        'Construction
        cOreMC = 2000 : BCOre.Text = "Ore Mine: " & cOreMC.ToString("$0") & vbCrLf & "(+ 0.2 ore/second)"
    End Sub

    'Remove money to buy : output new balance to label
    'Add a collector
    'Increase cost to buy : output new cost to label
#Region "Upgrades Setup"
    Private Sub BTaxC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTaxC.Click
        totalMoney -= TaxCollectorsC : Money.Text = totalMoney.ToString("$0.00")
        TaxCollectors += 1
        TaxCollectorsC = TaxCollectorsC * 1.25 : BTaxC.Text = "Tax Collector ($1/sec): " & TaxCollectorsC.ToString("$0")
    End Sub

    Private Sub BDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDo.Click
        totalMoney -= DonationsC : Money.Text = totalMoney.ToString("$0.00")
        Donations += 1
        DonationsC = DonationsC * 1.5 : BDo.Text = "Donations ($5/sec): " & DonationsC.ToString("$0")
    End Sub

#End Region
#Region "Workers Setup"
    Private Sub BWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BWork.Click
        totalMoney -= cWorkerC : Money.Text = totalMoney.ToString("$0.00")
        cWorker += 1
        cWorkerC = cWorkerC * 3 : BWork.Text = "Construction Worker: " & cWorkerC.ToString("$0") & vbCrLf & "(+ 0.5/sec Construction Speed)"
    End Sub
#End Region
#Region "Construction Setup"
    Private Sub BCOre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCOre.Click
        totalMoney -= cOreMC : Money.Text = totalMoney.ToString("$0.00")
        cOreM += 1
        cOreMC = cOreMC * 2 : BCOre.Text = "Ore Mine: " & cOreMC.ToString("$0") & vbCrLf & "(+ 0.2 ore/second)"
    End Sub
#End Region
#End Region



End Class

'<--------------------- NOTES ------------------------------>
'   -> Constuction workers make buildings
'   ->
'
'
'
'
'
'
'
'
'
'<--------------------- IDEAS ------------------------------>
'   -> Workers that cost an ammount of upgrades instead of money
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'
'