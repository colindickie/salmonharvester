
Module DrawTiming

    Public Sub draw_timing(gateclosedelay As Integer, hammerdelay As Integer, knifedelay As Integer, knifetime As Integer, lifttime As Integer, gatedelay As Integer, ByRef repeatcycle As Integer)

        'Clear old graphics
        Dim g As Graphics = MainForm.TabMachine.CreateGraphics()
        g.Clear(Color.White)
        g.Dispose()

        'redraw Reset button


        'Dim gateclosedelay = 10  'temporary
        Dim topmargin = 50
        Dim leftmargin = 50

        'set vertical spacing of lines
        Dim cLine(8) As Integer
        For Counter = 1 To 9
            cLine(Counter - 1) = topmargin + Counter * 40
        Next

        Dim scalefactor As Single = 1.2

        Dim trigger(7) As Single
        trigger(0) = leftmargin + 100 / scalefactor               'tail trigger activated
        trigger(1) = trigger(0) + gateclosedelay / scalefactor    'gate close activated
        trigger(2) = trigger(0) + 300 / scalefactor               'main trigger activated
        trigger(3) = trigger(2) + hammerdelay / scalefactor       'hammer activated
        trigger(4) = trigger(3) + knifedelay / scalefactor        'knife activated
        trigger(5) = trigger(4) + knifetime / scalefactor         'lift activated
        trigger(6) = trigger(5) + gatedelay / scalefactor         'tail gate opened
        trigger(7) = trigger(5) + lifttime / scalefactor          'lift deactivated

        'convert triggers to integers
        Dim triggerint(7) As Integer
        For Counter = 0 To 7
            triggerint(Counter) = Convert.ToInt32(trigger(Counter))

        Next


        'draw legend
        repeatcycle = Convert.ToInt32((trigger(6) - trigger(0)) * scalefactor)
        'MainForm.TabMachine = "Repeat Cycle [" & cycle.ToString & "ms approx]"

        draw_line(triggerint(0), cLine(0) - 30, triggerint(6), cLine(0) - 30, "Repeat Cycle", 3)
        draw_line(triggerint(0), cLine(8) + 10, triggerint(1), cLine(8) + 10, "Gate Close Delay", 3)
        draw_line(triggerint(2), cLine(8) - 30, triggerint(3), cLine(8) - 30, "Hammer Delay", 3)
        draw_line(triggerint(3), cLine(8) + 10, triggerint(4), cLine(8) + 10, "Knife Delay", 3)
        draw_line(triggerint(4), cLine(8) - 10, triggerint(5), cLine(8) - 10, "Knife Time", 3)
        draw_line(triggerint(5), cLine(8) - 30, triggerint(7), cLine(8) - 30, "Lift Time", 3)
        draw_line(triggerint(5), cLine(8) + 10, triggerint(6), cLine(8) + 10, "Gate Open Delay", 3)


        Dim repeat As Integer = triggerint(6)

        draw_line(triggerint(0), topmargin, triggerint(0), cLine(7) + 50, "Trigger1", 2)
        draw_line(triggerint(1), topmargin, triggerint(1), cLine(7) + 50, "Trigger2", 2)
        draw_line(triggerint(2), topmargin, triggerint(2), cLine(7) + 50, "Trigger3", 2)
        draw_line(triggerint(3), topmargin, triggerint(3), cLine(7) + 50, "Trigger4", 2)
        draw_line(triggerint(4), topmargin, triggerint(4), cLine(7) + 50, "Trigger5", 2)
        draw_line(triggerint(5), topmargin, triggerint(5), cLine(7) + 50, "Trigger6", 2)
        draw_line(triggerint(6), topmargin, triggerint(6), cLine(7) + 50, "Trigger7", 2)
        draw_line(triggerint(7), topmargin, triggerint(7), cLine(7) + 50, "Trigger8", 2)


        draw_function(True, cLine(0), leftmargin, triggerint(1), repeat)            ' Tail Gate
        draw_function(False, cLine(1), triggerint(0), 200, repeat)                  ' Tail Trigger
        draw_function(False, cLine(2), triggerint(2), triggerint(5), repeat)           ' Main Trigger
        draw_function(False, cLine(3), triggerint(2), triggerint(5), repeat)           ' Cheek
        draw_function(False, cLine(4), triggerint(3), triggerint(6), repeat)           ' Hammer
        draw_function(False, cLine(5), triggerint(4), triggerint(5), repeat)           ' Knife
        draw_function(False, cLine(6), triggerint(5), triggerint(7), repeat)           ' Lift
        draw_function(False, cLine(7), triggerint(0), triggerint(5), repeat)           ' hold down



    End Sub

    Sub draw_function(startpos As Boolean, linepos As Integer, sw1 As Integer, sw2 As Integer, repeat As Integer)
        'Dim ontime As Integer = 50
        Dim maxtime As Integer = 1500
        Dim shift As Integer = 20
        Dim leftmargin As Integer = 50

        repeat = repeat - leftmargin

        If startpos = False Then
            draw_line(leftmargin, linepos, sw1, linepos, "linea" & linepos.ToString, 0) 'accross
            draw_line(sw1, linepos, sw1, linepos - shift, "lineb" & linepos.ToString, 0) ' up
        End If
        draw_line(sw1, linepos - shift, sw2, linepos - shift, "linec" & linepos.ToString, 0) ' accross
        draw_line(sw2, linepos - shift, sw2, linepos, "lined" & linepos.ToString, 0) ' down

        'If sw1 > (maxtime - repeat) Then sw1 = maxtime + repeat
        sw1 = Math.Min(sw1, maxtime - repeat)

        draw_line(sw2, linepos, sw1 + repeat, linepos, "linee" & linepos.ToString, 1) ' accross
        sw2 = Math.Min(sw2, maxtime - repeat)
        draw_line(sw1 + repeat, linepos, sw1 + repeat, linepos - shift, "linef" & linepos.ToString, 1) ' up
        draw_line(sw1 + repeat, linepos - shift, sw2 + repeat, linepos - shift, "lineg" & linepos.ToString, 1) ' accross
        draw_line(sw2 + repeat, linepos - shift, sw2 + repeat, linepos, "lineh" & linepos.ToString, 1) ' down
        draw_line(sw2 + repeat, linepos, maxtime, linepos, "linei" & linepos.ToString, 1) ' accross


    End Sub

    Sub draw_line(startx As Integer, starty As Integer, endx As Integer, endy As Integer, name As String, linestyle As Integer)
        Dim g As Graphics = MainForm.TabMachine.CreateGraphics






        Dim pt1 = New System.Drawing.Point(startx, starty)
        Dim pt2 = New System.Drawing.Point(endx, endy)




        Select Case linestyle
            Case 0

                'main lines
                Dim mainPen As New Pen(Color.Red, 2)

                g.DrawLine(mainPen, pt1, pt2)
            Case 1
                'repeat lines
                Dim repeatPen As New Pen(Color.Blue, 0.5)

                g.DrawLine(repeatPen, pt1, pt2)
            Case 2
                'trigger lines
                Dim dashValues As Single() = {5, 2, 15, 4}
                Dim triggerPen As New Pen(Color.Gray, 1)
                triggerPen.DashPattern = dashValues

                g.DrawLine(triggerPen, pt1, pt2)
            Case 3

                'legend lines
                Dim ptlabel = New System.Drawing.Point(Convert.ToInt32((startx + endx) / 2 + 6), starty - 7)
                Dim legendPen As New Pen(Color.Gray, 0.5)
                legendPen.StartCap = Drawing2D.LineCap.RoundAnchor
                legendPen.EndCap = Drawing2D.LineCap.ArrowAnchor
                Dim dashValues2 As Single() = {5, 2, 5, 2}
                legendPen.DashPattern = dashValues2

                Dim legendlabel As Label
                If MainForm.TabMachine.Controls.Find(name, False).Length = 0 Then
                    legendlabel = New Label
                    MainForm.TabMachine.Controls.Add(legendlabel)
                Else
                    legendlabel = CType(MainForm.TabMachine.Controls.Find(name, False)(0), Label)
                End If

                legendlabel.Font = New Font("Microsoft Sans Serif", 7)
                legendlabel.Location = ptlabel
                legendlabel.Name = name
                legendlabel.Text = name
                legendlabel.AutoSize = True

                g.DrawLine(legendPen, pt1, pt2)

        End Select

    End Sub

End Module
