/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NotifyDungeonObject
	{
		// Fields
		private static int numNotice;
		private NotifyDelegate[] notifyDelegates;
	
		// Nested types
		public enum NoticeType
		{
			TargetObject = 0,
			Death = 1
		}
	
		public delegate void NotifyDelegate(DungeonObjectBase sender, NoticeType notice, object param);
	
		// Constructors
		public NotifyDungeonObject();
		static NotifyDungeonObject();
	
		// Methods
		private static int GetNoticeNum();
		public void Attach(NoticeType notice, NotifyDelegate func);
		public void Detach(NoticeType notice, NotifyDelegate func);
		public void Detach(NotifyDelegate func);
		public void Detach();
		public void Notify(DungeonObjectBase sender, NoticeType notice, object param = null);
	}
}
