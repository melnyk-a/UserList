using System.Collections.Generic;
using System.Xml;
using UserList.Models.Objects;

namespace UserList.Models.Repositories
{
    internal sealed class XMLRepository : IRepository<User>
    {
        private const string elementName = "user";
        private const string passwordAttributeName = "password";
        private const string userCollectionName = "users";
        private const string usernameAttributeName = "username";
        private const string XmlFileName = "Users.xml";
        private readonly XmlDocument document = new XmlDocument();

        public XMLRepository()
        {
            CreateEmptyXML();
        }

        public void Add(User item)
        {
            XmlElement root = document.DocumentElement;

            XmlElement user = document.CreateElement(elementName);
            XmlAttribute username = document.CreateAttribute(usernameAttributeName);
            username.Value = item.Name;
            XmlAttribute password = document.CreateAttribute(passwordAttributeName);
            password.Value = item.Password;

            user.Attributes.Append(username);
            user.Attributes.Append(password);
            root.AppendChild(user);

            Save();
        }

        private void CreateEmptyXML()
        {
            XmlElement root = document.CreateElement(userCollectionName);
            var declaration = document.CreateXmlDeclaration("1.0", "utf-8", "no");
            document.AppendChild(declaration);
            document.AppendChild(root);
            Save();
        }

        public void Delete(string name)
        {
            XmlElement root = document.DocumentElement;
            XmlNode node = FindByName(name);
            if (node != null)
            {
                root.RemoveChild(node);
                Save();
            }
        }

        public bool Exists(string username)
        {
            return FindByName(username) != null;
        }

        public bool Exists(User item)
        {
            bool isExist = false;
            XmlNode itemNode = FindByName(item.Name);
            if (itemNode != null)
            {
                XmlAttributeCollection attributes = itemNode.Attributes;
                foreach (XmlAttribute attribute in attributes)
                {
                    if (attribute.Name == passwordAttributeName &&
                        attribute.Value == item.Password)
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }

        private XmlNode FindByName(string name)
        {
            XmlNode finded = null;
            XmlNodeList children = document.ChildNodes;
            foreach (XmlNode child in children)
            {
                if (child.Name == userCollectionName)
                {
                    XmlNodeList users = child.ChildNodes;
                    foreach (XmlNode user in users)
                    {
                        XmlAttributeCollection attributes = user.Attributes;
                        foreach (XmlAttribute attribute in attributes)
                        {
                            if (attribute.Name == usernameAttributeName &&
                                attribute.Value == name)
                            {
                                finded = user;
                                break;
                            }
                        }
                    }
                }
            }
            return finded;
        }

        public IEnumerable<User> Items
        {
            get
            {
                var list = new List<User>();
                XmlNodeList children = document.ChildNodes;
                foreach (XmlNode child in children)
                {
                    if (child.Name == userCollectionName)
                    {
                        XmlNodeList users = child.ChildNodes;
                        foreach (XmlNode user in users)
                        {
                            XmlAttributeCollection attributes = user.Attributes;

                            string name = null;
                            string password = null;
                            foreach (XmlAttribute attribute in attributes)
                            {
                                if (attribute.Name == usernameAttributeName)
                                {
                                    name = attribute.Value;
                                }
                                else if (attribute.Name == passwordAttributeName)
                                {
                                    password = attribute.Value;
                                }
                            }
                            if (name != null && password != null)
                            {
                                list.Add(new User(name, password));
                            }
                        }
                    }
                }
                return list;
            }
        }

        private void Save()
        {
            document.Save(XmlFileName);
        }
    }
}