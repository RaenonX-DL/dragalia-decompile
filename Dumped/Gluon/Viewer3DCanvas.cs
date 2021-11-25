using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class Viewer3DCanvas : MonoBehaviour
	{
		[HideInInspector]
		public UnitDetailScene detailScene;

		public DragEventScrollRect dragScrollRect;

		[SerializeField]
		[Header("Publisher")]
		public UIAnimationPublisher mainPublisher;

		private CanvasGroup canvasGroup;

		private GameObject unitObject;

		private Animator unitAnimator;

		private float oldDragDistance;

		private bool playAnimationFlg;

		private float startPinchDistance;

		private float oldPinchDistance;

		private bool inViewMode;

		private void OnEnable()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void OnDisable()
		{
		}

		public void SwitchFromMainPage()
		{
		}

		public void SwitchFrom2DPage()
		{
		}

		public void SwitchChangeDragonId()
		{
		}

		public void SwitchTo2DPage()
		{
		}

		public void ReturnToMainPage([Optional] Action onDone)
		{
		}

		public void Update()
		{
		}

		private void Pinch(OutGameTouchManager.PinchState state)
		{
		}

		private float PinchOnDevice(OutGameTouchManager.PinchState state)
		{
			return default(float);
		}

		public void UnitModelPressed()
		{
		}

		private void Set3DModel()
		{
		}

		private void LoadRichDragon(GameObject unitObject, string modelPath)
		{
		}

		private void CreateDragon(int dragonId)
		{
		}

		public void ApplyShaderSettings(UnitDetailUnitShaderSettings unitShaderSettings)
		{
		}

		private IEnumerator SetUintPosToCenter()
		{
			return null;
		}

		private IEnumerator playAnimationDelay()
		{
			return null;
		}

		private void AttachDragonDecoration(int decoId)
		{
		}

		public void SetUnitObject(GameObject unitObject)
		{
		}
	}
}
