//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface UserProperties SupportByLibrary Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class UserProperties : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(UserProperties);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public UserProperties(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public UserProperties(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public UserProperties(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public UserProperties() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public UserProperties(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi.UserProperty this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi.UserProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.UserProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.UserProperty;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.OutlookApi.Enums.OlUserPropertyType Type</param>
		/// <param name="AddToFolderFields">optional object AddToFolderFields</param>
		/// <param name="DisplayFormat">optional object DisplayFormat</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.UserProperty Add(string name, NetOffice.OutlookApi.Enums.OlUserPropertyType type, object addToFolderFields, object displayFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, addToFolderFields, displayFormat);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.UserProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.UserProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.UserProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.OutlookApi.Enums.OlUserPropertyType Type</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.UserProperty Add(string name, NetOffice.OutlookApi.Enums.OlUserPropertyType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.UserProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.UserProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.UserProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Custom">optional object Custom</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.UserProperty Find(string name, object custom)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, custom);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.OutlookApi.UserProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.UserProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.UserProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.UserProperty Find(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.OutlookApi.UserProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.UserProperty.LateBindingApiWrapperType) as NetOffice.OutlookApi.UserProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Remove(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}