﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Navbar/navbarAdmin.Master" AutoEventWireup="true" CodeBehind="TransactionsReport.aspx.cs" Inherits="LABPSD_RAAMEN.View.Admin.TransactionsReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
</asp:Content>
