//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// Interface IOfflineInfo SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IOfflineInfo : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOfflineInfo(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOfflineInfo(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOfflineInfo(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOfflineInfo()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pwzUrl">string pwzUrl</param>
		/// <param name="pwzServerFilter">string pwzServerFilter</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 PutServerFilter(string pwzUrl, string pwzServerFilter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pwzUrl, pwzServerFilter);
			object returnItem = Invoker.MethodReturn(this, "PutServerFilter", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pwzUrl">string pwzUrl</param>
		/// <param name="pwzServerFilter">string pwzServerFilter</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 GetServerFilter(string pwzUrl, string pwzServerFilter)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pwzUrl, pwzServerFilter);
			object returnItem = Invoker.MethodReturn(this, "GetServerFilter", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pwzUrl">string pwzUrl</param>
		/// <param name="pfSubscribed">Int32 pfSubscribed</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 GetIsPageSubscribed(string pwzUrl, Int32 pfSubscribed)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pwzUrl, pfSubscribed);
			object returnItem = Invoker.MethodReturn(this, "GetIsPageSubscribed", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="pbstrPath">string pbstrPath</param>
		[SupportByLibrary("OWC10", 1)]
		public Int32 GetOfflineXMLFileLocation(string pbstrPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pbstrPath);
			object returnItem = Invoker.MethodReturn(this, "GetOfflineXMLFileLocation", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}