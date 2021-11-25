using UnityEngine;
using XLua;

namespace Gluon.Shooting
{
	[LuaCallCSharp(GenFlag.No)]
	public class BaseObject : MonoBehaviour
	{
		public enum CollisionType
		{
			None,
			Circle,
			Rect,
			Ellipse,
			Square
		}

		[SerializeField]
		[Header("RectTransform")]
		public Transform tf;

		[SerializeField]
		[Header("Image")]
		public SpriteRenderer image;

		private bool _stableAngle;

		[SerializeField]
		[Header("Parameters")]
		public float x;

		public float y;

		public int angle;

		public int headingAngle;

		public float speed;

		public float scale;

		public int alpha;

		public int timer;

		public bool exist;

		public int id;

		public int targetId;

		private static float newx;

		private static float newy;

		private static float BOBJ_M_CHASEAIM_SPEEDMIN;

		public static float iPhoneXTopVisibleMargin;

		private Renderer[] _rendererList;

		public bool stableAngle
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Renderer[] rendererList => null;

		public void GenRendererList()
		{
		}

		public int rMainAngle(float destx, float desty, float r = 0f)
		{
			return default(int);
		}

		public int aMainAngle(float destx, float desty, int a = 0)
		{
			return default(int);
		}

		public static int RMainAngle(float x, float y, float destx, float desty, float r = 0f)
		{
			return default(int);
		}

		public static int AMainAngle(float x, float y, float destx, float desty, int a = 0)
		{
			return default(int);
		}

		public int chaseAim(float destx, float desty, int chasetimer)
		{
			return default(int);
		}

		public bool checkCollisionCircle(float aimx, float aimy, float r)
		{
			return default(bool);
		}

		public bool checkCollisionBigCircle(float aimx, float aimy, float r)
		{
			return default(bool);
		}

		public bool checkCollisionEllipseRot(float aimx, float aimy, float rPrep, float rParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f)
		{
			return default(bool);
		}

		public bool checkCollisionEllipse(float aimx, float aimy, float rPrep, float rParal, int angle = 9000, float rOri = 0f)
		{
			return default(bool);
		}

		public bool checkCollisionRectRot(float aimx, float aimy, float rectPrep, float rectParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f)
		{
			return default(bool);
		}

		public bool checkCollisionRect(float aimx, float aimy, float rectPrep, float rectParal, int angle = 9000, float rOri = 0f)
		{
			return default(bool);
		}

		public bool checkCollisionRightAngledRot(float aimx, float aimy, float rightPrep, float rightParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f)
		{
			return default(bool);
		}

		public bool checkCollisionRightAngled(float aimx, float aimy, float rightPrep, float rightParal, int angle = 9000, float rOri = 0f)
		{
			return default(bool);
		}

		public bool checkCollisionSquare(float aimx, float aimy, float length, float height = 0f, float rOri = 0f)
		{
			return default(bool);
		}

		public static bool CheckCollisionCircle(float x, float y, float aimx, float aimy, float r)
		{
			return default(bool);
		}

		public static bool CheckCollisionBigCircle(float x, float y, float aimx, float aimy, float r)
		{
			return default(bool);
		}

		public static bool CheckCollisionEllipseRot(float x, float y, float aimx, float aimy, float rPrep, float rParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f)
		{
			return default(bool);
		}

		public static bool CheckCollisionEllipse(float x, float y, float aimx, float aimy, float rPrep, float rParal, int angle = 9000, float rOri = 0f)
		{
			return default(bool);
		}

		public static bool CheckCollisionRectRot(float x, float y, float aimx, float aimy, float rectPrep, float rectParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f)
		{
			return default(bool);
		}

		public static bool CheckCollisionRect(float x, float y, float aimx, float aimy, float rectPrep, float rectParal, int angle = 9000, float rOri = 0f)
		{
			return default(bool);
		}

		public static bool CheckCollisionRightAngledRot(float x, float y, float aimx, float aimy, float rightPrep, float rightParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f)
		{
			return default(bool);
		}

		public static bool CheckCollisionRightAngled(float x, float y, float aimx, float aimy, float rightPrep, float rightParal, int angle = 9000, float rOri = 0f)
		{
			return default(bool);
		}

		public static bool CheckCollisionSquare(float x, float y, float aimx, float aimy, float length, float height = 0f, float rOri = 0f)
		{
			return default(bool);
		}

		public void updateMove()
		{
		}

		public void Render()
		{
		}

		public bool IsCenterInVisibleRange()
		{
			return default(bool);
		}

		public static Vector2 InverseTransferPoint(Vector3 pos)
		{
			return default(Vector2);
		}

		public Vector3 TransferPoint(float x, float y, float z)
		{
			return default(Vector3);
		}
	}
}
