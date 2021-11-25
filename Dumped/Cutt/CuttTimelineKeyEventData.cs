using System;
using System.Collections.Generic;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyEventData : CuttTimelineKey
	{
		[Serializable]
		public class EventData
		{
			public CuttTimelineEventID eventId;

			private CuttEventParamBase eventParam;

			public string serializedParamter;

			public TypeValue GetParameter<TypeValue>() where TypeValue : CuttEventParamBase
			{
				return null;
			}

			public void OnLoad()
			{
			}
		}

		public List<EventData> eventList;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
