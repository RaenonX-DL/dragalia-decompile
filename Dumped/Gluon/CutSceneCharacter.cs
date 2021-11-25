using System.Collections;
using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CutSceneCharacter : FastUpdateMonoBehaviour
	{
		private class AnimationData
		{
			public bool enable;

			public bool playing;

			public float interval;

			public float time;

			public int count;

			public string stateName;

			public int materialIdx;

			public float intervalMin;

			public float intervalMax;

			public float loopInterval;
		}

		private class StateName
		{
			public string name;

			public string fullName;
		}

		[SerializeField]
		public string characterPrefabName;

		[SerializeField]
		public string animationControllerName;

		[SerializeField]
		public string weaponPrefabName;

		[SerializeField]
		public string eyeAnimationControllerName;

		[SerializeField]
		public string mouthAnimationControllerName;

		private GameObject character;

		private SkinnedMeshRenderer meshRenderer;

		private GameObject weapon;

		private GameObject eyeObject;

		private GameObject mouthObject;

		private Animator eyeAnimator;

		private Animator mouthAnimator;

		private AnimationData eye;

		private AnimationData mouth;

		private const float blinkIntervalMin = 1.5f;

		private const float blinkIntervalMax = 5f;

		private const float blinkLoopInterval = 5f / 12f;

		private CutSceneInitializer initializer;

		private static readonly int maxCut;

		private Dictionary<int, StateName> stateNameDictionary;

		private static readonly string baseLayerName;

		private IEnumerator Start()
		{
			return null;
		}

		private GameObject CreateFaceAnimationObject(string animationControllerName, out Animator animator, GameObject top)
		{
			return null;
		}

		private void UpdateAnimation(AnimationData animation, float[] offsetX)
		{
		}

		private void InitAutoAnimation(AnimationData data, string name)
		{
		}

		public void ClearLoop()
		{
		}

		private void UpdateFaceAnimation(GameObject obj, Animator animator, AnimationData data)
		{
		}

		private void LateUpdate()
		{
		}

		public void SetVisible(int visible)
		{
		}
	}
}
