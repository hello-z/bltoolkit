﻿'---------------------------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated by BLToolkit template for T4.
'    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
' </auto-generated>
'---------------------------------------------------------------------------------------------------
Imports System
Imports System.Collections.Generic
Imports System.Runtime.Serialization

Imports BLToolkit.Common
Imports BLToolkit.Data
Imports BLToolkit.Data.Linq
Imports BLToolkit.DataAccess
Imports BLToolkit.Mapping

Namespace Templates.VB

	Public Partial Class DataContext
		Inherits DbManager

		Public ReadOnly Property AlphabeticalListOfProducts() As Table(Of AlphabeticalListOfProducts)
			Get
				Return Me.GetTable(Of AlphabeticalListOfProducts)()
			End Get
		End Property

		Public ReadOnly Property Categories()                 As Table(Of Categories)
			Get
				Return Me.GetTable(Of Categories)()
			End Get
		End Property

		Public ReadOnly Property CategorySalesFor1997()       As Table(Of CategorySalesFor1997)
			Get
				Return Me.GetTable(Of CategorySalesFor1997)()
			End Get
		End Property

		Public ReadOnly Property CurrentProductList()         As Table(Of CurrentProductList)
			Get
				Return Me.GetTable(Of CurrentProductList)()
			End Get
		End Property

		Public ReadOnly Property CustomerAndSuppliersByCity() As Table(Of CustomerAndSuppliersByCity)
			Get
				Return Me.GetTable(Of CustomerAndSuppliersByCity)()
			End Get
		End Property

		Public ReadOnly Property CustomerCustomerDemo()       As Table(Of CustomerCustomerDemo)
			Get
				Return Me.GetTable(Of CustomerCustomerDemo)()
			End Get
		End Property

		Public ReadOnly Property CustomerDemographics()       As Table(Of CustomerDemographics)
			Get
				Return Me.GetTable(Of CustomerDemographics)()
			End Get
		End Property

		Public ReadOnly Property Customers()                  As Table(Of Customers)
			Get
				Return Me.GetTable(Of Customers)()
			End Get
		End Property

		Public ReadOnly Property Employees()                  As Table(Of Employees)
			Get
				Return Me.GetTable(Of Employees)()
			End Get
		End Property

		Public ReadOnly Property EmployeeTerritories()        As Table(Of EmployeeTerritories)
			Get
				Return Me.GetTable(Of EmployeeTerritories)()
			End Get
		End Property

		Public ReadOnly Property Invoices()                   As Table(Of Invoices)
			Get
				Return Me.GetTable(Of Invoices)()
			End Get
		End Property

		Public ReadOnly Property OrderDetails()               As Table(Of OrderDetails)
			Get
				Return Me.GetTable(Of OrderDetails)()
			End Get
		End Property

		Public ReadOnly Property OrderDetailsExtended()       As Table(Of OrderDetailsExtended)
			Get
				Return Me.GetTable(Of OrderDetailsExtended)()
			End Get
		End Property

		Public ReadOnly Property OrderSubtotals()             As Table(Of OrderSubtotals)
			Get
				Return Me.GetTable(Of OrderSubtotals)()
			End Get
		End Property

		Public ReadOnly Property Orders()                     As Table(Of Orders)
			Get
				Return Me.GetTable(Of Orders)()
			End Get
		End Property

		Public ReadOnly Property OrdersQry()                  As Table(Of OrdersQry)
			Get
				Return Me.GetTable(Of OrdersQry)()
			End Get
		End Property

		Public ReadOnly Property ProductSalesFor1997()        As Table(Of ProductSalesFor1997)
			Get
				Return Me.GetTable(Of ProductSalesFor1997)()
			End Get
		End Property

		Public ReadOnly Property Products()                   As Table(Of Products)
			Get
				Return Me.GetTable(Of Products)()
			End Get
		End Property

		Public ReadOnly Property ProductsAboveAveragePrice()  As Table(Of ProductsAboveAveragePrice)
			Get
				Return Me.GetTable(Of ProductsAboveAveragePrice)()
			End Get
		End Property

		Public ReadOnly Property ProductsByCategory()         As Table(Of ProductsByCategory)
			Get
				Return Me.GetTable(Of ProductsByCategory)()
			End Get
		End Property

		Public ReadOnly Property QuarterlyOrders()            As Table(Of QuarterlyOrders)
			Get
				Return Me.GetTable(Of QuarterlyOrders)()
			End Get
		End Property

		Public ReadOnly Property Region()                     As Table(Of Region)
			Get
				Return Me.GetTable(Of Region)()
			End Get
		End Property

		Public ReadOnly Property SalesByCategory()            As Table(Of SalesByCategory)
			Get
				Return Me.GetTable(Of SalesByCategory)()
			End Get
		End Property

		Public ReadOnly Property SalesTotalsByAmount()        As Table(Of SalesTotalsByAmount)
			Get
				Return Me.GetTable(Of SalesTotalsByAmount)()
			End Get
		End Property

		Public ReadOnly Property Shippers()                   As Table(Of Shippers)
			Get
				Return Me.GetTable(Of Shippers)()
			End Get
		End Property

		Public ReadOnly Property SummaryOfSalesByQuarter()    As Table(Of SummaryOfSalesByQuarter)
			Get
				Return Me.GetTable(Of SummaryOfSalesByQuarter)()
			End Get
		End Property

		Public ReadOnly Property SummaryOfSalesByYear()       As Table(Of SummaryOfSalesByYear)
			Get
				Return Me.GetTable(Of SummaryOfSalesByYear)()
			End Get
		End Property

		Public ReadOnly Property Suppliers()                  As Table(Of Suppliers)
			Get
				Return Me.GetTable(Of Suppliers)()
			End Get
		End Property

		Public ReadOnly Property Territories()                As Table(Of Territories)
			Get
				Return Me.GetTable(Of Territories)()
			End Get
		End Property
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Alphabetical list of products")> _
	Public Partial Class AlphabeticalListOfProducts
		Inherits EntityBase(Of AlphabeticalListOfProducts)

		<DataMember> _
		Public ProductID As Integer

		<DataMember> _
		Public ProductName As String

		<Nullable, DataMember> _
		Public SupplierID As Integer?

		<Nullable, DataMember> _
		Public CategoryID As Integer?

		<Nullable, DataMember> _
		Public QuantityPerUnit As String

		<Nullable, DataMember> _
		Public UnitPrice As Decimal?

		<Nullable, DataMember> _
		Public UnitsInStock As Short?

		<Nullable, DataMember> _
		Public UnitsOnOrder As Short?

		<Nullable, DataMember> _
		Public ReorderLevel As Short?

		<DataMember> _
		Public Discontinued As Boolean

		<DataMember> _
		Public CategoryName As String
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Categories")> _
	Public Partial Class Categories
		Inherits EntityBase(Of Categories)

		<Identity, PrimaryKey(1), DataMember> _
		Public CategoryID As Integer

		<DataMember> _
		Public CategoryName As String

		<Nullable, DataMember> _
		Public Description As String

		<Nullable, DataMember> _
		Public Picture As Byte()

		' FK_Products_Categories_BackReference
		<Association(ThisKey:="CategoryID", OtherKey:="CategoryID")> _
		Public Productss As IEnumerable(Of Products)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Category Sales for 1997")> _
	Public Partial Class CategorySalesFor1997
		Inherits EntityBase(Of CategorySalesFor1997)

		<DataMember> _
		Public CategoryName As String

		<Nullable, DataMember> _
		Public CategorySales As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Current Product List")> _
	Public Partial Class CurrentProductList
		Inherits EntityBase(Of CurrentProductList)

		<Identity, DataMember> _
		Public ProductID As Integer

		<DataMember> _
		Public ProductName As String
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Customer and Suppliers by City")> _
	Public Partial Class CustomerAndSuppliersByCity
		Inherits EntityBase(Of CustomerAndSuppliersByCity)

		<Nullable, DataMember> _
		Public City As String

		<DataMember> _
		Public CompanyName As String

		<Nullable, DataMember> _
		Public ContactName As String

		<DataMember> _
		Public Relationship As String
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="CustomerCustomerDemo")> _
	Public Partial Class CustomerCustomerDemo
		Inherits EntityBase(Of CustomerCustomerDemo)

		<PrimaryKey(1), DataMember> _
		Public CustomerID As String

		<PrimaryKey(2), DataMember> _
		Public CustomerTypeID As String

		' FK_CustomerCustomerDemo
		<Association(ThisKey:="CustomerTypeID", OtherKey:="CustomerTypeID")> _
		Public FK_CustomerCustomerDemo As IEnumerable(Of CustomerDemographics)

		' FK_CustomerCustomerDemo_Customers
		<Association(ThisKey:="CustomerID", OtherKey:="CustomerID")> _
		Public Customers As IEnumerable(Of Customers)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="CustomerDemographics")> _
	Public Partial Class CustomerDemographics
		Inherits EntityBase(Of CustomerDemographics)

		<PrimaryKey(1), DataMember> _
		Public CustomerTypeID As String

		<Nullable, DataMember> _
		Public CustomerDesc As String

		' FK_CustomerCustomerDemo_BackReference
		<Association(ThisKey:="CustomerTypeID", OtherKey:="CustomerTypeID")> _
		Public CustomerCustomerDemos As IEnumerable(Of CustomerCustomerDemo)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Customers")> _
	Public Partial Class Customers
		Inherits EntityBase(Of Customers)

		<PrimaryKey(1), DataMember> _
		Public CustomerID As String

		<DataMember> _
		Public CompanyName As String

		<Nullable, DataMember> _
		Public ContactName As String

		<Nullable, DataMember> _
		Public ContactTitle As String

		<Nullable, DataMember> _
		Public Address As String

		<Nullable, DataMember> _
		Public City As String

		<Nullable, DataMember> _
		Public Region As String

		<Nullable, DataMember> _
		Public PostalCode As String

		<Nullable, DataMember> _
		Public Country As String

		<Nullable, DataMember> _
		Public Phone As String

		<Nullable, DataMember> _
		Public Fax As String

		' FK_Orders_Customers_BackReference
		<Association(ThisKey:="CustomerID", OtherKey:="CustomerID")> _
		Public Orderss As IEnumerable(Of Orders)

		' FK_CustomerCustomerDemo_Customers_BackReference
		<Association(ThisKey:="CustomerID", OtherKey:="CustomerID")> _
		Public CustomerCustomerDemos As IEnumerable(Of CustomerCustomerDemo)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Employees")> _
	Public Partial Class Employees
		Inherits EntityBase(Of Employees)

		<Identity, PrimaryKey(1), DataMember> _
		Public EmployeeID As Integer

		<DataMember> _
		Public LastName As String

		<DataMember> _
		Public FirstName As String

		<Nullable, DataMember> _
		Public Title As String

		<Nullable, DataMember> _
		Public TitleOfCourtesy As String

		<Nullable, DataMember> _
		Public BirthDate As DateTime?

		<Nullable, DataMember> _
		Public HireDate As DateTime?

		<Nullable, DataMember> _
		Public Address As String

		<Nullable, DataMember> _
		Public City As String

		<Nullable, DataMember> _
		Public Region As String

		<Nullable, DataMember> _
		Public PostalCode As String

		<Nullable, DataMember> _
		Public Country As String

		<Nullable, DataMember> _
		Public HomePhone As String

		<Nullable, DataMember> _
		Public Extension As String

		<Nullable, DataMember> _
		Public Photo As Byte()

		<Nullable, DataMember> _
		Public Notes As String

		<Nullable, DataMember> _
		Public ReportsTo As Integer?

		<Nullable, DataMember> _
		Public PhotoPath As String

		' FK_Employees_Employees
		<Association(ThisKey:="ReportsTo", OtherKey:="EmployeeID")> _
		Public ReportsToEmployee As IEnumerable(Of Employees)

		' FK_Orders_Employees_BackReference
		<Association(ThisKey:="EmployeeID", OtherKey:="EmployeeID")> _
		Public Orderss As IEnumerable(Of Orders)

		' FK_EmployeeTerritories_Employees_BackReference
		<Association(ThisKey:="EmployeeID", OtherKey:="EmployeeID")> _
		Public EmployeeTerritoriess As IEnumerable(Of EmployeeTerritories)

		' FK_Employees_Employees_BackReference
		<Association(ThisKey:="EmployeeID", OtherKey:="ReportsTo")> _
		Public s As IEnumerable(Of Employees)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="EmployeeTerritories")> _
	Public Partial Class EmployeeTerritories
		Inherits EntityBase(Of EmployeeTerritories)

		<PrimaryKey(1), DataMember> _
		Public EmployeeID As Integer

		<PrimaryKey(2), DataMember> _
		Public TerritoryID As String

		' FK_EmployeeTerritories_Employees
		<Association(ThisKey:="EmployeeID", OtherKey:="EmployeeID")> _
		Public Employees As IEnumerable(Of Employees)

		' FK_EmployeeTerritories_Territories
		<Association(ThisKey:="TerritoryID", OtherKey:="TerritoryID")> _
		Public Territories As IEnumerable(Of Territories)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Invoices")> _
	Public Partial Class Invoices
		Inherits EntityBase(Of Invoices)

		<Nullable, DataMember> _
		Public ShipName As String

		<Nullable, DataMember> _
		Public ShipAddress As String

		<Nullable, DataMember> _
		Public ShipCity As String

		<Nullable, DataMember> _
		Public ShipRegion As String

		<Nullable, DataMember> _
		Public ShipPostalCode As String

		<Nullable, DataMember> _
		Public ShipCountry As String

		<Nullable, DataMember> _
		Public CustomerID As String

		<DataMember> _
		Public CustomerName As String

		<Nullable, DataMember> _
		Public Address As String

		<Nullable, DataMember> _
		Public City As String

		<Nullable, DataMember> _
		Public Region As String

		<Nullable, DataMember> _
		Public PostalCode As String

		<Nullable, DataMember> _
		Public Country As String

		<DataMember> _
		Public Salesperson As String

		<DataMember> _
		Public OrderID As Integer

		<Nullable, DataMember> _
		Public OrderDate As DateTime?

		<Nullable, DataMember> _
		Public RequiredDate As DateTime?

		<Nullable, DataMember> _
		Public ShippedDate As DateTime?

		<DataMember> _
		Public ShipperName As String

		<DataMember> _
		Public ProductID As Integer

		<DataMember> _
		Public ProductName As String

		<DataMember> _
		Public UnitPrice As Decimal

		<DataMember> _
		Public Quantity As Short

		<DataMember> _
		Public Discount As Single

		<Nullable, DataMember> _
		Public ExtendedPrice As Decimal?

		<Nullable, DataMember> _
		Public Freight As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Order Details")> _
	Public Partial Class OrderDetails
		Inherits EntityBase(Of OrderDetails)

		<PrimaryKey(1), DataMember> _
		Public OrderID As Integer

		<PrimaryKey(2), DataMember> _
		Public ProductID As Integer

		<DataMember> _
		Public UnitPrice As Decimal

		<DataMember> _
		Public Quantity As Short

		<DataMember> _
		Public Discount As Single

		' FK_Order_Details_Orders
		<Association(ThisKey:="OrderID", OtherKey:="OrderID")> _
		Public OrderDetailsOrders As IEnumerable(Of Orders)

		' FK_Order_Details_Products
		<Association(ThisKey:="ProductID", OtherKey:="ProductID")> _
		Public OrderDetailsProducts As IEnumerable(Of Products)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Order Details Extended")> _
	Public Partial Class OrderDetailsExtended
		Inherits EntityBase(Of OrderDetailsExtended)

		<DataMember> _
		Public OrderID As Integer

		<DataMember> _
		Public ProductID As Integer

		<DataMember> _
		Public ProductName As String

		<DataMember> _
		Public UnitPrice As Decimal

		<DataMember> _
		Public Quantity As Short

		<DataMember> _
		Public Discount As Single

		<Nullable, DataMember> _
		Public ExtendedPrice As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Order Subtotals")> _
	Public Partial Class OrderSubtotals
		Inherits EntityBase(Of OrderSubtotals)

		<DataMember> _
		Public OrderID As Integer

		<Nullable, DataMember> _
		Public Subtotal As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Orders")> _
	Public Partial Class Orders
		Inherits EntityBase(Of Orders)

		<Identity, PrimaryKey(1), DataMember> _
		Public OrderID As Integer

		<Nullable, DataMember> _
		Public CustomerID As String

		<Nullable, DataMember> _
		Public EmployeeID As Integer?

		<Nullable, DataMember> _
		Public OrderDate As DateTime?

		<Nullable, DataMember> _
		Public RequiredDate As DateTime?

		<Nullable, DataMember> _
		Public ShippedDate As DateTime?

		<Nullable, DataMember> _
		Public ShipVia As Integer?

		<Nullable, DataMember> _
		Public Freight As Decimal?

		<Nullable, DataMember> _
		Public ShipName As String

		<Nullable, DataMember> _
		Public ShipAddress As String

		<Nullable, DataMember> _
		Public ShipCity As String

		<Nullable, DataMember> _
		Public ShipRegion As String

		<Nullable, DataMember> _
		Public ShipPostalCode As String

		<Nullable, DataMember> _
		Public ShipCountry As String

		' FK_Orders_Customers
		<Association(ThisKey:="CustomerID", OtherKey:="CustomerID")> _
		Public Customers As IEnumerable(Of Customers)

		' FK_Orders_Employees
		<Association(ThisKey:="EmployeeID", OtherKey:="EmployeeID")> _
		Public Employees As IEnumerable(Of Employees)

		' FK_Orders_Shippers
		<Association(ThisKey:="ShipVia", OtherKey:="ShipperID")> _
		Public Shippers As IEnumerable(Of Shippers)

		' FK_Order_Details_Orders_BackReference
		<Association(ThisKey:="OrderID", OtherKey:="OrderID")> _
		Public OrderDetailss As IEnumerable(Of OrderDetails)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Orders Qry")> _
	Public Partial Class OrdersQry
		Inherits EntityBase(Of OrdersQry)

		<DataMember> _
		Public OrderID As Integer

		<Nullable, DataMember> _
		Public CustomerID As String

		<Nullable, DataMember> _
		Public EmployeeID As Integer?

		<Nullable, DataMember> _
		Public OrderDate As DateTime?

		<Nullable, DataMember> _
		Public RequiredDate As DateTime?

		<Nullable, DataMember> _
		Public ShippedDate As DateTime?

		<Nullable, DataMember> _
		Public ShipVia As Integer?

		<Nullable, DataMember> _
		Public Freight As Decimal?

		<Nullable, DataMember> _
		Public ShipName As String

		<Nullable, DataMember> _
		Public ShipAddress As String

		<Nullable, DataMember> _
		Public ShipCity As String

		<Nullable, DataMember> _
		Public ShipRegion As String

		<Nullable, DataMember> _
		Public ShipPostalCode As String

		<Nullable, DataMember> _
		Public ShipCountry As String

		<DataMember> _
		Public CompanyName As String

		<Nullable, DataMember> _
		Public Address As String

		<Nullable, DataMember> _
		Public City As String

		<Nullable, DataMember> _
		Public Region As String

		<Nullable, DataMember> _
		Public PostalCode As String

		<Nullable, DataMember> _
		Public Country As String
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Product Sales for 1997")> _
	Public Partial Class ProductSalesFor1997
		Inherits EntityBase(Of ProductSalesFor1997)

		<DataMember> _
		Public CategoryName As String

		<DataMember> _
		Public ProductName As String

		<Nullable, DataMember> _
		Public ProductSales As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Products")> _
	Public Partial Class Products
		Inherits EntityBase(Of Products)

		<Identity, PrimaryKey(1), DataMember> _
		Public ProductID As Integer

		<DataMember> _
		Public ProductName As String

		<Nullable, DataMember> _
		Public SupplierID As Integer?

		<Nullable, DataMember> _
		Public CategoryID As Integer?

		<Nullable, DataMember> _
		Public QuantityPerUnit As String

		<Nullable, DataMember> _
		Public UnitPrice As Decimal?

		<Nullable, DataMember> _
		Public UnitsInStock As Short?

		<Nullable, DataMember> _
		Public UnitsOnOrder As Short?

		<Nullable, DataMember> _
		Public ReorderLevel As Short?

		<DataMember> _
		Public Discontinued As Boolean

		' FK_Products_Categories
		<Association(ThisKey:="CategoryID", OtherKey:="CategoryID")> _
		Public Categories As IEnumerable(Of Categories)

		' FK_Products_Suppliers
		<Association(ThisKey:="SupplierID", OtherKey:="SupplierID")> _
		Public Suppliers As IEnumerable(Of Suppliers)

		' FK_Order_Details_Products_BackReference
		<Association(ThisKey:="ProductID", OtherKey:="ProductID")> _
		Public OrderDetailss As IEnumerable(Of OrderDetails)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Products Above Average Price")> _
	Public Partial Class ProductsAboveAveragePrice
		Inherits EntityBase(Of ProductsAboveAveragePrice)

		<DataMember> _
		Public ProductName As String

		<Nullable, DataMember> _
		Public UnitPrice As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Products by Category")> _
	Public Partial Class ProductsByCategory
		Inherits EntityBase(Of ProductsByCategory)

		<DataMember> _
		Public CategoryName As String

		<DataMember> _
		Public ProductName As String

		<Nullable, DataMember> _
		Public QuantityPerUnit As String

		<Nullable, DataMember> _
		Public UnitsInStock As Short?

		<DataMember> _
		Public Discontinued As Boolean
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Quarterly Orders")> _
	Public Partial Class QuarterlyOrders
		Inherits EntityBase(Of QuarterlyOrders)

		<Nullable, DataMember> _
		Public CustomerID As String

		<Nullable, DataMember> _
		Public CompanyName As String

		<Nullable, DataMember> _
		Public City As String

		<Nullable, DataMember> _
		Public Country As String
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Region")> _
	Public Partial Class Region
		Inherits EntityBase(Of Region)

		<MapField("RegionID"), PrimaryKey(1), DataMember> _
		Public ID As Integer

		<DataMember> _
		Public RegionDescription As String

		' FK_Territories_Region_BackReference
		<Association(ThisKey:="ID", OtherKey:="RegionID")> _
		Public Territoriess As IEnumerable(Of Territories)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Sales by Category")> _
	Public Partial Class SalesByCategory
		Inherits EntityBase(Of SalesByCategory)

		<DataMember> _
		Public CategoryID As Integer

		<DataMember> _
		Public CategoryName As String

		<DataMember> _
		Public ProductName As String

		<Nullable, DataMember> _
		Public ProductSales As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Sales Totals by Amount")> _
	Public Partial Class SalesTotalsByAmount
		Inherits EntityBase(Of SalesTotalsByAmount)

		<Nullable, DataMember> _
		Public SaleAmount As Decimal?

		<DataMember> _
		Public OrderID As Integer

		<DataMember> _
		Public CompanyName As String

		<Nullable, DataMember> _
		Public ShippedDate As DateTime?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Shippers")> _
	Public Partial Class Shippers
		Inherits EntityBase(Of Shippers)

		<Identity, PrimaryKey(1), DataMember> _
		Public ShipperID As Integer

		<DataMember> _
		Public CompanyName As String

		<Nullable, DataMember> _
		Public Phone As String

		' FK_Orders_Shippers_BackReference
		<Association(ThisKey:="ShipperID", OtherKey:="ShipVia")> _
		Public Orderss As IEnumerable(Of Orders)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Summary of Sales by Quarter")> _
	Public Partial Class SummaryOfSalesByQuarter
		Inherits EntityBase(Of SummaryOfSalesByQuarter)

		<Nullable, DataMember> _
		Public ShippedDate As DateTime?

		<DataMember> _
		Public OrderID As Integer

		<Nullable, DataMember> _
		Public Subtotal As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Summary of Sales by Year")> _
	Public Partial Class SummaryOfSalesByYear
		Inherits EntityBase(Of SummaryOfSalesByYear)

		<Nullable, DataMember> _
		Public ShippedDate As DateTime?

		<DataMember> _
		Public OrderID As Integer

		<Nullable, DataMember> _
		Public Subtotal As Decimal?
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Suppliers")> _
	Public Partial Class Suppliers
		Inherits EntityBase(Of Suppliers)

		<Identity, PrimaryKey(1), DataMember> _
		Public SupplierID As Integer

		<DataMember> _
		Public CompanyName As String

		<Nullable, DataMember> _
		Public ContactName As String

		<Nullable, DataMember> _
		Public ContactTitle As String

		<Nullable, DataMember> _
		Public Address As String

		<Nullable, DataMember> _
		Public City As String

		<Nullable, DataMember> _
		Public Region As String

		<Nullable, DataMember> _
		Public PostalCode As String

		<Nullable, DataMember> _
		Public Country As String

		<Nullable, DataMember> _
		Public Phone As String

		<Nullable, DataMember> _
		Public Fax As String

		<Nullable, DataMember> _
		Public HomePage As String

		' FK_Products_Suppliers_BackReference
		<Association(ThisKey:="SupplierID", OtherKey:="SupplierID")> _
		Public Productss As IEnumerable(Of Products)
	End Class

	<Serializable, DataContract> _
	<TableName(Name:="Territories")> _
	Public Partial Class Territories
		Inherits EntityBase(Of Territories)

		<PrimaryKey(1), DataMember> _
		Public TerritoryID As String

		<DataMember> _
		Public TerritoryDescription As String

		<DataMember> _
		Public RegionID As Integer

		' FK_Territories_Region
		<Association(ThisKey:="RegionID", OtherKey:="ID")> _
		Public Region As IEnumerable(Of Region)

		' FK_EmployeeTerritories_Territories_BackReference
		<Association(ThisKey:="TerritoryID", OtherKey:="TerritoryID")> _
		Public EmployeeTerritoriess As IEnumerable(Of EmployeeTerritories)
	End Class

End Namespace
