/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlatinumImageSetting : MonoBehaviour
	{
		// Fields
		public GameObject singleImageViewObject;
		public GameObject charaMoveupObject;
		public GameObject platinumComment;
		public UnityEngine.UI.Text platinumText;
		public SummonButton platinumButton;
		public Image topBannerImage;
		public GameObject[] typeMarkList;
		public GameObject[] charaBGList;
		public FlashPlayerManager flashPlayerManager;
		public GameObject drawnMask;
		public UnityEngine.UI.Text scheduleText;
		public UnityEngine.UI.Text remainCountText;
		public GameObject remainCountBalloon;
		public GameObject[] periodType;
		public UnityEngine.UI.Text platinumTextDouble;
		[SerializeField]
		private Image topActivePeriodImage;
		[SerializeField]
		private UnityEngine.UI.Text topActivePeriodText;
		[Header]
		[SerializeField]
		public Button switchSummonButton;
		public Sprite[] switchSummonButtonImages;
		public Action onSwitchSummon;
		private const float charaMoveupRate = 0.625f;
		private int summonId;
		private readonly string[] flashPaths;
		private readonly string[] flashEventPath;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayKira_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlatinumImageSetting __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayKira_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PlatinumImageSetting();
	
		// Methods
		public void Setup(int index, float canvasHeight, SummonTopItemData data);
		[IteratorStateMachine]
		private IEnumerator PlayKira();
		private string GenerateScheduleText(int summonGroupId, int summonId);
		private string GenerateScheduleText(int summonId);
		private string GenerateCommentText(int summonGroupId);
		public void OnSwitchSummonPressed();
	}
}
