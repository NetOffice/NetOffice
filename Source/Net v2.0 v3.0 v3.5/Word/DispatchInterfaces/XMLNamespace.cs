//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface XMLNamespace SupportByLibrary Word, 11,12,14
	///</summary>
	[SupportByLibrary("Word", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XMLNamespace : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(XMLNamespace);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
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
		/// SupportByLibrary Word 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public string URI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "URI", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set Property
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("Word", 11,12,14)]
		public string get_Location(bool allUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set Property
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("Word", 11,12,14)]
		public void set_Location(bool allUsers, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "Location", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set Property
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("Word", 11,12,14)]
		public string get_Alias(bool allUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "Alias", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set Property
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("Word", 11,12,14)]
		public void set_Alias(bool allUsers, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "Alias", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public NetOffice.WordApi.XSLTransforms XSLTransforms
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XSLTransforms", paramsArray);
				NetOffice.WordApi.XSLTransforms newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XSLTransforms.LateBindingApiWrapperType) as NetOffice.WordApi.XSLTransforms;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set Property
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("Word", 11,12,14)]
		public NetOffice.WordApi.XSLTransform get_DefaultTransform(bool allUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "DefaultTransform", paramsArray);
			NetOffice.WordApi.XSLTransform newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XSLTransform.LateBindingApiWrapperType) as NetOffice.WordApi.XSLTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set Property
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("Word", 11,12,14)]
		public void set_DefaultTransform(bool allUsers, NetOffice.WordApi.XSLTransform value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "DefaultTransform", paramsArray, value);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		/// <param name="Document">object Document</param>
		[SupportByLibrary("Word", 11,12,14)]
		public void AttachToDocument(object document)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(document);
			Invoker.Method(this, "AttachToDocument", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}