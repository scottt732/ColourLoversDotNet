using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace ColourLovers.Repository
{
    public abstract class AbstractRepository<T> where T : class, new()
    {
        protected virtual T ExecuteHttpRequest(string urlPrefix, string argumentOrQueryString = null)
        {
            if (string.IsNullOrEmpty(urlPrefix)) { throw new ArgumentNullException(urlPrefix); }

            string url = urlPrefix + (argumentOrQueryString ?? string.Empty);
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            
            using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
            {
                // TODO: Very ugly
                if ((int) response.StatusCode >= 200 && (int) response.StatusCode < 400)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(T));                            
                            T result = serializer.Deserialize(responseStream) as T;
                            return result;
                        }
                    }
                }
                else
                {
                    throw new WebException(string.Format("Unable to parse response.  HTTP Status: {0} ({1})", response.StatusDescription, response.StatusCode));
                }
            }
            
            return null;
        }        
    }
}
