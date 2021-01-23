/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class CollectEventUtil
	{
		// Nested types
		public enum EventStoryGroupType
		{
			Normal = 1,
			UnlockByEventStory = 2,
			EventStory = 3
		}
	
		// Methods
		public static bool IsEventMenuGroupDummyQuest(QuestEventMenuElement questEventMenuElement);
		public static int GetCollectToalReleaseEventStoryCount(int eventId);
		public static QuestUtil.QuestState IsCollectEventAllReadStory(int eventId);
	}
}
