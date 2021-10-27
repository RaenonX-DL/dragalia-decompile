/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickRequiredBuffGaugeUI : CharaGimmickBaseGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform rootRt;
		[SerializeField]
		private RectTransform iconRootRt;
		[SerializeField]
		private SpriteRenderer bgImage;
		[SerializeField]
		private GameObject baseIconUI;
		[Header]
		[SerializeField]
		private float bgWidthSize;
		[SerializeField]
		private IconParam[] iconParams;
		private CharacterBase owner;
		private Dictionary<int, CharaGimmickRequiredBuffGaugeIconUI> iconUIDic;
		private List<CharaGimmickRequiredBuffGaugeIconUI> iconUIList;
		private bool isVisible;
	
		// Properties
		private int iconMaxNum { get; }
		private int iconActiveNum { get; }
	
		// Nested types
		[Serializable]
		public class IconParam
		{
			// Fields
			public int conditionId;
			public string iconName;
	
			// Constructors
			public IconParam();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<CharaGimmickRequiredBuffGaugeIconUI> __9__14_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _get_iconActiveNum_b__14_0(CharaGimmickRequiredBuffGaugeIconUI x);
		}
	
		// Constructors
		public CharaGimmickRequiredBuffGaugeUI();
	
		// Methods
		public static CharaGimmickRequiredBuffGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		private void Initialize(CharacterBase chara);
		private bool GetIconParam(int conditionId, out IconParam param);
		private void OnDestroy();
		public override void FastUpdate();
		public override void Show();
		public override void Hide();
		private void ExecHide(bool isForce = false);
		public override bool IsVisible();
		public override int GetGaugeType();
		[CompilerGenerated]
		private void _Initialize_b__16_0();
		[CompilerGenerated]
		private void _Initialize_b__16_1();
	}
}
