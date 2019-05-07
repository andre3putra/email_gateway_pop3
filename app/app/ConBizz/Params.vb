
Namespace ConBizz

    Public Class Params

        Public Parameter As Object
        Public Record As Object

        Public Sub New()
            'do nothing
        End Sub

        Public Sub New(ByVal Parameters As Object, ByVal Records As Object)
            Parameter = Parameters
            Record = Records
        End Sub

    End Class

End Namespace


