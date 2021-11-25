using System.Collections;
using UnityEngine;

namespace Gluon.Shooting
{
	public class ShootingResultScene : SceneBase
	{
		[SerializeField]
		private Camera mainCamera;

		public static string prefabDir;

		private ShootingResultUiCanvas mainCanvas;

		private static ShootingResultScene instance;

		public static ShootingResultScene Instance => null;

		private bool IsInstanceEmpty()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}
	}
}
