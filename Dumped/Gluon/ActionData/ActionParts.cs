using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.ActionData
{
	public abstract class ActionParts : MonoBehaviour
	{
		[Serializable]
		public class PartsData
		{
			[Serializable]
			public class ConditionData
			{
				public enum ConditionType
				{
					None,
					OwnerBuffCount,
					CPValue,
					Random,
					NearestEnemyDistance,
					SingleOrMultiPlay,
					SpecificTaggedBulletValid,
					ShikigamiLevel,
					SettingHitObjTagContains,
					ActionContainerHitCount,
					ActionCriticalStatus,
					HumanOrDragon,
					BulletTagContains,
					InitialOwner,
					RenderPartVisibility,
					TargetIdContains,
					AuraLevel,
					AllyHpRateLowest,
					CharaMode,
					RESERVE_05,
					RESERVE_06,
					RESERVE_07,
					RESERVE_08
				}

				public enum ConditionComparisonType
				{
					Equality,
					Inequality,
					GreaterThan,
					GreaterThanOrEqual,
					LessThan,
					LessThanOrEqual
				}

				[SerializeField]
				[HideInInspector]
				protected ConditionType _conditionType;

				private const int conditionValueMaxCount = 4;

				[SerializeField]
				[HideInInspector]
				protected int[] _conditionValue;

				[SerializeField]
				[HideInInspector]
				protected float _checkConditionTill;

				[SerializeField]
				[HideInInspector]
				protected bool _syncWithStartParam;

				public ActionContainer actionContainer
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					protected set
					{
					}
				}

				public int partIndex
				{
					[CompilerGenerated]
					get
					{
						return default(int);
					}
					[CompilerGenerated]
					protected set
					{
					}
				}

				public ConditionType conditionType => default(ConditionType);

				public int[] conditionValue => null;

				public float checkConditionTill => default(float);

				public bool syncWithStartParam => default(bool);

				public bool SetupActionContainer(ActionContainer container, Gluon.ActionParts parts)
				{
					return default(bool);
				}

				public ConditionData MakeClone()
				{
					return null;
				}

				public static bool IsMatchByConditionComparisonType(ConditionComparisonType comparisonType, int leftVal, int rightVal)
				{
					return default(bool);
				}

				public bool ContinueCheckExecuteCondition(float t)
				{
					return default(bool);
				}

				public static bool ZipStringToIntArray(string str, ref int[] arr, int l)
				{
					return default(bool);
				}

				public static void UnzipStringFromIntArray(ref string str, int[] arr, int l)
				{
				}

				public bool IsMatchCondition(CharacterBase owner)
				{
					return default(bool);
				}
			}

			[Serializable]
			public class LoopData
			{
				public bool flag;

				public int loopNum;

				public int restartFrame;

				public float restartSec;

				public LoopData MakeClone()
				{
					return null;
				}
			}

			[HideInInspector]
			public ActionDef.CommandType commandType;

			[SerializeField]
			[HideInInspector]
			protected float _seconds;

			[SerializeField]
			[HideInInspector]
			protected float _speed;

			[SerializeField]
			[HideInInspector]
			protected float _duration;

			[SerializeField]
			[HideInInspector]
			protected int _activateId;

			[SerializeField]
			[HideInInspector]
			protected ConditionData _conditionData;

			[SerializeField]
			[HideInInspector]
			public LoopData _loopData;

			public float seconds => default(float);

			public float speed => default(float);

			public float duration => default(float);

			public float endSeconds => default(float);

			public int activateId => default(int);

			public ConditionData conditionData => null;

			public LoopData loopData => null;

			public virtual void Initialize()
			{
			}
		}

		protected const string ActionPartsHelpURL = "https://wisdom.cygames.jp/pages/viewpage.action?";

		protected const string BulletHelpURL = "https://wisdom.cygames.jp/pages/viewpage.action?pageId=35742910#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E3%83%90%E3%83%AC%E3%83%83%E3%83%88%E7%B7%A8%EF%BC%89-";

		protected const string CommonHelpURL = "https://wisdom.cygames.jp/pages/viewpage.action?pageId=35731412#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E4%B8%80%E8%88%AC%E7%B7%A8%EF%BC%89-";

		public virtual PartsData data => null;
	}
}
