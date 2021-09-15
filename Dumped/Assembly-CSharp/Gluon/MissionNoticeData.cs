/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionNoticeData : MessageDataBase
	{
		// Fields
		public MissionNoticeType type;
		public int id;
		public int sortId;
	
		// Constructors
		public MissionNoticeData(MissionDrillDataElement element, int missionId);
		public MissionNoticeData(MissionBeginnerDataElement element, int missionId);
		public MissionNoticeData(MissionPeriodDataElement element, int missionId);
		public MissionNoticeData(MissionDailyDataElement element, int missionId);
		public MissionNoticeData(MissionNormalDataElement element, int missionId);
		public MissionNoticeData(MissionMainStoryDataElement element, int missionId);
		public MissionNoticeData(MissionMemoryEventDataElement element, int missionId);
		public MissionNoticeData(MissionAlbumDataElement element, int missionId);
		public MissionNoticeData(MissionSpecialDataElement element, int missionId);
	
		// Methods
		private void Init(MissionNoticeType type, int id, int sortId);
		public override void ReloadText();
	}
}
