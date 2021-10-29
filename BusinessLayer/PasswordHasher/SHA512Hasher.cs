using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer.PasswordHasher
{
	public static class SHA512Hasher
	{
		public static string Hash(string hashingPassword)
		{
			byte[] array = Encoding.UTF8.GetBytes(hashingPassword);

			using (var hash = SHA512.Create())
			{
				var hashedInputBytes = hash.ComputeHash(array);
				var hashedInputStringBuilder = new StringBuilder(128);

				foreach (var b in hashedInputBytes)
					hashedInputStringBuilder.Append(b.ToString("X2"));

				return hashedInputStringBuilder.ToString();
			}

		}

	}
}
