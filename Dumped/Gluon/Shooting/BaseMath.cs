using System;

namespace Gluon.Shooting
{
	public class BaseMath
	{
		private static int g_myseed;

		private const int RAND_MAX = 32767;

		public const float M_PI = (float)Math.PI;

		public const float M_PI_2 = (float)Math.PI / 2f;

		public const float M_PI_4 = (float)Math.PI / 4f;

		public const float M_1_PI = 1f / (float)Math.PI;

		public const float M_2_PI = 2f / (float)Math.PI;

		public const float M_2_SQRTPI = 1.1283792f;

		public const float M_SQRT2 = 1.4142135f;

		public const float M_SQRT1_2 = 0.70710677f;

		public const float M_ACTIVECLIENT_LEFT = 0f;

		public const float M_ACTIVECLIENT_RIGHT = 640f;

		public const float M_ACTIVECLIENT_TOP = 0f;

		public const float M_ACTIVECLIENT_BOTTOM = 900f;

		public const float M_MOVEABLEEDGE = 20f;

		public const float M_MOVEABLECLIENT_LEFT = 0f;

		public const float M_MOVEABLECLIENT_RIGHT = 640f;

		public const float M_MOVEABLECLIENT_TOP = 20f;

		public const float M_MOVEABLECLIENT_BOTTOM = 900f;

		public const float M_ACTIVECLIENT_WIDTH = 640f;

		public const float M_ACTIVECLIENT_HEIGHT = 900f;

		public const float M_ACTIVECLIENT_CENTER_X = 320f;

		public const float M_ACTIVECLIENT_CENTER_Y = 450f;

		public const float M_DELETEBOLDER = 64f;

		public const float M_DELETEBOLDER_TOPOFFSET = 72f;

		public const float M_DELETECLIENT_LEFT = -64f;

		public const float M_DELETECLIENT_RIGHT = 704f;

		public const float M_DELETECLIENT_TOP = -136f;

		public const float M_DELETECLIENT_BOTTOM = 964f;

		public const float M_GAMESQUARE_BOSSX = 320f;

		public const float M_GAMESQUARE_BOSSY = 225f;

		public static void srandt(int seed)
		{
		}

		public static int randt()
		{
			return default(int);
		}

		public static int randt(int imin, int imax)
		{
			return default(int);
		}

		public static float randtf(float fmin, float fmax)
		{
			return default(float);
		}

		public static float ARC(int x)
		{
			return default(float);
		}

		public static int ANGLE(float x)
		{
			return default(int);
		}

		public static float sqrtf(float x)
		{
			return default(float);
		}

		public static float atan2f(float y, float x)
		{
			return default(float);
		}

		public static float fabsf(float x)
		{
			return default(float);
		}

		public static float sint(int x)
		{
			return default(float);
		}

		public static float cost(int x)
		{
			return default(float);
		}

		public static float tant(int x)
		{
			return default(float);
		}

		public static float DIST(float X1, float Y1, float X2, float Y2)
		{
			return default(float);
		}

		public static float DIST2(float X1, float Y1, float X2, float Y2)
		{
			return default(float);
		}

		public static int SIGN(int X)
		{
			return default(int);
		}

		public static int ROLL(int X, int T)
		{
			return default(int);
		}

		public static float INTER(float A, float B, float X)
		{
			return default(float);
		}

		public static int RANDA()
		{
			return default(int);
		}

		public static int ModIndex(int usingTime, int baseMod, int interval, int maxIndex, int minIndex = 0, int returnOffset = 1, int intervalMod = 1)
		{
			return default(int);
		}
	}
}
