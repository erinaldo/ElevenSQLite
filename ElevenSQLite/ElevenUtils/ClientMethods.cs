/*
 * Creado por SharpDevelop.
 * Usuario: jezafran
 * Fecha: 8/09/2017
 * Hora: 12:47 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace ElevenSQLite.ElevenUtils
{
	/// <summary>
	/// Description of ClientMethods.
	/// </summary>
	public class ClientMethods
	{
		public static string EncriptarString(string cadena)
		{
			return ClientMethods.EncryptString(cadena, 1024, "<RSAKeyValue><Modulus>1c+1YbmkGKPjzi1EM3AfQRBt6EJancU0Ht7QFf6AG9mSY6HzxGgdOAY1pXJhY5kgYlIHpVIGbThZ6ts6nRzp+OPlgSasxxQPIDnEUrGR0hLYNdC0VCtoRdavWk37+DHSMEovIfo0tG+2pYdotO4HmrFNcuYb4VMNK+bxH2Mwvgc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		}

		public static string EncriptarClave(string clave)
		{
			byte[] bytes = Encoding.Default.GetBytes(clave);
			MD5 mD = new MD5CryptoServiceProvider();
			byte[] inArray = mD.ComputeHash(bytes);
			return Convert.ToBase64String(inArray);
		}

		public static RSACryptoServiceProvider GetRSACryptoServiceProvider()
		{
			RSACryptoServiceProvider cryptoProvider = SharedInformation.CryptoProvider;
			cryptoProvider.FromXmlString("<RSAKeyValue><Modulus>1c+1YbmkGKPjzi1EM3AfQRBt6EJancU0Ht7QFf6AG9mSY6HzxGgdOAY1pXJhY5kgYlIHpVIGbThZ6ts6nRzp+OPlgSasxxQPIDnEUrGR0hLYNdC0VCtoRdavWk37+DHSMEovIfo0tG+2pYdotO4HmrFNcuYb4VMNK+bxH2Mwvgc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			return cryptoProvider;
		}

		public static bool IsValid(string data, string signature)
		{
			RSACryptoServiceProvider cryptoProvider = SharedInformation.CryptoProvider;
			cryptoProvider.FromXmlString("<RSAKeyValue><Modulus>1c+1YbmkGKPjzi1EM3AfQRBt6EJancU0Ht7QFf6AG9mSY6HzxGgdOAY1pXJhY5kgYlIHpVIGbThZ6ts6nRzp+OPlgSasxxQPIDnEUrGR0hLYNdC0VCtoRdavWk37+DHSMEovIfo0tG+2pYdotO4HmrFNcuYb4VMNK+bxH2Mwvgc=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			byte[] bytes = Encoding.UTF8.GetBytes(data);
			byte[] signature2 = Convert.FromBase64String(signature);
			return cryptoProvider.VerifyData(bytes, SharedInformation.HashAlgorithm, signature2);
		}

		public static bool IsValidLicense(string filename)
		{
			if (!File.Exists(filename)) {
				return false;
			}
			XmlDocument xmlDocument = new XmlDocument();
			try {
				xmlDocument.Load(filename);
			}
			catch {
				return false;
			}
			XmlElement xmlElement = xmlDocument.SelectSingleNode("/root/lic") as XmlElement;
			XmlElement xmlElement2 = xmlDocument.SelectSingleNode("/root/signature") as XmlElement;
			return xmlElement != null && xmlElement2 != null && ClientMethods.IsValid(xmlElement.OuterXml, xmlElement2.InnerText);
		}

		public static string GetStringXML(string resourceName)
		{
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			TextReader textReader = new StreamReader(entryAssembly.GetManifestResourceStream(resourceName));
			string result = textReader.ReadToEnd();
			textReader.Close();
			return result;
		}

		public static string EncryptString(string inputString, int dwKeySize, string xmlString)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
			rSACryptoServiceProvider.FromXmlString(xmlString);
			int num = dwKeySize / 8;
			byte[] bytes = Encoding.UTF32.GetBytes(inputString);
			int num2 = num - 42;
			int num3 = bytes.Length;
			int num4 = num3 / num2;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i <= num4; i++) {
				byte[] array = new byte[(num3 - num2 * i > num2) ? num2 : (num3 - num2 * i)];
				Buffer.BlockCopy(bytes, num2 * i, array, 0, array.Length);
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, true);
				Array.Reverse(array2);
				stringBuilder.Append(Convert.ToBase64String(array2));
			}
			return stringBuilder.ToString();
		}
	}
}
