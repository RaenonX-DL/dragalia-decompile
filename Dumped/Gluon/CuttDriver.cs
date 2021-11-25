using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cutt;
using UnityEngine;

namespace Gluon
{
	public class CuttDriver : MonoBehaviour
	{
		private class BackupCameraData
		{
			public CameraGroup cam;

			public float orthographicSize;

			public float near;

			public float far;

			public Vector3 position;

			public Quaternion rotation;

			public float fov;
		}

		protected CuttTimelineControl _CuttTimelineControl;

		private CuttCharacterInitializer characterInitializer;

		private CuttFlashInitializer flashInitializer;

		public Canvas canvas;

		[SerializeField]
		private GameObject _gameCameraObject;

		[SerializeField]
		private CharaController _chara;

		[SerializeField]
		private MeshRenderer _floorMeshRenderer;

		[SerializeField]
		private MainCameraCtrl.CameraLabel _activeCameraLabel;

		public static bool isPlayingInGame;

		private List<BackupCameraData> backupCameraList;

		public MainCameraCtrl mainCameraCtrl
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

		public bool isTimelineControlled => default(bool);

		public bool InitializeTimeline(CuttTimelineControl timelineControl, bool loadAnimFlag)
		{
			return default(bool);
		}

		public void SetIngameCuttCameraAnim()
		{
		}

		protected void CreateCameraRoot()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected IEnumerator StartInitialize(GameObject canvasObject, bool loadAnimFlag = true)
		{
			return null;
		}

		public virtual IEnumerator Start()
		{
			return null;
		}

		public virtual void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void BackupCamera(CameraGroup[] camArray)
		{
		}

		public void Restore2DCameraSetting()
		{
		}
	}
}
