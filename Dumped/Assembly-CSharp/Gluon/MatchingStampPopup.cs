/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingStampPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		private PageViewBase pageView;
		[SerializeField]
		private ChatIconUI[] chatIcons;
		[Header]
		[SerializeField]
		private float fadeTime;
		[SerializeField]
		private float stayTime;
		private int playerIndex;
		private UnityAction<int> onStampClicked;
		private bool isDisplayIcon;
		private const int iconPerPageCount = 8;
		private const string prefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingStampPopup";
		private const string pagePrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingStampPage";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public MatchingStampPopup popup;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public MatchingStampPopup();
	
		// Methods
		public static MatchingStampPopup Create();
		public void EnableAndShow();
		public void Initialize(int playerIndex, UnityAction<int> onStampClicked = null, bool isDisplayIcon = true);
		public void SetStampParent(Transform[] parents);
		private void OnClickIcon(int id);
		public void DisplayIcon(int playerIndex, int id, bool callbakFlag = true);
		public void SetPlayerNo(int no);
		[CompilerGenerated]
		private void _Initialize_b__12_0(GameObject go, int index);
	}
}
