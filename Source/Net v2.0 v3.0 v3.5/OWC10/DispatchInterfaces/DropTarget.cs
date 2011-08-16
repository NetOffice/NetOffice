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
	/// DispatchInterface DropTarget SupportByLibrary OWC10, 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DropTarget : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DropTarget);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DropTarget(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DropTarget(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DropTarget(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DropTarget() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DropTarget(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="KeyState">Int32 KeyState</param>
		/// <param name="Effect">Int32 Effect</param>
		/// <param name="Object">object Object</param>
		[SupportByLibrary("OWC10", 1)]
		public void DragEnter(Int32 x, Int32 y, Int32 keyState, Int32 effect, object _object)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, keyState, effect, _object);
			Invoker.Method(this, "DragEnter", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="KeyState">Int32 KeyState</param>
		/// <param name="Effect">Int32 Effect</param>
		[SupportByLibrary("OWC10", 1)]
		public void DragOver(Int32 x, Int32 y, Int32 keyState, Int32 effect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, keyState, effect);
			Invoker.Method(this, "DragOver", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void DragLeave()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DragLeave", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="KeyState">Int32 KeyState</param>
		/// <param name="Effect">Int32 Effect</param>
		[SupportByLibrary("OWC10", 1)]
		public void Drop(Int32 x, Int32 y, Int32 keyState, Int32 effect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, keyState, effect);
			Invoker.Method(this, "Drop", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}