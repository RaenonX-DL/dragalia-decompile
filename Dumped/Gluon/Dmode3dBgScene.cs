using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class Dmode3dBgScene : SceneBase
	{
		public Camera mainCamera;

		public Camera render3dCamera;

		public GameObject renderBgCanvas;

		public Dmode3dBgCanvas controlCanvas;

		public QuestCharacterCtrl[] characterCtrls;

		public GameObject characterShaderSettingsObj;

		[SerializeField]
		[Header("Shader")]
		public PartyCharacterShaderSettings charaShaderSettings;

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

		public override void OnBeforeLeaving()
		{
		}

		public void FadeOutBgCanvas()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetupCharaShader()
		{
		}

		public void OnChangedBackgroundShaderParameter()
		{
		}
	}
}
