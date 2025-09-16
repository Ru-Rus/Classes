using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class HttpCookie {
        private readonly Dictionary<string, string> _dic;
        public DateTime expiry { get; set; }

        public HttpCookie()
        {
            _dic = new Dictionary<string, string>();
        }
        public void SetItem(string key, string value) { 
        
        }
        public string GetItem(string key) { 
            return _dic[key];
        }

        public string this[string key]
        {
            get { return _dic[key]; }
            set { _dic[key] = value; }
        }

    }
}
