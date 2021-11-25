using System.Collections;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gluon
{
	public class PartyBgManager : SingletonMonoBehaviour<PartyBgManager>
	{
		public PartyBgContent currentBgContent;

		public PartyBgContent nextBgContent;

		private string lastLightMapSceneName;

		private QuestBgSceneSettingKeeper bgSettingKeeper;

		public bool isSceneLoadCompleted;

		public bool dontDestroyOnDestroy;

		public bool dontReTetahedralizeLightProbeAtDestroyBgScene;

		private static Scene createdScene;

		private static DungeonManager.OutDesignerAreaDataCache designerAreaDataCache;

		private EnvironmentMap environment;

		private SceneShaderSettings sceneShaderSettings;

		public static string bgFileName;

		public bool isComnpleteSceneLightProbeTetrahedralized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void LoadBgScene()
		{
		}

		public void LoadBgScene(string resourcePath, string filename, int selectQuestId, bool needLightProbeseTetrahedralize)
		{
		}

		private IEnumerator LoadBgSceneCoroutine(string resourcePath, string filename, bool needLightProbeseTetrahedralize)
		{
			return null;
		}

		public void ApplyBgSceneShader()
		{
		}

		public bool ReloadBgFileNameFromCreatedScene()
		{
			return default(bool);
		}

		public void ReflectBgSettings(PostEffect pe)
		{
		}

		private Scene GetLatestSceneByName(string filename)
		{
			return default(Scene);
		}

		public void ShowBg()
		{
		}

		private IEnumerator ShowBgCoroutine()
		{
			return null;
		}

		public void Destroy()
		{
		}

		public void SetCharaLightProbeParam(GameObject character)
		{
		}

		public IEnumerator SetCharaLightProbeParamCoroutine(GameObject character)
		{
			return null;
		}
	}
}
