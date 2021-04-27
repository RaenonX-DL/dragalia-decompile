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
	public class CharaCircleGaugeAbilityRebornUI : CharaCircleGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		private InGameCounterUI _counterUI;
		private int _lastTimeImageIndex;
	
		// Constructors
		public CharaCircleGaugeAbilityRebornUI();
	
		// Methods
		public static CharaCircleGaugeAbilityRebornUI Create(GameObject parent, CharacterBase owner, CharacterMarkUI markUI, float adjustPosY, int siblingIndex = -1);
		protected override void Initialize(CharacterBase owner, CharacterMarkUI markUI, Type gaugeType, float adjustPosY);
		public override void SetGaugeTimer(float time, float initialTime, bool isPlayAnim = true, bool isForce = false);
	}
}
