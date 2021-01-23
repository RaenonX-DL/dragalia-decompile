/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CombatQuestMapObjectButton : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public PointerEventHandler[] pointerEventHandler;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private Image balloonImage;
		[SerializeField]
		private Image ribbonImage;
		[SerializeField]
		private GameObject[] bodyObject;
		[Header]
		[SerializeField]
		public Sprite[] ribbonSpriteList;
		[Header]
		[SerializeField]
		private QuestStateIcon stateIcon;
		[Header]
		[SerializeField]
		private Transform ballonTransform;
		[SerializeField]
		private float moveY;
		[SerializeField]
		private float moveTime;
		[SerializeField]
		private Ease easeType;
		private Sequence sequence;
		[Header]
		[SerializeField]
		private Transform lockIconParent;
		[SerializeField]
		private GameObject lockIcon;
		private FlashPlayer lockIconFlash;
		[SerializeField]
		private GameObject iconBadge;
		[SerializeField]
		private FlashPlayerManager flashPlayerManager;
		private FlashPlayer unlockFlash;
		[SerializeField]
		private Transform flashParent;
		private const string balloonPath = "Images/Icon/Combat/Balloon/{0:D5}/{1:D2}";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public Action<int> onTouched;
			public int masterIndex;
			public UnityAction __9__0;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _Setup_b__0();
		}
	
		// Constructors
		public CombatQuestMapObjectButton();
	
		// Methods
		public void Setup(int index, string titleText, Action<int> onTouched, int masterIndex, QuestUtil.QuestState state);
		public void UpdateState(int index, QuestUtil.QuestState state);
		public void PlayUnlockFlash(Action onAnimationEnded = null);
		private void OnDestroy();
		[CompilerGenerated]
		private void _UpdateState_b__21_0();
	}
}
