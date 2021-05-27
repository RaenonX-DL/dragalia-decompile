/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UtpCtrl
	{
		// Fields
		private float _point;
		[CompilerGenerated]
		private int _maxPoint_k__BackingField;
		[CompilerGenerated]
		private float _consumePoint_k__BackingField;
		private int _requirePoint;
		[CompilerGenerated]
		private float _maxRecastTime_k__BackingField;
		[CompilerGenerated]
		private float _currRecastTime_k__BackingField;
		[CompilerGenerated]
		private float _selfDamageRatio_k__BackingField;
		[CompilerGenerated]
		private bool _isPauseConsume_k__BackingField;
		[CompilerGenerated]
		private bool _isServantTransform_k__BackingField;
		private UtpMultiPlayService _multiPlayService;
		public static readonly int flashingPoint;
	
		// Properties
		public float point { get; private set; }
		public int maxPoint { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float consumePoint { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int requirePoint { get; private set; }
		public float maxRecastTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float currRecastTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float selfDamageRatio { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isPauseConsume { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isServantTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public UtpCtrl();
		static UtpCtrl();
	
		// Methods
		public void Initialize(AbilityDataElement ade, int idx, bool isServantTransform, UtpMultiPlayService multiPlayService);
		public void Update(PlayerCharacter owner);
		public void AddPoint(int value, CharacterBase owner);
		public void AddPointForSelfDamageAbility(float rate, CharacterBase owner);
		public void SetPoint(float value, bool isSielent = false);
		public void SetIsPauseConsume(bool isPause);
		public bool IsEnableTransform();
		public bool IsFull();
		public void Continue();
		public void SetRecastTime();
	}
}
