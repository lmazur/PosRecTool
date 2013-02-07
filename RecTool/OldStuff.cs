using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace OldStuff
{
    public enum KeyType { AndCondition, OrCondition };
    public class MatchingKey
    {
        private string _name;
        private KeyType _type = KeyType.OrCondition;
        public MatchingKey(string name)
        {
            this._name = name;
        }
        public MatchingKey(string name, KeyType type)
        {
            this._name = name;
            this._type = type;
        }
        public KeyType KeyType
        {
            set { this._type = value; }
            get { return this._type; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
    }
    public class MatchingKeys
    {
        private ArrayList _al = new ArrayList();
        private ArrayList _Mandatoryal = new ArrayList();
        private ArrayList _OrList = new ArrayList();

        public int Count
        {
            get { return _al.Count; }
        }

        public MatchingKeys()
        {
        }
        public void AddKey(string KeyName)
        {
            this._al.Add(new MatchingKey(KeyName));
        }
        public void AddKey(string KeyName, KeyType type)
        {
            this._al.Add(new MatchingKey(KeyName, type));
        }

        public void BuildAndOrList()
        {
            foreach (MatchingKey k in this._al)
            {
                if (k.KeyType == KeyType.AndCondition) this._Mandatoryal.Add(k);
                else if (k.KeyType == KeyType.OrCondition) this._OrList.Add(k);
            }
        }

        /// <summary>
        /// Gets the expression for where all keys = ''
        /// </summary>
        /// <returns></returns>
        public string WhereNotNullExpression()
        {
            string exp = "";
            if (this._al.Count > 0)
            {
                int i = 0;
                foreach (MatchingKey key in _al)
                {
                    if (i == 0)
                        exp += key.Name + " <> '' ";
                    else
                        //if (key.KeyType == KeyType.AndCondition)
                        //{
                        exp += "AND " + key.Name + " <> '' ";
                    //}
                    //else
                    //{
                    //    exp += "OR " + key.Name + " <> '' ";
                    //}

                    i++;
                }
            }
            else
            {
                exp = "";
            }
            return exp;
        }

        public string MatchRowsOnKeysExpression(DataRow dr)
        {
            string exp = "";
            if (this._al.Count > 0)
            {
                int i = 0;

                if (this._Mandatoryal.Count == 0 && this._OrList.Count == 0)
                    this.BuildAndOrList();

                //Build OR Condition
                foreach (MatchingKey key in this._OrList)
                {
                    if (i == 0)
                        exp += "(" + key.Name + " = '" + dr[key.Name] + "'";
                    else
                    {
                        exp += " OR " + key.Name + " = '" + dr[key.Name] + "'";
                    }
                    i++;
                }

                i = 0;
                if (this._OrList.Count > 0)
                {
                    exp += ") AND ";
                }

                //Build AND Condition
                foreach (MatchingKey key in this._Mandatoryal)
                {
                    if (i == 0)
                        exp += key.Name + " = '" + dr[key.Name] + "'";
                    else
                    {
                        exp += " AND " + key.Name + " = '" + dr[key.Name] + "'";
                    }
                }
            }
            else
            {
                exp = "";
            }
            return exp;
        }
    }
}
