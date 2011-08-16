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
	/// DispatchInterface Field20 SupportByLibrary ADODB, 2.5
	///</summary>
	[SupportByLibrary("ADODB", 2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Field20 : _ADO
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Field20);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Field20(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Field20(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Field20(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Field20() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Field20(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public Int32 ActualSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActualSize", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public Int32 Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Attributes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public Int32 DefinedSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefinedSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefinedSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public NetOffice.ADODBApi.Enums.DataTypeEnum Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.ADODBApi.Enums.DataTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public byte Precision
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Precision", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Precision", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public byte NumericScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumericScale", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumericScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public object OriginalValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OriginalValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public object UnderlyingValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UnderlyingValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public COMObject DataFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataFormat", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataFormat", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Data">object Data</param>
		[SupportByLibrary("ADODB", 2.5)]
		public void AppendChunk(object data)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(data);
			Invoker.Method(this, "AppendChunk", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.5
		/// </summary>
		/// <param name="Length">Int32 Length</param>
		[SupportByLibrary("ADODB", 2.5)]
		public object GetChunk(Int32 length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(length);
			object returnItem = Invoker.MethodReturn(this, "GetChunk", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}