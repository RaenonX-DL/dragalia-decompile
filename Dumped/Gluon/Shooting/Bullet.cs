using System;

namespace Gluon.Shooting
{
	public class Bullet : BaseObject
	{
		public enum ActionDefine
		{
			THEN = -1000000,
			BULA_CONDITIONSTART = 0,
			BULAC_FILTER = 240,
			BULAC_OTHER = 0,
			SECTIONEND = 0,
			EVERY = 1,
			EVERYMOD = 2,
			BULAC_TIMER = 0x10,
			TIMERGREAT = 17,
			TIMEREQUAL = 18,
			TIMERLESS = 19,
			TIMERRANGE = 20,
			BULAC_TYPE = 0x20,
			TYPEEQUAL = 33,
			BULAC_COLOR = 48,
			COLOREQUAL = 49,
			BULAC_ANGLE = 0x40,
			ANGLEGREAT = 65,
			ANGLEEQUAL = 66,
			ANGLELESS = 67,
			ANGLERANGE = 68,
			BULAC_POS = 80,
			XGREAT = 81,
			XLESS = 82,
			XRANGE = 83,
			YGREAT = 88,
			YLESS = 89,
			YRANGE = 90,
			BULAC_VAL = 96,
			VALGREAT = 97,
			VALEQUAL = 98,
			VALLESS = 99,
			VALRANGE = 100,
			BULAC_SPEED = 112,
			SPEEDGREAT = 113,
			SPEEDEQUAL = 114,
			SPEEDLESS = 115,
			SPEEDRANGE = 116,
			BULAC_INDEX = 0x80,
			INDEXMODGREAT = 129,
			INDEXMODEQUAL = 130,
			INDEXMODLESS = 131,
			INDEXMODRANGE = 132,
			BULAC_BOUNCE = 144,
			BOUNCEGREAT = 145,
			BOUNCEEQUAL = 146,
			BOUNCELESS = 147,
			BOUNCERANGE = 148,
			BULA_EXECUTESTART = 0x1000,
			BULAE_FILTER = 61440,
			BULAE_TYPE = 0x1000,
			TYPESET = 4352,
			BULAE_COLOR = 0x2000,
			COLORSET = 8448,
			BULAE_ANGLE = 12288,
			ANGLESET = 12544,
			ANGLESETADD = 12800,
			ANGLEADJUST = 13056,
			ANGLESETRMA = 13312,
			ANGLESETRMAP = 13568,
			ANGLESETRMAT = 13824,
			ANGLESETAMA = 14080,
			ANGLESETAMAP = 14336,
			ANGLESETAMAT = 14592,
			ANGLESETRAND = 14848,
			ANGLESETADDRAND = 15104,
			BULAE_HEADANGLE = 0x4000,
			HEADANGLESET = 16640,
			HEADANGLESETADD = 16896,
			BULAE_POS = 20480,
			XSET = 20736,
			YSET = 20992,
			XSETADD = 21248,
			YSETADD = 21504,
			XSETACCADD = 21760,
			YSETACCADD = 22016,
			BULAE_VAL = 24576,
			VALSET = 24832,
			VALSETADD = 25088,
			BULAE_SPEED = 28672,
			SPEEDSET = 28928,
			SPEEDSETADD = 29184,
			SPEEDSETMUL = 29440,
			BULAE_OTHER = 0x8000,
			CALLEVENT = 33024,
			CHASE = 33280,
			CHASEPOS = 33360,
			REMAIN = 33536,
			DECANCEL = 33792,
			FADEOUT = 34048,
			BOUNCE = 34816,
			BOUNCELR = 35072,
			BOUNCETB = 35328,
			BULA_SPECIALSTART = 0,
			AND = -1,
			OR = -2,
			NOT = -3,
			CONDITIONBYVAL = -4,
			CONDITIONBYINDEX = -5,
			EXECUTEBYVAL = -6,
			EXECUTEBYINDEX = -7
		}

		public enum Phase
		{
			FadeIn,
			Normal,
			FadeOut
		}

		private BulletManager.TemplateType type;

		private BulletTemplate template;

		private int fadeInTime;

		private int tarId;

		private float xplus;

		private float yplus;

		private float lastAngle;

		private float lastSpeed;

		private float lastx;

		private float lasty;

		private int bounceTime;

		[NonSerialized]
		public bool able;

		private bool grazed;

		private int toScoreItemTime;

		private BulletManager.TemplateType oldType;

		public const int ACTIONLISTMAX = 32;

		public int[] actionList;

		private const int BULLETACT_ANGLECHANGESE = 3000;

		private const float BULLETACT_FLOATSCALE = 100f;

		private Phase phase;

		public void ChangeType(BulletManager.TemplateType _type)
		{
		}

		public int GetTarID()
		{
			return default(int);
		}

		public void SetActionList(int[] ac)
		{
		}

		public void ClearActionList()
		{
		}

		public bool ValueSet(int _ID, float _x, float _y, int _angle, float _speed, BulletManager.TemplateType _type, int _color, int _fadeinTime, float avoid, int _tarID)
		{
			return default(bool);
		}

		public void SetSortingOrder(int z)
		{
		}

		public void Action()
		{
		}

		private void MatchFadeInColorType()
		{
		}

		private void MatchFadeOutColorType()
		{
		}

		private void UpdateFrame()
		{
		}

		private void DoIze()
		{
		}

		private bool ChangeAction(int nextStep = 0)
		{
			return default(bool);
		}

		private bool DoCollision()
		{
			return default(bool);
		}

		private void DoGraze()
		{
		}

		private bool IsInRect(float aimx, float aimy, float r, int nextstep = 0)
		{
			return default(bool);
		}
	}
}
