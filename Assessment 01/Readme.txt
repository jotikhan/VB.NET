
-----------Known Faults----------
Addition shot after win situation means the picture box always show the default game image and not the you have lost picture

I need to add a computuer lost picture / message instead of a you've survived picture


-------------Config----------------------------


In the btnSave_Click event the location of the save file is declared.  Please change the location as appropriate


    file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\jk017\Downloads\RR.txt", True)
        file.WriteLine(lblRRName.Text & "," & lblRound.Text)
