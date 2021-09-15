/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExcludeImageSetting : MonoBehaviour
	{
		// Fields
		public Image singleImageViewImage;
		public SummonButton campaignButton;
		public Image campaignButtonNormalImage;
		public Image campaignButtonSelectedImage;
		public Image topBannerImage;
		public UnityEngine.UI.Text remainCountText;
		public GameObject remainCountBalloon;
		[SerializeField]
		private Image topActivePeriodImage;
		[SerializeField]
		private UnityEngine.UI.Text topActivePeriodText;
		public FlashPlayerManager flashPlayerManager;
		private int summonId;
		private FlRoot kirakir;
		[Header]
		[SerializeField]
		public Button switchSummonButton;
		public Sprite[] switchSummonButtonImages;
		public Action onSwitchSummon;
		private readonly string[] flashPaths;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayKiraCorutine_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ExcludeImageSetting __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayKiraCorutine_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ExcludeImageSetting();
	
		// Methods
		public void Setup(SummonTopItemData topData);
		private void SetImage(string assetsPath, Image image, string pathTemplate);
		private string GenerateScheduleText(int summonId);
		[IteratorStateMachine]
		private IEnumerator PlayKiraCorutine();
		public void OnSwitchSummonPressed();
	}
}
