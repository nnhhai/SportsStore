﻿using SportsStore.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SportsStore
{
    public partial class CategoryList : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
    protected IEnumerable<string> GetCategories()
    {
        return new Repository().Products.Select(p => p.Category).Distinct().OrderBy(x => x);
    }
    protected string CreateHomeLinkHtml() 
    { 
        string path = RouteTable.Routes.GetVirtualPath(null, null).VirtualPath; 
        return string.Format("<a href='{0}'>Home</a>", path); 
    }
    protected string CreateLinkHtml()
    {
        string path = RouteTable.Routes.GetVirtualPath(null, null,
            new RouteValueDictionary()
            {
                {"category", category },
                {"page", "1" }
            }).VirtualPath;
        return string.Format("<a href='{0}'>{1}</a>", path, category);
    }
}