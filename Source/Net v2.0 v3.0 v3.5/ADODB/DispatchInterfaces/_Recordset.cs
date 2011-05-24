//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface _Recordset SupportByLibrary ADODB, 2.1,2.5
	///</summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Recordset : Recordset21
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Recordset()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Properties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.ADODBApi.Properties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.PositionEnum AbsolutePosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AbsolutePosition", paramsArray);
				return (NetOffice.ADODBApi.Enums.PositionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AbsolutePosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public COMObject ActiveConnection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveConnection", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ActiveConnection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public bool BOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object Bookmark
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bookmark", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Bookmark", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 CacheSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CacheSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CacheSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.CursorTypeEnum CursorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CursorType", paramsArray);
				return (NetOffice.ADODBApi.Enums.CursorTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CursorType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public bool EOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.ADODBApi.Fields newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.LockTypeEnum LockType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockType", paramsArray);
				return (NetOffice.ADODBApi.Enums.LockTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 MaxRecords
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaxRecords", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaxRecords", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 RecordCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public COMObject Source
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Source", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Source", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.PositionEnum AbsolutePage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AbsolutePage", paramsArray);
				return (NetOffice.ADODBApi.Enums.PositionEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AbsolutePage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.EditModeEnum EditMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EditMode", paramsArray);
				return (NetOffice.ADODBApi.Enums.EditModeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object Filter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filter", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Filter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 PageCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 PageSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PageSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PageSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string Sort
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sort", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sort", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 Status
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Status", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.CursorLocationEnum CursorLocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CursorLocation", paramsArray);
				return (NetOffice.ADODBApi.Enums.CursorLocationEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CursorLocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object get_Collect(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Collect", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void set_Collect(object index, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.PropertySet(this, "Collect", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.MarshalOptionsEnum MarshalOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarshalOptions", paramsArray);
				return (NetOffice.ADODBApi.Enums.MarshalOptionsEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarshalOptions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1
		/// </summary>
		[SupportByLibrary("ADODB", 2.1)]
		public string Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Index", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public COMObject DataSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSource", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public COMObject ActiveCommand
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveCommand", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public bool StayInSync
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StayInSync", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StayInSync", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public string DataMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataMember", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataMember", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="FieldList">optional object FieldList</param>
		/// <param name="Values">optional object Values</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void AddNew(object fieldList, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fieldList, values);
			Invoker.Method(this, "AddNew", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void AddNew()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddNew", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void CancelUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CancelUpdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Delete(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		/// <param name="Start">optional object Start</param>
		/// <param name="Fields">optional object Fields</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object GetRows(Int32 rows, object start, object fields)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows, start, fields);
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public object GetRows(Int32 rows)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows);
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="NumRecords">Int32 NumRecords</param>
		/// <param name="Start">optional object Start</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Move(Int32 numRecords, object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRecords, start);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="NumRecords">Int32 NumRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Move(Int32 numRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRecords);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MoveNext()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveNext", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MovePrevious()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MovePrevious", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MoveFirst()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveFirst", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void MoveLast()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveLast", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Source">object Source</param>
		/// <param name="ActiveConnection">object ActiveConnection</param>
		/// <param name="CursorType">NetOffice.ADODBApi.Enums.CursorTypeEnum CursorType</param>
		/// <param name="LockType">NetOffice.ADODBApi.Enums.LockTypeEnum LockType</param>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Open(object source, object activeConnection, NetOffice.ADODBApi.Enums.CursorTypeEnum cursorType, NetOffice.ADODBApi.Enums.LockTypeEnum lockType, Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, activeConnection, cursorType, lockType, options);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Requery(Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			Invoker.Method(this, "Requery", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void _xResync(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "_xResync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Fields">optional object Fields</param>
		/// <param name="Values">optional object Values</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Update(object fields, object values)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fields, values);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset _xClone()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_xClone", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void UpdateBatch(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "UpdateBatch", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void CancelBatch(NetOffice.ADODBApi.Enums.AffectEnum affectRecords)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords);
			Invoker.Method(this, "CancelBatch", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="RecordsAffected">optional object RecordsAffected</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset NextRecordset(object recordsAffected)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recordsAffected);
			object returnItem = Invoker.MethodReturn(this, "NextRecordset", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset NextRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextRecordset", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="CursorOptions">NetOffice.ADODBApi.Enums.CursorOptionEnum CursorOptions</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public bool Supports(NetOffice.ADODBApi.Enums.CursorOptionEnum cursorOptions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cursorOptions);
			object returnItem = Invoker.MethodReturn(this, "Supports", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		/// <param name="SkipRecords">Int32 SkipRecords</param>
		/// <param name="SearchDirection">NetOffice.ADODBApi.Enums.SearchDirectionEnum SearchDirection</param>
		/// <param name="Start">optional object Start</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Find(string criteria, Int32 skipRecords, NetOffice.ADODBApi.Enums.SearchDirectionEnum searchDirection, object start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria, skipRecords, searchDirection, start);
			Invoker.Method(this, "Find", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		/// <param name="SkipRecords">Int32 SkipRecords</param>
		/// <param name="SearchDirection">NetOffice.ADODBApi.Enums.SearchDirectionEnum SearchDirection</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Find(string criteria, Int32 skipRecords, NetOffice.ADODBApi.Enums.SearchDirectionEnum searchDirection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria, skipRecords, searchDirection);
			Invoker.Method(this, "Find", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1
		/// </summary>
		/// <param name="KeyValues">object KeyValues</param>
		/// <param name="SeekOption">NetOffice.ADODBApi.Enums.SeekEnum SeekOption</param>
		[SupportByLibrary("ADODB", 2.1)]
		public void Seek(object keyValues, NetOffice.ADODBApi.Enums.SeekEnum seekOption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(keyValues, seekOption);
			Invoker.Method(this, "Seek", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="PersistFormat">NetOffice.ADODBApi.Enums.PersistFormatEnum PersistFormat</param>
		[SupportByLibrary("ADODB", 2.5)]
		public void _xSave(string fileName, NetOffice.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, persistFormat);
			Invoker.Method(this, "_xSave", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="StringFormat">NetOffice.ADODBApi.Enums.StringFormatEnum StringFormat</param>
		/// <param name="NumRows">Int32 NumRows</param>
		/// <param name="ColumnDelimeter">string ColumnDelimeter</param>
		/// <param name="RowDelimeter">string RowDelimeter</param>
		/// <param name="NullExpr">string NullExpr</param>
		[SupportByLibrary("ADODB", 2.5)]
		public string GetString(NetOffice.ADODBApi.Enums.StringFormatEnum stringFormat, Int32 numRows, string columnDelimeter, string rowDelimeter, string nullExpr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat, numRows, columnDelimeter, rowDelimeter, nullExpr);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Bookmark1">object Bookmark1</param>
		/// <param name="Bookmark2">object Bookmark2</param>
		[SupportByLibrary("ADODB", 2.5)]
		public NetOffice.ADODBApi.Enums.CompareEnum CompareBookmarks(object bookmark1, object bookmark2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bookmark1, bookmark2);
			object returnItem = Invoker.MethodReturn(this, "CompareBookmarks", paramsArray);
			return (NetOffice.ADODBApi.Enums.CompareEnum)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="LockType">NetOffice.ADODBApi.Enums.LockTypeEnum LockType</param>
		[SupportByLibrary("ADODB", 2.5)]
		public NetOffice.ADODBApi._Recordset Clone(NetOffice.ADODBApi.Enums.LockTypeEnum lockType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lockType);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="AffectRecords">NetOffice.ADODBApi.Enums.AffectEnum AffectRecords</param>
		/// <param name="ResyncValues">NetOffice.ADODBApi.Enums.ResyncEnum ResyncValues</param>
		[SupportByLibrary("ADODB", 2.5)]
		public void Resync(NetOffice.ADODBApi.Enums.AffectEnum affectRecords, NetOffice.ADODBApi.Enums.ResyncEnum resyncValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords, resyncValues);
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Destination">object Destination</param>
		/// <param name="PersistFormat">NetOffice.ADODBApi.Enums.PersistFormatEnum PersistFormat</param>
		[SupportByLibrary("ADODB", 2.5)]
		public void Save(object destination, NetOffice.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(destination, persistFormat);
			Invoker.Method(this, "Save", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}