using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsMultiBullet : ActionPartsBullet
	{
		private readonly MultiBulletData _partsData;

		private BulletDataClone bulletData;

		private float _delayTime;

		private int _generateNum;

		private int _generateCnt;

		private int _hostileIdx;

		private List<CharacterBase> _hostile;

		private Vector3 _originPos;

		private float _forwardRot;

		private float _sectionRot;

		private List<CharacterBase> _listLockOnDebuff;

		private List<CharacterId> tmpListLockOnDebuff;

		private static int FIRESTOCK_BULLET_DATA_MAX;

		private string _hitAttrLabel;

		private RandomXorshift _random;

		private RunActionMultiBulletParameter _runActionParam;

		private List<int> _tmpAppearChildTaskIds;

		private List<int> _appearChildTaskIds;

		private int _syncGenerateNum;

		private List<CharacterBase> _tmpList1;

		private List<CharacterBase> _tmpList2;

		public List<CharacterBase> bulletTargets
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterBase fireStockBulletTarget
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ActionPartsMultiBullet(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private bool SetupMultiGenerate()
		{
			return default(bool);
		}

		private bool CreateBullet()
		{
			return default(bool);
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		private bool SetHostile(MultiBulletData.MultiGenerateStyle generateStyle)
		{
			return default(bool);
		}

		private void AddHostile(CharacterBase chara, MultiBulletData.MultiGenerateStyle generateStyle, bool playerSide = false)
		{
		}

		private void CreateTargets()
		{
		}

		private void SetMultiPlayerTarget(MultiBulletData.MultiGenerateStyle generate)
		{
		}

		private void ShuffleCharacter(List<CharacterBase> list)
		{
		}

		private int GetFireStockBulletNum()
		{
			return default(int);
		}

		private void CalculateFireStockBulletParam(int bulletCount, int bulletIndex, ref BulletDataClone bulletData, ref BulletObject bullet)
		{
		}

		public CharacterBase SetMultiBulletSharedTarget(CharacterBase target, bool isTargetLockedWithOtherMultiBullet)
		{
			return null;
		}

		public bool IsTargetLockedWithOtherMultiBullet(CharacterBase target)
		{
			return default(bool);
		}

		protected override void OnFinish()
		{
		}

		private void CreateLockOnDebuffList()
		{
		}

		private void SetLockOnHostile(MultiBulletData.MultiGenerateStyle generate)
		{
		}
	}
}
