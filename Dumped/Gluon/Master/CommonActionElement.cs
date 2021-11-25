using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CommonActionElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Sp;

		[SerializeField]
		private int _Cd;

		[SerializeField]
		private float _Range;

		[SerializeField]
		private int _IsApproch;

		[SerializeField]
		private int _IsTurn;

		[SerializeField]
		private float _TurnturnDurationSec;

		[SerializeField]
		private float _PrepareSec;

		[SerializeField]
		private int _PrepareMaterial;

		[SerializeField]
		private string _PrepareEffect;

		[SerializeField]
		private int _CanTurnPrepare;

		[SerializeField]
		private float _ZoomDistance;

		[SerializeField]
		private ActionFocusPos _FocusPos;

		[SerializeField]
		private float _FocusSec;

		[SerializeField]
		private float _FocusDurationSec;

		[SerializeField]
		private float _IntervalSec;

		[SerializeField]
		private float _LifeSec;

		[SerializeField]
		private int _IsDefaultSkill;

		[SerializeField]
		private int _IsChargeSkill;

		[SerializeField]
		private int _IsHeroSkill;

		[SerializeField]
		private int _IsHealType;

		[SerializeField]
		private int _IsAvoidType;

		[SerializeField]
		private int _IsRegistBlast;

		[SerializeField]
		private int _IsExtraAction;

		[SerializeField]
		private int _IsShowName;

		[SerializeField]
		private int _IsPreActionSuperAmor;

		[SerializeField]
		private int _SkillCategory01;

		[SerializeField]
		private int _SkillCategory02;

		[SerializeField]
		private int _SkillCategory03;

		[SerializeField]
		private int _SkillCategory04;

		[SerializeField]
		private int _SkillCategory05;

		[SerializeField]
		private int _SkillCategory06;

		[SerializeField]
		private int _SkillCategory07;

		[SerializeField]
		private Gluon.ActionTarget _Target;

		[SerializeField]
		private int _MultiHit;

		[SerializeField]
		private int _CollisionOff;

		[SerializeField]
		private int _Pid;

		[SerializeField]
		private string _BrokenMaterial;

		public int Id => default(int);

		public int Sp => default(int);

		public int Cd => default(int);

		public float Range => default(float);

		public int IsApproch => default(int);

		public int IsTurn => default(int);

		public float TurnturnDurationSec => default(float);

		public float PrepareSec => default(float);

		public int PrepareMaterial => default(int);

		public string PrepareEffect => null;

		public int CanTurnPrepare => default(int);

		public float ZoomDistance => default(float);

		public ActionFocusPos FocusPos => default(ActionFocusPos);

		public float FocusSec => default(float);

		public float FocusDurationSec => default(float);

		public float IntervalSec => default(float);

		public float LifeSec => default(float);

		public int IsDefaultSkill => default(int);

		public int IsChargeSkill => default(int);

		public int IsHeroSkill => default(int);

		public int IsHealType => default(int);

		public int IsAvoidType => default(int);

		public int IsRegistBlast => default(int);

		public int IsExtraAction => default(int);

		public int IsShowName => default(int);

		public int IsPreActionSuperAmor => default(int);

		public int SkillCategory01 => default(int);

		public int SkillCategory02 => default(int);

		public int SkillCategory03 => default(int);

		public int SkillCategory04 => default(int);

		public int SkillCategory05 => default(int);

		public int SkillCategory06 => default(int);

		public int SkillCategory07 => default(int);

		public Gluon.ActionTarget Target => default(Gluon.ActionTarget);

		public int MultiHit => default(int);

		public int CollisionOff => default(int);

		public int Pid => default(int);

		public string BrokenMaterial => null;
	}
}
