Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Controls
Imports System.Windows.Media
Imports DevExpress.Xpf.Editors

Namespace ColorEdit_CustomPalette
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			' Removes the 'Standard Colors' palette.
			colorEdit1.Palettes.Remove(colorEdit1.Palettes("Standard Colors"))
			' Adds a custom gradient palette.
			colorEdit1.Palettes.Add(CustomPalette.CreateGradientPalette("Apex Colors", PredefinedColorCollections.Apex))
			' Adds a new palette with three custom RGB colors.
			Dim colors As List(Of Color) = New List(Of Color)()
                                                colors.Add(Color.FromArgb(100, 150, 18, 30))
                                                colors.Add(Color.FromArgb(255, 20, 40, 20))
                                                colors.Add(Color.FromArgb(255, 88, 73, 29))
                                                colorEdit1.Palettes.Add(New CustomPalette("Custom RGB Colors", colors))
		End Sub
	End Class
End Namespace
