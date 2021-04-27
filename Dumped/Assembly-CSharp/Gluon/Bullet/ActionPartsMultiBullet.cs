/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsMultiBullet : ActionPartsBullet
	{
		// Fields
		private readonly MultiBulletData _partsData;
		private BulletDataClone bulletData;
		private float _delayTime;
		private int _generateNum;
		private int _generateCnt;
		private int _hostileIdx;
		private List<CharacterBase> _hostile;
		[CompilerGenerated]
		private List<CharacterBase> _bulletTargets_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _fireStockBulletTarget_k__BackingField;
		private Vector3 _originPos;
		private float _forwardRot;
		private float _sectionRot;
		private List<CharacterBase> _listLockOnDebuff;
		private static int FIRESTOCK_BULLET_DATA_MAX;
		private string _hitAttrLabel;
		private RandomXorshift _random;
		private RunActionMultiBulletParameter _runActionParam;
		private List<int> _tmpAppearChildTaskIds;
		private List<int> _appearChildTaskIds;
		private int _syncGenerateNum;
		private List<CharacterBase> _tmpList1;
		private List<CharacterBase> _tmpList2;
	
		// Properties
		public List<CharacterBase> bulletTargets { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterBase fireStockBulletTarget { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<CharacterBase> __9__33_0;
			public static Predicate<CharacterBase> __9__33_1;
			public static Predicate<CharacterBase> __9__33_2;
			public static Comparison<CharacterBase> __9__39_0;
			public static Comparison<CharacterBase> __9__39_1;
			public static Comparison<CharacterBase> __9__39_2;
			public static Comparison<CharacterBase> __9__39_3;
			public static Func<KeyValuePair<CharacterBase, int>, int> __9__43_0;
			public static Comparison<CharacterBase> __9__47_0;
			public static Comparison<CharacterBase> __9__47_3;
			public static Comparison<CharacterBase> __9__47_4;
			public static Comparison<CharacterBase> __9__47_5;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _CreateBullet_b__33_0(CharacterBase a);
			internal bool _CreateBullet_b__33_1(CharacterBase a);
			internal bool _CreateBullet_b__33_2(CharacterBase a);
			internal int _SetMultiPlayerTarget_b__39_0(CharacterBase a, CharacterBase b);
			internal int _SetMultiPlayerTarget_b__39_1(CharacterBase a, CharacterBase b);
			internal int _SetMultiPlayerTarget_b__39_2(CharacterBase a, CharacterBase b);
			internal int _SetMultiPlayerTarget_b__39_3(CharacterBase a, CharacterBase b);
			internal int _SetMultiBulletSharedTarget_b__43_0(KeyValuePair<CharacterBase, int> x);
			internal int _SetLockOnHostile_b__47_0(CharacterBase a, CharacterBase b);
			internal int _SetLockOnHostile_b__47_3(CharacterBase a, CharacterBase b);
			internal int _SetLockOnHostile_b__47_4(CharacterBase a, CharacterBase b);
			internal int _SetLockOnHostile_b__47_5(CharacterBase a, CharacterBase b);
		}
	
		// Constructors
		public ActionPartsMultiBullet(Gluon.ActionData.ActionParts resource);
		static ActionPartsMultiBullet();
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private bool SetupMultiGenerate();
		private bool CreateBullet();
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		private bool SetHostile(MultiBulletData.MultiGenerateStyle generateStyle);
		private void AddHostile(CharacterBase chara, MultiBulletData.MultiGenerateStyle generateStyle, bool playerSide = false);
		private void CreateTargets();
		private void SetMultiPlayerTarget(MultiBulletData.MultiGenerateStyle generate);
		private void ShuffleCharacter(List<CharacterBase> list);
		private int GetFireStockBulletNum();
		private void CalculateFireStockBulletParam(int bulletCount, int bulletIndex, ref BulletDataClone bulletData, ref BulletObject bullet);
		public CharacterBase SetMultiBulletSharedTarget(CharacterBase target, bool isTargetLockedWithOtherMultiBullet);
		public bool IsTargetLockedWithOtherMultiBullet(CharacterBase target);
		protected override void OnFinish();
		private void CreateLockOnDebuffList();
		private void SetLockOnHostile(MultiBulletData.MultiGenerateStyle generate);
		[CompilerGenerated]
		private int _SetHostile_b__36_0(EnemyManage.EnemyInfo a, EnemyManage.EnemyInfo b);
		[CompilerGenerated]
		private int _SetHostile_b__36_1(CharacterSelector a, CharacterSelector b);
		[CompilerGenerated]
		private int _SetLockOnHostile_b__47_1(CharacterBase a, CharacterBase b);
		[CompilerGenerated]
		private int _SetLockOnHostile_b__47_2(CharacterBase a, CharacterBase b);
	}
}
