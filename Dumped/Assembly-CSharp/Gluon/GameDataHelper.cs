/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GameDataHelper
	{
		// Constructors
		public GameDataHelper();
	
		// Methods
		public static int CastULongToInt(ulong num);
		public static void CopyObject<T1, T2>(T1[] src, ref T2[] dst)
			where T2 : new();
		public static void CopyObject<T1, T2>(T1 src, ref T2 dst)
			where T2 : new();
		private static void CopyObject(object src, ref object dst, Type dstType);
		private static object CreateInstance(Type type, object srcValue);
		private static void CopyFields(object src, object dst);
		public static T CreateLike<T>(T obj)
			where T : new();
		public static int[] CreateLike(int[] obj, int size);
		public static T CreateLikeElementType<T>(T[] obj)
			where T : new();
		public static T CreateLikeElementType<T>(DataManager.GameData<T> obj)
			where T : class, new();
		public static T[] CreateLike<T>(T[] obj, int size)
			where T : new();
		public static T[][] CreateLike<T>(T[][] obj, int size1, int size2)
			where T : new();
		public static Dictionary<ulong, int> CreateDictionary<T>(T[] array, Func<T, ulong> getId);
	}
}
