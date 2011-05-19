//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PPAlert SupportByLibrary "PowerPoint", 9
	///</summary>
	[SupportByLibrary("PowerPoint", 9)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PPAlert : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPAlert(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPAlert(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPAlert(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPAlert()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
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
		/// SupportByLibrary 9 
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public Int32 PressedButton
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PressedButton", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public string OnButton
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnButton", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnButton", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		/// <param name="Title">string Title</param>
		/// <param name="Type">Int32 Type</param>
		/// <param name="Text">string Text</param>
		/// <param name="leftBtn">string leftBtn</param>
		/// <param name="middleBtn">string middleBtn</param>
		/// <param name="rightBtn">string rightBtn</param>
		[SupportByLibrary("PowerPoint", 9)]
		public void Run(string title, Int32 type, string text, string leftBtn, string middleBtn, string rightBtn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(title, type, text, leftBtn, middleBtn, rightBtn);
			Invoker.Method(this, "Run", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}