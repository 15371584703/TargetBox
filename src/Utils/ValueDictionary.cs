using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Utils
{
    public class ValueDictionary
    {
        private static ValueDictionary _Instance;

        private Dictionary<string, Dictionary<string, string>> ValueStore;

        static ValueDictionary()
        {
            _Instance = null;
        }

        static public ValueDictionary Instance
        {
            get
            {
                if (_Instance == null)
                {
                    throw new Exception("ValueDictionary Not Initialized");
                }

                return _Instance;
            }
        }

        static public void Init(string conf_file)
        {
            _Instance = new ValueDictionary();

            _Instance.Load(conf_file);
        }

        public Dictionary<string, string> this[string name]
        {
            get
            {
                Dictionary<string, string> Result = null;

                if (this.ValueStore.ContainsKey(name))
                {
                    Result = this.ValueStore[name];
                }

                return Result;
            }
        }

        public string GetText(string topic, string value)
        {
            string Result = null;

            Dictionary<string, string> ItemList = this[topic];
            if (ItemList != null)
            {
                if (ItemList.ContainsKey(value))
                {
                    Result = ItemList[value];
                }
            }

            return Result;
        }

        private void Load(string conf_file)
        {
            ValueStore = new Dictionary<string, Dictionary<string, string>>();

            XmlDocument Doc = new XmlDocument();
            Doc.Load(conf_file);
            XmlNode root = Doc.DocumentElement;

            XmlNodeList Topics = root.SelectNodes("Topic");
            foreach (XmlNode topic in Topics)
            {
                string TopicName = topic.Attributes["Name"].Value;
                Dictionary<string, string> ItemList = new Dictionary<string, string>();
                ValueStore.Add(TopicName, ItemList);

                XmlNodeList Items = topic.SelectNodes("Item");
                foreach (XmlNode item in Items)
                {
                    string ItemName = item.Attributes["Name"].Value;
                    string ItemText = item.InnerText;

                    ItemList.Add(ItemName, ItemText);
                }
            }
        }
    }
}
