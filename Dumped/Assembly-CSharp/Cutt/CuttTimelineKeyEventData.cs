/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyEventData : CuttTimelineKey
	{
		// Fields
		public List<EventData> eventList;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Nested types
		[Serializable]
		public class EventData
		{
			// Fields
			public CuttTimelineEventID eventId;
			private CuttEventParamBase eventParam;
			public string serializedParamter;
	
			// Constructors
			public EventData();
	
			// Methods
			public TypeValue GetParameter<TypeValue>()
				where TypeValue : CuttEventParamBase;
			public void OnLoad();
		}
	
		// Constructors
		public CuttTimelineKeyEventData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
