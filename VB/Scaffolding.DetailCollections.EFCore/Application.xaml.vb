Imports DevExpress.Xpf.Core
Imports Microsoft.EntityFrameworkCore
Imports Scaffolding.DetailCollectionsEFCore.Model
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows

Namespace Scaffolding.DetailCollections.EFCore
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			MyBase.OnStartup(e)
			ApplicationThemeHelper.UpdateApplicationThemeName()
			Using context = New DepartmentContext()
				context.Database.Migrate()
				context.EnsureSeedData()
			End Using
		End Sub

		Protected Overrides Sub OnExit(ByVal e As ExitEventArgs)
			ApplicationThemeHelper.SaveApplicationThemeName()
		End Sub
	End Class
End Namespace
