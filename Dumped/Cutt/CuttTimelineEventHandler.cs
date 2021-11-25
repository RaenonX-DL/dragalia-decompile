using System.Runtime.InteropServices;

namespace Cutt
{
	[StructLayout(3, Size = 8)]
	public delegate void CuttTimelineEventHandler(CuttTimelineKeyEventData.EventData eventData);
}
