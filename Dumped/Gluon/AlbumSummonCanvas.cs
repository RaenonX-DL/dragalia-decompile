using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class AlbumSummonCanvas : MonoBehaviour
	{
		private Vector2 _canvasSize;

		[HideInInspector]
		public Camera flashCamera;

		[HideInInspector]
		public Canvas uiCanvas;

		public UnityAction onEndCallback;

		private AlbumSummonPlay summonPlay;

		public Vector2 canvasSize => default(Vector2);

		public void SetUp(GiftType giftType, int masterId, Rarity rarity, Camera camera, UnityAction action)
		{
		}

		private void Start()
		{
		}

		public void ResetFlashCameraSize()
		{
		}

		private void Load3DScene()
		{
		}

		public void ChangeToResultPage()
		{
		}

		public void OnScreenTapped()
		{
		}
	}
}
