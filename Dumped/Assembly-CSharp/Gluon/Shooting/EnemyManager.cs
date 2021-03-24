/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class EnemyManager : STGSingletonMonoBehaviour<Gluon.Shooting.EnemyManager>
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform enemyParent;
		[NonSerialized]
		public Camera enemyCamera;
		private int zOrder;
		[Header]
		[SerializeField]
		public EnemyPool[] en;
		private Dictionary<TemplateType, EnemyPool> poolDic;
		[NonSerialized]
		public Enemy boss;
		public static bool shouldDisableSmall;
		public CatmullRomSpline waveRightCatmull;
		public CatmullRomSpline exitRightCatmull;
		public CatmullRomSpline circleRightCatmull;
		private GuideActionDefine[] guideActionList;
	
		// Nested types
		[Serializable]
		public class EnemyPool
		{
			// Fields
			public TemplateType type;
			public EnemyTemplate template;
			public int poolSize;
			[NonSerialized]
			public Pool pool;
	
			// Constructors
			public EnemyPool();
		}
	
		[LuaCallCSharp]
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
			// Fields
			public TemplateType type;
			public int actionIndex;
			public int subIndex;
			public string animName;
	
			// Constructors
			public GuideActionDefine(TemplateType _type, int _actionIndex, int _subIndex, string _animName);
		}
	
		public enum CatmullType
		{
			WaveRight = 0,
			ExitRight = 1,
			CircleRight = 2
		}
	
		// Constructors
		public EnemyManager();
		static EnemyManager();
	
		// Methods
		public CatmullRomSpline GetCatmull(CatmullType type);
		public bool IsTeamEnemyAllDied();
		public void Init();
		public EnemyTemplate GetTemplate(TemplateType type);
		public Enemy Build(float x, float y, int angle, float speed, int level, TemplateType type, GameParameterController.ParseEnemyPatternDefineTable subSchedule, int guideAction, int subIndex, int infiTimer);
		public string GetGuideActionName(TemplateType type, int guideAction, int subIndex);
		public void Action(int time);
		public void Render();
		public void TurnOff();
		public void Clear();
	}
}
