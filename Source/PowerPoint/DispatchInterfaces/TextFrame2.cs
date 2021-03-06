using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface TextFrame2 
	/// SupportByVersion PowerPoint, 12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745938.aspx
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TextFrame2 : COMObject
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
                    _type = typeof(TextFrame2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public TextFrame2(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextFrame2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextFrame2(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextFrame2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextFrame2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextFrame2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TextFrame2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745455.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public object Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746553.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746188.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
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
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746697.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public Single MarginBottom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarginBottom", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarginBottom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746466.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public Single MarginLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarginLeft", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarginLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746260.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public Single MarginRight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarginRight", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarginRight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744717.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public Single MarginTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarginTop", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarginTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745236.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoTextOrientation Orientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Orientation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTextOrientation)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Orientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744106.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoHorizontalAnchor HorizontalAnchor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalAnchor", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoHorizontalAnchor)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HorizontalAnchor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746484.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoVerticalAnchor VerticalAnchor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VerticalAnchor", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoVerticalAnchor)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VerticalAnchor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744719.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPathFormat PathFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PathFormat", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPathFormat)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PathFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744141.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoWarpFormat WarpFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WarpFormat", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoWarpFormat)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WarpFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745351.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoPresetTextEffect WordArtFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WordArtFormat", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoPresetTextEffect)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WordArtFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746152.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoTriState WordWrap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WordWrap", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WordWrap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744773.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoAutoSize AutoSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoSize", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoAutoSize)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744121.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.PowerPointApi.ThreeDFormat ThreeD
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThreeD", paramsArray);
				NetOffice.PowerPointApi.ThreeDFormat newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ThreeDFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ThreeDFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744869.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasText", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744292.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.TextRange2 TextRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextRange", paramsArray);
				NetOffice.OfficeApi.TextRange2 newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextRange2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextRange2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746348.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.TextColumn2 Column
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Column", paramsArray);
				NetOffice.OfficeApi.TextColumn2 newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.TextColumn2.LateBindingApiWrapperType) as NetOffice.OfficeApi.TextColumn2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744383.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public NetOffice.OfficeApi.Ruler2 Ruler
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Ruler", paramsArray);
				NetOffice.OfficeApi.Ruler2 newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.Ruler2.LateBindingApiWrapperType) as NetOffice.OfficeApi.Ruler2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff746350.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15)]
		public NetOffice.OfficeApi.Enums.MsoTriState NoTextRotation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NoTextRotation", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NoTextRotation", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff744756.aspx
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 12,14,15)]
		public void DeleteText()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DeleteText", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}