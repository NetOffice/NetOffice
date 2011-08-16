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
	/// DispatchInterface Envelope SupportByLibrary Word, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Envelope : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Envelope);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Envelope(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range ReturnAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddress", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool DefaultPrintBarCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultPrintBarCode", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultPrintBarCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool DefaultPrintFIMA
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultPrintFIMA", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultPrintFIMA", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single DefaultHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultHeight", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single DefaultWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultWidth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public string DefaultSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultSize", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool DefaultOmitReturnAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultOmitReturnAddress", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultOmitReturnAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdPaperTray FeedSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FeedSource", paramsArray);
				return (NetOffice.WordApi.Enums.WdPaperTray)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FeedSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single AddressFromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressFromLeft", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AddressFromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single AddressFromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressFromTop", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AddressFromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single ReturnAddressFromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddressFromLeft", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReturnAddressFromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single ReturnAddressFromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddressFromTop", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReturnAddressFromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Style AddressStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressStyle", paramsArray);
				NetOffice.WordApi.Style newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Style.LateBindingApiWrapperType) as NetOffice.WordApi.Style;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Style ReturnAddressStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReturnAddressStyle", paramsArray);
				NetOffice.WordApi.Style newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Style.LateBindingApiWrapperType) as NetOffice.WordApi.Style;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdEnvelopeOrientation DefaultOrientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultOrientation", paramsArray);
				return (NetOffice.WordApi.Enums.WdEnvelopeOrientation)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultOrientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool DefaultFaceUp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultFaceUp", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultFaceUp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool Vertical
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Vertical", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Vertical", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single RecipientNamefromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientNamefromLeft", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientNamefromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single RecipientNamefromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientNamefromTop", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientNamefromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single RecipientPostalfromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientPostalfromLeft", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientPostalfromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single RecipientPostalfromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecipientPostalfromTop", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RecipientPostalfromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single SenderNamefromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderNamefromLeft", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderNamefromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single SenderNamefromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderNamefromTop", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderNamefromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single SenderPostalfromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderPostalfromLeft", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderPostalfromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set Property
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single SenderPostalfromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SenderPostalfromTop", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SenderPostalfromTop", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9
		/// </summary>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="OmitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="ReturnAddress">optional object ReturnAddress</param>
		/// <param name="ReturnAutoText">optional object ReturnAutoText</param>
		/// <param name="PrintBarCode">optional object PrintBarCode</param>
		/// <param name="PrintFIMA">optional object PrintFIMA</param>
		/// <param name="Size">optional object Size</param>
		/// <param name="Height">optional object Height</param>
		/// <param name="Width">optional object Width</param>
		/// <param name="FeedSource">optional object FeedSource</param>
		/// <param name="AddressFromLeft">optional object AddressFromLeft</param>
		/// <param name="AddressFromTop">optional object AddressFromTop</param>
		/// <param name="ReturnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="ReturnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="DefaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="DefaultOrientation">optional object DefaultOrientation</param>
		[SupportByLibrary("Word", 9)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="OmitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="ReturnAddress">optional object ReturnAddress</param>
		/// <param name="ReturnAutoText">optional object ReturnAutoText</param>
		/// <param name="PrintBarCode">optional object PrintBarCode</param>
		/// <param name="PrintFIMA">optional object PrintFIMA</param>
		/// <param name="Size">optional object Size</param>
		/// <param name="Height">optional object Height</param>
		/// <param name="Width">optional object Width</param>
		/// <param name="FeedSource">optional object FeedSource</param>
		/// <param name="AddressFromLeft">optional object AddressFromLeft</param>
		/// <param name="AddressFromTop">optional object AddressFromTop</param>
		/// <param name="ReturnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="ReturnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="DefaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="DefaultOrientation">optional object DefaultOrientation</param>
		/// <param name="PrintEPostage">optional object PrintEPostage</param>
		/// <param name="Vertical">optional object Vertical</param>
		/// <param name="RecipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="RecipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="RecipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="RecipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="SenderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="SenderNamefromTop">optional object SenderNamefromTop</param>
		/// <param name="SenderPostalfromLeft">optional object SenderPostalfromLeft</param>
		/// <param name="SenderPostalfromTop">optional object SenderPostalfromTop</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void Insert(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop, object senderPostalfromLeft, object senderPostalfromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop, senderPostalfromLeft, senderPostalfromTop);
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Insert()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Insert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9
		/// </summary>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="OmitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="ReturnAddress">optional object ReturnAddress</param>
		/// <param name="ReturnAutoText">optional object ReturnAutoText</param>
		/// <param name="PrintBarCode">optional object PrintBarCode</param>
		/// <param name="PrintFIMA">optional object PrintFIMA</param>
		/// <param name="Size">optional object Size</param>
		/// <param name="Height">optional object Height</param>
		/// <param name="Width">optional object Width</param>
		/// <param name="FeedSource">optional object FeedSource</param>
		/// <param name="AddressFromLeft">optional object AddressFromLeft</param>
		/// <param name="AddressFromTop">optional object AddressFromTop</param>
		/// <param name="ReturnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="ReturnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="DefaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="DefaultOrientation">optional object DefaultOrientation</param>
		[SupportByLibrary("Word", 9)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="OmitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="ReturnAddress">optional object ReturnAddress</param>
		/// <param name="ReturnAutoText">optional object ReturnAutoText</param>
		/// <param name="PrintBarCode">optional object PrintBarCode</param>
		/// <param name="PrintFIMA">optional object PrintFIMA</param>
		/// <param name="Size">optional object Size</param>
		/// <param name="Height">optional object Height</param>
		/// <param name="Width">optional object Width</param>
		/// <param name="FeedSource">optional object FeedSource</param>
		/// <param name="AddressFromLeft">optional object AddressFromLeft</param>
		/// <param name="AddressFromTop">optional object AddressFromTop</param>
		/// <param name="ReturnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="ReturnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="DefaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="DefaultOrientation">optional object DefaultOrientation</param>
		/// <param name="PrintEPostage">optional object PrintEPostage</param>
		/// <param name="Vertical">optional object Vertical</param>
		/// <param name="RecipientNamefromLeft">optional object RecipientNamefromLeft</param>
		/// <param name="RecipientNamefromTop">optional object RecipientNamefromTop</param>
		/// <param name="RecipientPostalfromLeft">optional object RecipientPostalfromLeft</param>
		/// <param name="RecipientPostalfromTop">optional object RecipientPostalfromTop</param>
		/// <param name="SenderNamefromLeft">optional object SenderNamefromLeft</param>
		/// <param name="SenderNamefromTop">optional object SenderNamefromTop</param>
		/// <param name="SenderPostalfromLeft">optional object SenderPostalfromLeft</param>
		/// <param name="SenderPostalfromTop">optional object SenderPostalfromTop</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void PrintOut(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation, object printEPostage, object vertical, object recipientNamefromLeft, object recipientNamefromTop, object recipientPostalfromLeft, object recipientPostalfromTop, object senderNamefromLeft, object senderNamefromTop, object senderPostalfromLeft, object senderPostalfromTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation, printEPostage, vertical, recipientNamefromLeft, recipientNamefromTop, recipientPostalfromLeft, recipientPostalfromTop, senderNamefromLeft, senderNamefromTop, senderPostalfromLeft, senderPostalfromTop);
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void UpdateDocument()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateDocument", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="OmitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="ReturnAddress">optional object ReturnAddress</param>
		/// <param name="ReturnAutoText">optional object ReturnAutoText</param>
		/// <param name="PrintBarCode">optional object PrintBarCode</param>
		/// <param name="PrintFIMA">optional object PrintFIMA</param>
		/// <param name="Size">optional object Size</param>
		/// <param name="Height">optional object Height</param>
		/// <param name="Width">optional object Width</param>
		/// <param name="FeedSource">optional object FeedSource</param>
		/// <param name="AddressFromLeft">optional object AddressFromLeft</param>
		/// <param name="AddressFromTop">optional object AddressFromTop</param>
		/// <param name="ReturnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="ReturnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="DefaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="DefaultOrientation">optional object DefaultOrientation</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void Insert2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void Insert2000()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Insert2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		/// <param name="ExtractAddress">optional object ExtractAddress</param>
		/// <param name="Address">optional object Address</param>
		/// <param name="AutoText">optional object AutoText</param>
		/// <param name="OmitReturnAddress">optional object OmitReturnAddress</param>
		/// <param name="ReturnAddress">optional object ReturnAddress</param>
		/// <param name="ReturnAutoText">optional object ReturnAutoText</param>
		/// <param name="PrintBarCode">optional object PrintBarCode</param>
		/// <param name="PrintFIMA">optional object PrintFIMA</param>
		/// <param name="Size">optional object Size</param>
		/// <param name="Height">optional object Height</param>
		/// <param name="Width">optional object Width</param>
		/// <param name="FeedSource">optional object FeedSource</param>
		/// <param name="AddressFromLeft">optional object AddressFromLeft</param>
		/// <param name="AddressFromTop">optional object AddressFromTop</param>
		/// <param name="ReturnAddressFromLeft">optional object ReturnAddressFromLeft</param>
		/// <param name="ReturnAddressFromTop">optional object ReturnAddressFromTop</param>
		/// <param name="DefaultFaceUp">optional object DefaultFaceUp</param>
		/// <param name="DefaultOrientation">optional object DefaultOrientation</param>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void PrintOut2000(object extractAddress, object address, object autoText, object omitReturnAddress, object returnAddress, object returnAutoText, object printBarCode, object printFIMA, object size, object height, object width, object feedSource, object addressFromLeft, object addressFromTop, object returnAddressFromLeft, object returnAddressFromTop, object defaultFaceUp, object defaultOrientation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extractAddress, address, autoText, omitReturnAddress, returnAddress, returnAutoText, printBarCode, printFIMA, size, height, width, feedSource, addressFromLeft, addressFromTop, returnAddressFromLeft, returnAddressFromTop, defaultFaceUp, defaultOrientation);
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void PrintOut2000()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public void Options()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Options", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}