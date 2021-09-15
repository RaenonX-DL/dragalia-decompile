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
	public class CharaCircleGaugeDrasticForceUI : CharaCircleGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		protected RectTransform _countAdjustRt;
		[SerializeField]
		[Tooltip]
		protected RectTransform _countRt_01;
		[SerializeField]
		[Tooltip]
		protected SpriteRenderer _countMultiImage;
		[SerializeField]
		[Tooltip]
		protected SpriteRenderer[] _countImageArray;
		[Header]
		[SerializeField]
		protected Sprite[] _countSprites;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _oneDigitCountAdjustPosX;
		[SerializeField]
		[Tooltip]
		private float _oneDigitCountPosX_01;
		private int _maxCount;
	
		// Constructors
		public CharaCircleGaugeDrasticForceUI();
	
		// Methods
		public static CharaCircleGaugeDrasticForceUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1);
		protected override void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY);
		public override void SetCount(int count);
		private void SetCountSprite(ref SpriteRenderer image, int count, int targetDigit);
		private void SetCountSprite(ref SpriteRenderer image, int index, bool enabled);
		public override void SetGaugeTimer(float time, float initialTime, bool isPlayAnim = true, bool isForce = false);
		protected override void SetSortingOrder(int v, bool force = false);
	}
}
