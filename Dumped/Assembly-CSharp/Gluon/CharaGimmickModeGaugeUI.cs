/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickModeGaugeUI : CharaGimmickActiveGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		protected SpriteRenderer[] _bgImage;
		[SerializeField]
		[Tooltip]
		protected SpriteRenderer[] _iconImage;
		[Header]
		[SerializeField]
		[Tooltip]
		protected Color _deactiveColor;
		private VisibleUIObject[] _gaugeVisible;
	
		// Constructors
		public CharaGimmickModeGaugeUI();
	
		// Methods
		public static new CharaGimmickModeGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected override void Initialize(CharacterBase chara);
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false);
		public void SetMode(int mode);
		protected void SetColor(Color color, int index, bool active);
		protected void SetColor(ref SpriteRenderer sprite, Color color);
		protected void SetActiveColor(int index);
		protected void SetDeactiveColor(int index);
		public override int GetGaugeType();
	}
}
