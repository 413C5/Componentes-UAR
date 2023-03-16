Public Class frmPrincipal
#Region "Atributos"
    Private _veces As Integer
    Dim componentesUAR() As String = {"Con el objetivo de que se archive el reporte, este debe contar con un identificador único. Este identificador se puede formar con números y letras, para el caso en que más de una persona esté trabajando en este proyecto o para el caso que se esté utilizando más de una técnica de análisis. Por ejemplo, si Carlos Pérez y Judith Taméz están llevando este análisis, podemos crear un identificador como CP10 o JT8. Si se están utilizando los estudios de evaluación heurística y usabilidad de pensamiento en voz alta, los identificadores pudieran ser HE4 o TA9.",
        "Esta descripción será el ""nombre"" de la UAR que usarás cuando la menciones como relación con otra UAR. Asigna el nombre más corto que puedas (de tres a cinco palabras) asegurando que describa el aspecto y además que se distinga del resto de los aspectos del sistema.",
        "Este es el material de soporte objetivo que justifica el aspecto que identificaste y especifica que merece un reporte. Esta sección debe contener la información suficiente para que la persona que lea este UAR comprenda la razón que hizo que se creara este reporte. Para un reporte HE, por ejemplo, las evidencias pueden consistir en una imagen que represente desorden y la heurística que habla de diseño estético y minimalista. O puede consistir en una lista de elementos de menú que no tienen un atajo y la heurística que habla de incluir atajos. En un estudio de pensamiento en voz alta la prueba consiste, por lo general de lo que se ve en pantalla ( una impresión de la pantalla o una descripción), las acciones que realizó el usuario (teclado, movimientos de mouse), lo que hizo el sistema como respuesta a las acciones del usuario, y lo que dijo el usuario. Si cuentas con un video o con la posibilidad de editarlo, puedes incluir una animación breve.",
        "Esta es la interpretación de la evidencia. Esto es, para la prueba de usabilidad de pensamiento en voz alta, la razón por la cual pasó lo que pasó, o, para una HE, la razón por la cual crees que se diseñó de la manera en que está diseñada. Aquí se pueden incluir leyendas como: ""la etiqueta del botón XYZ, es un término de programación estándar, pero el usuario, al parecer, no estaba familiarizado con este término"" o ""el sistema estaba en modo de edición, pero el usuario pensó que estaba en modo ejecutable porque no hay una diferencia muy marcada entre estos modos en la pantalla."" (Esto se debe expresar de manera que analice la situación que sucedió con el aspecto del sistema, NO de una manera que de insinúe que se debe hacer una evaluación del desarrollador o del usuario.)",
        "Aquí debes especificar, según tu razonamiento, el grado de importancia que tiene este problema para que se resuelva o para mantenerlo como característica positiva. Aquí puedes incluir información referente a la frecuencia con la cual se le presentará al usuario, si acaso crees que aprenda el usuario como funciona este problema, si crees que el problema le afecta más a los usuarios nuevos, no frecuentes o con experiencia, entre otros.",
        "Si el aspecto representa un problema (opuesto a una característica positiva que debe permanecer en la siguiente versión del software), aquí es donde se debe proponer una solución. No es necesario contar con una solución al momento que identificaste un problema—podrá darse el caso en que después de analizar toda la interfaz, muchos problemas estén relacionados y se puedan solucionar todos haciendo algunos cambios generales.",
        "Muchas veces los UAR están relacionados entre sí. Aquí es donde se documenta con cual UAR está relacionado cada uno y un breve enunciado que indica la forma en que está relacionado. Asegúrate que todas las UAR relacionadas documenten al resto de las UAR relacionadas. Por decir, Si el UAR #1 está relacionado con el UAR #30, el UAR #30 debe indicar en esta sección, la relación que tiene con UAR #1 y el UAR #1 debe indicar la relación que tiene con la UAR #30. (El error más común es que en la UAR más reciente indiques la relación con las UAR anteriores, pero no te regreses para documentar en las UAR previas su relación con la UAR más reciente)."}

    Public Property Veces As Integer
        Set(value As Integer)
            'Validar que el valor sea permitido
            If value < 0 Then
                value = 0
            End If

            'Validar si hay un cambio en el valor
            If value <> _veces Then
                _veces = value
                'Cambiar objetos que dependen del valor
                If _veces = 0 Then
                    labPrimera.Visible = False
                    labUltima.Visible = False
                Else
                    labPrimera.Visible = True
                    labUltima.Visible = True
                End If
            End If
        End Set
        Get
            Return _veces
        End Get
    End Property
#End Region

