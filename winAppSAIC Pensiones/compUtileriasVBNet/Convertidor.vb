Public Class Convertidor

    'variable utilizada en el método para generar Leyenda de Importes en MXP
    Public Shared bFlag As Boolean

    ''' <summary>
    ''' Método que elimina las comas del valor numerico
    ''' </summary>
    ''' <param name="pNumero"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function EliminarComasEnValoresNumericos(pNumero As String) As String
        Dim Temp As String = ""
        Dim i As Integer, caracter As String

        For i = 1 To Len(pNumero)
            caracter = Mid(pNumero, i, 1)
            If caracter = "." Then
                bFlag = True    'no tiene decimales
                'concatena valores y punto decimal. Elimina las comas
                Temp = Temp + caracter
            ElseIf caracter <> "," Then
                'concatena valores y punto decimal. Elimina las comas
                Temp = Temp + caracter
            End If
        Next

        Return Temp    'regresa varlor
    End Function

    '******************************************************************************************
    'Metodo que hace la conversion a Importe con Letra de la Moneda MXP de un
    'valor numerico que recibe como parametro
    'Creador por ISC Oliver Blanco D.
    'Fecha Creación: Mayo 8, 2005
    'Fecha Ultima Modificación: Junio 22, 2012
    '******************************************************************************************
    Public Shared Function ConvierteImporte2Leyenda(pValor As Decimal, pDescMoneda As String) As String
        Dim digits As Integer, j As Integer
        Dim vNumber As String, valorEntero As String
        Dim valorDecimal As String, Temp As String
        Dim num As String

        'sLeyenda = "PESOS"
        Dim sLeyenda As String = pDescMoneda        'asignar la descripcion de la moneda

        bFlag = False   'inicializar valor de bandera para indicar si el numero tiene decimales <> .00

        'si el importe es igual a CERO
        If pValor = 0 Then
            num = 0
        Else
            'eliminar comas del valor numerico y concatenar 2 ceros al final
            'para garantizar que siempre se obtengan con 2 decimales
            num = EliminarComasEnValoresNumericos(CStr(pValor))
        End If

        If bFlag = True Then
            valorDecimal = Left(Mid(num, InStr(num, ".") + 1, 2) & "00", 2)    '*** Almacena parte decimal
            valorEntero = Left(num, InStr(num, ".") - 1)    '*** Almacena parte entera
        Else
            valorDecimal = "00"
            valorEntero = num    '*** Almacena parte entera
        End If

        If Left(valorEntero, 1) = "-" Then
            valorEntero = Right(valorEntero, Len(valorEntero) - 1)
        End If

        Select Case pDescMoneda     'Asignar la terminacion M.N. si la moneda es MXP, sino NO incluirla
            Case "PESOS"
                sLeyenda = String.Format("{0} {1}/100 M. N.", sLeyenda, valorDecimal)
            Case Else
                sLeyenda = String.Format("{0} {1}/100", sLeyenda, valorDecimal)
        End Select

        digits = Len(valorEntero)          '*** Almacena el numero de digitos del numero a convertir

        For j = 1 To digits
            If (digits = 1) Or (((j - 1) Mod 3) = 0) Then    '* Units
                vNumber = Right(valorEntero, j)
                Select Case j
                    Case 4, 10
                        If Left(Right(valorEntero, j + 2), 3) <> "000" Then
                            sLeyenda = "MIL " + sLeyenda
                        End If
                    Case 7
                        If Right(valorEntero, 6) = "000000" Then
                            sLeyenda = "DE " + sLeyenda
                        End If
                        If Left(vNumber, 1) = "1" Then
                            If digits = 7 Then
                                sLeyenda = "MILLON " + sLeyenda
                            Else
                                sLeyenda = "MILLONES " + sLeyenda
                            End If
                        Else
                            sLeyenda = "MILLONES " + sLeyenda
                        End If
                    Case 13
                        If Right(valorEntero, 12) = "000000000000" Then
                            sLeyenda = "DE " + sLeyenda
                        End If
                        If Left(vNumber, 1) = "1" Then
                            sLeyenda = "BILLON " + sLeyenda
                        Else
                            sLeyenda = "BILLONES " + sLeyenda
                        End If
                End Select

                Select Case Left(vNumber, 1)
                    Case "0"
                        Temp = sLeyenda   '*** Almacena el ultimo texto en orden a las unidades
                        sLeyenda = sLeyenda
                    Case "1"
                        Temp = sLeyenda
                        sLeyenda = "UN " + sLeyenda
                    Case "2"
                        Temp = sLeyenda
                        sLeyenda = "DOS " + sLeyenda
                    Case "3"
                        Temp = sLeyenda
                        sLeyenda = "TRES " + sLeyenda
                    Case "4"
                        Temp = sLeyenda
                        sLeyenda = "CUATRO " + sLeyenda
                    Case "5"
                        Temp = sLeyenda
                        sLeyenda = "CINCO " + sLeyenda
                    Case "6"
                        sLeyenda = "SEIS " + sLeyenda
                    Case "7"
                        sLeyenda = "SIETE " + sLeyenda
                    Case "8"
                        sLeyenda = "OCHO " + sLeyenda
                    Case "9"
                        sLeyenda = "NUEVE " + sLeyenda
                End Select
            ElseIf ((((j - 2) Mod 3) = 0) And (digits > 1)) Then      '*** Decenas
                vNumber = Right(valorEntero, j)

                Select Case Left(vNumber, 1)
                    Case "0"
                        sLeyenda = sLeyenda
                    Case "1"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "DIEZ " + Temp
                            Case "1"
                                sLeyenda = "ONCE " + Temp
                            Case "2"
                                sLeyenda = "DOCE " + Temp
                            Case "3"
                                sLeyenda = "TRECE " + Temp
                            Case "4"
                                sLeyenda = "CATORCE " + Temp
                            Case "5"
                                sLeyenda = "QUINCE " + Temp
                            Case Else
                                sLeyenda = "DIEZ Y " + sLeyenda
                        End Select
                    Case "2"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "VEINTE " + sLeyenda
                            Case Else
                                sLeyenda = "VEINTE Y " + sLeyenda
                        End Select
                    Case "3"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "TREINTA " + sLeyenda
                            Case Else
                                sLeyenda = "TREINTA Y " + sLeyenda
                        End Select
                    Case "4"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "CUARENTA " + sLeyenda
                            Case Else
                                sLeyenda = "CUARENTA Y " + sLeyenda
                        End Select
                    Case "5"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "CINCUENTA " + sLeyenda
                            Case Else
                                sLeyenda = "CINCUENTA Y " + sLeyenda
                        End Select
                    Case "6"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "SESENTA " + sLeyenda
                            Case Else
                                sLeyenda = "SESENTA Y " + sLeyenda
                        End Select
                    Case "7"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "SETENTA " + sLeyenda
                            Case Else
                                sLeyenda = "SETENTA Y " + sLeyenda
                        End Select
                    Case "8"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "OCHENTA " + sLeyenda
                            Case Else
                                sLeyenda = "OCHENTA Y " + sLeyenda
                        End Select
                    Case "9"
                        Select Case Right(Left(vNumber, 2), 1)
                            Case "0"
                                sLeyenda = "NOVENTA " + sLeyenda
                            Case Else
                                sLeyenda = "NOVENTA Y " + sLeyenda
                        End Select
                End Select

            ElseIf (((j Mod 3) = 0) And (digits > 1)) Then      '*** Centenas
                vNumber = Right(valorEntero, j)

                Select Case Left(vNumber, 1)
                    Case "0"
                        sLeyenda = sLeyenda
                    Case "1"
                        If Right(Left(vNumber, 3), 1) = "0" And Right(Left(vNumber, 2), 1) = "0" Then
                            sLeyenda = "CIEN " + sLeyenda     '*** Si son decenas y unidades son ceros
                        Else
                            sLeyenda = "CIENTO " + sLeyenda
                        End If
                    Case "2"
                        sLeyenda = "DOSCIENTOS " + sLeyenda
                    Case "3"
                        sLeyenda = "TRESCIENTOS " + sLeyenda
                    Case "4"
                        sLeyenda = "CUATROCIENTOS " + sLeyenda
                    Case "5"
                        sLeyenda = "QUINIENTOS " + sLeyenda
                    Case "6"
                        sLeyenda = "SEISCIENTOS " + sLeyenda
                    Case "7"
                        sLeyenda = "SETECIENTOS " + sLeyenda
                    Case "8"
                        sLeyenda = "OCHOCIENTOS " + sLeyenda
                    Case "9"
                        sLeyenda = "NOVECIENTOS " + sLeyenda
                End Select
            End If

        Next j

        Return sLeyenda     'regresar Texto Importe
    End Function


End Class
