using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Infrastructure.Core
{
    public class PanigationSet <T>
    {
        public int Page { set; get; }

        public int Count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }

        public int  ToTalPages { set; get; }

        public int TotalCount { set; get; }

        public IEnumerable<T> Items { set; get; }
    }
}