/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaCircleGaugeMultiWeakPointUI : CharaCircleGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _markUIAdjustRt;
		[SerializeField]
		protected RectTransform _wpOneDigitRt;
		[SerializeField]
		protected SpriteRenderer _wpBgImage;
		[SerializeField]
		protected SpriteRenderer _wpIconImage;
		[SerializeField]
		protected SpriteRenderer _wpMultiImage;
		[SerializeField]
		protected SpriteRenderer[] _wpCountImage;
		[Header]
		[SerializeField]
		protected Sprite[] _countSprites;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _oneDigitAdjustPosX;
		[SerializeField]
		[Tooltip]
		private float _showMarkUIAdjustPosY;
		private int _maxCount;
	
		// Constructors
		public CharaCircleGaugeMultiWeakPointUI();
	
		// Methods
		public static CharaCircleGaugeMultiWeakPointUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1);
		protected override void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY);
		public override void SetCount(int count);
		private void SetCountSprite(ref SpriteRenderer image, int count, int targetDigit);
		private void SetCountSprite(ref SpriteRenderer image, int index, bool enabled);
		protected override void SetSortingOrder(int v, bool force = false);
	}
}
