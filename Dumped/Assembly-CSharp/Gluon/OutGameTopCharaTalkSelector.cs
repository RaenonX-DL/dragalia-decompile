/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameTopCharaTalkSelector : MonoBehaviour
	{
		// Fields
		protected List<TalkData> specialList;
		protected List<TalkData> highList;
		protected List<TalkData> lowList;
		protected Dictionary<int, TalkData> allList;
		protected int maxLastPlayedHighCount;
		protected int maxLastPlayedLowCount;
		protected Queue<int> lastPlayedQueue;
	
		// Nested types
		public enum Priority
		{
			None = 0,
			High = 1,
			Low = 2
		}
	
		public enum Category0
		{
			Growth = 1,
			Fort = 2,
			Shop = 3,
			Record = 4,
			Mypage = 5
		}
	
		public class TalkData
		{
			// Fields
			public int id;
			public int category1;
			public string text;
			public Priority priority;
			public string voiceId;
	
			// Constructors
			public TalkData(int id, string text, Priority priority, string voiceId);
		}
	
		// Constructors
		public OutGameTopCharaTalkSelector();
	
		// Methods
		public virtual void Awake();
		public TalkData SelectTalk();
		protected void AddTalkData(int id, string text, Priority priority, string voiceId);
		protected void ShuffleSpecialList();
		protected void ShuffleLowList();
		protected void ShuffleHighList();
		protected void LeftSpecialOne();
		protected void ShuffleList(ref List<TalkData> list);
		protected virtual TalkData SelectFromSpecialList();
		protected virtual TalkData SelectFromHighList();
		protected virtual TalkData SelectFromLowList();
		protected TalkData SelectFromList(List<TalkData> list, int maxLastPlayedCount);
		public static MenuTalkGroupElement GetActiveMenuTalkGroupId(Category0 category);
	}
}
