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
	public class CharaCircleGaugeScapegoatUI : CharaCircleGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _oneDigitRt;
		[SerializeField]
		protected SpriteRenderer[] _countImage;
		[Header]
		[SerializeField]
		protected Sprite[] _countSprites;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _oneDigitAdjustPosX;
	
		// Constructors
		public CharaCircleGaugeScapegoatUI();
	
		// Methods
		public static CharaCircleGaugeScapegoatUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1);
		public override void SetCount(int count);
		private void SetCountSprite(ref SpriteRenderer image, int count, int targetDigit);
		private void SetCountSprite(ref SpriteRenderer image, int index, bool enabled);
	}
}
