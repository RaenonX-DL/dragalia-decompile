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
	public class CharaCircleGaugeElectrifiedUI : CharaCircleGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected Sprite[] _iconSprites;
	
		// Constructors
		public CharaCircleGaugeElectrifiedUI();
	
		// Methods
		public static CharaCircleGaugeElectrifiedUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1);
		public override void SetCount(int count);
	}
}
