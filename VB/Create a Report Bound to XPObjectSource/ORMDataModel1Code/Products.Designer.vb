﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection
Namespace Create_a_Report_Bound_to_XPObjectSource.nwind

    Partial Public Class Products
        Inherits XPLiteObject

        Private fCategoryID As Categories
        <Association("ProductsReferencesCategories")> _
        Public Property CategoryID() As Categories
            Get
                Return fCategoryID
            End Get
            Set(ByVal value As Categories)
                SetPropertyValue(Of Categories)(NameOf(CategoryID), fCategoryID, value)
            End Set
        End Property
        Private fDiscontinued As Boolean
        <ColumnDbDefaultValue("=No")> _
        Public Property Discontinued() As Boolean
            Get
                Return fDiscontinued
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)(NameOf(Discontinued), fDiscontinued, value)
            End Set
        End Property
        Private fEAN13 As String
        <Size(12), ColumnDbDefaultValue("0")> _
        Public Property EAN13() As String
            Get
                Return fEAN13
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(EAN13), fEAN13, value)
            End Set
        End Property
        Private fProductID As Integer
        <Key(True)> _
        Public Property ProductID() As Integer
            Get
                Return fProductID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)(NameOf(ProductID), fProductID, value)
            End Set
        End Property
        Private fProductName As String
        <Indexed(Name := "ProductName"), Size(40)> _
        Public Property ProductName() As String
            Get
                Return fProductName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(ProductName), fProductName, value)
            End Set
        End Property
        Private fQuantityPerUnit As String
        <Size(20)> _
        Public Property QuantityPerUnit() As String
            Get
                Return fQuantityPerUnit
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(QuantityPerUnit), fQuantityPerUnit, value)
            End Set
        End Property
        Private fReorderLevel As Short
        <ColumnDbDefaultValue("0")> _
        Public Property ReorderLevel() As Short
            Get
                Return fReorderLevel
            End Get
            Set(ByVal value As Short)
                SetPropertyValue(Of Short)(NameOf(ReorderLevel), fReorderLevel, value)
            End Set
        End Property
        Private fSupplierID As Integer
        <Indexed(Name := "SupplierID")> _
        Public Property SupplierID() As Integer
            Get
                Return fSupplierID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)(NameOf(SupplierID), fSupplierID, value)
            End Set
        End Property
        Private fUnitPrice As Decimal
        <ColumnDbDefaultValue("0")> _
        Public Property UnitPrice() As Decimal
            Get
                Return fUnitPrice
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)(NameOf(UnitPrice), fUnitPrice, value)
            End Set
        End Property
        Private fUnitsInStock As Short
        <ColumnDbDefaultValue("0")> _
        Public Property UnitsInStock() As Short
            Get
                Return fUnitsInStock
            End Get
            Set(ByVal value As Short)
                SetPropertyValue(Of Short)(NameOf(UnitsInStock), fUnitsInStock, value)
            End Set
        End Property
        Private fUnitsOnOrder As Short
        <ColumnDbDefaultValue("0")> _
        Public Property UnitsOnOrder() As Short
            Get
                Return fUnitsOnOrder
            End Get
            Set(ByVal value As Short)
                SetPropertyValue(Of Short)(NameOf(UnitsOnOrder), fUnitsOnOrder, value)
            End Set
        End Property
    End Class

End Namespace
