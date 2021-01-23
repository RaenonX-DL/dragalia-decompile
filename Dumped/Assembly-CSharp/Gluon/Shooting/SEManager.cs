/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class SEManager
	{
		// Fields
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
	
		// Properties
		public static SEManager Instance { get; }
	
		// Nested types
		public struct SE
		{
			// Fields
			public Type type;
			public float xSum;
			public int counter;
		}
	
		public enum BGMType
		{
			NormalStage = 0,
			BossStage = 1,
			Result = 2,
			GameOver = 3,
			Title = 4
		}
	
		public enum VOType
		{
			Start = 0,
			BeforeBoss = 1,
			BossAppear = 2,
			BossCrush = 3,
			BossRetire = 4,
			ResultS = 5,
			ResultA = 6,
			ResultB = 7,
			ResultC = 8,
			RankInTop = 9,
			RankInBest3 = 10,
			RankInBest5 = 11,
			LevelUp = 12,
			OnDamage1 = 13,
			OnDamage2 = 14,
			OnDamage3 = 15,
			OnDamage4 = 16,
			OnDamage5 = 17,
			Pause1 = 18,
			Pause2 = 19,
			GameOver = 20,
			TrueBoss = 21
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
			BossAppear = 15,
			BossAppearExtreme = 16,
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
			PowerItemGetLevelup = 31,
			PowerItemGetMax = 32,
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
	
		// Constructors
		private SEManager();
		static SEManager();
	
		// Methods
		public static void Dispose();
		public void OnInit();
		public void TearDown();
		public AudioPlayback PlayVoice(VOType type);
		public void PlayBGM(BGMType type);
		public void PlaySavedBGM();
		public void PauseBGM(bool isPause);
		public void StopBGM(float t = 1f);
		public void Push(Type type, float x);
		public void Play();
		public void Stop(Type type);
		public void StopAll();
		public void PlaySE(Type type);
	}
}
