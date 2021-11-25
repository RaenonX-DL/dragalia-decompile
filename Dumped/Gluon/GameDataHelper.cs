using System;
using System.Collections.Generic;

namespace Gluon
{
	public class GameDataHelper
	{
		public static int CastULongToInt(ulong num)
		{
			return default(int);
		}

		public static void CopyObject<T1, T2>(T1[] src, ref T2[] dst) where T2 : new()
		{
		}

		public static void CopyObject<T1, T2>(T1 src, ref T2 dst) where T2 : new()
		{
		}

		private static void CopyObject(object src, ref object dst, Type dstType)
		{
		}

		private static object CreateInstance(Type type, object srcValue)
		{
			return null;
		}

		private static void CopyFields(object src, object dst)
		{
		}

		public static T CreateLike<T>(T obj) where T : new()
		{
			return (T)null;
		}

		public static int[] CreateLike(int[] obj, int size)
		{
			return null;
		}

		public static T CreateLikeElementType<T>(T[] obj) where T : new()
		{
			return (T)null;
		}

		public static T CreateLikeElementType<T>(DataManager.GameData<T> obj) where T : class, new()
		{
			return null;
		}

		public static T[] CreateLike<T>(T[] obj, int size) where T : new()
		{
			return null;
		}

		public static T[][] CreateLike<T>(T[][] obj, int size1, int size2) where T : new()
		{
			return null;
		}

		public static Dictionary<ulong, int> CreateDictionary<T>(T[] array, Func<T, ulong> getId)
		{
			return null;
		}
	}
}
