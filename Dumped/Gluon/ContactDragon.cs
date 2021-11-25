using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class ContactDragon : MonoBehaviour
	{
		public const int ContactArrayMaxSize = 10;

		private GameObject dragonObj;

		private Animator dragonMainAnimator;

		private Animator[] dragonAnimListWithDeco;

		private GameObject shadowObj;

		private ContactAsset contactAsset;

		public const string animationStateNameIdle = "90_01 idle";

		public const string animationStateNameHappy = "90_04 happy";

		public const string animationTriggerIdleToJoy = "idleToJoy";

		public const string animationTriggerIdleToHappy = "idleToHappy";

		public const string animationTriggerJoyToHappy = "joyToHappy";

		public const string animationTriggerJoyToIdle = "joyToIdle";

		private const string appearingEffectDispBone = "jHip";

		private const string appearingEffectName = "EFF_FOR_SDR_003";

		private bool _isAppearingEffectAlreadyPlayed;

		private const string changeDragonSEName = "SE_DC_0009";

		public ContactFacialExpression facialExpression;

		protected Dictionary<int, AttachObject> attachObjects;

		private const int stageEffectMax = 2;

		private EffectObject[] stageEffects;

		private bool isPlayingStageEffect;

		[HideInInspector]
		public DragonStrokeMain strokeMain;

		public GameObject traceBoneForEmotion
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

		public bool isAppearingEffectAlreadyPlayed
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void Clear()
		{
		}

		public ContactAsset GetContactAsset()
		{
			return null;
		}

		public void SetActive(bool active)
		{
		}

		public bool LoadDragon(int dragonID, Transform parentNode, bool enableEffect = true)
		{
			return default(bool);
		}

		public GameObject RecursiveFindChild(string name)
		{
			return null;
		}

		public static GameObject RecursiveFindChild(GameObject root, string name)
		{
			return null;
		}

		public bool IsIdleMotion()
		{
			return default(bool);
		}

		public void PlayAppearingEffect()
		{
		}

		public void SetTriggerJoyToIdle()
		{
		}

		public void SetTriggerIdleToJoy()
		{
		}

		public void SetTriggerIdleToHappy()
		{
		}

		public void SetTriggerJoyToHappy()
		{
		}

		public bool IsEndHappyAnimation()
		{
			return default(bool);
		}

		public bool IsWalkerEndHappyAnimation()
		{
			return default(bool);
		}

		public bool IsIdleAnimation()
		{
			return default(bool);
		}

		public GameObject GetMainObject()
		{
			return null;
		}

		private void AttachDragonDecoration(int decoId)
		{
		}
	}
}
