/*

FilterExpression :Filter | InFilter | ANDFilter | ORFilter
Filter :Filter Name & Sql Operator & Filter Value 
InFilter :Filter Name & 'IN' & {Filter Value}+
ANDFilter :'(' & FilterExpression & 'AND' & {FilterExpression}+ & ')'
ORFilter :'(' & FilterExpression & 'OR' & {FilterExpression}+ & ')'
* */

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace Library.SqlFilter
{
    public enum SqlOperators
    {
        Greater,
        Less,
        Equal,
        StartsLike,
        EndsLike,
        Like,
        NotLike,
        LessOrEqual,
        GreaterOrEqual,
        NotEqual
    }

    public interface IFilter
    {
        string FilterString
        {
            get;
        }
    }

    [Serializable()]
    public class Filter : IFilter
    {
        private string m_strID;
        private string m_strFilterName;
        private SqlOperators m_sqlOperator;
        private string m_strFilterValue;
        public Filter(string strFilterName, SqlOperators sqlOperator, string strFilterValue)
        {
            m_strFilterName = strFilterName;
            m_sqlOperator = sqlOperator;
            m_strFilterValue = strFilterValue;

            //Id tracks the original FilterName in case the value pairs are to change
            m_strID = strFilterName;
        }

        public SqlFilter.SqlOperators SqlOperator
        {
            get { return this.m_sqlOperator; }
            set { this.m_sqlOperator = value; }
        }
        public string FilterString
        {
            get
            {
                string strFilter = "";
                m_strFilterValue = m_strFilterValue.Replace("'", "''");
                switch (m_sqlOperator)
                {
                    case SqlOperators.Greater:
                        strFilter = m_strFilterName + " > '" + m_strFilterValue + "'";
                        break;
                    case SqlOperators.Less:
                        strFilter = m_strFilterName + " < '" + m_strFilterValue + "'";
                        break;
                    case SqlOperators.Equal:
                        strFilter = m_strFilterName + " = '" + m_strFilterValue + "'";
                        break;
                    case SqlOperators.LessOrEqual:
                        strFilter = m_strFilterName + " <= '" + m_strFilterValue + "'";
                        break;
                    case SqlOperators.GreaterOrEqual:
                        strFilter = m_strFilterName + " >= '" + m_strFilterValue + "'";
                        break;
                    case SqlOperators.NotEqual:
                        strFilter = m_strFilterName + " <> '" + m_strFilterValue + "'";
                        break;
                    case SqlOperators.StartsLike:
                        strFilter = m_strFilterName + " LIKE '" + m_strFilterValue + "%'";
                        break;
                    case SqlOperators.EndsLike:
                        strFilter = m_strFilterName + " LIKE '%" + m_strFilterValue + "'";
                        break;
                    case SqlOperators.Like:
                        strFilter = m_strFilterName + " LIKE '%" + m_strFilterValue + "%'";
                        break;
                    case SqlOperators.NotLike:
                        strFilter = m_strFilterName + " NOT LIKE '" + m_strFilterValue + "'";
                        break;
                    default:
                        throw new Exception("This operator type is not supported");
                }
                return strFilter;
            }
        }
        public string FilterID
        {
            get { return this.m_strID; }
            set { this.m_strID = value; }
        }
        public string FilterName
        {
            get { return this.m_strFilterName; }
            set { this.m_strFilterName = value; }
        }
        public string FilterValue
        {
            get { return this.m_strFilterValue; }
            set { this.m_strFilterValue = value; }
        }
    }

    [Serializable()]
    public class INFilter : IFilter
    {
        private string m_strFilterName;
        private StringCollection m_strColFilterValues;
        public INFilter(string strFilterName, StringCollection strColValues)
        {
            m_strFilterName = strFilterName;
            m_strColFilterValues = strColValues;
        }

        public string FilterString
        {
            get
            {
                string strFilter = "";
                if (m_strColFilterValues.Count > 0)
                {
                    for (int i = 0; i < m_strColFilterValues.Count - 1; i++)
                    {
                        strFilter += "'" + m_strColFilterValues[i].ToString() + "'" + ",";
                    }
                    strFilter += "'" + m_strColFilterValues[m_strColFilterValues.Count - 1].ToString() + "'";
                    strFilter = m_strFilterName + " IN(" + strFilter + ")";
                }
                return strFilter;
            }
        }
    }

    [Serializable()]
    public class ANDFilter : IFilter
    {
        private FilterExpressionList m_filterExpressionList = new FilterExpressionList();
        public ANDFilter(IFilter filterExpressionLeft, IFilter filterExpressionRight)
        {
            m_filterExpressionList.Add(filterExpressionLeft);
            m_filterExpressionList.Add(filterExpressionRight);
        }

        public ANDFilter(FilterExpressionList filterExpressionList)
        {
            m_filterExpressionList = filterExpressionList;
        }

        public string FilterString
        {
            get
            {
                string strFilter = "";
                if (m_filterExpressionList.Count > 0)
                {
                    for (int i = 0; i < m_filterExpressionList.Count - 1; i++)
                    {
                        strFilter += m_filterExpressionList[i].FilterString + " AND ";
                    }
                    strFilter += m_filterExpressionList[m_filterExpressionList.Count - 1].FilterString;
                    strFilter = "(" + strFilter + ")";
                }
                return strFilter;
            }
        }
    }

    [Serializable()]
    public class ORFilter : IFilter
    {
        private FilterExpressionList m_filterExpressionList = new FilterExpressionList();
        public ORFilter(IFilter filterExpressionLeft, IFilter filterExpressionRight)
        {
            m_filterExpressionList.Add(filterExpressionLeft);
            m_filterExpressionList.Add(filterExpressionRight);
        }

        public ORFilter(FilterExpressionList filterExpressionList)
        {
            m_filterExpressionList = filterExpressionList;
        }

        public string FilterString
        {
            get
            {
                string strFilter = "";
                if (m_filterExpressionList.Count > 0)
                {
                    for (int i = 0; i < m_filterExpressionList.Count - 1; i++)
                    {
                        strFilter += m_filterExpressionList[i].FilterString + " OR ";
                    }
                    strFilter += m_filterExpressionList[m_filterExpressionList.Count - 1].FilterString;
                    strFilter = "(" + strFilter + ")";
                }
                return strFilter;
            }
        }
    }

    [Serializable()]
    public class FilterExpressionList : IEnumerable, IEnumerator
    {
        ArrayList alItems;
        System.Collections.IEnumerator ienum;

        public FilterExpressionList()
        {
            alItems = new ArrayList();
            ienum = alItems.GetEnumerator();
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public IFilter Current
        {
            get
            {
                return (IFilter)ienum.Current;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return ienum.Current;
            }
        }

        public void Reset()
        {
            ienum.Reset();
        }

        public bool MoveNext()
        {
            return ienum.MoveNext();
        }

        public void Add(IFilter filterExpresion)
        {
            alItems.Add(filterExpresion);
        }

        public IFilter this[int index]
        {
            get
            {
                return (IFilter)alItems[index];
            }
            set
            {
                alItems[index] = value;
            }
        }
       
            public int Count
        {
            get
            {
                return alItems.Count;
            }
        }
    }

}

