<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Paper.aspx.cs" Inherits="ConferenceMgmt.View_Paper" MasterPageFile = "Final.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="AA1" runat ="server">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" class = "art-postcontent" runat="server">
    <div class = "contents" id = "container">
     <asp:GridView ID="grvPapersView" AutoGenerateColumns="false" 
        runat="server">
        <Columns>
        <asp:BoundField DataField="PaperID" HeaderText="PaperID" />
        <asp:BoundField DataField="ConferenceID" HeaderText="ConferenceID" />
        <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="FileName" HeaderText="File Name" />
            <asp:BoundField DataField="PaperName" HeaderText="Paper Name" />
            <asp:BoundField DataField="PaperFees" HeaderText="Paper Fees" />
            <asp:BoundField DataField="IsAccepted" HeaderText="Accepted" />
            
                    </Columns>
    </asp:GridView>
   
    </div>
    </form>
</body>
</asp:Content>
