using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Gluon.Shooting
{
	[LuaCallCSharp(GenFlag.No)]
	public class BulletManager : STGSingletonMonoBehaviour<BulletManager>
	{
		public enum TemplateType
		{
			EnemyBullet = 10,
			Ellipse = 11,
			CircleL = 100,
			CircleS = 101,
			CircleLPurple = 110,
			CircleSPurple = 111,
			CircleLLPurple = 112,
			CircleLLLPurple = 113,
			ScaleL = 150,
			ScaleW = 151,
			ScaleS = 152,
			EOrange = 400,
			EAqua = 401,
			EBlue = 402,
			ECrimson = 403,
			EGreen = 404,
			ELightBlue = 405,
			EPink = 406,
			EPurple = 407,
			ERed = 408,
			EYellow = 409
		}

		[SerializeField]
		[Header("Pool")]
		public GameObject poolTemplate;

		public Transform bulletParent;

		[NonSerialized]
		public Camera bulletCamera;

		[SerializeField]
		[Header("Template")]
		public BulletTemplate[] buTemplates;

		[SerializeField]
		[Header("PlayerCircle")]
		public SpriteRenderer playerCircle;

		public const int bulletPoolSize = 1024;

		[NonSerialized]
		public int livingCount;

		private int zOrder;

		private Dictionary<TemplateType, BulletTemplate> bulletTemplateDic;

		private Pool bu;

		public static int[] actionList;

		public static void SetActionList(int[] ac)
		{
		}

		public static void ClearActionList()
		{
		}

		public BulletTemplate OverrideByTemplate(Bullet bullet, TemplateType type)
		{
			return null;
		}

		public void Init()
		{
		}

		public int Build(float x, float y, int angle, float speed, TemplateType type, int color, int fadeinTime, float avoid, int tarID = 0)
		{
			return default(int);
		}

		public void BuildFan(int num, int baseangle, int angleOffset, float x, float y, float speed, TemplateType type, int color, int fadeinTime, float avoid)
		{
		}

		public void BuildCircle(int num, int baseangle, float baser, float x, float y, float speed, TemplateType type, int color, int fadeinTime, float avoid)
		{
		}

		public void BuildLine(int num, int baseangle, float space, int baseindex, float x, float y, int angle, float anglefactor, float speed, float speedfactor, TemplateType type, int color, int fadeinTime, float avoid)
		{
		}

		public void Action(int time)
		{
		}

		public void Render()
		{
		}

		public void RenderPlayerCircle()
		{
		}

		public void Clear()
		{
		}

		public int GetLivingCount()
		{
			return default(int);
		}
	}
}
