using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Gluon.Shooting
{
	[LuaCallCSharp(GenFlag.No)]
	public class EnemyManager : STGSingletonMonoBehaviour<EnemyManager>
	{
		[Serializable]
		public class EnemyPool
		{
			public TemplateType type;

			public EnemyTemplate template;

			public int poolSize;

			[NonSerialized]
			public Pool pool;
		}

		[LuaCallCSharp(GenFlag.No)]
		public enum TemplateType
		{
			Mush = 0,
			Eye = 1,
			Eagle = 2,
			Pole = 3,
			Fafnir = 10,
			Mid = 100,
			Head = 200,
			Ghost01 = 400,
			Ghost02 = 401,
			Ghost03 = 402,
			Ghost04 = 403
		}

		private class GuideActionDefine
		{
			public TemplateType type;

			public int actionIndex;

			public int subIndex;

			public string animName;

			public GuideActionDefine(TemplateType _type, int _actionIndex, int _subIndex, string _animName)
			{
			}
		}

		public enum CatmullType
		{
			WaveRight,
			ExitRight,
			CircleRight
		}

		[SerializeField]
		[Header("Pool")]
		public Transform enemyParent;

		[NonSerialized]
		public Camera enemyCamera;

		private int zOrder;

		[SerializeField]
		[Header("Template")]
		public EnemyPool[] en;

		private Dictionary<TemplateType, EnemyPool> poolDic;

		[NonSerialized]
		public Enemy boss;

		public static bool shouldDisableSmall;

		public CatmullRomSpline waveRightCatmull;

		public CatmullRomSpline exitRightCatmull;

		public CatmullRomSpline circleRightCatmull;

		private GuideActionDefine[] guideActionList;

		public CatmullRomSpline GetCatmull(CatmullType type)
		{
			return null;
		}

		public bool IsTeamEnemyAllDied()
		{
			return default(bool);
		}

		public void Init()
		{
		}

		public EnemyTemplate GetTemplate(TemplateType type)
		{
			return null;
		}

		public Enemy Build(float x, float y, int angle, float speed, int level, TemplateType type, GameParameterController.ParseEnemyPatternDefineTable subSchedule, int guideAction, int subIndex, int infiTimer)
		{
			return null;
		}

		public string GetGuideActionName(TemplateType type, int guideAction, int subIndex)
		{
			return null;
		}

		public void Action(int time)
		{
		}

		public void Render()
		{
		}

		public void TurnOff()
		{
		}

		public void Clear()
		{
		}
	}
}
