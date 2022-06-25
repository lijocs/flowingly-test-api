using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SDC.Api.Helpers
{
    /// <summary>
    /// XML Serialization helper class.
    /// </summary>
    /// <typeparam name="T">The type of the object to be serialized or deserialized.</typeparam>
    public class XmlSerializationHelper<T>
    {
        #region Public Methods

        /// <summary>
        /// Deserializes the specified XML data.
        /// </summary>
        /// <param name="xmlData">The XML data.</param>
        /// <returns>Deserialized object of type T.</returns>
        public T Deserialize(string xmlData)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(xmlData))
                {
                    throw new ArgumentNullException(nameof(xmlData));
                }

                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.DtdProcessing = DtdProcessing.Prohibit;
                xmlData = String.Format(Strings.XmlContent, xmlData);

                using MemoryStream stream = new MemoryStream(Encoding.Default.GetBytes(xmlData));
                T data;
                using (XmlReader reader = XmlReader.Create(stream, settings))
                {
                    data = (T)serializer.Deserialize(reader);
                }

                return data;
            }

            catch
            {
                return default(T);
            }
        }

        #endregion
    }
}
