using System.Collections;
using System.Collections.Generic;
using FLATOUT.Main;
using Gluon.Http;
using Gluon.LoginBonus;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class LoginBonusScene : SceneBase
	{
		private enum Phase
		{
			Na,
			Init,
			MainBonus,
			EventBonus,
			Flash,
			End
		}

		public enum SpfxEffectKind
		{
			Wipe,
			BgParticle,
			Nof
		}

		[SerializeField]
		private Camera _mainCamera;

		[SerializeField]
		private Camera _backCamera;

		[SerializeField]
		private Camera _flashCamera;

		[SerializeField]
		private Camera _sparkCamera;

		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;

		public float[] flashPlayScale;

		private FlashPlayer[] flashPlayers;

		[SerializeField]
		private GameObject effectRoot;

		private Color storedCameraClearColor;

		private int currentLoginBonusIndex;

		private List<AtgenLoginBonusList> loginBonusList;

		private EffectObject[] spfxEffect;

		private Phase phase;

		private const string loginBonusBGM = "BGM_IN_STORY_0004_01";

		public const string nhaamVoiceGroup = "VO_CHR_100007_01_OUT";

		public static readonly float SPFX_WIPE_EFFECT_START_TIME;

		public static readonly float SPFX_WIPE_EFFECT_END_TIME;

		public Camera mainCamera => null;

		public Camera backCamera => null;

		public Camera flashCamera => null;

		public Camera sparkCamera => null;

		public FlashPlayer getFlashPlayer(Constants.FlashResourceKind kind)
		{
			return null;
		}

		public AtgenLoginBonusList GetCurrentLoginBonus()
		{
			return null;
		}

		public LoginBonusDataElement GetCurrentLoginBonusMasterDataElement()
		{
			return null;
		}

		private void Awake()
		{
		}

		public override void StartExitAnimation()
		{
		}

		public FlashPlayer PlayFlash(Constants.FlashResourceKind kind, Vector3 pos, Constants.UIPlaneKind planeKind)
		{
			return null;
		}

		private static void DisableFlPlane(FlashPlayer player, string planeName)
		{
		}

		private static FlPlane FindFlPlane(FlashPlayer player, string planeName)
		{
			return null;
		}

		public void HideAllFlash()
		{
		}

		public void HideFlash(Constants.FlashResourceKind kind)
		{
		}

		public void DetachFlash(Constants.FlashResourceKind kind)
		{
		}

		public static bool CheckPlayLoginBonusDemo()
		{
			return default(bool);
		}

		private void ClearLoginBonusList()
		{
		}

		private void UpdateLoginBonusList()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnEnterScene()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		private void OnInitReady()
		{
		}

		private IEnumerator LoadScene()
		{
			return null;
		}

		private IEnumerator ChangeLocalizeTextPositionCoroutine(FlashPlayer flashPlayer)
		{
			return null;
		}

		private void ChangeLocalizeTextPosition(float addX, float addY, FlashPlayer flashPlayer)
		{
		}

		private IEnumerator GotoMainPage()
		{
			return null;
		}

		private IEnumerator GotoEventPage()
		{
			return null;
		}

		private IEnumerator GotoSpecialFlashPage()
		{
			return null;
		}

		public void PlaySpfxEffect(SpfxEffectKind kind)
		{
		}

		public void PlaySpfxEffect(SpfxEffectKind kind, Vector3 pos, Vector3 scale)
		{
		}

		public void TriggerNextSpfxEffect(SpfxEffectKind kind)
		{
		}

		public void TriggerStopSpfxEffect(SpfxEffectKind kind)
		{
		}

		public void StopSpfxEffect(SpfxEffectKind kind)
		{
		}

		public void OnPageDemoFinished()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		private IEnumerator GotoNextScene()
		{
			return null;
		}

		private IEnumerator GotoShooting()
		{
			return null;
		}

		private IEnumerator GotoMyPage()
		{
			return null;
		}

		private IEnumerator GotoSummonUpdated(int encounterStoryId)
		{
			return null;
		}

		private IEnumerator GoToFreeSummonsAnounce()
		{
			return null;
		}

		private IEnumerator GoToScratchScene()
		{
			return null;
		}

		private IEnumerator GotoLotteryUpdated()
		{
			return null;
		}
	}
}
