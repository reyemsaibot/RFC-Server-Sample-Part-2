﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("NCo_3_RFC_Server_Sample_Tobias_Meyer_P2.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {&quot;name&quot;:&quot;PCD&quot;,&quot;format&quot;:&quot;1.0&quot;,&quot;unicodeEnabled&quot;:true,&quot;functions&quot;:[
        '''    {&quot;name&quot;:&quot;STFC_CONNECTION&quot;,&quot;basXmlEnabled&quot;:false,&quot;parameters&quot;:[
        '''	    {&quot;name&quot;:&quot;ECHOTEXT&quot;,&quot;direction&quot;:&quot;EXPORT&quot;,&quot;optional&quot;:false,&quot;abapType&quot;:&quot;C&quot;,&quot;nucLength&quot;:255,&quot;ucLength&quot;:510},
        '''		{&quot;name&quot;:&quot;RESPTEXT&quot;,&quot;direction&quot;:&quot;EXPORT&quot;,&quot;optional&quot;:false,&quot;abapType&quot;:&quot;C&quot;,&quot;nucLength&quot;:255,&quot;ucLength&quot;:510},
        '''		{&quot;name&quot;:&quot;REQUTEXT&quot;,&quot;direction&quot;:&quot;IMPORT&quot;,&quot;optional&quot;:false,&quot;abapType&quot;:&quot;C&quot;,&quot;nucLength&quot;:255,&quot;ucLength&quot;:510}]
        '''	}	
        '''	]
        '''}.
        '''</summary>
        Friend ReadOnly Property repo() As String
            Get
                Return ResourceManager.GetString("repo", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
