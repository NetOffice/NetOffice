using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdPageColor
	{
		 /// <summary>
		 /// SupportByVersion Word 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Word", 15)]
		 wdPageColorNone = 0,

		 /// <summary>
		 /// SupportByVersion Word 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Word", 15)]
		 wdPageColorSepia = 1,

		 /// <summary>
		 /// SupportByVersion Word 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Word", 15)]
		 wdPageColorInverse = 2
	}
}