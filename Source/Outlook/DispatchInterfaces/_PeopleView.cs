using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _PeopleView 
	/// SupportByVersion Outlook, 15
	///</summary>
	[SupportByVersionAttribute("Outlook", 15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _PeopleView : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_PeopleView);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public _PeopleView(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PeopleView(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PeopleView(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PeopleView(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PeopleView(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PeopleView() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _PeopleView(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228406.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230583.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228591.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230405.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227687.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public string Language
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Language", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Language", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228057.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public bool LockUserChanges
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockUserChanges", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockUserChanges", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231136.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230036.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi.Enums.OlViewSaveOption SaveOption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SaveOption", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlViewSaveOption)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229062.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public bool Standard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Standard", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229669.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi.Enums.OlViewType ViewType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlViewType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228325.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "XML", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj228064.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public string Filter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filter", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Filter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229733.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi.OrderFields SortFields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SortFields", paramsArray);
				NetOffice.OutlookApi.OrderFields newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OutlookApi.OrderFields.LateBindingApiWrapperType) as NetOffice.OutlookApi.OrderFields;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227495.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public void Apply()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Apply", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231247.aspx
		/// </summary>
		/// <param name="name">string Name</param>
		/// <param name="saveOption">optional NetOffice.OutlookApi.Enums.OlViewSaveOption SaveOption</param>
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi.View Copy(string name, object saveOption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, saveOption);
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			NetOffice.OutlookApi.View newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.View.LateBindingApiWrapperType) as NetOffice.OutlookApi.View;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231247.aspx
		/// </summary>
		/// <param name="name">string Name</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 15)]
		public NetOffice.OutlookApi.View Copy(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "Copy", paramsArray);
			NetOffice.OutlookApi.View newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.View.LateBindingApiWrapperType) as NetOffice.OutlookApi.View;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj227780.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj231541.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230523.aspx
		/// </summary>
		[SupportByVersionAttribute("Outlook", 15)]
		public void Save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj230336.aspx
		/// </summary>
		/// <param name="date">DateTime Date</param>
		[SupportByVersionAttribute("Outlook", 15)]
		public void GoToDate(DateTime date)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(date);
			Invoker.Method(this, "GoToDate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}