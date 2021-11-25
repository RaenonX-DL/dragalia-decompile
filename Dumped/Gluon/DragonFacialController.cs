using System;
using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class DragonFacialController : MonoBehaviour
	{
		public enum ChangingPart
		{
			Mouth,
			Eye
		}

		public enum PartDefine
		{
			Normal,
			Close,
			Half,
			Damaged,
			Smiling
		}

		[Serializable]
		public class StateDependentFacialData
		{
			[SerializeField]
			[Header("è¡\u00a8æ\u0083\u0085ã\u0082\u0092å¤\u0089ã\u0081\u0088ã\u0082\u008bã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0083\u0088å\u0090\u008d")]
			public string stateName;

			[SerializeField]
			[Header("ç\u009b®ã\u0081\u008bå\u008f£ã\u0081\u008b")]
			public ChangingPart part;

			[SerializeField]
			[Header("è¡\u00a8æ\u0083\u0085")]
			public PartDefine type;

			[HideInInspector]
			public int prevType;
		}

		private const int maxFacialCount = 5;

		private GameObject[] eyeList;

		private GameObject[] mouthList;

		private Coroutine autoBlinkCoroutine;

		private Coroutine autoTalkCoroutine;

		public PartDefine lastMouth;

		public PartDefine lastEye;

		[Header("ã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0083\u0088ã\u0081«ç\u00b4\u0090ã\u0081¥ã\u0081\u0084ã\u0081\u009fè¡\u00a8æ\u0083\u0085æ\u008c\u0087å®\u009a")]
		public StateDependentFacialData[] stateDependentFacialData;

		private Animator animator;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void ProcessCommand(ChangingPart changingPart, int index, float rawValue)
		{
		}

		public void ChangeFacial(ChangingPart changingPart, int index)
		{
		}

		public void ResetToNormalFace(bool stopAllAutoAnimations = true)
		{
		}

		public void StartAutoBlink()
		{
		}

		private int GetCurrentAnimationNameHash(Animator anim)
		{
			return default(int);
		}

		private bool CheckAnimationMatch(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation)
		{
			return default(bool);
		}

		public void StopAutoBlink()
		{
		}

		private IEnumerator AutoBlinkCoroutine(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation)
		{
			return null;
		}

		public void StartAutoTalk()
		{
		}

		public void StopAutoTalk()
		{
		}

		private IEnumerator AutoTalkCoroutine(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation)
		{
			return null;
		}

		public void FBXImport_mMouth_01(float val)
		{
		}

		public void FBXImport_mMouth_02(float val)
		{
		}

		public void FBXImport_mMouth_03(float val)
		{
		}

		public void FBXImport_mMouth_04(float val)
		{
		}

		public void FBXImport_mMouth_05(float val)
		{
		}

		public void FBXImport_mEye_01(float val)
		{
		}

		public void FBXImport_mEye_02(float val)
		{
		}

		public void FBXImport_mEye_03(float val)
		{
		}

		public void FBXImport_mEye_04(float val)
		{
		}

		public void FBXImport_mEye_05(float val)
		{
		}

		public void FBXImport_DirectControl(string command)
		{
		}
	}
}
