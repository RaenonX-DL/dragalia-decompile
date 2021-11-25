using Gluon.Event;

namespace Gluon
{
	public class PhotonStatistics
	{
		private struct MeasureSectionData
		{
			public long beginTick;

			public long lastBytesIn;

			public long lastBytesOut;

			public int maxQueuedIncommingCommands;

			public int maxQueuedOutgoingCommands;
		}

		private PhotonClient _client;

		private bool _isMeasuring;

		private float _nextSendEventTimer;

		private static readonly float SendEventInterval;

		private Statistics _tempSendEvent;

		private MeasureSectionData _measureSectionData;

		public PhotonStatistics(PhotonClient client)
		{
		}

		public void Clear()
		{
		}

		public void Begin()
		{
		}

		public void End()
		{
		}

		public bool IsMeasuring()
		{
			return default(bool);
		}

		public void Update()
		{
		}

		private void SendEvent()
		{
		}

		private void UpdateMeasure()
		{
		}

		private void BeginNewMeasure()
		{
		}

		private long GetCurrentTick()
		{
			return default(long);
		}
	}
}
