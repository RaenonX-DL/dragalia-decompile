/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineEventPublisher
	{
		// Fields
		public static Dictionary<CuttTimelineEventID, IParamGenerator> paramGeneratorDict;
		private Dictionary<CuttTimelineEventID, EventWrapper> eventDict;
	
		// Nested types
		private class EventWrapper
		{
			// Fields
			public CuttTimelineEventID id;
			[CompilerGenerated]
			private CuttTimelineEventHandler handler;
	
			// Events
			public event CuttTimelineEventHandler handler {
				add;
				remove;
			}
	
			// Constructors
			public EventWrapper(CuttTimelineEventID id_);
	
			// Methods
			public void fire(CuttTimelineKeyEventData.EventData data);
		}
	
		public interface IParamGenerator
		{
			// Methods
			CuttEventParamBase ToObject(string json);
			CuttEventParamBase Create();
		}
	
		public class ParamGenerator<TypeParam> : IParamGenerator
			where TypeParam : CuttEventParamBase, new()
		{
			// Constructors
			public ParamGenerator();
	
			// Methods
			public CuttEventParamBase ToObject(string json);
			public CuttEventParamBase Create();
		}
	
		// Constructors
		static CuttTimelineEventPublisher();
		public CuttTimelineEventPublisher();
	
		// Methods
		public void BeginPublish();
		public void EndPublish();
		public void Subscribe(CuttTimelineEventID id, CuttTimelineEventHandler handler);
		public void Unsubscribe(CuttTimelineEventID id, CuttTimelineEventHandler handler);
		public void FireEvent(CuttTimelineKeyEventData eventData);
		private EventWrapper GetEvent(CuttTimelineEventID id);
	}
}
