/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HeaderMissionMessage : HeaderMessageBase<Gluon.MissionNoticeData>
	{
		// Fields
		public Image ribbonLeft;
		public Image ribbonRight;
		public Image missionStamp;
		public Image drillMissionStamp;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<MissionNoticeData> __9__5_0;
			public static Comparison<MissionNoticeData> __9__5_1;
			public static Comparison<MissionNoticeData> __9__5_2;
			public static Comparison<MissionNoticeData> __9__5_3;
			public static Comparison<MissionNoticeData> __9__5_4;
			public static Comparison<MissionNoticeData> __9__5_5;
			public static Comparison<MissionNoticeData> __9__5_6;
			public static Comparison<MissionNoticeData> __9__5_7;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _AddMessage_b__5_0(MissionNoticeData a, MissionNoticeData b);
			internal int _AddMessage_b__5_1(MissionNoticeData a, MissionNoticeData b);
			internal int _AddMessage_b__5_2(MissionNoticeData a, MissionNoticeData b);
			internal int _AddMessage_b__5_3(MissionNoticeData a, MissionNoticeData b);
			internal int _AddMessage_b__5_4(MissionNoticeData a, MissionNoticeData b);
			internal int _AddMessage_b__5_5(MissionNoticeData a, MissionNoticeData b);
			internal int _AddMessage_b__5_6(MissionNoticeData a, MissionNoticeData b);
			internal int _AddMessage_b__5_7(MissionNoticeData a, MissionNoticeData b);
		}
	
		// Constructors
		public HeaderMissionMessage();
	
		// Methods
		public static void UpdateData();
		private static void AddMessage(MissionNotice mission_notice);
		protected override bool isShowOtherNotice();
		protected override void UpdateMessageUI(MissionNoticeData messageData);
	}
}
