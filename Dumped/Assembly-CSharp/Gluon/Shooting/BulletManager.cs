/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class BulletManager : STGSingletonMonoBehaviour<Gluon.Shooting.BulletManager>
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject poolTemplate;
		public Transform bulletParent;
		[NonSerialized]
		public Camera bulletCamera;
		[Header]
		[SerializeField]
		public BulletTemplate[] buTemplates;
		[Header]
		[SerializeField]
		public SpriteRenderer playerCircle;
		public const int bulletPoolSize = 1024;
		[NonSerialized]
		public int livingCount;
		private int zOrder;
		private Dictionary<TemplateType, BulletTemplate> bulletTemplateDic;
		private Pool bu;
		public static int[] actionList;
	
		// Nested types
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
	
		// Constructors
		public BulletManager();
		static BulletManager();
	
		// Methods
		public static void SetActionList(int[] ac);
		public static void ClearActionList();
		public BulletTemplate OverrideByTemplate(Bullet bullet, TemplateType type);
		public void Init();
		public int Build(float x, float y, int angle, float speed, TemplateType type, int color, int fadeinTime, float avoid, int tarID = 0);
		public void BuildFan(int num, int baseangle, int angleOffset, float x, float y, float speed, TemplateType type, int color, int fadeinTime, float avoid);
		public void BuildCircle(int num, int baseangle, float baser, float x, float y, float speed, TemplateType type, int color, int fadeinTime, float avoid);
		public void BuildLine(int num, int baseangle, float space, int baseindex, float x, float y, int angle, float anglefactor, float speed, float speedfactor, TemplateType type, int color, int fadeinTime, float avoid);
		public void Action(int time);
		public void Render();
		public void RenderPlayerCircle();
		public void Clear();
		public int GetLivingCount();
	}
}
