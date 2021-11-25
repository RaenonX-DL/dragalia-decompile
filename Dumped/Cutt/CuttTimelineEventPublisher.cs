using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cutt
{
	public class CuttTimelineEventPublisher
	{
		private class EventWrapper
		{
			public CuttTimelineEventID id;

			public event CuttTimelineEventHandler handler
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public EventWrapper(CuttTimelineEventID id_)
			{
			}

			public void fire(CuttTimelineKeyEventData.EventData data)
			{
			}
		}

		public interface IParamGenerator
		{
			CuttEventParamBase ToObject(string json);

			CuttEventParamBase Create();
		}

		public class ParamGenerator<TypeParam> : IParamGenerator where TypeParam : CuttEventParamBase, new()
		{
			public CuttEventParamBase ToObject(string json)
			{
				return null;
			}

			public CuttEventParamBase Create()
			{
				return null;
			}
		}

		public static Dictionary<CuttTimelineEventID, IParamGenerator> paramGeneratorDict;

		private Dictionary<CuttTimelineEventID, EventWrapper> eventDict;

		public void BeginPublish()
		{
		}

		public void EndPublish()
		{
		}

		public void Subscribe(CuttTimelineEventID id, CuttTimelineEventHandler handler)
		{
		}

		public void Unsubscribe(CuttTimelineEventID id, CuttTimelineEventHandler handler)
		{
		}

		public void FireEvent(CuttTimelineKeyEventData eventData)
		{
		}

		static CuttTimelineEventPublisher()
		{
		}

		private EventWrapper GetEvent(CuttTimelineEventID id)
		{
			return null;
		}
	}
}
