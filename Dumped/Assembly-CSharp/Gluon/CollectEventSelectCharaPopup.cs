/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CollectEventSelectCharaPopup : PopupBase
	{
		// Fields
		public TabBase tabController;
		public Transform unreadContent;
		public Transform allContent;
		public CollectEventSelectCharaPopupCell cellTemplate;
		[SerializeField]
		private UnityEngine.UI.Text releaseItemCountText;
		[SerializeField]
		private Image releaseItemImgage;
		[SerializeField]
		private UnityEngine.UI.Text completeText;
		private int eventId;
		public const string prefabPath = "Prefabs/OutGame/EventQuest/CollectEventSelectCharaPopup";
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<EventStoryElement, string> __9__10_0;
			public static Func<EventStoryElement, int> __9__10_1;
			public static Func<EventStoryElement, int> __9__10_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _Start_b__10_0(EventStoryElement x);
			internal int _Start_b__10_1(EventStoryElement x);
			internal int _Start_b__10_2(EventStoryElement x);
		}
	
		// Constructors
		public CollectEventSelectCharaPopup();
	
		// Methods
		public static CollectEventSelectCharaPopup Create(int eventId);
		protected override void Start();
		public void OnSelectedTypeTab(int index);
	}
}
