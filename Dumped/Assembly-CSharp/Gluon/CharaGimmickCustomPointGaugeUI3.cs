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
	public class CharaGimmickCustomPointGaugeUI3 : CharaGimmickCustomPointGaugeUI2
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _stepGaugeRootRt;
		[Header]
		[SerializeField]
		[Tooltip]
		protected Color _gaugeNegativeColor;
		[SerializeField]
		[Tooltip]
		protected int[] _negativeConditionId;
		protected HumanCharacter _owner;
		protected IconData[] _iconDataList;
		protected StateType _state;
	
		// Nested types
		protected enum StateType
		{
			Normal = 0,
			Negative = 1,
			Num = 2
		}
	
		protected class IconData
		{
			// Fields
			protected Sprite _sprite;
			protected Material _material;
	
			// Properties
			public Sprite Sprite { get; }
			public Material Material { get; }
	
			// Constructors
			private IconData();
			public IconData(string iconName);
	
			// Methods
			~IconData();
			public void LoadIcon(string iconName);
		}
	
		// Constructors
		public CharaGimmickCustomPointGaugeUI3();
	
		// Methods
		public static new CharaGimmickCustomPointGaugeUI3 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected override void Initialize(CharacterBase chara);
		private void SetState(StateType type, bool isForce = false);
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false);
		protected override void UpdateGaugeValue();
		protected bool GetBuffCountForConditionId(out int conditionId, out int count);
		public override int GetGaugeType();
	}
}
