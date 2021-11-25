using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FLATOUT.Main;
using UnityEngine;

namespace Gluon
{
	public class ContactFlashEffect : MonoBehaviour
	{
		public enum FlashType
		{
			Normal,
			HeartIn
		}

		public enum FlashState
		{
			None,
			Initialized,
			Play,
			End,
			HeartIn,
			Max
		}

		private GameObject flashBase;

		private GameObject flashMot;

		private FlRoot flashRoot;

		private FlMotion rootMotion;

		private List<FlMotion> listMotion;

		private List<FlPlane> listPlane;

		private bool bEdgePause;

		private FlashType flashType;

		private FlashState flashState;

		private Transform parentTransform;

		private Camera parentCamera;

		private const float nearClipDistance = 2f;

		private GameObject[] flyingHeartIconArray;

		private Vector2 posOnCanvasOrigin;

		private Canvas selfCanvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector2 posOnCanvas
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 posHeartTarget
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize(string flashPath, Transform cameraTrans, Camera camera, Canvas canvas, FlashType a_flashType = FlashType.Normal, [Optional] GameObject a_heartIcon, [Optional] Transform trans)
		{
		}

		private void Update()
		{
		}

		public void Stop()
		{
		}

		public void ForceEnd()
		{
		}

		public void Play(int id = 0, string name = "")
		{
		}

		public bool IsEnd()
		{
			return default(bool);
		}

		private void PlayMotion()
		{
		}

		private void PauseMotion()
		{
		}

		private void FixTransform(Vector2 pos)
		{
		}

		private bool MoveToHeartIcon()
		{
			return default(bool);
		}

		private void InitMoveToHeartIconByImage()
		{
		}

		public void ReplaceIcon(int id)
		{
		}

		public void SetDragonModeTimeEffect(bool isActive)
		{
		}
	}
}
