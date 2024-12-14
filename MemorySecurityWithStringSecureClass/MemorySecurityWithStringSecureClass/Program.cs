using System.Runtime.InteropServices;
using System.Security;


string cardNo = "1111 2222 3333 4444";

SecureString secureString = new SecureString();
cardNo.ToList().ForEach(c => secureString.AppendChar(c));
secureString.MakeReadOnly();


#region 1. usul

//IntPtr bstr = Marshal.SecureStringToBSTR(secureString);
//string value = Marshal.PtrToStringUni(bstr);
//Console.WriteLine($"1.usul: {value}");

#endregion

#region 2. usul

//IntPtr bstr = Marshal.SecureStringToBSTR(secureString);
//string value = Marshal.PtrToStringAuto(bstr);
//Console.WriteLine($"2.usul: {value}");

#endregion


#region 3. usul

IntPtr bstr = Marshal.SecureStringToBSTR(secureString);
char[] characters = new char[secureString.Length];
Marshal.Copy(bstr, characters, 0, secureString.Length);
string value = string.Join("", characters);
Marshal.ZeroFreeBSTR(bstr);
Console.WriteLine(value);

#endregion

