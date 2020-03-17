<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" Inherits="SportsStore.CategoryList" %>
<%=CreateHomeLinkHtml() %>
<% foreach (string cat in GetCategories()) 
    {
        Response.Write(CreateLinkHtml(cat));
    }
   %>
<SS:CatLinks runat="server" />