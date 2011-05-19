//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface IAddinClient SupportByLibrary "OWC10", 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IAddinClient : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAddinClient(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAddinClient(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAddinClient(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAddinClient()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		/// <param name="vardisp">ref object vardisp</param>
		[SupportByLibrary("OWC10", 1)]
		public void GrantAddinHost(ref object vardisp)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(vardisp);
			Invoker.Method(this, "GrantAddinHost", paramsArray, modifiers);
			vardisp = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void RemoveAddinHost()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveAddinHost", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		/// <param name="SemiCalced">ref bool SemiCalced</param>
		[SupportByLibrary("OWC10", 1)]
		public void IsSemiCalced(Int32 dispid, ref bool semiCalced)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(dispid, semiCalced);
			Invoker.Method(this, "IsSemiCalced", paramsArray, modifiers);
			semiCalced = (bool)paramsArray[1];
		}

		#endregion
		#pragma warning restore
	}
}