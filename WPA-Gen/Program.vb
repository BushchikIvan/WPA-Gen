Module Program
    Sub Main(args As String())
        Dim temp As String
        Dim mass() As Char
        FileOpen(1, "list.txt", OpenMode.Output)
        mass= {"", " ", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J", "k", "K", "l", "L", "m", "M", "n", "N", "o", "O", "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "w", "W", "x", "X", "y", "Y", "z", "Z", "а", "А", "б", "Б", "в", "В", "г", "Г", "д", "Д", "е", "Е", "ё", "Ё", "ж", "Ж", "з", "З", "и", "И", "й", "Й", "к", "К", "л", "Л", "м", "М", "н", "Н", "о", "О", "п", "П", "р", "Р", "с", "С", "т", "Т", "у", "У", "ф", "Ф", "х", "Х", "ц", "Ц", "ч", "Ч", "ш", "Щ", "ъ", "Ъ", "ы", "Ы", "ь", "Ь", "э", "Э", "ю", "Ю", "я", "Я", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "=", "{", "}", "[", "]", "\", ":", ";", "'", "<", ">", ",", ".", "?", "/"}
        For a = 0 To Ubound(mass)
            For b = 0 To Ubound(mass)
                For c = 0 To Ubound(mass)
                    For d = 0 To Ubound(mass)
                        For e = 0 To Ubound(mass)
                            For f = 0 To Ubound(mass)
                                For g = 0 To Ubound(mass)
                                    For h = 0 To Ubound(mass)
                                        For a1 = 1 To Ubound(mass)
                                            For b1 = 1 To Ubound(mass)
                                                For c1 = 1 To Ubound(mass)
                                                    For d1 = 1 To Ubound(mass)
                                                        For e1 = 1 To Ubound(mass)
                                                            For f1 = 1 To Ubound(mass)
                                                                For g1 = 1 To Ubound(mass)
                                                                    For h1 = 1 To Ubound(mass)
                                                                        temp = mass(a) + mass(b) + mass(c) + mass(d) + mass(e) + mass(f) + mass(g) + mass(h) + mass(a1) + mass(b1) + mass(c1) + mass(d1) + mass(e1) + mass(f1) + mass(g1) + mass(h1)
                                                                        PrintLine(temp)
                                                                    Next
                                                                Next
                                                            Next
                                                        Next
                                                    Next
                                                Next
                                            Next
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next
        FileClose(1)
    End Sub
End Module
