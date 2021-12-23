using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class AttachObject
	{
		private Animator animator;

		private RuntimeAnimatorController savedRuntimeAnimatorController;

		public GameObject go
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

		public AttachObject(GameObject obj)
		{
		}

		public void SetAnimation(string motionPath)
		{
		}

		private bool GetAnimatorComponent()
		{
			return default(bool);
		}

		public void SaveCurrentAnimation()
		{
		}

		public void LoadSavedAnimation()
		{
		}

		public void Attach(Transform attachNode)
		{
		}

		public void SetOffset(Vector3 pos, Vector3 rot, Vector3 scl)
		{
		}

		public void PlayAnimation(string stateName)
		{
		}

		public void PlayBlendAnimation(string stateName, float blendDuration, bool checkSame)
		{
		}

		public bool IsAnimationState(string stateName)
		{
			return default(bool);
		}

		public bool IsNextAnimationState(string stateName)
		{
			return default(bool);
		}

		public void SetVisible(bool visible, bool forcibly = false)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void SetLightProbeAnchor(Transform lightProbeAnchorNode)
		{
		}
	}
}
