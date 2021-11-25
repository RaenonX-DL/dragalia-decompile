using System;

namespace Cutt
{
	[Serializable]
	public abstract class CuttTimelineKey
	{
		public int frame;

		public CuttTimelineKeyAttribute attribute;

		public abstract CuttTimelineKeyDataType dataType { get; }

		public virtual bool IsInterpolateKey()
		{
			return default(bool);
		}

		public virtual void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
