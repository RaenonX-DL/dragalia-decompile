using System.Collections.Generic;
using Cute.Cri;

namespace Gluon.Shooting
{
	public class SEManager
	{
		public struct SE
		{
			public Type type;

			public float xSum;

			public int counter;
		}

		public enum BGMType
		{
			NormalStage,
			BossStage,
			Result,
			GameOver,
			Title
		}

		public enum VOType
		{
			Start,
			BeforeBoss,
			BossAppear,
			BossCrush,
			BossRetire,
			ResultS,
			ResultA,
			ResultB,
			ResultC,
			RankInTop,
			RankInBest3,
			RankInBest5,
			LevelUp,
			OnDamage1,
			OnDamage2,
			OnDamage3,
			OnDamage4,
			OnDamage5,
			Pause1,
			Pause2,
			GameOver,
			TrueBoss
		}

		public enum Type
		{
			Shoot1 = 0,
			Shoot2 = 1,
			Shoot3 = 2,
			Shoot4 = 3,
			Shoot5 = 4,
			Shoot6 = 5,
			Shoot7 = 6,
			Shoot8 = 7,
			Shoot9 = 8,
			Turn = 9,
			OnDamage = 10,
			GameOver = 11,
			EnemyShoot = 12,
			PlayerBulletHit = 13,
			EnemyCrush = 14,
			BossAppear = 0xF,
			BossAppearExtreme = 0x10,
			Boss1A = 17,
			Boss2B = 18,
			Boss1B = 19,
			Boss2A = 20,
			Boss2CL = 21,
			Boss2CR = 22,
			Boss2D = 23,
			BossHalf = 24,
			BossDamage = 25,
			BossOnDamage = 26,
			BossCrush = 27,
			BossExit = 28,
			PowerItemAppear = 29,
			PowerItemGet = 30,
			PowerItemGetLevelup = 0x1F,
			PowerItemGetMax = 0x20,
			ScoreStarGet = 33,
			LifeDown = 34,
			LifeRecover = 35,
			RankIn1 = 36,
			RankIn23 = 37,
			RankIn45 = 38,
			RankIn1TitleAccept = 39,
			TitleAccept = 40,
			TitleBack = 41,
			GameStart = 42,
			FinalScoreStar1 = 43,
			FinalScoreStar2 = 44,
			FinalScoreStar3 = 45,
			FinalScoreStar4 = 46,
			FinalScoreStar5 = 47,
			BulletItemize = 48,
			Head = 49,
			UseBomb = 50,
			SE_BULLET_CHANGE_1 = 100,
			SE_BULLET_CHANGE_2 = 101
		}

		private static SEManager instance;

		public const int MAX_SE = 128;

		private const float M_SE_PAN = 0.35f;

		public const string nhaamVoiceGroup = "VO_CHR_100007_01_APRIL2019_STG";

		public const string seGroup = "APRIL2019_STG";

		public readonly Dictionary<BGMType, string> bgmTable;

		public readonly Dictionary<VOType, string> voTable;

		private BGMType currentBGMType;

		private AudioPlayback bgmPlayback;

		public List<SE> seList;

		public readonly Dictionary<Type, string> seTable;

		public static SEManager Instance => null;

		public static void Dispose()
		{
		}

		private SEManager()
		{
		}

		public void OnInit()
		{
		}

		public void TearDown()
		{
		}

		public AudioPlayback PlayVoice(VOType type)
		{
			return default(AudioPlayback);
		}

		public void PlayBGM(BGMType type)
		{
		}

		public void PlaySavedBGM()
		{
		}

		public void PauseBGM(bool isPause)
		{
		}

		public void StopBGM(float t = 1f)
		{
		}

		public void Push(Type type, float x)
		{
		}

		public void Play()
		{
		}

		public void Stop(Type type)
		{
		}

		public void StopAll()
		{
		}

		public void PlaySE(Type type)
		{
		}
	}
}
