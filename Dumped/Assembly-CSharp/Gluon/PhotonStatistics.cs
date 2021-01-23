/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonStatistics
	{
		// Fields
		private PhotonClient _client;
		private bool _isMeasuring;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private Statistics _tempSendEvent;
		private MeasureSectionData _measureSectionData;
	
		// Nested types
		private struct MeasureSectionData
		{
			// Fields
			public long beginTick;
			public long lastBytesIn;
			public long lastBytesOut;
			public int maxQueuedIncommingCommands;
			public int maxQueuedOutgoingCommands;
		}
	
		// Constructors
		public PhotonStatistics(PhotonClient client);
		static PhotonStatistics();
	
		// Methods
		public void Clear();
		public void Begin();
		public void End();
		public bool IsMeasuring();
		public void Update();
		private void SendEvent();
		private void UpdateMeasure();
		private void BeginNewMeasure();
		private long GetCurrentTick();
	}
}
