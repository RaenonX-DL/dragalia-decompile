/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	public abstract class ActionParts : MonoBehaviour
	{
		// Fields
		protected const string ActionPartsHelpURL = "https://wisdom.cygames.jp/pages/viewpage.action?";
		protected const string BulletHelpURL = "https://wisdom.cygames.jp/pages/viewpage.action?pageId=35742910#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E3%83%90%E3%83%AC%E3%83%83%E3%83%88%E7%B7%A8%EF%BC%89-";
		protected const string CommonHelpURL = "https://wisdom.cygames.jp/pages/viewpage.action?pageId=35731412#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E4%B8%80%E8%88%AC%E7%B7%A8%EF%BC%89-";
	
		// Properties
		public virtual PartsData data { get; }
	
		// Nested types
		[Serializable]
		public class PartsData
		{
			// Fields
			[HideInInspector]
			public ActionDef.CommandType commandType;
			[HideInInspector]
			[SerializeField]
			protected float _seconds;
			[HideInInspector]
			[SerializeField]
			protected float _speed;
			[HideInInspector]
			[SerializeField]
			protected float _duration;
			[HideInInspector]
			[SerializeField]
			protected int _activateId;
			[HideInInspector]
			[SerializeField]
			protected ConditionData _conditionData;
			[HideInInspector]
			[SerializeField]
			public LoopData _loopData;
	
			// Properties
			public float seconds { get; }
			public float speed { get; }
			public float duration { get; }
			public float endSeconds { get; }
			public int activateId { get; }
			public ConditionData conditionData { get; }
			public LoopData loopData { get; }
	
			// Nested types
			[Serializable]
			public class ConditionData
			{
				// Fields
				[CompilerGenerated]
				private ActionContainer _actionContainer_k__BackingField;
				[CompilerGenerated]
				private int _partIndex_k__BackingField;
				[HideInInspector]
				[SerializeField]
				protected ConditionType _conditionType;
				private const int conditionValueMaxCount = 4;
				[HideInInspector]
				[SerializeField]
				protected int[] _conditionValue;
				[HideInInspector]
				[SerializeField]
				protected float _checkConditionTill;
				[HideInInspector]
				[SerializeField]
				protected bool _syncWithStartParam;
	
				// Properties
				public ActionContainer actionContainer { [CompilerGenerated] get; [CompilerGenerated] protected set; }
				public int partIndex { [CompilerGenerated] get; [CompilerGenerated] protected set; }
				public ConditionType conditionType { get; }
				public int[] conditionValue { get; }
				public float checkConditionTill { get; }
				public bool syncWithStartParam { get; }
	
				// Nested types
				public enum ConditionType
				{
					None = 0,
					OwnerBuffCount = 1,
					CPValue = 2,
					Random = 3,
					NearestEnemyDistance = 4,
					SingleOrMultiPlay = 5,
					SpecificTaggedBulletValid = 6,
					ShikigamiLevel = 7,
					SettingHitObjTagContains = 8,
					ActionContainerHitCount = 9,
					ActionCriticalStatus = 10,
					HumanOrDragon = 11,
					BulletTagContains = 12,
					InitialOwner = 13,
					RenderPartVisibility = 14,
					RESERVE_01 = 15,
					RESERVE_02 = 16,
					RESERVE_03 = 17,
					RESERVE_04 = 18,
					RESERVE_05 = 19,
					RESERVE_06 = 20,
					RESERVE_07 = 21,
					RESERVE_08 = 22
				}
	
				public enum ConditionComparisonType
				{
					Equality = 0,
					Inequality = 1,
					GreaterThan = 2,
					GreaterThanOrEqual = 3,
					LessThan = 4,
					LessThanOrEqual = 5
				}
	
				[CompilerGenerated]
				private sealed class __c__DisplayClass29_0
				{
					// Fields
					public string partName;
	
					// Constructors
					public __c__DisplayClass29_0();
	
					// Methods
					internal bool _IsMatchCondition_b__0(RenderPartsData.PartsMeshData x);
				}
	
				// Constructors
				public ConditionData();
	
				// Methods
				public bool SetupActionContainer(ActionContainer container, Gluon.ActionParts parts);
				public ConditionData MakeClone();
				public static bool IsMatchByConditionComparisonType(ConditionComparisonType comparisonType, int leftVal, int rightVal);
				public bool ContinueCheckExecuteCondition(float t);
				public static bool ZipStringToIntArray(string str, ref int[] arr, int l);
				public static void UnzipStringFromIntArray(ref string str, int[] arr, int l);
				public bool IsMatchCondition(CharacterBase owner);
			}
	
			[Serializable]
			public class LoopData
			{
				// Fields
				public bool flag;
				public int loopNum;
				public int restartFrame;
				public float restartSec;
	
				// Constructors
				public LoopData();
	
				// Methods
				public LoopData MakeClone();
			}
	
			// Constructors
			public PartsData();
	
			// Methods
			public virtual void Initialize();
		}
	
		// Constructors
		protected ActionParts();
	}
}
