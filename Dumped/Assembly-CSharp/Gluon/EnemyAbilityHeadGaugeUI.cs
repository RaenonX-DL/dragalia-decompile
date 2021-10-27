/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityHeadGaugeUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform offsetRt;
		[SerializeField]
		private SpriteRenderer iconImage;
		[SerializeField]
		private InGameGaugeUISpriteRenderer gaugeUI;
		[Header]
		[SerializeField]
		private Sprite[] iconResources;
		[CompilerGenerated]
		private IconType _iconType_k__BackingField;
		private RectTransform rootRt;
		private RectTransform iconRt;
		private CharacterBase owner;
		private CharacterMarkUI markUI;
		[CompilerGenerated]
		private bool _isVisible_k__BackingField;
	
		// Properties
		public IconType iconType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isVisible { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum IconType
		{
			None = -1,
			Phoenix = 0
		}
	
		// Constructors
		public EnemyAbilityHeadGaugeUI();
	
		// Methods
		public static EnemyAbilityHeadGaugeUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, IconType type, int siblingIndex = -1);
		private void Initialize(CharacterBase owner, CharacterMarkUI markUI, IconType type);
		public override void FastUpdate();
		public void Visible(bool b);
		public void SetIcon(IconType type, bool isForce = false);
		public void SetGaugeRate(float rate, bool isImmediate = false);
		public void SetOffsetY(float offsetY);
		protected bool IsShow();
		protected bool IsParentVisible();
	}
}
