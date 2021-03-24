/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class BaseObject : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform tf;
		[Header]
		[SerializeField]
		public SpriteRenderer image;
		private bool _stableAngle;
		[Header]
		[SerializeField]
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
	
		// Properties
		public bool stableAngle { get; set; }
		public Renderer[] rendererList { get; }
	
		// Nested types
		public enum CollisionType
		{
			None = 0,
			Circle = 1,
			Rect = 2,
			Ellipse = 3,
			Square = 4
		}
	
		// Constructors
		public BaseObject();
		static BaseObject();
	
		// Methods
		public void GenRendererList();
		public int rMainAngle(float destx, float desty, float r = 0f);
		public int aMainAngle(float destx, float desty, int a = 0);
		public static int RMainAngle(float x, float y, float destx, float desty, float r = 0f);
		public static int AMainAngle(float x, float y, float destx, float desty, int a = 0);
		public int chaseAim(float destx, float desty, int chasetimer);
		public bool checkCollisionCircle(float aimx, float aimy, float r);
		public bool checkCollisionBigCircle(float aimx, float aimy, float r);
		public bool checkCollisionEllipseRot(float aimx, float aimy, float rPrep, float rParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f);
		public bool checkCollisionEllipse(float aimx, float aimy, float rPrep, float rParal, int angle = 9000, float rOri = 0f);
		public bool checkCollisionRectRot(float aimx, float aimy, float rectPrep, float rectParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f);
		public bool checkCollisionRect(float aimx, float aimy, float rectPrep, float rectParal, int angle = 9000, float rOri = 0f);
		public bool checkCollisionRightAngledRot(float aimx, float aimy, float rightPrep, float rightParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f);
		public bool checkCollisionRightAngled(float aimx, float aimy, float rightPrep, float rightParal, int angle = 9000, float rOri = 0f);
		public bool checkCollisionSquare(float aimx, float aimy, float length, float height = 0f, float rOri = 0f);
		public static bool CheckCollisionCircle(float x, float y, float aimx, float aimy, float r);
		public static bool CheckCollisionBigCircle(float x, float y, float aimx, float aimy, float r);
		public static bool CheckCollisionEllipseRot(float x, float y, float aimx, float aimy, float rPrep, float rParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f);
		public static bool CheckCollisionEllipse(float x, float y, float aimx, float aimy, float rPrep, float rParal, int angle = 9000, float rOri = 0f);
		public static bool CheckCollisionRectRot(float x, float y, float aimx, float aimy, float rectPrep, float rectParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f);
		public static bool CheckCollisionRect(float x, float y, float aimx, float aimy, float rectPrep, float rectParal, int angle = 9000, float rOri = 0f);
		public static bool CheckCollisionRightAngledRot(float x, float y, float aimx, float aimy, float rightPrep, float rightParal, float rotCos = 0f, float rotSin = 1f, float rOri = 0f);
		public static bool CheckCollisionRightAngled(float x, float y, float aimx, float aimy, float rightPrep, float rightParal, int angle = 9000, float rOri = 0f);
		public static bool CheckCollisionSquare(float x, float y, float aimx, float aimy, float length, float height = 0f, float rOri = 0f);
		public void updateMove();
		public void Render();
		public bool IsCenterInVisibleRange();
		public static Vector2 InverseTransferPoint(Vector3 pos);
		public Vector3 TransferPoint(float x, float y, float z);
	}
}