#Region "Metodos"

    ''' <summary>
    ''' Asigna un texto UAR en base al índice proveido 
    ''' </summary>
    ''' <param name="valor"></param>
    Private Sub AsignarUAR(ByVal valor As String)
        Dim mensaje, estilo, titulo As String
        mensaje = "Teclea un valor entre 1 y 7"
        estilo = vbCritical
        titulo = "Error"
        Try
            'Rango 1-7
            Dim indice As Integer = Integer.Parse(valor)
            Select Case indice
                Case 1
                    txtDescripcion.Text = componentesUAR(0)
                Case 2
                    txtDescripcion.Text = componentesUAR(1)
                Case 3
                    txtDescripcion.Text = componentesUAR(2)
                Case 4
                    txtDescripcion.Text = componentesUAR(3)
                Case 5
                    txtDescripcion.Text = componentesUAR(4)
                Case 6
                    txtDescripcion.Text = componentesUAR(5)
                Case 7
                    txtDescripcion.Text = componentesUAR(6)

                    'Índice fuera de rango
                Case Else
                    MsgBox(mensaje, estilo, titulo)
                    txtNumero.SelectAll()
                    txtNumero.Focus()
            End Select

            'Cuando el índice que se provee es vacio o una cadena
        Catch ex As Exception
            estilo = vbExclamation
            MsgBox(mensaje, estilo, titulo)
            txtNumero.SelectAll()
            txtNumero.Focus()
        End Try
    End Sub

    ''' <summary>
    ''' Limpia los textboxes utilizados, asi como el hacer invisibles los labels de instancias
    ''' </summary>
    Private Sub Limpiar()
        txtNumero.Clear()
        txtCadena.Clear()
        txtDescripcion.Clear()
        labPrimera.Visible = False
        labUltima.Visible = False
    End Sub

    ''' <summary>
    ''' Busca una cadena dentro de otra cadena, indicando las veces en que se encuentra la cadena, asi como la primera y ultima instancia 
    ''' de donde se encuentran
    ''' </summary>
    ''' <param name="palabra"></param>
    ''' <param name="texto"></param>
    Private Sub Buscar(ByVal palabra As String, ByVal texto As String)
        Dim prueba = 0
        Dim ultimaPosicion As Integer
        Dim cursor As Integer = LCase(texto).IndexOf(LCase(palabra), 0)
        Dim respuesta As Integer
        Dim mensaje, estilo, titulo

        Try
            'No se ha asignado un índice de descripción UAR
            If String.IsNullOrEmpty(texto) = True Then
                Throw New ArgumentException()
            End If

            'En caso de encontrar coincidencia, se inicia la busqueda
            If cursor <> -1 Then

                'Si devuelve -1 es porque no encontro coincidencia
                If String.IsNullOrEmpty(txtCadena.Text) = True Then
                    Throw New Exception()
                End If

                'Primera ocurrencia de la palabra
                labPrimera.Text = "Primera posición:" & cursor
                labPrimera.Visible = True

                'Se recorre toda la cadena, para contar cuantas veces se encuentra la palabra
                While cursor <> -1
                    Veces += 1
                    ultimaPosicion = cursor
                    cursor = LCase(texto).IndexOf(LCase(palabra), cursor + 1)
                End While

                'Ultima ocurrencia de la palabra
                labUltima.Text = "Última posición:" & ultimaPosicion
                labUltima.Visible = True

                'En caso de haber encontrado una palabra, se pregunta si se quiere hacer otra busqueda
                Beep()
                mensaje = "Se ha encontrado la palabra " & Veces & " veces.¿Desea buscar nuevamente?"
                estilo = vbYesNo + vbQuestion
                titulo = "Palabra encontrada"

                'Si la busqueda se quiere realizar en la misma descripción (exito)
                respuesta = MsgBox(mensaje, estilo, titulo)
                If respuesta = vbYes Then
                    txtCadena.SelectAll()
                    txtCadena.Focus()

                    'Si la busqueda se quiere hacer en otra descripción (exito)
                Else
                    Limpiar()
                    'txtDescripcion.Clear()
                    txtNumero.Focus()
                    mensaje = "Ingrese nuevamente información en los campos"
                    estilo = vbInformation
                    titulo = "Ingresar datos"
                    MsgBox(mensaje, estilo, titulo)
                End If

                'Si la busqueda se quiere hacer en la misma descripción (sin coincidencia)
            Else
                mensaje = "No se encontro la palabra.¿Desea realizar otra busqueda en la misma descripción?"
                estilo = vbYesNo + vbQuestion
                titulo = "Búsqueda"

                Beep()
                respuesta = MsgBox(mensaje, estilo, titulo)
                If respuesta = vbYes Then
                    txtCadena.Clear()
                    txtCadena.Focus()

                    'Si la busqueda se quiere hacer en otra descripción (sin coincidencia)
                Else
                    Limpiar()
                    'txtDescripcion.Clear()
                    txtNumero.Focus()
                End If
            End If

            'Sin descripcion UAR
        Catch ex As ArgumentException
            mensaje = "Seleccione una descripción de UAR"
            estilo = vbCritical
            titulo = "Sin descripción UAR"

            'Pasar enfoque al boton Mostrar
            If String.IsNullOrEmpty(txtNumero.Text) = True Then
                MsgBox(mensaje, estilo, titulo)
                txtNumero.Focus()
            Else
                btnMostrar.Select()
            End If

            'Sin palabra clave
        Catch ex As Exception
            mensaje = "Ingrese una palabra clave"
            estilo = vbCritical
            titulo = "Palabra clave"

            MsgBox(mensaje, estilo, titulo)
            txtCadena.Focus()
        End Try
    End Sub

#End Region
#Region "Eventos"
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        AsignarUAR(txtNumero.Text)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Veces = 0
        Buscar(txtCadena.Text, txtDescripcion.Text)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
#End Region
End Class
