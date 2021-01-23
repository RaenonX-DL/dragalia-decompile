/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyListElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _GaugeName;
		[SerializeField]
		private TribeType _TribeType;
		[SerializeField]
		private int _Register;
		[SerializeField]
		private int _SortKey;
		[SerializeField]
		private int _Rarity;
		[SerializeField]
		private int _MaxCount;
		[SerializeField]
		private float _BossAppearMotionStartTime;
		[SerializeField]
		private float _BossAppearTime;
		[SerializeField]
		private float _BossAppearCameraAnimationCutTime;
		[SerializeField]
		private float _BossScale;
		[SerializeField]
		private BossCamera _BossCameraType;
		[SerializeField]
		private string _BossBlurEffect;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string GaugeName { get; }
		public TribeType TribeType { get; }
		public int Register { get; }
		public int SortKey { get; }
		public int Rarity { get; }
		public int MaxCount { get; }
		public float BossAppearMotionStartTime { get; }
		public float BossAppearTime { get; }
		public float BossAppearCameraAnimationCutTime { get; }
		public float BossScale { get; }
		public BossCamera BossCameraType { get; }
		public string BossBlurEffect { get; }
	
		// Constructors
		public EnemyListElement();
	}
}
