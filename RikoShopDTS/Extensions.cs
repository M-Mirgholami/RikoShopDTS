using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RikoShopDTS
{
    public static class Extensions
    {
        public static string UnicodeToString(this string unicodedstr)
        {
            string unicodestring = unicodedstr;

            // Create two different encodings.
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;
            //Encoding Utf8 = Encoding.UTF8;

            // // Convert the string into a byte array.
            byte[] unicodeBytes = unicode.GetBytes(unicodestring);

            // // Perform the conversion from one encoding to the other.
            byte[] ascibytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // // Convert the new byte[] into a char[] and then into a string.
            char[] asciiChars = new char[ascii.GetCharCount(ascibytes, 0, ascibytes.Length)];
            ascii.GetChars(ascibytes, 0, ascibytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            // // Display the strings created before and after the conversion.
            //MessageBox.Show("Original string is"+unicodeString);
            return asciiString;
        }
    }
}
