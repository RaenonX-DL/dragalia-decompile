using System.Security.Cryptography;

namespace XLua
{
	public class SignatureLoader
	{
		private LuaEnv.CustomLoader userLoader;

		private RSACryptoServiceProvider rsa;

		private SHA1 sha;

		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader)
		{
		}

		private byte[] load_and_verify(ref string filepath)
		{
			return null;
		}

		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader)
		{
			return null;
		}
	}
}
