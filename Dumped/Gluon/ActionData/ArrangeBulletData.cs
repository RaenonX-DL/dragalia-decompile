using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ArrangeBulletData : ActionParts.PartsData
	{
		public enum ArrangeBulletTriggerCondition
		{
			NormalHit,
			GroundHit,
			DurationTime,
			Distance,
			NormalHit_EnemyOnly
		}

		[Serializable]
		public struct CastingMoveInfo
		{
			public bool isEnableCastingMove;

			public float r;

			public float moveSpeed;
		}

		[SerializeField]
		[HideInInspector]
		private float _abDuration;

		[SerializeField]
		[HideInInspector]
		private float _abWaitTime;

		[SerializeField]
		[HideInInspector]
		private string _abEffectName;

		[SerializeField]
		[HideInInspector]
		private string[] _abElementalEffectName;

		[SerializeField]
		[HideInInspector]
		private int _abEffectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _abEffectInfluencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private bool _abEffectUseElementalTrigger;

		[SerializeField]
		[HideInInspector]
		private bool _isSeparatelyLoadEffect;

		[SerializeField]
		[HideInInspector]
		private Vector3 _abOffsetScale;

		[SerializeField]
		[HideInInspector]
		private bool _abIsKeepBulletDirection;

		[SerializeField]
		[HideInInspector]
		private EffectObject.EraseType _abEffectEraseType;

		[SerializeField]
		[HideInInspector]
		private float _abEffectDisappearTime;

		[SerializeField]
		[HideInInspector]
		private string _abWaitingEffectName;

		[SerializeField]
		[HideInInspector]
		private int _abWaitingEffectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private string _abHitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private bool _abUseElementalHit;

		[SerializeField]
		[HideInInspector]
		private string[] _abElementalHitLabel;

		[SerializeField]
		[HideInInspector]
		private float _abHitInterval;

		[SerializeField]
		[HideInInspector]
		private bool _abUseAccurateCollisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private bool _abHitDelete;

		[SerializeField]
		[HideInInspector]
		private bool _abForceHitEndOnABGen;

		[SerializeField]
		[HideInInspector]
		private bool _abWallCheckBaseOnSelfPos;

		[SerializeField]
		[HideInInspector]
		private List<ArrangeBulletTriggerCondition> _abTriggerCondition;

		[SerializeField]
		[HideInInspector]
		private bool _abTriggerOnNormalHit;

		[SerializeField]
		[HideInInspector]
		private EffectData _abHitEffect;

		[SerializeField]
		[HideInInspector]
		private string _abHitSEName;

		[SerializeField]
		[HideInInspector]
		private string _abFireSEName;

		[SerializeField]
		[HideInInspector]
		private bool _abUseHitCameraShake;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakeType _abHitCameraShake;

		[SerializeField]
		[HideInInspector]
		private ActionCollision _abCollisionShape;

		[SerializeField]
		[HideInInspector]
		private ActionCollisionPos _abCollisionPosId;

		[SerializeField]
		[HideInInspector]
		private bool _abIsCollisionSlotFront;

		[SerializeField]
		[HideInInspector]
		private Vector3 _abCollisionOffset;

		[SerializeField]
		[HideInInspector]
		private float _abCollisionParams01;

		[SerializeField]
		[HideInInspector]
		private float _abCollisionParams02;

		[SerializeField]
		[HideInInspector]
		private float _abCollisionParams03;

		[SerializeField]
		[HideInInspector]
		private float _abCollisionParams05;

		[SerializeField]
		[HideInInspector]
		private float _abCollisionParams06;

		[SerializeField]
		[HideInInspector]
		private CastingMoveInfo _abCastingMoveInfo;

		[SerializeField]
		[HideInInspector]
		private bool _abCopySameTimeHitId;

		[SerializeField]
		[HideInInspector]
		private int _abSameTimeHitId;

		public float abDuration => default(float);

		public float abWaitTime => default(float);

		public string abEffectName => null;

		public string[] abElementalEffectName => null;

		public int abEffectTriggerIdx => default(int);

		public bool abEffectInfluencedCharaterElement => default(bool);

		public bool abEffectUseElementalTrigger => default(bool);

		public bool isSeparatelyLoadEffect => default(bool);

		public Vector3 abOffsetScale => default(Vector3);

		public bool abIsKeepBulletDirection => default(bool);

		public EffectObject.EraseType abEffectEraseType => default(EffectObject.EraseType);

		public float abEffectDisappearTime => default(float);

		public string abWaitingEffectName => null;

		public int abWaitingEffectTriggerIdx => default(int);

		public string abHitAttrLabel => null;

		public bool abUseElementalHit => default(bool);

		public string[] abElementalHitLabel => null;

		public float abHitInterval => default(float);

		public bool abUseAccurateCollisionHitInterval => default(bool);

		public bool abHitDelete => default(bool);

		public bool abForceHitEndOnABGen => default(bool);

		public bool abWallCheckBaseOnSelfPos => default(bool);

		public List<ArrangeBulletTriggerCondition> abTriggerCondition => null;

		public bool abTriggerOnNormalHit => default(bool);

		public EffectData abHitEffect => null;

		public string abHitSEName => null;

		public string abFireSEName => null;

		public bool abUseHitCameraShake => default(bool);

		public CameraController.ShakeType abHitCameraShake => default(CameraController.ShakeType);

		public ActionCollision abCollisionShape => default(ActionCollision);

		public ActionCollisionPos abCollisionPosId => default(ActionCollisionPos);

		public bool abIsCollisionSlotFront => default(bool);

		public Vector3 abCollisionOffset => default(Vector3);

		public float abCollisionParams01 => default(float);

		public float abCollisionParams02 => default(float);

		public float abCollisionParams03 => default(float);

		public float abCollisionParams05 => default(float);

		public float abCollisionParams06 => default(float);

		public CastingMoveInfo abCastingMoveInfo => default(CastingMoveInfo);

		public bool abCopySameTimeHitId => default(bool);

		public int abSameTimeHitId => default(int);

		public void Copy(ArrangeBulletData src)
		{
		}
	}
}
