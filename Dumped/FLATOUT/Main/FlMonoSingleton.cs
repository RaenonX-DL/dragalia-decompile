using UnityEngine;
using UnityEngine.SceneManagement;

namespace FLATOUT.Main
{
	public abstract class FlMonoSingleton<T> : MonoBehaviour where T : FlMonoSingleton<T>
	{
		private static T _instance;

		private static bool _isQuitting;

		public static T Instance => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void SceneManagerSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private static void _Initialize(T instance)
		{
		}

		private static void _Release(T instance)
		{
		}

		private static void _Loaded(T instance)
		{
		}

		public virtual void _OnInitialize()
		{
		}

		public virtual void _OnFinalize()
		{
		}

		public virtual void _OnLoaded()
		{
		}

		public virtual void _Boot()
		{
		}
	}
}
