/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UtpCtrl
	{
		// Fields
		[CompilerGenerated]
		private float _point_k__BackingField;
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
		public static readonly int flashingPoint;
	
		// Properties
		public float point { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int maxPoint { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float consumePoint { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int requirePoint { get; private set; }
		public float maxRecastTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float currRecastTime { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float selfDamageRatio { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isPauseConsume { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public UtpCtrl();
		static UtpCtrl();
	
		// Methods
		public void Initialize(AbilityDataElement ade, int idx);
		public void Update(PlayerCharacter owner);
		public void AddPoint(int value);
		public void AddPointForSelfDamageAbility(float rate);
		public void SetPoint(int value);
		public void SetIsPauseConsume(bool isPause);
		public bool IsEnableTransform();
		public bool IsFull();
		public void Continue();
	}
}
