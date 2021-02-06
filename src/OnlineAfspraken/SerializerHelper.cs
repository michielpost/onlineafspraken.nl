using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OnlineAfspraken
{
    public static class SerializerHelper
    {
        public static T? XmlDeserialize<T>(this string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringReader textReader = new StringReader(toDeserialize))
            {
                return (T?)xmlSerializer.Deserialize(textReader);
            }
        }

        public static string XmlSerialize<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }
    }
}
